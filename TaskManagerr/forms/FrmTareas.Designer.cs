namespace TaskManagerr
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DGVtareas = new System.Windows.Forms.DataGridView();
            this.btnHecha = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Tareas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(25, 460);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 60);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DGVtareas
            // 
            this.DGVtareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtareas.Location = new System.Drawing.Point(12, 119);
            this.DGVtareas.Name = "DGVtareas";
            this.DGVtareas.RowHeadersWidth = 51;
            this.DGVtareas.RowTemplate.Height = 24;
            this.DGVtareas.Size = new System.Drawing.Size(743, 294);
            this.DGVtareas.TabIndex = 2;
            this.DGVtareas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVtareas_CellFormatting);
            // 
            // btnHecha
            // 
            this.btnHecha.BackColor = System.Drawing.Color.LightGreen;
            this.btnHecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHecha.Location = new System.Drawing.Point(257, 460);
            this.btnHecha.Name = "btnHecha";
            this.btnHecha.Size = new System.Drawing.Size(287, 60);
            this.btnHecha.TabIndex = 3;
            this.btnHecha.Text = "Marcar como Hecha";
            this.btnHecha.UseVisualStyleBackColor = false;
            this.btnHecha.Click += new System.EventHandler(this.btnHecha_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(550, 460);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(213, 60);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(779, 545);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnHecha);
            this.Controls.Add(this.DGVtareas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVtareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView DGVtareas;
        private System.Windows.Forms.Button btnHecha;
        private System.Windows.Forms.Button btnEliminar;
    }
}

