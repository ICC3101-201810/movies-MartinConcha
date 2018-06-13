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
    public partial class ListaProductores : Form
    {
        public ListaProductores()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listBox2.Visible = false;

            foreach (BaseDeDatos.Productor productor in BaseDeDatos.productores)
            {
                listBox1.Items.Add(productor.Nombre);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            foreach (BaseDeDatos.Productor productor in BaseDeDatos.productores)
            {
                if (curItem == productor.Nombre)
                {
                    label1.Visible = true;
                    label1.Text = "Nombre: " + productor.Nombre;
                    label2.Visible = true;
                    label2.Text = "Apellido: " + productor.Apellido;
                    label3.Visible = true;
                    label3.Text = "Fecha Nacimiento: " + productor.Fecha_nacimiento;
                    label4.Visible = true;
                    label4.Text = "Biografia: " + productor.Biografia;
                    break;
                }
            }
            listBox2.Visible = true;
            foreach (BaseDeDatos.PeliculaProductor pa in BaseDeDatos.pps)
            {
                if (pa.Productor.Nombre == curItem)
                {
                    listBox2.Items.Add(pa.Pelicula.Nombre);
                }
            }
        }
    }
}
