using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie
{
    public partial class ListaPeliculas : Form
    {
        public ListaPeliculas()
        {
            
            InitializeComponent();
            this.CenterToScreen();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;

            foreach (BaseDeDatos.Pelicula pelicula in BaseDeDatos.peliculas)
            {
                listBox1.Items.Add(pelicula.Nombre);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            foreach(BaseDeDatos.Pelicula pelicula in BaseDeDatos.peliculas)
            {
                if (curItem == pelicula.Nombre)
                {
                    label1.Visible = true;
                    label1.Text = "Nombre: " + pelicula.Nombre;
                    label2.Visible = true;
                    label2.Text = "Nombre Director: " + pelicula.Director.Nombre;
                    label3.Visible = true;
                    label3.Text = "Fecha Estreno: " + pelicula.Fecha_estreno;
                    label4.Visible = true;
                    label4.Text = "Descripcion: " + pelicula.Descripcion;
                    label5.Visible = true;
                    label5.Text = "Presupuesto: " + pelicula.Presupuesto.ToString();
                    label6.Visible = true;
                    label6.Text = "Estudio: " + pelicula.Estudio.Nombre;
                    break;
                }
            }
            listBox2.Visible = true;
            listBox3.Visible = true;
            foreach(BaseDeDatos.PeliculaActor pa in BaseDeDatos.pas)
            {
                if (curItem == pa.Pelicula.Nombre)
                {
                    listBox2.Items.Add(pa.Actor.Nombre);
                }
            }
            foreach (BaseDeDatos.PeliculaProductor pp in BaseDeDatos.pps)
            {
                if (curItem == pp.Pelicula.Nombre)
                {
                    listBox3.Items.Add(pp.Productor.Nombre);
                }
            }
        }
    }
}
