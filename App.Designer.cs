namespace AsposeTemplateHandler
{
    partial class App
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SelectTemplateBtn = new System.Windows.Forms.Button();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.LocalDbOption = new System.Windows.Forms.RadioButton();
            this.ExcelOption = new System.Windows.Forms.RadioButton();
            this.WordOption = new System.Windows.Forms.RadioButton();
            this.TemplatePath = new System.Windows.Forms.Label();
            this.TemplateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(42, 166);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(681, 191);
            this.DataGridView.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(42, 392);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SelectTemplateBtn
            // 
            this.SelectTemplateBtn.Location = new System.Drawing.Point(42, 60);
            this.SelectTemplateBtn.Name = "SelectTemplateBtn";
            this.SelectTemplateBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectTemplateBtn.TabIndex = 2;
            this.SelectTemplateBtn.Text = "Select";
            this.SelectTemplateBtn.UseVisualStyleBackColor = true;
            this.SelectTemplateBtn.Click += new System.EventHandler(this.SelectTemplateBtn_Click);
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(39, 39);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(51, 13);
            this.TemplateLabel.TabIndex = 3;
            this.TemplateLabel.Text = "Template";
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.AutoSize = true;
            this.DataSourceLabel.Location = new System.Drawing.Point(39, 104);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(67, 13);
            this.DataSourceLabel.TabIndex = 4;
            this.DataSourceLabel.Text = "Data Source";
            // 
            // LocalDbOption
            // 
            this.LocalDbOption.AutoSize = true;
            this.LocalDbOption.Location = new System.Drawing.Point(42, 125);
            this.LocalDbOption.Name = "LocalDbOption";
            this.LocalDbOption.Size = new System.Drawing.Size(65, 17);
            this.LocalDbOption.TabIndex = 6;
            this.LocalDbOption.TabStop = true;
            this.LocalDbOption.Text = "LocalDb";
            this.LocalDbOption.UseVisualStyleBackColor = true;
            this.LocalDbOption.CheckedChanged += new System.EventHandler(this.LocalDbOption_CheckedChanged);
            // 
            // ExcelOption
            // 
            this.ExcelOption.AutoSize = true;
            this.ExcelOption.Enabled = false;
            this.ExcelOption.Location = new System.Drawing.Point(170, 125);
            this.ExcelOption.Name = "ExcelOption";
            this.ExcelOption.Size = new System.Drawing.Size(51, 17);
            this.ExcelOption.TabIndex = 7;
            this.ExcelOption.TabStop = true;
            this.ExcelOption.Text = "Excel";
            this.ExcelOption.UseVisualStyleBackColor = true;
            this.ExcelOption.CheckedChanged += new System.EventHandler(this.ExcelOption_CheckedChanged);
            // 
            // WordOption
            // 
            this.WordOption.AutoSize = true;
            this.WordOption.Location = new System.Drawing.Point(113, 125);
            this.WordOption.Name = "WordOption";
            this.WordOption.Size = new System.Drawing.Size(51, 17);
            this.WordOption.TabIndex = 8;
            this.WordOption.TabStop = true;
            this.WordOption.Text = "Word";
            this.WordOption.UseVisualStyleBackColor = true;
            this.WordOption.CheckedChanged += new System.EventHandler(this.WordOption_CheckedChanged);
            // 
            // TemplatePath
            // 
            this.TemplatePath.AutoSize = true;
            this.TemplatePath.Location = new System.Drawing.Point(123, 65);
            this.TemplatePath.Name = "TemplatePath";
            this.TemplatePath.Size = new System.Drawing.Size(280, 13);
            this.TemplatePath.TabIndex = 10;
            this.TemplatePath.Text = global::AsposeTemplateHandler.Properties.Settings.Default.TemplateBasePath;
            // 
            // TemplateFileDialog
            // 
            this.TemplateFileDialog.InitialDirectory = global::AsposeTemplateHandler.Properties.Settings.Default.TemplateBasePath;
            // 
            // SaveFolderBrowserDialog
            // 
            this.SaveFolderBrowserDialog.SelectedPath = global::AsposeTemplateHandler.Properties.Settings.Default.SaveDir;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TemplatePath);
            this.Controls.Add(this.WordOption);
            this.Controls.Add(this.ExcelOption);
            this.Controls.Add(this.LocalDbOption);
            this.Controls.Add(this.DataSourceLabel);
            this.Controls.Add(this.TemplateLabel);
            this.Controls.Add(this.SelectTemplateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DataGridView);
            this.Name = "App";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SelectTemplateBtn;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.RadioButton LocalDbOption;
        private System.Windows.Forms.RadioButton ExcelOption;
        private System.Windows.Forms.RadioButton WordOption;
        private System.Windows.Forms.OpenFileDialog TemplateFileDialog;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowserDialog;
        private System.Windows.Forms.Label TemplatePath;
    }
}

