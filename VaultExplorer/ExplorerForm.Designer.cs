namespace VaultExplorer
{
    partial class ExplorerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unsealButton = new System.Windows.Forms.Button();
            this.sealButton = new System.Windows.Forms.Button();
            this.unsealKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backendsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sealStatusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sealStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.backendsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sealStatusLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sealStatusButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.unsealKeyTextBox);
            this.groupBox1.Controls.Add(this.sealButton);
            this.groupBox1.Controls.Add(this.unsealButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seal";
            // 
            // unsealButton
            // 
            this.unsealButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unsealButton.Location = new System.Drawing.Point(566, 25);
            this.unsealButton.Name = "unsealButton";
            this.unsealButton.Size = new System.Drawing.Size(163, 56);
            this.unsealButton.TabIndex = 0;
            this.unsealButton.Text = "Unseal";
            this.unsealButton.UseVisualStyleBackColor = true;
            this.unsealButton.Click += new System.EventHandler(this.unsealButton_Click);
            // 
            // sealButton
            // 
            this.sealButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sealButton.Location = new System.Drawing.Point(735, 25);
            this.sealButton.Name = "sealButton";
            this.sealButton.Size = new System.Drawing.Size(163, 56);
            this.sealButton.TabIndex = 1;
            this.sealButton.Text = "Seal";
            this.sealButton.UseVisualStyleBackColor = true;
            this.sealButton.Click += new System.EventHandler(this.sealButton_Click);
            // 
            // unsealKeyTextBox
            // 
            this.unsealKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unsealKeyTextBox.Location = new System.Drawing.Point(148, 25);
            this.unsealKeyTextBox.Name = "unsealKeyTextBox";
            this.unsealKeyTextBox.Size = new System.Drawing.Size(412, 26);
            this.unsealKeyTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unseal key";
            // 
            // backendsTabControl
            // 
            this.backendsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backendsTabControl.Controls.Add(this.tabPage1);
            this.backendsTabControl.Location = new System.Drawing.Point(22, 179);
            this.backendsTabControl.Name = "backendsTabControl";
            this.backendsTabControl.SelectedIndex = 0;
            this.backendsTabControl.Size = new System.Drawing.Size(894, 713);
            this.backendsTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Secret";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sealStatusButton
            // 
            this.sealStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sealStatusButton.Location = new System.Drawing.Point(566, 87);
            this.sealStatusButton.Name = "sealStatusButton";
            this.sealStatusButton.Size = new System.Drawing.Size(332, 50);
            this.sealStatusButton.TabIndex = 5;
            this.sealStatusButton.Text = "Get Status";
            this.sealStatusButton.UseVisualStyleBackColor = true;
            this.sealStatusButton.Click += new System.EventHandler(this.sealStatusButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // sealStatusLabel
            // 
            this.sealStatusLabel.AutoSize = true;
            this.sealStatusLabel.Location = new System.Drawing.Point(144, 61);
            this.sealStatusLabel.Name = "sealStatusLabel";
            this.sealStatusLabel.Size = new System.Drawing.Size(76, 20);
            this.sealStatusLabel.TabIndex = 7;
            this.sealStatusLabel.Text = "Unknown";
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 904);
            this.Controls.Add(this.backendsTabControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExplorerForm";
            this.Text = "ExplorerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.backendsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unsealButton;
        private System.Windows.Forms.Button sealButton;
        private System.Windows.Forms.TextBox unsealKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl backendsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button sealStatusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sealStatusLabel;
    }
}