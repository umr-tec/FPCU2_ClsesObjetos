using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOC_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ClaseCasa
            //    Casa.valor = "2342";
            //    //2. Crear las instancias necesarias
            //    //nombreClase nombreObjeto = new nombreClase();
            //    Casa objetoCasa1 = new Casa("UMR", "MTZ", ConsoleColor.Blue);
            //    Casa objetoCasa2 = new Casa("Luis Diego","Barajas", ConsoleColor.Green);

            //    //Acceder a los miembros de una clase
            //    //Como?: nombreObjeto.Accion
            //   // objetoCasa1.NombreDuenoCasa = "UMR";
            //  //  objetoCasa1.ApellidoDuenoCasa = "MTZ";
            ////    objetoCasa1.ColorCasa = ConsoleColor.Green;
            //    objetoCasa1.EngancheCasa = 2349.32;
            //    objetoCasa1.ColorCasa = ConsoleColor.White;


            //    //Imprimir los valores de las Propiedades
            //    objetoCasa1.MostrarDetalles();


            //    //
            //    objetoCasa2.NombreDuenoCasa = "Álvaro";
            //    objetoCasa2.ApellidoDuenoCasa = "Sánchez";
            //    objetoCasa2.ColorCasa = ConsoleColor.Red;
            //    objetoCasa2.EngancheCasa = 23349.32;

            //    //Imprimir los valores de las Propiedades
            //    objetoCasa2.MostrarDetalles();
            //    
            #endregion
            string nombre, pApellido, sApellido, carrera, matroaula;
            //Console.WriteLine("Ingresa la matricula del alumno");
            //matroaula = Console.ReadLine();

            //Clase Alumno
            Alumno alumno2 = new Alumno();
            Alumno alumno1 = new Alumno() ;
                   
            //Valores para el segundo objeto (alumno2)
            //Pedir los valores para las propiedades del objeto
            //Console.WriteLine("Ingresa la matricula del alumno");
            //alumno2.Matricula = Console.ReadLine();
            //Console.WriteLine("Ingresa el nombre del alumno");
        
            //Console.WriteLine("Ingresa el primer apellido del alumno");
            //alumno2.PrimerApellidoAlumno = Console.ReadLine();

            //Imprimir los valores
            alumno1.MostrarDetalles();
            alumno2.MostrarDetalles();
            Console.ReadKey();
        }
    }
}
