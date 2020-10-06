using General.CLS;
using General.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.GUI.Ventas
{
    public interface Contrato
    {
        void addDetalle(DetalleVenta d);
        void addBufferStock(BufferStock b);
    }
}
