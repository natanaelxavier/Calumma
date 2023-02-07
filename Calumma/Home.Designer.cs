
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.CampoCodigoColor = new System.Windows.Forms.TextBox();
            this.ComboTiposPesquisa = new System.Windows.Forms.ComboBox();
            this.ListBoxColors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PainelDeCor = new System.Windows.Forms.Label();
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
            // ListBoxColors
            // 
            this.ListBoxColors.FormattingEnabled = true;
            this.ListBoxColors.Location = new System.Drawing.Point(6, 169);
            this.ListBoxColors.Name = "ListBoxColors";
            this.ListBoxColors.Size = new System.Drawing.Size(191, 199);
            this.ListBoxColors.TabIndex = 3;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 374);
            this.Controls.Add(this.PainelDeCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxColors);
            this.Controls.Add(this.ComboTiposPesquisa);
            this.Controls.Add(this.CampoCodigoColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calumma Color";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CampoCodigoColor;
        private System.Windows.Forms.ComboBox ComboTiposPesquisa;
        private System.Windows.Forms.ListBox ListBoxColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PainelDeCor;
    }
}