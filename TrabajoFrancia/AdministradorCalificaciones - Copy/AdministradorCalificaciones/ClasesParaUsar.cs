using System;
using System.Collections.Generic;

namespace AdministradorCalificaciones
{
    public class Estudiantes
    {

        public List<Materia> listaMateriaEst = new List<Materia>();

        private string ID;
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Carrera;
        public string carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }

        private decimal Calificacion;
        public decimal calificacion
        {
            get { return Calificacion; }
            set { Calificacion = value; }
        }

        private double Indice;
        public double indice
        {
            get { return Indice; }
            set { Indice = value; }
        }

        private string Honores;
        public string honores
        {
            get { return Honores; }
            set { Honores = value; }
        }

        public Estudiantes() { }

        public Estudiantes(string IDPer, string NombrePer, string CarreraPer)
        {
            this.ID = IDPer;
            this.Nombre = NombrePer;
            this.Carrera = CarreraPer;
        }



    }

    public class Materia
    {
        private string nombre;
        private byte cantidadCred;
        private double notaMateria;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public byte CantidadCred
        {
            get
            {
                return this.cantidadCred;
            }
            set
            {
                this.cantidadCred = value;
            }
        }

        

        public double NotaMateria
        {
            get { return notaMateria; }
            set { notaMateria = value; }
        }

        public Materia() { }

        public Materia(string nombreMateria, byte cantidadCred, double notaMateria)
        {
            this.nombre = nombreMateria;
            this.cantidadCred = cantidadCred;
            this.NotaMateria = notaMateria;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", this.nombre,this.cantidadCred,this.NotaMateria);
        }
    }
}

