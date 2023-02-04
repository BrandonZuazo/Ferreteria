using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logics;
using Modelo;



namespace ferretere
{
    public partial class Form1 : Form
    {
        private List<Productos> listaProductos ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarcolumnas();

        }
        private void ocultarcolumnas()
        {
            
            dataProductos.Columns["Imagen"].Visible= false;
            
            
          
        }
        private void cargarcolumnas()
        {
            
            Herramientalogic logica = new Herramientalogic();
            listaProductos = logica.listar();
            dataProductos.DataSource = listaProductos;
            cargarimagen(listaProductos[0].Imagen);
            ocultarcolumnas();

        }
        private void cargarimagen(string imagen)
        {
            try
            {
                pictureProductos.Load(imagen);
            }
            catch (Exception)
            {

                pictureProductos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            alta agregar = new alta();
            agregar.ShowDialog();
            cargarcolumnas();
        }

        private void dataProductos_SelectionChanged(object sender, EventArgs e)
        {
            if(dataProductos.CurrentRow!= null)
            {
                Productos seleccionado=(Productos)dataProductos.CurrentRow.DataBoundItem;
                cargarimagen(seleccionado.Imagen);
            }
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            Productos seleccionado;
            seleccionado = (Productos)dataProductos.CurrentRow.DataBoundItem;
            alta Modificar = new alta(seleccionado);
            Modificar.ShowDialog();
            cargarcolumnas();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
                Productos product;
                Herramientalogic logica = new Herramientalogic();
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar este producto", "Bases de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(DialogResult.Yes == respuesta)
                {
                    product = (Productos)dataProductos.CurrentRow.DataBoundItem;
                    logica.Eliminar(product.ID);
                    cargarcolumnas();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void textFiltr_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filtro = textFiltr.Text;
            List<Productos> Listafiltrada;

            if (filtro != "")
            {
                Listafiltrada = listaProductos.FindAll(x => x.Nombre.Trim().Contains(filtro.Trim().ToUpper()));

            }
            else
            {
                Listafiltrada = listaProductos;
            }
            dataProductos.DataSource = null;
            dataProductos.DataSource = Listafiltrada;
            ocultarcolumnas();
        }
    }
}
