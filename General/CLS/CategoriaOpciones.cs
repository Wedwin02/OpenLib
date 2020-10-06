using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class CategoriaOpciones
    {
        Int32 _IDCategoria;
        String Categoria;

        public int IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string Categoria1 { get => Categoria; set => Categoria = value; }
        public Boolean Guardar()
        {
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();


            try
            {
                //insertar

                sentencia = "INSERT INTO categoriasopciones(IDCategoria,Categoria) VALUES(";
                sentencia += "'" + _IDCategoria + "',";
                sentencia += "'" + Categoria + "');";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    guardar = true;
                }
                else
                {
                    guardar = false;

                }

            }
            catch
            {
                guardar = false;
            }
            return guardar;


        }



    }
}
