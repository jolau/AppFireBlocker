namespace ProgrammWallBlocker
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.ofdFileDir = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseDir = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.cbInboundRule = new System.Windows.Forms.CheckBox();
            this.cbOutboundRule = new System.Windows.Forms.CheckBox();
            this.btnAddRoules = new System.Windows.Forms.Button();
            this.btnDeleteRoule = new System.Windows.Forms.Button();
            this.grpRulesOptions = new System.Windows.Forms.GroupBox();
            this.grpRulesOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(12, 28);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(418, 20);
            this.tbPath.TabIndex = 1;
            // 
            // ofdFileDir
            // 
            this.ofdFileDir.FileName = "openFileDialog1";
            this.ofdFileDir.Multiselect = true;
            this.ofdFileDir.Title = "Browse the Files/Directory";
            // 
            // btnBrowseDir
            // 
            this.btnBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDir.Location = new System.Drawing.Point(436, 12);
            this.btnBrowseDir.Name = "btnBrowseDir";
            this.btnBrowseDir.Size = new System.Drawing.Size(99, 23);
            this.btnBrowseDir.TabIndex = 2;
            this.btnBrowseDir.Text = "Browse Directory";
            this.btnBrowseDir.UseVisualStyleBackColor = true;
            this.btnBrowseDir.Click += new System.EventHandler(this.btnBrowseDir_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile.Location = new System.Drawing.Point(436, 41);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(99, 23);
            this.btnBrowseFile.TabIndex = 3;
            this.btnBrowseFile.Text = "Browse Files";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // cbInboundRule
            // 
            this.cbInboundRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInboundRule.AutoSize = true;
            this.cbInboundRule.Location = new System.Drawing.Point(15, 19);
            this.cbInboundRule.Name = "cbInboundRule";
            this.cbInboundRule.Size = new System.Drawing.Size(95, 17);
            this.cbInboundRule.TabIndex = 4;
            this.cbInboundRule.Text = "Inbound Rules";
            this.cbInboundRule.UseVisualStyleBackColor = true;
            // 
            // cbOutboundRule
            // 
            this.cbOutboundRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutboundRule.AutoSize = true;
            this.cbOutboundRule.Location = new System.Drawing.Point(116, 19);
            this.cbOutboundRule.Name = "cbOutboundRule";
            this.cbOutboundRule.Size = new System.Drawing.Size(103, 17);
            this.cbOutboundRule.TabIndex = 5;
            this.cbOutboundRule.Text = "Outbound Rules";
            this.cbOutboundRule.UseVisualStyleBackColor = true;
            // 
            // btnAddRoules
            // 
            this.btnAddRoules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoules.Location = new System.Drawing.Point(436, 79);
            this.btnAddRoules.Name = "btnAddRoules";
            this.btnAddRoules.Size = new System.Drawing.Size(99, 23);
            this.btnAddRoules.TabIndex = 6;
            this.btnAddRoules.Text = "Add Roules";
            this.btnAddRoules.UseVisualStyleBackColor = true;
            this.btnAddRoules.Click += new System.EventHandler(this.btnAddRoules_Click);
            // 
            // btnDeleteRoule
            // 
            this.btnDeleteRoule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteRoule.Location = new System.Drawing.Point(12, 79);
            this.btnDeleteRoule.Name = "btnDeleteRoule";
            this.btnDeleteRoule.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteRoule.TabIndex = 7;
            this.btnDeleteRoule.Text = "Delete Roules";
            this.btnDeleteRoule.UseVisualStyleBackColor = true;
            this.btnDeleteRoule.Click += new System.EventHandler(this.btnDeleteRoule_Click);
            // 
            // grpRulesOptions
            // 
            this.grpRulesOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRulesOptions.Controls.Add(this.cbOutboundRule);
            this.grpRulesOptions.Controls.Add(this.cbInboundRule);
            this.grpRulesOptions.Location = new System.Drawing.Point(198, 64);
            this.grpRulesOptions.Name = "grpRulesOptions";
            this.grpRulesOptions.Size = new System.Drawing.Size(232, 44);
            this.grpRulesOptions.TabIndex = 8;
            this.grpRulesOptions.TabStop = false;
            this.grpRulesOptions.Text = "Rules Options";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 120);
            this.Controls.Add(this.grpRulesOptions);
            this.Controls.Add(this.btnDeleteRoule);
            this.Controls.Add(this.btnAddRoules);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.btnBrowseDir);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Block apps with firewall";
            this.grpRulesOptions.ResumeLayout(false);
            this.grpRulesOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.OpenFileDialog ofdFileDir;
        private System.Windows.Forms.Button btnBrowseDir;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.CheckBox cbInboundRule;
        private System.Windows.Forms.CheckBox cbOutboundRule;
        private System.Windows.Forms.Button btnAddRoules;
        private System.Windows.Forms.Button btnDeleteRoule;
        private System.Windows.Forms.GroupBox grpRulesOptions;
    }
}

