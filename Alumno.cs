using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOC_Ejemplo1
{
    class Alumno
    {
        //Crear campos (variebles globales)
        //nombre, semstre, carreera, matricula, curp
        string matricula, nombreAlumno, primerApellidoAlumno, segundoApellidoAlumno;
        private string nombreCarreraAlumno, curpAlumno, semestreAlumno;
        private string calleAlumno, coloniaAlumno, noCasaAlumno, ciudadAlumno, cpAlumno, estadoAlumno, paisAlumno;
        private char grupoSanguineoAlumno, rhAlumno; 
        private DateTime fechaIngresoAlumno;

        //Propiedades
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        //propiedad para nombreAlumno
        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }
        //propiedad para primerApellidoAlumno
        public string PrimerApellidoAlumno
        {
            get { return primerApellidoAlumno; }
            set { primerApellidoAlumno = value; }
        }

        //Metodos
        public void MostrarDetalles() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            //Imprimir letreros
            Console.WriteLine("\t \t SistemaTec");
            Console.WriteLine("\t \t Bienvenidos a la impresión de detalles de un alumno.");
            Console.WriteLine("\n");
            Console.WriteLine("Matricula del alumno: {0}", matricula);
            Console.WriteLine("Nombre completo del alumno: {0} {1} {2}", nombreAlumno,primerApellidoAlumno,segundoApellidoAlumno);
            Console.WriteLine("\n");
            Console.WriteLine("\t \t SistemaTec ");
            Console.WriteLine("\n");
        }
    }
}
