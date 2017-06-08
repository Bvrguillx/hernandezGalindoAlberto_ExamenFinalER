using hernandezGalindoAlberto_ExamenFinalER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hernandezGalindoAlberto_ExamenFinalER.Models
{
    public abstract class Animal : IPesable
    {
        // ATRIBUTOS
        public string nombreAni;
        public string fechaNacimientoAni;
        public double pesoAni;
        public string comentariosAni;
        public double IPeso { get; set; }

        // CONSTRUCTOR VACIO
        protected Animal() { }

        // CONSTRUCTOR CON LOS ATRIBUTOS
        protected Animal(string nombreAni, string fechaNacimientoAni, double pesoAni)
        {
            nombreProp = nombreAni;
            fechaNacimientoProp = fechaNacimientoAni;
            pesoProp = pesoAni;
            comentariosProp = null;
        }

        // GETTERS & SETTERS
        protected string nombreProp
        {
            get
            {
                if (string.IsNullOrEmpty(nombreAni))
                {
                    throw new Exception("ERROR: Nombre no establecido");
                }
                return nombreAni;
            }
            set
            {
                // SOLO LECTURA PARA ESTA PROPIEDAD
            }
        }
        protected string fechaNacimientoProp
        {
            get
            {
                if (string.IsNullOrEmpty(fechaNacimientoAni))
                {
                    throw new Exception("ERROR: Fecha no establecida");
                }
                return fechaNacimientoAni;
            }
            set
            {
                // SOLO LECTURA PARA ESTA PROPIEDAD
            }
        }
        protected double pesoProp
        {
            get
            {
                if (pesoAni < 0)
                {
                    throw new Exception("ERROR: Peso Incorrecto o No establecido");
                }
                return pesoAni;
            }
            set
            {
                // SOLO LECTURA PARA ESTA PROPIEDAD
            }
        }
        public string comentariosProp
        {
            get
            {
                return comentariosAni;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Comentarios no establecidos");
                } else
                {
                    comentariosAni = value;
                }
            }
        }

        public void IPesar(double peso)
        {
            this.IPeso = peso;
        }
    }
}
