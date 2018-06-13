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
    public partial class ListaEstudios : Form
    {
        public ListaEstudios()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listBox2.Visible = false;

            foreach (BaseDeDatos.Estudio estudio in BaseDeDatos.estudios)
            {
                listBox1.Items.Add(estudio.Nombre);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            foreach (BaseDeDatos.Estudio estudio in BaseDeDatos.estudios)
            {
                if (curItem == estudio.Nombre)
                {
                    label1.Visible = true;
                    label1.Text = "Nombre: " + estudio.Nombre;
                    label2.Visible = true;
                    label2.Text = "Direccion: " + estudio.Direccion;
                    label3.Visible = true;
                    label3.Text = "Fecha Apertura: " + estudio.Fecha_apertura;

                }
            }
            listBox2.Visible = true;
            foreach(BaseDeDatos.Pelicula pelicula in BaseDeDatos.peliculas)
            {
                if (curItem == pelicula.Estudio.Nombre)
                {
                    listBox2.Items.Add(pelicula.Nombre);
                }
            }
        }
    }
}
