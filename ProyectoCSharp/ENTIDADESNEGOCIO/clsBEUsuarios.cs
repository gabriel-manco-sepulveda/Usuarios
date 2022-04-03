using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoCSharp.ENTIDADESNEGOCIO
{
    public class clsBEUsuarios
    {
		public int ID_Usuario { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Identificacion { get; set; }
		public string Pais { get; set; }
		public int ID_Profesion { get; set; }
		public double Sueldo { get; set; }
		public string Estado { get; set; }
		public string Codigo { get; set; }
	}
}
