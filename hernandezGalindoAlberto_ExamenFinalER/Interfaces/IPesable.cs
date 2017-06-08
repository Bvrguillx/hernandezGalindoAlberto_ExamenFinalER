using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hernandezGalindoAlberto_ExamenFinalER.Interfaces
{
    public interface IPesable
    {
        double IPeso { get; set; }

        void IPesar(double peso);
    }
}
