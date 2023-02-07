using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calumma.Enums
{
	/// <summary>
	/// Enum representando o tipo de formas para visualizar as cores.
	/// </summary>
	enum ETipoCores
	{
		[Description("HTML")]
		Html,
		[Description("RGB")]
		Rgb,
		[Description("C#")]
		Csharp
	}
}
