using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hernandezGalindoAlberto_ExamenFinalER.Models
{
    public class ClinicaVeterinaria
    {
        protected List<Animal> ListaAnimales { get; set; }

        public ClinicaVeterinaria()
        {
            ListaAnimales = new List<Animal>();
            menuPrincipal();
        }

        public void menuPrincipal()
        {
            Console.WriteLine("BIENVENIDO A LA CLINICA DE BVRGUILLX");
            string opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine("------- MENU PRINCIPAL -------");
                Console.WriteLine("");
                Console.WriteLine("(1). AÑADIR ANIMAL ");
                Console.WriteLine("(2). BUSCAR ANIMAL ");
                Console.WriteLine("(3). MODIFICAR COMENTARIOS DEL ANIMAL ");
                Console.WriteLine("(4). PESAR ANIMAL");
                Console.WriteLine("(5). MOSTRAR FICHA DEL ANIMAL");

                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        aniadirAnimal();
                        break;
                    case "2":
                        BuscarAnimal();
                        break;
                    case "3":
                        // SIN METODO
                        break;
                    case "4":
                        pesarAnimal();
                        break;
                    case "5":
                        Console.WriteLine("HOLA MANIN");
                        break;
                }
            } while (opcion != "1");
        }

        private string subMenu()
        {
            string opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine("----- TIPO ANIMAL -----");
                Console.WriteLine("");
                Console.WriteLine(" (1). PERRO ");
                Console.WriteLine(" (2). GATO ");
                Console.WriteLine(" (3). PAJARO ");
                Console.WriteLine(" (4). REPTIL ");
                Console.WriteLine();
                Console.WriteLine("¿TIPO DE ANIMAL?: ");

                opcion = Console.ReadLine();
            } while (opcion == "1");
            return opcion;
        }
        public void aniadirAnimal()
        {
            // ATRIBUTOS
            string nombre;
            string fechaNacimiento;
            double peso;

            // INTRODUCIR DATOS POR PANTALLA
            Console.WriteLine("NOMBRE: ");
            nombre = Console.ReadLine();
            Console.WriteLine("FECHA: ");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("PESO: ");
            peso = Console.Read();

            string variableAuxiliar;

            switch (subMenu())
            {
                case "1":
                    string razaPerro, microChipPerro;
                    Console.WriteLine("RAZA: ");
                    razaPerro = Console.ReadLine();
                    Console.WriteLine("MICROCHIP: ");
                    microChipPerro = Console.ReadLine();
                    Perro P = new Perro(nombre, razaPerro, fechaNacimiento, peso, microChipPerro);
                    InsertarAnimal(P);
                    break;
                case "2":
                    string razaGato, microChripGato;
                    Console.WriteLine("RAZA: ");
                    razaGato = Console.ReadLine();
                    Console.WriteLine("MICROCHIP: ");
                    microChripGato = Console.ReadLine();
                    Gato G = new Gato(nombre, razaGato, fechaNacimiento, peso, microChripGato);
                    InsertarAnimal(G);
                    break;
                case "3":
                    string especiePajaro;
                    bool cantor = false;
                    Console.WriteLine("ESPECIE: ");
                    especiePajaro = Console.ReadLine();
                    Console.WriteLine("¿CANTA?: (1). SI (2). NO");
                    do
                    {
                        variableAuxiliar = Console.ReadLine();
                    } while (variableAuxiliar != "1" || variableAuxiliar != "2");
                    if (variableAuxiliar == "1")
                    {
                        cantor = true;
                    } else if (variableAuxiliar == "2")
                    {
                        cantor = false;
                    } else
                    {
                        Console.WriteLine("ERROR: OPCION SELECCIONADA NO VALIDA");
                    }
                    Pajaro Paj = new Pajaro(nombre, especiePajaro, fechaNacimiento, peso, cantor);
                    InsertarAnimal(Paj);
                    break;
                case "4":
                    string especieReptil;
                    bool venenoso = false;
                    Console.WriteLine("ESPECIE: ");
                    especieReptil = Console.ReadLine();
                    Console.WriteLine("¿VENENOSO?: (1). SI (2). NO");
                    do
                    {
                        variableAuxiliar = Console.ReadLine();
                    } while (variableAuxiliar != "1" || variableAuxiliar != "2");
                    if (variableAuxiliar == "1")
                    {
                        venenoso = true;
                    }
                    else if (variableAuxiliar == "2")
                    {
                        venenoso = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: OPCION SELECCIONADA NO VALIDA");
                    }
                    Reptil R = new Reptil(nombre, especieReptil, fechaNacimiento, peso, venenoso);
                    InsertarAnimal(R);
                    break;
            }
        }
        private void InsertarAnimal(Animal a)
        {
            if (!this.ListaAnimales.Contains(a))
            {
                this.ListaAnimales.Add(a);
            } else
            {
                Console.WriteLine("EL ANIMAL " + a.nombreAni + " YA ESTA EN LA CLINICA");
            }
        }
        private void BuscarAnimal()
        {
            Console.WriteLine("¿NOMBRE DE SU MASCOTA, PORFAVOR?:");
            string nombreAuxiliar = Console.ReadLine();
            Animal aBuscar = null;
            foreach (Animal a in ListaAnimales)
            {
                if (a.nombreAni.Equals(nombreAuxiliar))
                {
                    aBuscar = a;
                }
            }
            // SI LO ENCUENTRA, LO MUESTRA
            if (aBuscar != null || ListaAnimales.Contains(aBuscar))
            {
                Console.WriteLine(aBuscar);
            } else
            {
                Console.WriteLine("ERROR: NO HEMOS ENCONTRADO EL ANIMAL");
            }
        }
        public void pesarAnimal()
        {
            string nombre;
            Console.WriteLine("¿NOMBRE DEL ANIMAL?: ");
            nombre = Console.ReadLine();
            Animal aBuscar = null;

            foreach (Animal a in ListaAnimales)
            {
                if (a.nombreAni.Equals(nombre))
                {
                    aBuscar = a;
                }
            }
            // SI LO ENCUENTRA, NOS DEJA MODIFICAR
            /**
            * NO ME TERMINA DE FUNCIONAR ESTE METODO
    
            **/
            // if (aBuscar != null || ListaAnimales.Contains(aBuscar))
            // {
            //     Console.WriteLine("COMENTARIOS NUEVOS: ");
            //    aBuscar.IPeso = Console.Read();
            // }
        }
    }
}
