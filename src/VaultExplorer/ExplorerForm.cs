using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turbocharged.Vault;

namespace VaultExplorer
{
    public partial class ExplorerForm : Form
    {
        readonly VaultClient _client;
        BindingList<Pair<string, object>> _secretValues = new BindingList<Pair<string, object>>();
        BindingList<Mount> _mounts = new BindingList<Mount>();
        BindingList<string> _policyNames = new BindingList<string>();

        public ExplorerForm(Uri baseUri, IAuthenticationMethod auth)
        {
            InitializeComponent();
            _client = new VaultClient(baseUri, auth);
            secretDataGridView.DataSource = _secretValues;
            mountsListBox.DataSource = _mounts;
        }

        protected override async void OnLoad(EventArgs e)
        {
            SetControls(false);
            var status = await _client.SealStatusAsync();
            UpdateSealStatus(status);
            if (!status.Sealed)
            {
                await UpdateAllAsync();
            }
        }

        async void sealStatusButton_Click(object sender, EventArgs e)
        {
            var status = await _client.SealStatusAsync();
            UpdateSealStatus(status);
            if (!status.Sealed)
            {
                await UpdateAllAsync();
            }
        }

        async void unsealButton_Click(object sender, EventArgs e)
        {
            var unsealKey = unsealKeyTextBox.Text;
            unsealKeyTextBox.Text = "";
            var status = await _client.UnsealAsync(unsealKey);
            UpdateSealStatus(status);
            if (!status.Sealed)
            {
                await UpdateAllAsync();
            }
        }

        Task UpdateAllAsync()
        {
            return Task.WhenAll(
                UpdateMountsAsync(),
                UpdatePoliciesAsync());
        }

        async Task UpdateMountsAsync()
        {
            List<Mount> mounts;
            try
            {
                mounts = await _client.GetMountsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _mounts = new BindingList<Mount>(mounts);
            mountsListBox.DataSource = _mounts;
        }

        async Task UpdatePoliciesAsync()
        {
            List<string> policies;
            try
            {
                policies = await _client.GetPolicyNamesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _policyNames = new BindingList<string>(policies);
            policiesListBox.DataSource = _policyNames;
        }

        async void sealButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _client.SealAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Update the seal status anyway
            }

            var status = await _client.SealStatusAsync();
            UpdateSealStatus(status);
        }

        void UpdateSealStatus(SealStatus status)
        {
            if (status.Sealed)
            {
                SetControls(false);
                var required = status.Threshold - status.Progress;
                sealStatusLabel.Text = "Sealed, " + required + " shares remaining";
            }
            else
            {
                sealStatusLabel.Text = "Unsealed";
                SetControls(true);
            }
        }

        void SetControls(bool enabled)
        {
            secretsTabPage.Enabled
                = mountsTabPage.Enabled
                = policiesTabPage.Enabled
                = sealButton.Enabled
                = enabled;

            unsealButton.Enabled
                = !enabled;
        }

        async void getSecretButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            Lease lease;
            try
            {
                lease = await _client.LeaseAsync(path);
            }
            catch (Exception ex)
            {
                var type = ex.GetType();
                MessageBox.Show(ex.Message + "(" + type.Name + ")", "Error");
                return;
            }

            if (lease == null)
            {
                MessageBox.Show("Path not found: " + path);
                return;
            }

            var values = lease.Data
                .Select(d => new Pair<string, object>(d.Key, d.Value))
                .ToList();

            _secretValues = new BindingList<Pair<string, object>>(values);
            secretDataGridView.DataSource = _secretValues;
        }

        class Pair<TKey,TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public Pair()
            {
            }

            public Pair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        async void saveButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            var data = _secretValues
                .ToDictionary(
                    obj => obj.Key,
                    obj => obj.Value);

            await _client.WriteSecretAsync(path, data);

            MessageBox.Show("Saved");
        }

        async void policiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = policiesListBox.SelectedIndex;
            var policy = _policyNames[index];
            await DisplayPolicy(policy);
        }

        async Task DisplayPolicy(string name)
        {
            var document = await _client.GetPolicyAsync(name);
            policyNameTextBox.Text = name;
            policyDocumentTextBox.Text = document;
        }

        async void savePolicyButton_Click(object sender, EventArgs e)
        {
            var name = policyNameTextBox.Text;
            var document = policyDocumentTextBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Policy must have a name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(document))
            {
                MessageBox.Show("Policy must have a document.");
                return;
            }

            await _client.SetPolicyAsync(name, document);
            await UpdatePoliciesAsync();
            MessageBox.Show("Saved");
        }
    }
}
