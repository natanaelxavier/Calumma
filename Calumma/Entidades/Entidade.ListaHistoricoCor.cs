using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calumma.Entidades
{
    public class ListaHistoricoCor : List<HistoricoCor>, IDisposable
    {
        public void Add(Color Cor, Enums.ETipoCores Tipo)
        {
            if (this.Find(t => t.Cor.Equals(Cor)) != null)
            {
                using (var obj = this.Find(t => t.Cor.Equals(Cor)))
                {
                    obj.Tipo = Tipo;
                }
            }
            else
            {
                base.Add(new HistoricoCor(Cor, Tipo));
            }
        }


        public void Dispose() => GC.SuppressFinalize(this);
    }
}
