using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loteria.Modal
{
    public interface IJogo
    {
        IList<int> GeraJogoAleatorio();
        IList<int> GetResultado();

    }
}
