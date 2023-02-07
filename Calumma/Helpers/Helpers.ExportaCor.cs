using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calumma.Helpers
{
    /// <summary>
    /// Classe de apoio para exportar a cor de acordo com a escolha do usuário.
    /// </summary>
    internal static class HelpExportaCor
    {
        #region ToStrings
        public static string ToStringHexDecimal(this Color c)
        {
            try
            {
                return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception Problema)
            {
                throw new Exception(Problema.Message);
            }
        }
        public static string ToStringRGB(this Color c,char Divisor = ',')
        {
            return string.Format(@"{0}#{1}#{2}", c.R, c.G, c.B).Replace('#',Divisor);
        }
        #endregion

        #region Retorna Cores
        public static Color ForeColor(this Color c)
        {
            return (Convert.ToInt32(((c.R) + c.G + c.B / 1000))) > 150 ? Color.Black : Color.White;
        }
        #endregion
    }
}
