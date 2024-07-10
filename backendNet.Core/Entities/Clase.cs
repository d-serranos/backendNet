using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Core.Entities
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { set; get; }
        public int EscuelaId { set; get; }
        public Escuela Escuela { set; get; }
    }
}
