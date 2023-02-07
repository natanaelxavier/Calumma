using Calumma.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calumma
{
    public partial class Home : Form
    {
        #region Importações do Windows
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        #endregion

        #region Atributos
        readonly Timer Observador;
        Enums.ETipoCores TipoSelecionado;
        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        Color CorDetectada;
        #endregion

        #region Constructs
        public Home()
        {
            InitializeComponent();
            this.KeyPreview = true;
            ComboTiposPesquisa.CarregarComboComEnum<Enums.ETipoCores>();
            Observador = new Timer { Interval = 1 };
            Observador.Tick += Tempo_Tick;
            Observador.Start();
        }
        void Tempo_Tick(object sender, EventArgs e)
        {
            var pt = new Point();
            GetCursorPos(ref pt);
            this.CorDetectada = CapturarCor(new Point(pt.X, pt.Y));
            CarregarNaTela();
        }
        #endregion

        #region Methods
        public Color CapturarCor(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return screenPixel.GetPixel(0, 0);
        }
        void CarregarNaTela()
        {
            try
            {
                if (this.CorDetectada != null)
                {
                    PainelDeCor.BackColor = this.CorDetectada;
                    PainelDeCor.ForeColor = this.CorDetectada.ForeColor();
                }

                switch (this.TipoSelecionado)
                {
                    case Enums.ETipoCores.Html:
                        PainelDeCor.Text = this.CorDetectada.ToStringHexDecimal();
                        break;
                    case Enums.ETipoCores.Rgb:
                        PainelDeCor.Text = this.CorDetectada.ToStringRGB();
                        break;
                    case Enums.ETipoCores.Csharp:
                        PainelDeCor.Text = this.CorDetectada.ToStringRGB(';');
                        break;
                }
            }
            catch (Exception Problema)
            {
                throw Problema;
            }
        }
        #endregion

        #region Events
        void ComboTiposPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.TipoSelecionado = (Enums.ETipoCores)((KeyValuePair<string, object>)ComboTiposPesquisa.SelectedItem).Value;
            }
            catch (Exception Problema)
            {
                MessageBox.Show(Problema.Message);
            }
        }
        private void Home_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.X)
                {
                    if (e.Alt)
                    {
                        ListViewItem item = new ListViewItem();
                        item.BackColor = this.CorDetectada;
                        item.ForeColor = this.CorDetectada.ForeColor();

                        switch (TipoSelecionado)
                        {
                            case Enums.ETipoCores.Html:
                                item.Text = this.CorDetectada.ToStringHexDecimal();
                                break;
                            case Enums.ETipoCores.Rgb:
                                item.Text = this.CorDetectada.ToStringRGB();
                                break;
                            case Enums.ETipoCores.Csharp:
                                item.Text = this.CorDetectada.ToStringRGB(';');
                                break;
                        }

                        ListBoxColors.Items.Add(item);
                    }
                }
            }
            catch (Exception Problema)
            {
                MessageBox.Show(Problema.Message);
            }
        }
        #endregion
    }
}
