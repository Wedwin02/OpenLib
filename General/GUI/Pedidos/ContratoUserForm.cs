using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.GUI.Pedidos
{
    public interface ContratoUserForm
    {
        void RefreshItems(int IdPedido, ItemPedido itemCuston);
    }
}
