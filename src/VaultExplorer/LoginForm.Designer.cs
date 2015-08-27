namespace VaultExplorer
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tokenAuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tokenAuthSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baseUriTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tokenAuthSignIn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tokenAuthToken);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Token Auth";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "App ID Auth";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tokenAuthToken
            // 
            this.tokenAuthToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenAuthToken.Location = new System.Drawing.Point(147, 39);
            this.tokenAuthToken.Name = "tokenAuthToken";
            this.tokenAuthToken.Size = new System.Drawing.Size(517, 26);
            this.tokenAuthToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token";
            // 
            // tokenAuthSignIn
            // 
            this.tokenAuthSignIn.Location = new System.Drawing.Point(147, 90);
            this.tokenAuthSignIn.Name = "tokenAuthSignIn";
            this.tokenAuthSignIn.Size = new System.Drawing.Size(151, 39);
            this.tokenAuthSignIn.TabIndex = 2;
            this.tokenAuthSignIn.Text = "Sign In";
            this.tokenAuthSignIn.UseVisualStyleBackColor = true;
            this.tokenAuthSignIn.Click += new System.EventHandler(this.tokenAuthSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vault URI";
            // 
            // baseUriTextBox
            // 
            this.baseUriTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseUriTextBox.Location = new System.Drawing.Point(163, 12);
            this.baseUriTextBox.Name = "baseUriTextBox";
            this.baseUriTextBox.Size = new System.Drawing.Size(517, 26);
            this.baseUriTextBox.TabIndex = 2;
            this.baseUriTextBox.Text = "http://localhost:8200/";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baseUriTextBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tokenAuthToken;
        private System.Windows.Forms.Button tokenAuthSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseUriTextBox;
    }
}

