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
    public partial class ListaActores : Form
    {
        public ListaActores()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listBox2.Visible = false;

            foreach (BaseDeDatos.Actor actor in BaseDeDatos.actores)
            {
                listBox1.Items.Add(actor.Nombre);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            foreach (BaseDeDatos.Actor actor in BaseDeDatos.actores)
            {
                if (curItem == actor.Nombre)
                {
                    label1.Visible = true;
                    label1.Text = "Nombre: " + actor.Nombre;
                    label2.Visible = true;
                    label2.Text = "Apellido: " + actor.Apellido;
                    label3.Visible = true;
                    label3.Text = "Fecha Nacimiento: " + actor.Fecha_nacimiento;
                    label4.Visible = true;
                    label4.Text = "Biografia: " + actor.Biografia;
                    break;
                }
            }
            listBox2.Visible = true;

            foreach (BaseDeDatos.PeliculaActor pa in BaseDeDatos.pas)
            {
                if (pa.Actor.Nombre == curItem)
                {
                    listBox2.Items.Add(pa.Pelicula.Nombre);
                }
            }
        }

        private void ListaActores_Load(object sender, EventArgs e)
        {

        }
    }
}
