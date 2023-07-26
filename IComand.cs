using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    //Aplicación del Patron de diseño Command mediante una interfaz
    //que contine el método Ejecutar
    interface ICommand
    {
        void Ejecutar();
    }
}
