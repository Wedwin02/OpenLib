using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLib.CLS
{
    class AppManager : ApplicationContext
    {
        public AppManager()
        {
            if (this.Splash())
            {
                if (this.Login())
                {
                    GUI.Principal f = new GUI.Principal();
                    f.ShowDialog();
                }
            }

        }

        private Boolean Splash()
        {
            Boolean Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
            return Resultado;
        }
        private Boolean Login()
        {
            Boolean Resultado = false;
            GUI.Login f = new GUI.Login();
            f.ShowDialog();
            Resultado = f.Autorizado;
            return Resultado;
        }

    }
}
