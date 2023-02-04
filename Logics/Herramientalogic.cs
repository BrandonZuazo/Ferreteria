using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;





namespace Logics
{
    public class Herramientalogic
    {
        public List<Productos> listar()
        {
            List<Productos> Lista = new List<Productos>();
            Accesodatos datos= new Accesodatos();
            try
            {
                datos.setearconsulta("select IdProducto, Nombre,Cantidad,Preciocompra,Precioventa,Imagen,Detalle from Mercaderias WHERE Activo =1");
                datos.ejecutarlectura();
                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();
                    aux.ID = (int)datos.Lector["IdProducto"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.PrecioCompra = (int)datos.Lector["Preciocompra"];
                    aux.PrecioVenta = (int)datos.Lector["Precioventa"];
                    if (!(datos.Lector["Imagen"] is DBNull))
                    {
                    aux.Imagen = (string)datos.Lector["Imagen"];

                    }
                    aux.Detalle = (string)datos.Lector["Detalle"];

                    Lista.Add(aux);
                    
                }
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.Cerrarconexion();
            }
        }

        public void Agregar(Productos productos)
        {
            Accesodatos datos = new Accesodatos();
            try
            {
                datos.setearconsulta("insert into Mercaderias values (@nombre,@cantidad,@pcompra,@pventa,@imagen,@detalle,1)");
                datos.setearparametro("@nombre",productos.Nombre);
                datos.setearparametro("@cantidad",productos.Cantidad);
                datos.setearparametro("@pcompra",productos.PrecioCompra);
                datos.setearparametro("@pventa",productos.PrecioVenta);
                datos.setearparametro("@imagen",productos.Imagen);
                datos.setearparametro("@detalle",productos.Detalle);
                datos.ejecutarAccion();
               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.Cerrarconexion();
            }
        }
        public void MODIFICAR(Productos productos)
        {
            Accesodatos datos= new Accesodatos();
            try
            {
                datos.setearconsulta("update Mercaderias set Nombre=@nombre ,Cantidad=@cantidad,Preciocompra=@pcompra,Precioventa=@pventa,Imagen=@imagen,Detalle=@detalle where IdProducto =@id");
                datos.setearparametro("@nombre", productos.Nombre);
                datos.setearparametro("@cantidad", productos.Cantidad);
                datos.setearparametro("@pcompra", productos.PrecioCompra);
                datos.setearparametro("pventa", productos.PrecioVenta);
                datos.setearparametro("@imagen", productos.Imagen);
                datos.setearparametro("@detalle", productos.Detalle);
                datos.setearparametro("@id", productos.ID);
                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.Cerrarconexion();}
        }
        public void Eliminar(int id)
        {
            Accesodatos datos = new Accesodatos();
            try
            {
                datos.setearconsulta("UPDATE Mercaderias SET Activo=0 WHERE IdProducto=@id");
                datos.setearparametro("@id",id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.Cerrarconexion();
            }
        }
    }
}
