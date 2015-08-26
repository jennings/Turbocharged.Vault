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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void tokenAuthSignIn_Click(object sender, EventArgs e)
        {
            var baseUri = new Uri(baseUriTextBox.Text);
            var token = tokenAuthToken.Text;
            var auth = new TokenAuthentication(token);
            var form = new ExplorerForm(baseUri, auth);
            form.Show();
        }
    }
}
