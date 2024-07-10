using backendNet.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Core.Interfaces
{
    public interface ITareasRepositorio: IDisposable
    {
        IEscuelaRepositorio EscuelaRepositorio { get; }
        IClaseRepositorio ClaseRepositorio { get; }
        Task<int> CommitAsync();
    }
}
