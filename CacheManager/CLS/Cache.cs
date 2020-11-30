using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.CLS
{
    public static class Cache
    {
        public static DataTable Todos_Los_Empleados()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"SELECT
                           a.DUI, a.Nombres, a.Apellidos, a.Direccion, a.Telefono, a.Genero, a.FechaNacimiento,b.IDUsuario, b.usuario,c.IDRol, c.Rol, c.Descripcion
                           FROM empleados a , usuarios b, roles c where a.estado_campo= true and a.DUI = b.IDEmpleado and  b.IDRol = c.IDRol;";


                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable Todos_Los_Roles()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"SELECT IDRol , Rol, Descripcion FROM roles ORDER BY Rol;";


                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable Asignaciones_de_Permisos_Segun_IDRol(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {


                Consulta = @"SELECT a.IDOpcion, a.Opcion, a.IDCategoria ,b.Categoria,
                            IFNULL((SELECT  c.IDPermiso FROM permisos c WHERE c.IDRol =" + pIDRol + @" and c.IDOpcion=a.IDOpcion),0) AS 'IDPermiso',
                            IF(IFNULL((SELECT  c.IDPermiso FROM permisos c WHERE c.IDRol =" + pIDRol + @" and c.IDOpcion=a.IDOpcion),0)>0,1,0) AS 'Asignado'
                            FROM Opciones a, CategoriasOpciones b
                            WHERE a.IDCategoria= b.IDCategoria;";


                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static System.Data.DataTable TODOS_LOS_PRODUCTOS()
        {
            DataTable Resultado = new DataTable();

            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT * from Productos;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ALL_CATEGORIAS()
        {
            DataTable Resultado = new DataTable();
            String sql;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                sql = @"select * from categorias;";
                Resultado = oConsulta.Consultar(sql);
            }
            catch
            {
                //Informacion de error
            }
            return Resultado;
        }

        public static DataTable ALL_PRODUTOS_DISPLAY()
        {
            DataTable Resultado = new DataTable();
            String sql = "";
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                sql = @"select p.IDProducto as Id,p.Codigo,p.Nombre,p.PrecioCompra,p.PrecioVenta,p.idArchivo, c.IDCategoria,c.Categoria,p.Stock 
                    from productos p, categorias c where p.IDCategoria = c.IDCategoria AND p.estado_campo = TRUE;";
                Resultado = oConsulta.Consultar(sql);
            }
            catch (Exception e)
            {
                //Informe de error 
                Console.WriteLine(e.Message);
            }
            return Resultado;
        }

        public static String getImgBase64(int id) {
            String base64 = "";
            DataTable Resultado = new DataTable();
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                String sql = String.Format("SELECT datos FROM Archivos WHERE id = {0};", id);
                Resultado = oConsulta.Consultar(sql);
                base64 = Resultado.Rows[0]["datos"].ToString();
            }
            catch (Exception ex)
            {

            }

            return base64;
        }

        public static DataTable ALL_SALES()
        {
            DataTable Resultado = new DataTable();
            String sql = "";
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                sql = @"SELECT v.IDVenta, v.FechaEmision, v.TotalVenta, v.TotalDescuento, v.Cliente, e.Apellidos AS Vendedor FROM ventas v 
                                INNER JOIN usuarios u ON u.IDUsuario = v.IDVendedor  INNER JOIN empleados e ON e.DUI = u.IDEmpleado; ";
                Resultado = oConsulta.Consultar(sql);
            }
            catch (Exception ex) { 
            }
            return Resultado;
        }

        public static DataTable DETALLES_BY_ID(int id)
        {
            DataTable Resultado = new DataTable();
            String sql = "";
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                sql = String.Format(@"SELECT p.Nombre,d.Precio,d.Cantidad,d.Descuento, ((d.Precio*d.Cantidad)-d.Descuento) AS Importe 
                                                    FROM detallesventas d INNER JOIN productos p ON p.IDProducto = d.IDProducto WHERE IDVenta = {0}; ", id);
                Resultado = oConsulta.Consultar(sql);
            }
            catch(Exception ex)
            {

            }
            return Resultado;
        }



        public static DataTable Consulta_Usuario_Segun_Dui(String pIDEmpleado)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {

                Consulta = @"select IDUsuario from Usuarios where IDEmpleado='" + pIDEmpleado + "';";


                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable Todos_Las_Categorias()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();


            try
            {
                Consulta = @"SELECT IDCategoria, Categoria, estado_campo FROM Categorias WHERE estado_campo = true ;";


                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable INFO_FACTURA(int id)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = String.Format(@"SELECT v.Cliente,CONCAT(e.Nombres,' ',e.Apellidos) AS strVendedor, DATE_FORMAT(v.FechaEmision,'%d/%m/%Y') as strFecha,
                                                                v.TotalVenta, v.TotalDescuento, v.SubTotal from ventas V INNER JOIN Usuarios u ON u.IDUsuario = v.IDVendedor
                                                                INNER JOIN Empleados e ON e.DUI = u.IDEmpleado WHERE v.IDVenta = {0};", id);
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch(Exception ex)
            {

            }
            return Resultado;
        }

        public static DataTable VENTAS_BY_RANGE(String init, String end)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = String.Format(@"SELECT v.Cliente,DATE_FORMAT(v.FechaEmision,'%d/%m/%Y') as strFecha,v.SubTotal,v.TotalDescuento,v.TotalVenta,CONCAT(e.Nombres,' ',e.Apellidos) as strVendedor 
                                        FROM  ventas v INNER JOIN Usuarios u on u.IDUsuario = v.IDVendedor INNER JOIN Empleados e on e.DUI = u.IDEmpleado
                                        WHERE  FechaEmision BETWEEN '{0}' AND '{1}';", init,end);
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch(Exception ex)
            {

            }
            return Resultado;
        }

        public static DataTable SUM_VENTAS_RANGE(String init,String end)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = String.Format(@"SELECT SUM(v.TotalVenta) AS MontoVenta, SUM(v.TotalDescuento) AS MontoDescuento FROM ventas v 
                                                                WHERE  v.FechaEmision BETWEEN '{0}' AND '{1}';", init, end);
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception ex)
            {

            }
            return Resultado;
        }

        public static String COUNT_ACTIVE_RECORDATORIOS()
        {
            int count = 0;
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"SELECT COUNT(*)  as Total FROM recordatorio WHERE EstadoActividad = 'Ejecucion'";
                Resultado = oConsulta.Consultar(Consulta);
                count = Convert.ToInt32(Resultado.Rows[0]["Total"]);
            }
            catch(Exception ex)
            {

            }
            return count.ToString();
        }

		public static DataTable ALL_RECORDATORIOS()		
		{
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
			
            try
            {
                        Consulta = @"SELECT IDRecordatorio, FechaCreacion, FechaPrevFin, Titulo, Descripcion, Prioridad, EstadoActividad FROM  recordatorio ;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                //Informacion de error
            }
            return Resultado;
        }

        public static String TODAY_SALES()
        {
            decimal count = 0;
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = String.Format("SELECT SUM(TotalVenta) AS Total FROM ventas WHERE FechaEmision = '{0}';", DateTime.Now.ToString("yyyy/MM/dd"));
                Resultado = oConsulta.Consultar(Consulta);
                count = Convert.ToDecimal(Resultado.Rows[0]["Total"]);
            }
            catch (Exception ex)
            {

            }
            return count.ToString();
        }

        public static DataTable Permisos_De_un_Rol(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {


                Consulta = @"SELECT a.IDPermiso, a.IDOpcion, 
                            (SELECT b.Opcion FROM Opciones b WHERE b.IDOpcion= a.IDOpcion) as 'Opciones',
                            a.IDRol FROM permisos a WHERE IDROl ="+ pIDRol + ";";
                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable Todos_Los_Proveedores()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"SELECT IDProveedore, NombreProveedor, Direccion, Telefono, CorreoElectronico from proveedores  WHERE estado_campo=true;";

                Resultado = oConsulta.Consultar(Consulta);

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
