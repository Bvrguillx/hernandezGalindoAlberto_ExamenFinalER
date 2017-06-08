using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hernandezGalindoAlberto_ExamenFinalER.Models
{
    public class Gato : Animal
    {
        // ATRIBUTOS ADICIONALES
        protected string raza;
        protected string microChip;

        // CONSTRUCTOR
        public Gato(string nombre, string raza, string fechaNacimiento,
            double peso, string microChip)
            : 
            base (nombre, fechaNacimiento, peso)
        {

        }
        public string toString()
        {
            return "Ficha de Gato \n" +
                "Nombre: " + nombreAni + "\n" +
                "Raza: " + raza + "\n" +
                "Fecha: " + fechaNacimientoAni + "\n" +
                "Peso: " + pesoAni + "\n" +
                "Microchip: " + microChip + "\n" +
                "Comentarios: " + comentariosAni + "\n";
        }
    }
}
