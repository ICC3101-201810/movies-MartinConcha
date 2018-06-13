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
    public partial class ListaBuscador : Form
    {
        TextBox tx;
        public ListaBuscador(TextBox tx)
        {
            
            InitializeComponent();
            this.CenterToScreen();
            this.tx = tx;
            listView1.Visible = true;
            listView1.Items.Clear();
            int c1 = 0;
            foreach (BaseDeDatos.Actor actor in BaseDeDatos.actores)
            {
                if (c1 > 10)
                {
                    break;
                }
                if (actor.Nombre.Contains(tx.Text)==true || actor.Apellido.Contains(tx.Text) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(actor.Nombre);
                    item.SubItems.Add(actor.Apellido);
                    item.SubItems.Add("actor");
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                    c1++;
                }
                
                
            }
            foreach (BaseDeDatos.Director director in BaseDeDatos.directores)
            {
                if (c1 > 20)
                {
                    break;
                }
                if (director.Nombre.Contains(tx.Text) == true || director.Apellido.Contains(tx.Text) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(director.Nombre);
                    item.SubItems.Add(director.Apellido);
                    item.SubItems.Add("director");
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                    c1++;
                }
                
            }
            foreach (BaseDeDatos.Productor productor in BaseDeDatos.productores)
            {
                if (c1 > 30)
                {
                    break;
                }
                if (productor.Nombre.Contains(tx.Text) == true || productor.Apellido.Contains(tx.Text) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(productor.Nombre);
                    item.SubItems.Add(productor.Apellido);
                    item.SubItems.Add("productor");
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                    c1++;
                }
                    
            }
            foreach (BaseDeDatos.Pelicula pelicula in BaseDeDatos.peliculas)
            {
                if (c1 > 40)
                {
                    break;
                }
                if (pelicula.Nombre.Contains(tx.Text) == true || pelicula.Descripcion.Contains(tx.Text) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(pelicula.Nombre);
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                    item.SubItems.Add(pelicula.Descripcion);
                    c1++;
                }
                    
            }
            foreach (BaseDeDatos.Estudio estudio in BaseDeDatos.estudios)
            {
                if (c1 > 50)
                {
                    break;
                }
                if (estudio.Nombre.Contains(tx.Text) == true || estudio.Direccion.Contains(tx.Text) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(estudio.Nombre);
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                    item.SubItems.Add(estudio.Direccion);
                    item.SubItems.Add("null");
                    c1++;
                }
                    
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
