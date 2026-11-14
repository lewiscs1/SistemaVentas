using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ProductoBL
    {
        public List<Producto> Buscar(string nombre)
        {
            if (nombre == null)
                nombre = "";
            return ProductoDAO.Instancia.Listar(nombre.Trim());
        }

        // Devuelve "" si todo está bien, o el mensaje de error
        private string Validar(Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                return "Ingrese el nombre del producto.";
            if (string.IsNullOrWhiteSpace(p.Categoria))
                return "Seleccione una categoría.";
            if (p.Precio <= 0)
                return "El precio debe ser mayor a 0.";
            return "";
        }

        public string Registrar(Producto p)
        {
            string error = Validar(p);
            if (error != "")
                return error;

            ProductoDAO.Instancia.Insertar(p);
            return "";
        }

        public string Actualizar(Producto p)
        {
            if (p.IdProducto <= 0)
                return "Seleccione un producto de la tabla.";

            string error = Validar(p);
            if (error != "")
                return error;

            ProductoDAO.Instancia.Actualizar(p);
            return "";
        }
    }
}
