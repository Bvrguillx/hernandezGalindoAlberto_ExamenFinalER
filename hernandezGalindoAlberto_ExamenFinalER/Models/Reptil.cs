using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hernandezGalindoAlberto_ExamenFinalER.Models
{
    public class Reptil : Animal
    {
        // ATRIBUTOS ADICIONALES
        protected string especie;
        protected bool venenoso;

        // CONSTRUCTOR
        public Reptil (string nombre, string especie, string fechaNacimiento,
            double peso, bool venenoso)
            : 
            base (nombre, fechaNacimiento, peso)
        {

        }
        public string toString()
        {
            return "Ficha de Pajaro \n" +
                "Nombre: " + nombreAni + "\n" +
                "Especie: " + especie + "\n" +
                "Fecha: " + fechaNacimientoAni + "\n" +
                "Peso: " + pesoAni + "\n" +
                "Venenoso: " + venenoso + "\n" +
                "Comentarios: " + comentariosAni + "\n";
        }
    }
}
