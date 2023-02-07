using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calumma.Helpers
{
    /// <summary>
    /// Classe de apoio ao carregamento dos combosBox.
    /// </summary>
    internal static class HelpComboBox
    {
        public static void CarregarComboComEnum<TEnum>(this ComboBox comboBox)
        {
            var enumTipo = typeof(TEnum);

            var campos = enumTipo.GetMembers()
                                  .OfType<FieldInfo>()
                                  .Where(p => p.MemberType == MemberTypes.Field)
                                  .Where(p => p.IsLiteral)
                                  .ToList();

            var valoresPorNome = new Dictionary<string, object>();

            foreach (var campo in campos)
            {
                var descricaoAtributo = campo.GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;

                var valor = (int)campo.GetValue(null);
                var descricao = string.Empty;

                if (!string.IsNullOrEmpty(descricaoAtributo?.Description))
                {
                    descricao = descricaoAtributo.Description;
                }
                else
                {
                    descricao = campo.Name;
                }

                valoresPorNome[descricao] = valor;
            }

            comboBox.DataSource = valoresPorNome.ToList();
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
        }
    }
}
