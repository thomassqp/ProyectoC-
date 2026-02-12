    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace TaskManagerr.forms
    {
        public partial class FrmAgregarTareas : Form
        {
        public FrmAgregarTareas()
        {
            InitializeComponent();
            this.Load += FrmAgregarTareas_Load;
        }


        private void FrmAgregarTareas_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarPrioridades();
        }


        private void CargarCategorias()
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlDataAdapter da =
                    new SqlDataAdapter("SELECT CategoriaID, Nombre FROM Categorias", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategoria.DataSource = dt;
                    cmbCategoria.DisplayMember = "Nombre";
                    cmbCategoria.ValueMember = "CategoriaID";
                }
            }

            private void CargarPrioridades()
            {
                cbPrioridad.Items.Add("Alta");
                cbPrioridad.Items.Add("Media");
                cbPrioridad.Items.Add("Baja");
                cbPrioridad.SelectedIndex = 1;

            }


            private void btnAgregar_Click(object sender, EventArgs e)
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    string sql = @"
                    INSERT INTO Tareas
                    (Titulo, Descripcion, CategoriaID, Prioridad, FechaLimite)
                    VALUES (@t, @d, @c, @p, @f)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@t", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@d", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@c", cmbCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@p", cbPrioridad.Text);
                    cmd.Parameters.AddWithValue("@f", dtpFecha.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                DialogResult = DialogResult.OK;
                Close();
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }
