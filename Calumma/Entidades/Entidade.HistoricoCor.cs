using Calumma.Enums;
using Calumma.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calumma.Entidades
{
    /// <summary>
    /// Classe representando a cor Salva na Lista de historico.
    /// </summary>
    public class HistoricoCor : IDisposable
    {
        #region Atributos
        private DateTime _DataInclusao;
        private Color _Cor;
        private Enums.ETipoCores _Tipo;
        #endregion

        #region Contrutores
        /// <summary>
        /// Construtor da Classe HistoricoCor.
        /// </summary>
        /// <param name="cor">Cor Escolhida pelo usuário.</param>
        /// <param name="tipo">Tipo de escolha de visualização da cor atual.</param>
        public HistoricoCor(Color cor, Enums.ETipoCores tipo)
        {
            _DataInclusao = DateTime.Now;
            _Cor = cor;
            Tipo = tipo;
        }
        #endregion

        #region Propriedades
        public DateTime DataInclusao { private get => _DataInclusao; set => _DataInclusao = value; }
        public Color Cor { get => _Cor; set => _Cor = value; }
        internal ETipoCores Tipo { get => _Tipo; set => _Tipo = value; }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            return obj is HistoricoCor cor &&
                   EqualityComparer<Color>.Default.Equals(_Cor, cor._Cor);
        }
        public override int GetHashCode()
        {
            return 1766889566 + _Cor.GetHashCode();
        }
        public void Dispose() => GC.SuppressFinalize(this);
        public override string ToString()
        {
            string vRetorno = string.Empty;
            switch (this._Tipo)
            {
                case Enums.ETipoCores.Html:
                    vRetorno = this._Cor.ToStringHexDecimal();
                    break;
                case Enums.ETipoCores.Rgb:
                    vRetorno = this._Cor.ToStringRGB();
                    break;
                case Enums.ETipoCores.Csharp:
                    vRetorno = this._Cor.ToStringRGB(';');
                    break;
            }
            return vRetorno;
        }
        #endregion
    }
}
