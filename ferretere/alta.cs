using Logics;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ferretere
{
    public partial class alta : Form
    {
        private OpenFileDialog archivo =  null;
        private Productos productos =  null;
        public alta()
        {
            InitializeComponent();

        }
        public alta(Productos productos)
        {
            InitializeComponent();
            this.productos = productos;
            Text = "Modificar";

        }

        private void alta_Load(object sender, EventArgs e)
        {
            try
            {
                if(productos!= null)
                {
                    textName.Text = productos.Nombre;
                    textCantidad.Text = productos.Cantidad.ToString();
                    textPcompra.Text = productos.PrecioCompra.ToString();
                    textPventa.Text = productos.PrecioVenta.ToString();
                    textImagen.Text = productos.Imagen;
                    textDetalle.Text = productos.Detalle;
                    cargarimagen(productos.Imagen);
                
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            
            Herramientalogic logica= new Herramientalogic();
            try
            {
                if (productos == null)
                    productos = new Productos();


                productos.Nombre = textName.Text.ToUpper().Trim();
                productos.Cantidad = int.Parse(textCantidad.Text.ToUpper().Trim());
                productos.PrecioCompra = int.Parse(textPcompra.Text.ToUpper().Trim());
                productos.PrecioVenta = int.Parse(textPventa.Text.ToUpper().Trim());
                productos.Imagen = textImagen.Text;
                cargarimagen(productos.Imagen);
                productos.Detalle = textDetalle.Text.ToUpper().Trim();

                if (productos.ID != 0)
                {
                    logica.MODIFICAR(productos);
                    MessageBox.Show("Se ah Modificado de manera exitosa a la base de datos", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    logica.Agregar(productos);
                    MessageBox.Show("Se ah Agregado de manera exitosa a la base de datos", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (archivo != null && textImagen.Text.ToUpper().Contains("HTTP"))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + archivo.SafeFileName);
                }



                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargarimagen(string imagen)
        {
            try
            {
                pictureProducto.Load(imagen);
            }
            catch (Exception)
            {

                pictureProducto.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void textImagen_Leave(object sender, EventArgs e)
        {
            cargarimagen(textImagen.Text);
        }

        private void butagregarimagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                textImagen.Text = archivo.FileName;
                cargarimagen(archivo.FileName);
                

            }
        }
    }
}
