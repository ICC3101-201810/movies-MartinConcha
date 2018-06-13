using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    [Serializable()]
    public class BaseDeDatos
    {
        public static List<Actor> actores = new List<Actor>();
        public static List<Productor> productores = new List<Productor>();
        public static List<Director> directores = new List<Director>();
        public static List<Pelicula> peliculas = new List<Pelicula>();
        public static List<Estudio> estudios = new List<Estudio>();
        public static List<PeliculaActor> pas = new List<PeliculaActor>();
        public static List<PeliculaProductor> pps = new List<PeliculaProductor>();

        public class Persona
        {
            private string nombre;
            private string apellido;
            private string fecha_nacimiento;
            private string biografia;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
            public string Biografia { get => biografia; set => biografia = value; }

            public Persona(string nombre, string apellido, string fecha_nacimiento, string biografia)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Fecha_nacimiento = fecha_nacimiento;
                this.Biografia = biografia;
            }


        }
        public class Actor:Persona
        {
            private string a = "actor";
            public Actor(string nombre, string apellido, string fecha_nacimiento, string biografia, string a):base(nombre,apellido,fecha_nacimiento,biografia)
            {
                this.a = a;
            }
            
        }
        public class Director : Persona
        {
            private string d = "director";
            public Director(string nombre, string apellido, string fecha_nacimiento, string biografia, string d) : base(nombre, apellido, fecha_nacimiento, biografia)
            {
                this.d = d;
            }

        }
        public class Productor : Persona
        {
            private string p = "productor";
            public Productor(string nombre, string apellido, string fecha_nacimiento, string biografia, string p) : base(nombre, apellido, fecha_nacimiento, biografia)
            {
                this.p = p;
            }

        }

        public class Estudio
        {
            private string nombre;
            private string direccion;
            private string fecha_apertura;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public string Fecha_apertura { get => fecha_apertura; set => fecha_apertura = value; }

            public Estudio(string nombre, string direccion, string fecha_apertura)
            {
                this.nombre = nombre;
                this.direccion = direccion;
                this.fecha_apertura = fecha_apertura;
            }

            
        }
        public class Pelicula
        {
            private string nombre;
            private Director director;
            private string fecha_estreno;
            private string descripcion;
            private int presupuesto;
            private Estudio estudio;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Fecha_estreno { get => fecha_estreno; set => fecha_estreno = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public int Presupuesto { get => presupuesto; set => presupuesto = value; }
            public Estudio Estudio { get => estudio; set => estudio = value; }
            public Director Director { get => director; set => director = value; }

            public Pelicula(string nombre, Director director, string fecha_estreno, string descripcion, int presupuesto, Estudio estudio)
            {
                this.nombre = nombre;
                this.director = director;
                this.fecha_estreno = fecha_estreno;
                this.descripcion = descripcion;
                this.presupuesto = presupuesto;
                this.estudio = estudio;
            }
        }
        public class PeliculaActor
        {
            private Pelicula pelicula;
            private Actor actor;

            public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
            public Actor Actor { get => actor; set => actor = value; }

            public PeliculaActor(Pelicula pelicula, Actor actor)
            {
                this.pelicula = pelicula;
                this.actor = actor;
            }

        }
        public class PeliculaProductor
        {
            private Pelicula pelicula;
            private Productor productor;

            public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
            public Productor Productor { get => productor; set => productor = value; }

            public PeliculaProductor(Pelicula pelicula, Productor productor)
            {
                this.pelicula = pelicula;
                this.productor = productor;
            }
        }
        public static void Serializar(BaseDeDatos bs)
        {
            try
            {
                FileStream _fs = new FileStream(@"..\..\docs\base.dat", FileMode.Create);
                BinaryFormatter _formatter = new BinaryFormatter();
                _formatter.Serialize(_fs, bs);
                _fs.Close();
            }
            catch (Exception)
            {
                
            }  
            
        }
        public static BaseDeDatos Deserializar(string pArchivo)
        {
            try
            {
                if (File.Exists(@"..\..\docs\" + pArchivo) == true)
                {
                    FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                    BinaryFormatter _formatter = new BinaryFormatter();
                    BaseDeDatos bsd = _formatter.Deserialize(_fs) as BaseDeDatos;
                    _fs.Close();
                    return bsd;
                }
                return new BaseDeDatos();
            }
            catch (Exception)
            {
                return new BaseDeDatos();
            }
            
        }
    }

}
