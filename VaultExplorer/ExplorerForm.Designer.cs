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
            this.sealStatusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sealStatusLabel = new System.Windows.Forms.Label();
            this.mountsGroupBox = new System.Windows.Forms.GroupBox();
            this.secretsGroupBox = new System.Windows.Forms.GroupBox();
            this.mountsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.getSecretButton = new System.Windows.Forms.Button();
            this.secretDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.mountsGroupBox.SuspendLayout();
            this.secretsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretDataGridView)).BeginInit();
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
            // mountsGroupBox
            // 
            this.mountsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mountsGroupBox.Controls.Add(this.mountsListBox);
            this.mountsGroupBox.Location = new System.Drawing.Point(12, 161);
            this.mountsGroupBox.Name = "mountsGroupBox";
            this.mountsGroupBox.Size = new System.Drawing.Size(279, 731);
            this.mountsGroupBox.TabIndex = 1;
            this.mountsGroupBox.TabStop = false;
            this.mountsGroupBox.Text = "Mounts";
            // 
            // secretsGroupBox
            // 
            this.secretsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secretsGroupBox.Controls.Add(this.saveButton);
            this.secretsGroupBox.Controls.Add(this.secretDataGridView);
            this.secretsGroupBox.Controls.Add(this.getSecretButton);
            this.secretsGroupBox.Controls.Add(this.pathTextBox);
            this.secretsGroupBox.Controls.Add(this.label3);
            this.secretsGroupBox.Location = new System.Drawing.Point(297, 161);
            this.secretsGroupBox.Name = "secretsGroupBox";
            this.secretsGroupBox.Size = new System.Drawing.Size(619, 731);
            this.secretsGroupBox.TabIndex = 2;
            this.secretsGroupBox.TabStop = false;
            this.secretsGroupBox.Text = "Secrets";
            // 
            // mountsListBox
            // 
            this.mountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mountsListBox.FormattingEnabled = true;
            this.mountsListBox.ItemHeight = 20;
            this.mountsListBox.Location = new System.Drawing.Point(14, 25);
            this.mountsListBox.MultiColumn = true;
            this.mountsListBox.Name = "mountsListBox";
            this.mountsListBox.Size = new System.Drawing.Size(252, 684);
            this.mountsListBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(113, 25);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(500, 26);
            this.pathTextBox.TabIndex = 1;
            // 
            // getSecretButton
            // 
            this.getSecretButton.Location = new System.Drawing.Point(113, 57);
            this.getSecretButton.Name = "getSecretButton";
            this.getSecretButton.Size = new System.Drawing.Size(163, 56);
            this.getSecretButton.TabIndex = 8;
            this.getSecretButton.Text = "Query";
            this.getSecretButton.UseVisualStyleBackColor = true;
            this.getSecretButton.Click += new System.EventHandler(this.getSecretButton_Click);
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
            this.secretDataGridView.Location = new System.Drawing.Point(10, 119);
            this.secretDataGridView.Name = "secretDataGridView";
            this.secretDataGridView.RowTemplate.Height = 28;
            this.secretDataGridView.Size = new System.Drawing.Size(603, 590);
            this.secretDataGridView.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.DarkRed;
            this.saveButton.Location = new System.Drawing.Point(450, 57);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 56);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 904);
            this.Controls.Add(this.secretsGroupBox);
            this.Controls.Add(this.mountsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExplorerForm";
            this.Text = "ExplorerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mountsGroupBox.ResumeLayout(false);
            this.secretsGroupBox.ResumeLayout(false);
            this.secretsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretDataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox mountsGroupBox;
        private System.Windows.Forms.GroupBox secretsGroupBox;
        private System.Windows.Forms.ListBox mountsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button getSecretButton;
        private System.Windows.Forms.DataGridView secretDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
    }
}