using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOC_Ejemplo1
{
    class Casa
    {

        public static string valor;
      
        #region MiembrosDeTipoCampo
        //Miembros de tipo campo (variables)
        string nombreDuenoCasa, apellidoDuenoCasa, materialCasa;
        string calleCasa, coloniaCasa, ciudadCasa,estadoCasa, materialTechoCasa;
        byte cantidadHabitacionesCasa;
        double precioVentaCasa = 1670345.98, engancheCasa;
        ConsoleColor colorCasa;
        #endregion

        #region MiembrosDeTipoConstructor
        public Casa(string nombreDuenoCasa, string apellidoDuenoCasa, ConsoleColor colorCasa)
        {           
            //asignacion de variable local a campo(variable global)
            this.nombreDuenoCasa = nombreDuenoCasa;
            this.apellidoDuenoCasa = apellidoDuenoCasa;
            this.colorCasa = colorCasa;       
        }
        #endregion

        #region MiembrosDeTipoPropiedad
        //Propiedades
        //Propiedad para el campo nombreDuenoCasa
        public string NombreDuenoCasa
        {
            get { return nombreDuenoCasa; }
            set { nombreDuenoCasa = value; }
        }
        //Propiedad para el campo apellidoDuenoCasa
        public string ApellidoDuenoCasa
        {
            get { return apellidoDuenoCasa; }
            set { apellidoDuenoCasa = value; }
        }
        //
        public double EngancheCasa
        {
           // get { return engancheCasa; }//Obtener
            set { engancheCasa = value; }//Enviar
        }

        //Propiedad para el campo colorCasa
        public ConsoleColor ColorCasa {
            get { return colorCasa; }
            set { colorCasa = value; }
        }
        //Propiedad para el campo precioVentaCasa
        public double PrecioVentaCasa
        {
            get { return precioVentaCasa; }
        }
        #endregion

        #region MiembrosDeTipoMétodo
        //Metodo
        //Como se construyen los metodos:
        //tipoDeAcceso (public) tipoDato nombreMetodo (* params *){}
        public void MostrarDetalles() {
            //Cuerpo del método
            Console.ForegroundColor = colorCasa;
            
            Console.WriteLine("\t DETALLES DE VENTA.");
            Console.WriteLine("El cliente es: {0} {1}", nombreDuenoCasa, apellidoDuenoCasa);
            Console.WriteLine("La dirección de la casa en venta es:");
            Console.WriteLine("Calle: {0}, Colonia: {1}, Ciudad: {2}, Esatdo: {3}",calleCasa,coloniaCasa,ciudadCasa,estadoCasa);
            Console.WriteLine("El precio total de venta es de: ${0}", precioVentaCasa);
            Console.WriteLine("El total de impuestos es de: ${0}", precioVentaCasa * Impuestos.impuestoEstatal);
        }
        #endregion
    }
}
