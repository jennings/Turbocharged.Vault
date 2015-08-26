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

        public ExplorerForm(Uri baseUri, IAuthenticationMethod auth)
        {
            InitializeComponent();
            _client = new VaultClient(baseUri, auth);
        }

        protected override async void OnLoad(EventArgs e)
        {
            var status = await _client.SealStatusAsync();
            UpdateSealStatus(status);
        }

        async void sealStatusButton_Click(object sender, EventArgs e)
        {
            var status = await _client.SealStatusAsync();
            UpdateSealStatus(status);
        }

        async void unsealButton_Click(object sender, EventArgs e)
        {
            var unsealKey = unsealKeyTextBox.Text;
            unsealKeyTextBox.Text = "";
            var status = await _client.UnsealAsync(unsealKey);
            UpdateSealStatus(status);
        }

        async void sealButton_Click(object sender, EventArgs e)
        {
            await _client.SealAsync();
            var status = await _client.SealStatusAsync();
            UpdateSealStatus(status);
        }

        void UpdateSealStatus(SealStatus status)
        {
            if (status.Sealed)
            {
                backendsTabControl.Enabled = false;
                unsealButton.Enabled = true;
                sealButton.Enabled = false;

                var required = status.Threshold - status.Progress;
                sealStatusLabel.Text = "Sealed, " + required + " shares remaining";
            }
            else
            {
                sealStatusLabel.Text = "Unsealed";
                backendsTabControl.Enabled = true;
                unsealButton.Enabled = false;
                sealButton.Enabled = true;
            }
        }
    }
}
