using Restaurant.Datos;
using Restaurant.Model;
using System.Data;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        DataTable Tabla;
        Usuario dato = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }
        private void INICIAR_COBRO_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }
        private void Borrar_Orden_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Desayunos");
            Tabla.Columns.Add("Platillos");
            Tabla.Columns.Add("Postres");
            Tabla.Columns.Add("Bebidas");
            Tabla.Columns.Add("Total");
            // grilla.DataSource = Tabla;
        }

        private void Guardar()
        {
            usuarioModel modelo = new usuarioModel()
            {
                Desayunos = Orddesayuno.Text,
                Platillos = ordplatillos.Text,
                Postres = ordpostres.Text,
                Bebidas = ordbebidas.Text,
                Total = int.Parse(textTOTAL.Text)
            };
            dato.Iniciar(modelo);
        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = Tabla.NewRow();
                fila["DESAYUNOS"] = item.Desayunos;
                fila["PLATILLOS"] = item.Platillos;
                fila["POSTRES"] = item.Postres;
                fila["BEBIDAS"] = item.Bebidas;
                fila["TOTAL"] = item.Total;
                Tabla.Rows.Add(fila);
            }
        }
        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            Orddesayuno.Text = "";
            ordplatillos.Text = "";
            ordpostres.Text = "";
            ordbebidas.Text = "";
            textTOTAL.Text = "";
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}