using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hernandezGalindoAlberto_ExamenFinalER.Models
{
    public class Pajaro : Animal
    {
        // ATRIBUTOS ADICIONALES
        protected string especie;
        protected bool cantor;

        // CONSTRUCTOR
        public Pajaro(string nombre, string especie, string fechaNacimiento,
            double peso, bool cantor)
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
                "Cantor: " + cantor + "\n" +
                "Comentarios: " + comentariosAni + "\n";
        }
    }
}
