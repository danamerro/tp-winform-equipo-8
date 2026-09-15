using dominio;
using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace negocio
{
    public class CatalogoNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
                                "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                                "A.IdMarca, M.Descripcion AS Marca, " +
                                "A.IdCategoria, C.Descripcion AS Categoria " +
                                "FROM ARTICULOS A " +
                                "INNER JOIN MARCAS M ON A.IdMarca = M.Id " +
                                "INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }
        //Falta: Agregar, filtrar, modificar, eliminar, etc.
        public void agregar(Articulo nuevo)
        {
            //INSERT
        }
        public void modificar(Articulo articulo)
        {
            // UPDATE
        }
        public void eliminar(int id)
        {
            // DELETE
        }
        /*
        public List<Articulo> filtrar()
        {
            // búsqueda
        }
        */
    }
}
