using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Core.Entities
{
    public class Escuela
    {
        public Escuela() {
            Clases = new Collection<Clase>();

        }

        public int Id { get; set; }
        public string Nombre { get; set; }  
        public string Direccion { set; get; }   
        public ICollection<Clase> Clases { get; set; }
    }
}
