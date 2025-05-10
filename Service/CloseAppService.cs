using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Voluntariado.Service
{
   public static class CloseAppService
    {
        public static void CloseApp(object sender, FormClosingEventArgs e) { 
        
            Application.ExitThread();
                
        }

    }
}
