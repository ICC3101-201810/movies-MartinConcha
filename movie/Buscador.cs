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
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
            BaseDeDatos.Deserializar("base.dat");
            this.CenterToScreen();
        }

        private void peliculas_Click(object sender, EventArgs e)
        {
            ListaPeliculas lp = new ListaPeliculas();
            lp.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength>=3)
            {
                ListaBuscador lb = new ListaBuscador(textBox1);
                lb.Show();
            }
        }
        BaseDeDatos bs;
        private void Cerrar_Click(object sender, EventArgs e)
        {
            BaseDeDatos.Serializar(bs);
            Application.Exit();
        }

        private void actores_Click(object sender, EventArgs e)
        {
            ListaActores la = new ListaActores();
            la.Show();
        }

        private void directores_Click(object sender, EventArgs e)
        {
            ListaDirectores ld = new ListaDirectores();
            ld.Show();
        }

        private void productores_Click(object sender, EventArgs e)
        {
            ListaProductores lp = new ListaProductores();
            lp.Show();
        }

        private void estudios_Click(object sender, EventArgs e)
        {
            ListaEstudios le = new ListaEstudios();
            le.Show();
        }
    }
}
