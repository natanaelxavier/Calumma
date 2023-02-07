
namespace Calumma
{
    partial class Home
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "A"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "B"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.AppWorkspace, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "C"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "D"}, -1, System.Drawing.Color.White, System.Drawing.SystemColors.InfoText, null);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "E"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "F"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "G"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Yellow, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.CampoCodigoColor = new System.Windows.Forms.TextBox();
            this.ComboTiposPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PainelDeCor = new System.Windows.Forms.Label();
            this.ListBoxColors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CampoCodigoColor
            // 
            this.CampoCodigoColor.Location = new System.Drawing.Point(6, 110);
            this.CampoCodigoColor.Name = "CampoCodigoColor";
            this.CampoCodigoColor.Size = new System.Drawing.Size(191, 20);
            this.CampoCodigoColor.TabIndex = 1;
            // 
            // ComboTiposPesquisa
            // 
            this.ComboTiposPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTiposPesquisa.FormattingEnabled = true;
            this.ComboTiposPesquisa.Location = new System.Drawing.Point(6, 83);
            this.ComboTiposPesquisa.Name = "ComboTiposPesquisa";
            this.ComboTiposPesquisa.Size = new System.Drawing.Size(191, 21);
            this.ComboTiposPesquisa.TabIndex = 2;
            this.ComboTiposPesquisa.SelectedIndexChanged += new System.EventHandler(this.ComboTiposPesquisa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Cores";
            // 
            // PainelDeCor
            // 
            this.PainelDeCor.BackColor = System.Drawing.Color.DimGray;
            this.PainelDeCor.Location = new System.Drawing.Point(6, 6);
            this.PainelDeCor.Name = "PainelDeCor";
            this.PainelDeCor.Size = new System.Drawing.Size(191, 71);
            this.PainelDeCor.TabIndex = 5;
            this.PainelDeCor.Text = "#000000";
            this.PainelDeCor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBoxColors
            // 
            this.ListBoxColors.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListBoxColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListBoxColors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.ListBoxColors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.ListBoxColors.Location = new System.Drawing.Point(6, 167);
            this.ListBoxColors.MultiSelect = false;
            this.ListBoxColors.Name = "ListBoxColors";
            this.ListBoxColors.ShowGroups = false;
            this.ListBoxColors.Size = new System.Drawing.Size(191, 199);
            this.ListBoxColors.TabIndex = 6;
            this.ListBoxColors.TileSize = new System.Drawing.Size(1, 1);
            this.ListBoxColors.UseCompatibleStateImageBehavior = false;
            this.ListBoxColors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coluna";
            this.columnHeader1.Width = 95;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 374);
            this.Controls.Add(this.PainelDeCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboTiposPesquisa);
            this.Controls.Add(this.CampoCodigoColor);
            this.Controls.Add(this.ListBoxColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calumma Color";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Home_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CampoCodigoColor;
        private System.Windows.Forms.ComboBox ComboTiposPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PainelDeCor;
        private System.Windows.Forms.ListView ListBoxColors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}