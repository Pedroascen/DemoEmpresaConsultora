using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaEstadistica { 

    static class Program
    {
        static void Main(){
            Application.Run(new Bienvenida());
            Application.Run(new LoginWF());
        }
    }
}
