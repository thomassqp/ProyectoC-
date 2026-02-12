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
using TaskManagerr.forms;

namespace TaskManagerr
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            this.Load += FrmInicio_Load;
        }

        private void FrmInicio_Load (object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void CargarTareas()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string sql = @"
                SELECT 
                    T.TareaID,
                    T.Titulo,
                    C.Nombre AS Categoria,
                    T.Prioridad,
                    T.FechaLimite,
                    T.Completada
                FROM Tareas T
                INNER JOIN Categorias C ON T.CategoriaID = C.CategoriaID
                ORDER BY T.Completada, T.FechaLimite";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DGVtareas.DataSource = dt;
            }
            DGVtareas.Columns["TareaID"].Visible = false;
            DGVtareas.Columns["Completada"].HeaderText = "Hecha";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarTareas frm = new FrmAgregarTareas();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarTareas();
        }

        private void btnHecha_Click(object sender, EventArgs e)
        {
            if (DGVtareas.CurrentRow == null) return;
            int id = Convert.ToInt32(
                DGVtareas.CurrentRow.Cells["TareaID"].Value);

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string sql = @"
                UPDATE Tareas 
                SET Completada = 1,
                    FechaCompletada = GETDATE()
                WHERE TareaID = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            CargarTareas();
        }

        private void DGVtareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVtareas.Rows[e.RowIndex].Cells["Completada"].Value != DBNull.Value)
            {
                bool completada = Convert.ToBoolean(
                    DGVtareas.Rows[e.RowIndex].Cells["Completada"].Value);

                if (completada)
                {
                    e.CellStyle.ForeColor = Color.Gray;
                    e.CellStyle.Font =
                        new Font(DGVtareas.Font, FontStyle.Strikeout);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVtareas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una tarea primero.");
                return;
            }

            int id = Convert.ToInt32(
                DGVtareas.CurrentRow.Cells["TareaID"].Value);

            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres eliminar esta tarea?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    string sql = "DELETE FROM Tareas WHERE TareaID = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn); 
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                CargarTareas();
            }
        }

    }
}
