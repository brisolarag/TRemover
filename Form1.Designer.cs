namespace TRemover
{
    partial class Form1
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.checkBoxPrefetch = new System.Windows.Forms.CheckBox();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxTempP = new System.Windows.Forms.CheckBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBoxSoftwareDistributionDownload = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 41);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(300, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(318, 41);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxPaths
            // 
            this.listBoxPaths.FormattingEnabled = true;
            this.listBoxPaths.Location = new System.Drawing.Point(12, 136);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.Size = new System.Drawing.Size(300, 264);
            this.listBoxPaths.TabIndex = 2;
            // 
            // checkBoxPrefetch
            // 
            this.checkBoxPrefetch.AutoSize = true;
            this.checkBoxPrefetch.Checked = true;
            this.checkBoxPrefetch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrefetch.Location = new System.Drawing.Point(12, 113);
            this.checkBoxPrefetch.Name = "checkBoxPrefetch";
            this.checkBoxPrefetch.Size = new System.Drawing.Size(66, 17);
            this.checkBoxPrefetch.TabIndex = 3;
            this.checkBoxPrefetch.Text = "Prefetch";
            this.checkBoxPrefetch.UseVisualStyleBackColor = true;
            this.checkBoxPrefetch.CheckedChanged += new System.EventHandler(this.checkBoxPrefetch_CheckedChanged);
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.Checked = true;
            this.checkBoxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTemp.Location = new System.Drawing.Point(12, 90);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Size = new System.Drawing.Size(53, 17);
            this.checkBoxTemp.TabIndex = 3;
            this.checkBoxTemp.Text = "Temp";
            this.checkBoxTemp.UseVisualStyleBackColor = true;
            this.checkBoxTemp.CheckedChanged += new System.EventHandler(this.checkBoxTemp_CheckedChanged);
            // 
            // checkBoxTempP
            // 
            this.checkBoxTempP.AutoSize = true;
            this.checkBoxTempP.Checked = true;
            this.checkBoxTempP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTempP.Location = new System.Drawing.Point(12, 67);
            this.checkBoxTempP.Name = "checkBoxTempP";
            this.checkBoxTempP.Size = new System.Drawing.Size(69, 17);
            this.checkBoxTempP.TabIndex = 3;
            this.checkBoxTempP.Text = "%Temp%";
            this.checkBoxTempP.UseVisualStyleBackColor = true;
            this.checkBoxTempP.CheckedChanged += new System.EventHandler(this.checkBoxTempP_CheckedChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(318, 342);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 58);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove selected from list";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 25);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(65, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Path to add:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(318, 136);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 200);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete all temporary files";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkBoxSoftwareDistributionDownload
            // 
            this.checkBoxSoftwareDistributionDownload.AutoSize = true;
            this.checkBoxSoftwareDistributionDownload.Checked = true;
            this.checkBoxSoftwareDistributionDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSoftwareDistributionDownload.Location = new System.Drawing.Point(172, 113);
            this.checkBoxSoftwareDistributionDownload.Name = "checkBoxSoftwareDistributionDownload";
            this.checkBoxSoftwareDistributionDownload.Size = new System.Drawing.Size(140, 17);
            this.checkBoxSoftwareDistributionDownload.TabIndex = 6;
            this.checkBoxSoftwareDistributionDownload.Text = "Windows Att Temp Files";
            this.checkBoxSoftwareDistributionDownload.UseVisualStyleBackColor = true;
            this.checkBoxSoftwareDistributionDownload.CheckedChanged += new System.EventHandler(this.checkBoxSoftwareDistributionDownload_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(296, 411);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by Gabriel Brisolara";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(399, 433);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxSoftwareDistributionDownload);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.checkBoxTempP);
            this.Controls.Add(this.checkBoxTemp);
            this.Controls.Add(this.checkBoxPrefetch);
            this.Controls.Add(this.listBoxPaths);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TRemover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxPaths;
        private System.Windows.Forms.CheckBox checkBoxPrefetch;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.CheckBox checkBoxTempP;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxSoftwareDistributionDownload;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

