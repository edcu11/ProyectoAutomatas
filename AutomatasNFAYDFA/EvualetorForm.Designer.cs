namespace AutomatasNFAYDFA
{
    partial class EvualetorForm
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
            this.FileNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CheckFile = new MetroFramework.Controls.MetroTile();
            this.resultsView = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // FileNameTxt
            // 
            // 
            // 
            // 
            this.FileNameTxt.CustomButton.Image = null;
            this.FileNameTxt.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.FileNameTxt.CustomButton.Name = "";
            this.FileNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FileNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FileNameTxt.CustomButton.TabIndex = 1;
            this.FileNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FileNameTxt.CustomButton.UseSelectable = true;
            this.FileNameTxt.CustomButton.Visible = false;
            this.FileNameTxt.Lines = new string[0];
            this.FileNameTxt.Location = new System.Drawing.Point(105, 87);
            this.FileNameTxt.MaxLength = 32767;
            this.FileNameTxt.Name = "FileNameTxt";
            this.FileNameTxt.PasswordChar = '\0';
            this.FileNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FileNameTxt.SelectedText = "";
            this.FileNameTxt.SelectionLength = 0;
            this.FileNameTxt.SelectionStart = 0;
            this.FileNameTxt.ShortcutsEnabled = true;
            this.FileNameTxt.Size = new System.Drawing.Size(202, 23);
            this.FileNameTxt.TabIndex = 0;
            this.FileNameTxt.UseSelectable = true;
            this.FileNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FileNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "File Name";
            // 
            // CheckFile
            // 
            this.CheckFile.ActiveControl = null;
            this.CheckFile.Location = new System.Drawing.Point(24, 116);
            this.CheckFile.Name = "CheckFile";
            this.CheckFile.Size = new System.Drawing.Size(283, 42);
            this.CheckFile.TabIndex = 2;
            this.CheckFile.Text = "Check File";
            this.CheckFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckFile.UseSelectable = true;
            this.CheckFile.Click += new System.EventHandler(this.CheckFile_Click);
            // 
            // resultsView
            // 
            this.resultsView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultsView.FullRowSelect = true;
            this.resultsView.Location = new System.Drawing.Point(340, 64);
            this.resultsView.Name = "resultsView";
            this.resultsView.OwnerDraw = true;
            this.resultsView.Size = new System.Drawing.Size(485, 97);
            this.resultsView.TabIndex = 3;
            this.resultsView.UseCompatibleStateImageBehavior = false;
            this.resultsView.UseSelectable = true;
            // 
            // EvualetorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 221);
            this.Controls.Add(this.resultsView);
            this.Controls.Add(this.CheckFile);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.FileNameTxt);
            this.Name = "EvualetorForm";
            this.Text = "EvualetorForm";
            this.Load += new System.EventHandler(this.EvualetorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox FileNameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile CheckFile;
        private MetroFramework.Controls.MetroListView resultsView;
    }
}