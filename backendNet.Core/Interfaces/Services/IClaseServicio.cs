using backendNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Core.Interfaces.Services
{
    public interface IClaseServicio
    {
        Task<Clase> GetClaseID(int Id);
        Task<IEnumerable<Clase>> GetAll();
        Task<Clase> CrearClase(Clase nuevaClase);
        Task<Clase> ActualizarClase(int Idclase , Clase actualizarClase);
        Task EliminarClase(int IdClase);

    }
}
