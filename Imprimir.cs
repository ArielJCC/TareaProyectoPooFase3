using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    //Se implementa la Clase Imprimir que implementa a la interfaz ICommand
    class Imprimir : ICommand
    {
        Cliente datos;

        public Imprimir(Cliente pdatos)
        {
            datos = pdatos;
        }

        public void Ejecutar()
        {
            datos.Imprimir();
            //Se invoca la acción relacionada con los Datos en específico del cliente
        }
    }
}
