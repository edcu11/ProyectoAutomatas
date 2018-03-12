namespace AutomatasNFAYDFA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.AddSymbolBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.symbolTxt = new MetroFramework.Controls.MetroTextBox();
            this.tablaDeEstados = new MetroFramework.Controls.MetroListView();
            this.SymbolsTable = new MetroFramework.Controls.MetroListView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.stateFromCB = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AddTransitionBtn = new MetroFramework.Controls.MetroButton();
            this.stateToCB = new MetroFramework.Controls.MetroComboBox();
            this.SymbolsCb = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.IsAcceptable = new MetroFramework.Controls.MetroCheckBox();
            this.IsInitial = new MetroFramework.Controls.MetroCheckBox();
            this.AddStateBtn = new MetroFramework.Controls.MetroButton();
            this.stateNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.LoadFile = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.AddSymbolBtn);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.symbolTxt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(609, 160);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(122, 87);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // AddSymbolBtn
            // 
            this.AddSymbolBtn.Location = new System.Drawing.Point(3, 45);
            this.AddSymbolBtn.Name = "AddSymbolBtn";
            this.AddSymbolBtn.Size = new System.Drawing.Size(114, 23);
            this.AddSymbolBtn.TabIndex = 6;
            this.AddSymbolBtn.Text = "Add Symbol";
            this.AddSymbolBtn.UseSelectable = true;
            this.AddSymbolBtn.Click += new System.EventHandler(this.AddSymbolBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Symbol";
            // 
            // symbolTxt
            // 
            // 
            // 
            // 
            this.symbolTxt.CustomButton.Image = null;
            this.symbolTxt.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.symbolTxt.CustomButton.Name = "";
            this.symbolTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.symbolTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.symbolTxt.CustomButton.TabIndex = 1;
            this.symbolTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.symbolTxt.CustomButton.UseSelectable = true;
            this.symbolTxt.CustomButton.Visible = false;
            this.symbolTxt.Lines = new string[0];
            this.symbolTxt.Location = new System.Drawing.Point(62, 16);
            this.symbolTxt.MaxLength = 32767;
            this.symbolTxt.Name = "symbolTxt";
            this.symbolTxt.PasswordChar = '\0';
            this.symbolTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.symbolTxt.SelectedText = "";
            this.symbolTxt.SelectionLength = 0;
            this.symbolTxt.SelectionStart = 0;
            this.symbolTxt.ShortcutsEnabled = true;
            this.symbolTxt.Size = new System.Drawing.Size(55, 23);
            this.symbolTxt.TabIndex = 2;
            this.symbolTxt.UseSelectable = true;
            this.symbolTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.symbolTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.symbolTxt.Enter += new System.EventHandler(this.symbolTxt_Enter);
            // 
            // tablaDeEstados
            // 
            this.tablaDeEstados.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.tablaDeEstados.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tablaDeEstados.FullRowSelect = true;
            this.tablaDeEstados.GridLines = true;
            this.tablaDeEstados.Location = new System.Drawing.Point(23, 160);
            this.tablaDeEstados.Name = "tablaDeEstados";
            this.tablaDeEstados.OwnerDraw = true;
            this.tablaDeEstados.Size = new System.Drawing.Size(481, 291);
            this.tablaDeEstados.TabIndex = 1;
            this.tablaDeEstados.UseCompatibleStateImageBehavior = false;
            this.tablaDeEstados.UseSelectable = true;
            // 
            // SymbolsTable
            // 
            this.SymbolsTable.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.SymbolsTable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SymbolsTable.FullRowSelect = true;
            this.SymbolsTable.GridLines = true;
            this.SymbolsTable.Location = new System.Drawing.Point(511, 159);
            this.SymbolsTable.Name = "SymbolsTable";
            this.SymbolsTable.OwnerDraw = true;
            this.SymbolsTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SymbolsTable.Size = new System.Drawing.Size(92, 291);
            this.SymbolsTable.TabIndex = 5;
            this.SymbolsTable.UseCompatibleStateImageBehavior = false;
            this.SymbolsTable.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.stateFromCB);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.AddTransitionBtn);
            this.metroPanel2.Controls.Add(this.stateToCB);
            this.metroPanel2.Controls.Add(this.SymbolsCb);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(245, 67);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(358, 87);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // stateFromCB
            // 
            this.stateFromCB.FormattingEnabled = true;
            this.stateFromCB.ItemHeight = 23;
            this.stateFromCB.Location = new System.Drawing.Point(75, 14);
            this.stateFromCB.Name = "stateFromCB";
            this.stateFromCB.Size = new System.Drawing.Size(121, 29);
            this.stateFromCB.TabIndex = 8;
            this.stateFromCB.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "From";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(200, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Symbol";
            // 
            // AddTransitionBtn
            // 
            this.AddTransitionBtn.Location = new System.Drawing.Point(237, 49);
            this.AddTransitionBtn.Name = "AddTransitionBtn";
            this.AddTransitionBtn.Size = new System.Drawing.Size(99, 23);
            this.AddTransitionBtn.TabIndex = 4;
            this.AddTransitionBtn.Text = "Add Transition";
            this.AddTransitionBtn.UseSelectable = true;
            this.AddTransitionBtn.Click += new System.EventHandler(this.AddTransitionBtn_Click);
            // 
            // stateToCB
            // 
            this.stateToCB.FormattingEnabled = true;
            this.stateToCB.ItemHeight = 23;
            this.stateToCB.Location = new System.Drawing.Point(228, 14);
            this.stateToCB.Name = "stateToCB";
            this.stateToCB.Size = new System.Drawing.Size(121, 29);
            this.stateToCB.TabIndex = 3;
            this.stateToCB.UseSelectable = true;
            // 
            // SymbolsCb
            // 
            this.SymbolsCb.FormattingEnabled = true;
            this.SymbolsCb.ItemHeight = 23;
            this.SymbolsCb.Location = new System.Drawing.Point(75, 49);
            this.SymbolsCb.Name = "SymbolsCb";
            this.SymbolsCb.Size = new System.Drawing.Size(121, 29);
            this.SymbolsCb.TabIndex = 2;
            this.SymbolsCb.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.IsAcceptable);
            this.metroPanel3.Controls.Add(this.IsInitial);
            this.metroPanel3.Controls.Add(this.AddStateBtn);
            this.metroPanel3.Controls.Add(this.stateNameTxt);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(23, 67);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(216, 87);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // IsAcceptable
            // 
            this.IsAcceptable.AutoSize = true;
            this.IsAcceptable.Location = new System.Drawing.Point(12, 63);
            this.IsAcceptable.Name = "IsAcceptable";
            this.IsAcceptable.Size = new System.Drawing.Size(85, 15);
            this.IsAcceptable.TabIndex = 10;
            this.IsAcceptable.Text = "Acceptance";
            this.IsAcceptable.UseSelectable = true;
            // 
            // IsInitial
            // 
            this.IsInitial.AutoSize = true;
            this.IsInitial.Location = new System.Drawing.Point(12, 45);
            this.IsInitial.Name = "IsInitial";
            this.IsInitial.Size = new System.Drawing.Size(52, 15);
            this.IsInitial.TabIndex = 9;
            this.IsInitial.Text = "Initial";
            this.IsInitial.UseSelectable = true;
            // 
            // AddStateBtn
            // 
            this.AddStateBtn.Location = new System.Drawing.Point(103, 49);
            this.AddStateBtn.Name = "AddStateBtn";
            this.AddStateBtn.Size = new System.Drawing.Size(96, 23);
            this.AddStateBtn.TabIndex = 8;
            this.AddStateBtn.Text = "Add State";
            this.AddStateBtn.UseSelectable = true;
            this.AddStateBtn.Click += new System.EventHandler(this.AddStateBtn_Click);
            // 
            // stateNameTxt
            // 
            // 
            // 
            // 
            this.stateNameTxt.CustomButton.Image = null;
            this.stateNameTxt.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.stateNameTxt.CustomButton.Name = "";
            this.stateNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.stateNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stateNameTxt.CustomButton.TabIndex = 1;
            this.stateNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stateNameTxt.CustomButton.UseSelectable = true;
            this.stateNameTxt.CustomButton.Visible = false;
            this.stateNameTxt.Lines = new string[0];
            this.stateNameTxt.Location = new System.Drawing.Point(97, 16);
            this.stateNameTxt.MaxLength = 32767;
            this.stateNameTxt.Name = "stateNameTxt";
            this.stateNameTxt.PasswordChar = '\0';
            this.stateNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stateNameTxt.SelectedText = "";
            this.stateNameTxt.SelectionLength = 0;
            this.stateNameTxt.SelectionStart = 0;
            this.stateNameTxt.ShortcutsEnabled = true;
            this.stateNameTxt.Size = new System.Drawing.Size(102, 23);
            this.stateNameTxt.TabIndex = 7;
            this.stateNameTxt.UseSelectable = true;
            this.stateNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stateNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "State Name";
            // 
            // LoadFile
            // 
            this.LoadFile.ActiveControl = null;
            this.LoadFile.Location = new System.Drawing.Point(612, 379);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(114, 71);
            this.LoadFile.TabIndex = 7;
            this.LoadFile.Text = "Load File";
            this.LoadFile.UseSelectable = true;
            this.LoadFile.Click += new System.EventHandler(this.Evaluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 473);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.SymbolsTable);
            this.Controls.Add(this.tablaDeEstados);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton AddSymbolBtn;
        private MetroFramework.Controls.MetroListView SymbolsTable;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox symbolTxt;
        private MetroFramework.Controls.MetroListView tablaDeEstados;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton AddTransitionBtn;
        private MetroFramework.Controls.MetroComboBox stateToCB;
        private MetroFramework.Controls.MetroComboBox SymbolsCb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton AddStateBtn;
        private MetroFramework.Controls.MetroTextBox stateNameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox IsAcceptable;
        private MetroFramework.Controls.MetroCheckBox IsInitial;
        private MetroFramework.Controls.MetroComboBox stateFromCB;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile LoadFile;
    }
}

