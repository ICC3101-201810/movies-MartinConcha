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
    public partial class ListaDirectores : Form
    {
        public ListaDirectores()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listBox2.Visible = false;
            foreach (BaseDeDatos.Director director in BaseDeDatos.directores)
            {
                listBox1.Items.Add(director.Nombre);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            foreach (BaseDeDatos.Director director in BaseDeDatos.directores)
            {
                if (curItem == director.Nombre)
                {
                    label1.Visible = true;
                    label1.Text = "Nombre: " + director.Nombre;
                    label2.Visible = true;
                    label2.Text = "Apellido: " + director.Apellido;
                    label3.Visible = true;
                    label3.Text = "Fecha Nacimiento: " + director.Fecha_nacimiento;
                    label4.Visible = true;
                    label4.Text = "Biografia: " + director.Biografia;
                    break;
                }
            }
            listBox2.Visible = true;
            foreach(BaseDeDatos.Pelicula pelicula in BaseDeDatos.peliculas)
            {
                if (pelicula.Director.Nombre == curItem)
                {
                    listBox2.Items.Add(pelicula.Nombre);
                }
            }
        }
    }
}
