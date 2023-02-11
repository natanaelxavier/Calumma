
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
            this.label1 = new System.Windows.Forms.Label();
            this.PainelDeCor = new System.Windows.Forms.Label();
            this.GridHistoricoCores = new System.Windows.Forms.DataGridView();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistoricoCores)).BeginInit();
            this.SuspendLayout();
            // 
            // CampoCodigoColor
            // 
            this.CampoCodigoColor.Location = new System.Drawing.Point(6, 110);
            this.CampoCodigoColor.Name = "CampoCodigoColor";
            this.CampoCodigoColor.ReadOnly = true;
            this.CampoCodigoColor.Size = new System.Drawing.Size(191, 20);
            this.CampoCodigoColor.TabIndex = 1;
            this.CampoCodigoColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // GridHistoricoCores
            // 
            this.GridHistoricoCores.AllowUserToAddRows = false;
            this.GridHistoricoCores.AllowUserToDeleteRows = false;
            this.GridHistoricoCores.AllowUserToResizeColumns = false;
            this.GridHistoricoCores.AllowUserToResizeRows = false;
            this.GridHistoricoCores.BackgroundColor = System.Drawing.Color.White;
            this.GridHistoricoCores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHistoricoCores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridHistoricoCores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistoricoCores.ColumnHeadersVisible = false;
            this.GridHistoricoCores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cor});
            this.GridHistoricoCores.Location = new System.Drawing.Point(6, 171);
            this.GridHistoricoCores.MultiSelect = false;
            this.GridHistoricoCores.Name = "GridHistoricoCores";
            this.GridHistoricoCores.ReadOnly = true;
            this.GridHistoricoCores.RowHeadersVisible = false;
            this.GridHistoricoCores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridHistoricoCores.Size = new System.Drawing.Size(191, 195);
            this.GridHistoricoCores.TabIndex = 6;
            this.GridHistoricoCores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHistoricoCores_CellClick);
            this.GridHistoricoCores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridHistoricoCores_CellFormatting);
            this.GridHistoricoCores.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridHistoricoCores_RowPrePaint);
            // 
            // Cor
            // 
            this.Cor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cor.DataPropertyName = "Cor";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alt + X";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridHistoricoCores);
            this.Controls.Add(this.PainelDeCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboTiposPesquisa);
            this.Controls.Add(this.CampoCodigoColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calumma Color";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Home_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistoricoCores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CampoCodigoColor;
        private System.Windows.Forms.ComboBox ComboTiposPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PainelDeCor;
        private System.Windows.Forms.DataGridView GridHistoricoCores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.Label label2;
    }
}