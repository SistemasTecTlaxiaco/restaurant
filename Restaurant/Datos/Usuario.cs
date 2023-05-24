using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Datos
{
    public class Usuario
    {
        List<usuarioModel> lista = new List<usuarioModel>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelo"></param>
        public void Iniciar(usuarioModel modelo)
        {
            lista.Add(modelo);
        }
        public List<usuarioModel> Consultar()
        {
            return lista;
        }
    }
}
