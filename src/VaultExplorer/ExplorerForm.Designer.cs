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
            this.sealStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sealStatusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unsealKeyTextBox = new System.Windows.Forms.TextBox();
            this.sealButton = new System.Windows.Forms.Button();
            this.unsealButton = new System.Windows.Forms.Button();
            this.mountsListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.secretDataGridView = new System.Windows.Forms.DataGridView();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSecretButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.secretsTabPage = new System.Windows.Forms.TabPage();
            this.mountsTabPage = new System.Windows.Forms.TabPage();
            this.policiesTabPage = new System.Windows.Forms.TabPage();
            this.policiesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.policyNameTextBox = new System.Windows.Forms.TextBox();
            this.policyDocumentTextBox = new System.Windows.Forms.TextBox();
            this.savePolicyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.secretsTabPage.SuspendLayout();
            this.mountsTabPage.SuspendLayout();
            this.policiesTabPage.SuspendLayout();
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
            // sealStatusLabel
            // 
            this.sealStatusLabel.AutoSize = true;
            this.sealStatusLabel.Location = new System.Drawing.Point(144, 61);
            this.sealStatusLabel.Name = "sealStatusLabel";
            this.sealStatusLabel.Size = new System.Drawing.Size(76, 20);
            this.sealStatusLabel.TabIndex = 7;
            this.sealStatusLabel.Text = "Unknown";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unseal key";
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
            // mountsListBox
            // 
            this.mountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mountsListBox.FormattingEnabled = true;
            this.mountsListBox.ItemHeight = 20;
            this.mountsListBox.Location = new System.Drawing.Point(6, 6);
            this.mountsListBox.MultiColumn = true;
            this.mountsListBox.Name = "mountsListBox";
            this.mountsListBox.Size = new System.Drawing.Size(290, 684);
            this.mountsListBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.DarkRed;
            this.saveButton.Location = new System.Drawing.Point(727, 38);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 56);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // secretDataGridView
            // 
            this.secretDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secretDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.secretDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secretDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyColumn,
            this.valueColumn});
            this.secretDataGridView.Location = new System.Drawing.Point(6, 100);
            this.secretDataGridView.Name = "secretDataGridView";
            this.secretDataGridView.RowTemplate.Height = 28;
            this.secretDataGridView.Size = new System.Drawing.Size(884, 592);
            this.secretDataGridView.TabIndex = 9;
            // 
            // keyColumn
            // 
            this.keyColumn.DataPropertyName = "Key";
            this.keyColumn.FillWeight = 50F;
            this.keyColumn.HeaderText = "Key";
            this.keyColumn.Name = "keyColumn";
            // 
            // valueColumn
            // 
            this.valueColumn.DataPropertyName = "Value";
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            // 
            // getSecretButton
            // 
            this.getSecretButton.Location = new System.Drawing.Point(120, 38);
            this.getSecretButton.Name = "getSecretButton";
            this.getSecretButton.Size = new System.Drawing.Size(163, 56);
            this.getSecretButton.TabIndex = 8;
            this.getSecretButton.Text = "Query";
            this.getSecretButton.UseVisualStyleBackColor = true;
            this.getSecretButton.Click += new System.EventHandler(this.getSecretButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(120, 6);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(770, 26);
            this.pathTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.secretsTabPage);
            this.tabControl1.Controls.Add(this.mountsTabPage);
            this.tabControl1.Controls.Add(this.policiesTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 731);
            this.tabControl1.TabIndex = 3;
            // 
            // secretsTabPage
            // 
            this.secretsTabPage.Controls.Add(this.saveButton);
            this.secretsTabPage.Controls.Add(this.secretDataGridView);
            this.secretsTabPage.Controls.Add(this.pathTextBox);
            this.secretsTabPage.Controls.Add(this.getSecretButton);
            this.secretsTabPage.Controls.Add(this.label3);
            this.secretsTabPage.Location = new System.Drawing.Point(4, 29);
            this.secretsTabPage.Name = "secretsTabPage";
            this.secretsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.secretsTabPage.Size = new System.Drawing.Size(896, 698);
            this.secretsTabPage.TabIndex = 0;
            this.secretsTabPage.Text = "Secrets";
            this.secretsTabPage.UseVisualStyleBackColor = true;
            // 
            // mountsTabPage
            // 
            this.mountsTabPage.Controls.Add(this.mountsListBox);
            this.mountsTabPage.Location = new System.Drawing.Point(4, 29);
            this.mountsTabPage.Name = "mountsTabPage";
            this.mountsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mountsTabPage.Size = new System.Drawing.Size(896, 698);
            this.mountsTabPage.TabIndex = 1;
            this.mountsTabPage.Text = "Mounts";
            this.mountsTabPage.UseVisualStyleBackColor = true;
            // 
            // policiesTabPage
            // 
            this.policiesTabPage.Controls.Add(this.savePolicyButton);
            this.policiesTabPage.Controls.Add(this.policyDocumentTextBox);
            this.policiesTabPage.Controls.Add(this.policyNameTextBox);
            this.policiesTabPage.Controls.Add(this.label5);
            this.policiesTabPage.Controls.Add(this.label4);
            this.policiesTabPage.Controls.Add(this.policiesListBox);
            this.policiesTabPage.Location = new System.Drawing.Point(4, 29);
            this.policiesTabPage.Name = "policiesTabPage";
            this.policiesTabPage.Size = new System.Drawing.Size(896, 698);
            this.policiesTabPage.TabIndex = 2;
            this.policiesTabPage.Text = "Policies";
            this.policiesTabPage.UseVisualStyleBackColor = true;
            // 
            // policiesListBox
            // 
            this.policiesListBox.FormattingEnabled = true;
            this.policiesListBox.ItemHeight = 20;
            this.policiesListBox.Location = new System.Drawing.Point(7, 8);
            this.policiesListBox.Name = "policiesListBox";
            this.policiesListBox.Size = new System.Drawing.Size(264, 604);
            this.policiesListBox.TabIndex = 0;
            this.policiesListBox.SelectedIndexChanged += new System.EventHandler(this.policiesListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Policy name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Policy document";
            // 
            // policyNameTextBox
            // 
            this.policyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.policyNameTextBox.Location = new System.Drawing.Point(277, 31);
            this.policyNameTextBox.Name = "policyNameTextBox";
            this.policyNameTextBox.Size = new System.Drawing.Size(609, 26);
            this.policyNameTextBox.TabIndex = 3;
            // 
            // policyDocumentTextBox
            // 
            this.policyDocumentTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyDocumentTextBox.Location = new System.Drawing.Point(277, 90);
            this.policyDocumentTextBox.Multiline = true;
            this.policyDocumentTextBox.Name = "policyDocumentTextBox";
            this.policyDocumentTextBox.Size = new System.Drawing.Size(609, 522);
            this.policyDocumentTextBox.TabIndex = 4;
            // 
            // savePolicyButton
            // 
            this.savePolicyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePolicyButton.Location = new System.Drawing.Point(723, 618);
            this.savePolicyButton.Name = "savePolicyButton";
            this.savePolicyButton.Size = new System.Drawing.Size(163, 56);
            this.savePolicyButton.TabIndex = 8;
            this.savePolicyButton.Text = "Save";
            this.savePolicyButton.UseVisualStyleBackColor = true;
            this.savePolicyButton.Click += new System.EventHandler(this.savePolicyButton_Click);
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 904);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExplorerForm";
            this.Text = "ExplorerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.secretsTabPage.ResumeLayout(false);
            this.secretsTabPage.PerformLayout();
            this.mountsTabPage.ResumeLayout(false);
            this.policiesTabPage.ResumeLayout(false);
            this.policiesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unsealButton;
        private System.Windows.Forms.Button sealButton;
        private System.Windows.Forms.TextBox unsealKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sealStatusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sealStatusLabel;
        private System.Windows.Forms.ListBox mountsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button getSecretButton;
        private System.Windows.Forms.DataGridView secretDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage secretsTabPage;
        private System.Windows.Forms.TabPage mountsTabPage;
        private System.Windows.Forms.TabPage policiesTabPage;
        private System.Windows.Forms.ListBox policiesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox policyNameTextBox;
        private System.Windows.Forms.Button savePolicyButton;
        private System.Windows.Forms.TextBox policyDocumentTextBox;
    }
}