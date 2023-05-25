using Restaurant.Datos;
using Restaurant.Model;
using System.Data;
using System.Windows.Forms;

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
            InicializaConsulta();
        }
        private string operacion = "";
        private void InicializaConsulta()
        {
            operacion = "";

            Orddesayuno.Text = null;
            Orddesayuno.Enabled = true;
            ordplatillos.Text = null;
            ordplatillos.Enabled = false;
            ordpostres.Text = null;
            ordpostres.Enabled = false;
            ordbebidas.Text = null;
            ordbebidas.Enabled = false;
            TOTAL.Text = null;
            TOTAL.Enabled = false;

            INICIAR_COBRO.Enabled = false;
            INICIAR_COBRO.Visible = false;
            Borrar_Orden.Enabled = false;
            Borrar_Orden.Visible = false;
            Cerrar.Enabled = false;
            Cerrar.Visible = false;
            //
            btBuscar.Enabled = true;
            btBuscar.Visible = true;
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
        private void InicializaNuevo()
        {
            operacion = "nuevo";

            Orddesayuno.Text = clConsultasOrdenar.SiguienteRegistro();
            Orddesayuno.Enabled = false;
            ordplatillos.Text = null;
            ordplatillos.Enabled = true;
            ordpostres.Text = null;
            ordpostres.Enabled = true;
            ordbebidas.Text = null;
            ordbebidas.Enabled = true;
            TOTAL.Text = null;
            TOTAL.Enabled = true;

            INICIAR_COBRO.Enabled = true;
            INICIAR_COBRO.Visible = true;
            Borrar_Orden.Enabled = true;
            Borrar_Orden.Visible = true;
            Cerrar.Enabled = true;
            Cerrar.Visible = true;

            btBuscar.Enabled = false;
            btBuscar.Visible = false;
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

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cONSULTARToolStripSplitBtn_ButtonClick(object sender, EventArgs e)
        {
            InicializaConsulta();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
           // InicializaNuevo();
        }
        private void presionaBuscar()
        {
            try
            {
                clOrdenar producto = clConsultasOrdenar.BuscarporIdOrdenar(int.Parse(Orddesayuno.Text));
                Orddesayuno.Text = producto.desayunos1;
                ordplatillos.Text = producto.platillos1;
                ordpostres.Text = producto.postres1;
                ordbebidas.Text = producto.bebidas1;

                if (operacion == "editar")
                {
                    Orddesayuno.Enabled = false;
                    ordplatillos.Enabled = false;
                    ordpostres.Enabled = false;
                    ordbebidas.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar el Id de la Orden!");
                Orddesayuno.Focus();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void nUEVOToolStripSplitBtn_ButtonClick(object sender, EventArgs e)
        {
            InicializaNuevo();
        }
    }
}