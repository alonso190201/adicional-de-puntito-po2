
namespace Sagua
{
    partial class frmConsultas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnEquiposDisponibles = new System.Windows.Forms.Button();
            this.btnEquiposPrestados = new System.Windows.Forms.Button();
            this.lblCodigoEstudiante = new System.Windows.Forms.Label();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarPrestamosFechas = new System.Windows.Forms.Button();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.btnBuscarPrestamosEstudiante = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquiposDisponibles
            // 
            this.btnEquiposDisponibles.Location = new System.Drawing.Point(12, 12);
            this.btnEquiposDisponibles.Name = "btnEquiposDisponibles";
            this.btnEquiposDisponibles.Size = new System.Drawing.Size(150, 30);
            this.btnEquiposDisponibles.TabIndex = 0;
            this.btnEquiposDisponibles.Text = "Equipos Disponibles";
            this.btnEquiposDisponibles.UseVisualStyleBackColor = true;
            this.btnEquiposDisponibles.Click += new System.EventHandler(this.btnEquiposDisponibles_Click);
            // 
            // btnEquiposPrestados
            // 
            this.btnEquiposPrestados.Location = new System.Drawing.Point(168, 12);
            this.btnEquiposPrestados.Name = "btnEquiposPrestados";
            this.btnEquiposPrestados.Size = new System.Drawing.Size(150, 30);
            this.btnEquiposPrestados.TabIndex = 1;
            this.btnEquiposPrestados.Text = "Equipos Prestados";
            this.btnEquiposPrestados.UseVisualStyleBackColor = true;
            this.btnEquiposPrestados.Click += new System.EventHandler(this.btnEquiposPrestados_Click);
            // 
            // lblCodigoEstudiante
            // 
            this.lblCodigoEstudiante.AutoSize = true;
            this.lblCodigoEstudiante.Location = new System.Drawing.Point(12, 55);
            this.lblCodigoEstudiante.Name = "lblCodigoEstudiante";
            this.lblCodigoEstudiante.Size = new System.Drawing.Size(96, 13);
            this.lblCodigoEstudiante.TabIndex = 2;
            this.lblCodigoEstudiante.Text = "Código Estudiante:";
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(114, 52);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoEstudiante.TabIndex = 3;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(270, 50);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstudiante.TabIndex = 4;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 90);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(200, 90);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 6;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(86, 87);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(263, 87);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // btnBuscarPrestamosFechas
            // 
            this.btnBuscarPrestamosFechas.Location = new System.Drawing.Point(380, 85);
            this.btnBuscarPrestamosFechas.Name = "btnBuscarPrestamosFechas";
            this.btnBuscarPrestamosFechas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPrestamosFechas.TabIndex = 9;
            this.btnBuscarPrestamosFechas.Text = "Buscar";
            this.btnBuscarPrestamosFechas.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamosFechas.Click += new System.EventHandler(this.btnBuscarPrestamosFechas_Click);
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(12, 125);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(100, 13);
            this.lblNombreEstudiante.TabIndex = 10;
            this.lblNombreEstudiante.Text = "Nombre Estudiante:";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(123, 122);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEstudiante.TabIndex = 11;
            // 
            // btnBuscarPrestamosEstudiante
            // 
            this.btnBuscarPrestamosEstudiante.Location = new System.Drawing.Point(329, 120);
            this.btnBuscarPrestamosEstudiante.Name = "btnBuscarPrestamosEstudiante";
            this.btnBuscarPrestamosEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPrestamosEstudiante.TabIndex = 12;
            this.btnBuscarPrestamosEstudiante.Text = "Buscar";
            this.btnBuscarPrestamosEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamosEstudiante.Click += new System.EventHandler(this.btnBuscarPrestamosEstudiante_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(15, 160);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(700, 280);
            this.dgvResultados.TabIndex = 13;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 460);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscarPrestamosEstudiante);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.lblNombreEstudiante);
            this.Controls.Add(this.btnBuscarPrestamosFechas);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.txtCodigoEstudiante);
            this.Controls.Add(this.lblCodigoEstudiante);
            this.Controls.Add(this.btnEquiposPrestados);
            this.Controls.Add(this.btnEquiposDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquiposDisponibles;
        private System.Windows.Forms.Button btnEquiposPrestados;
        private System.Windows.Forms.Label lblCodigoEstudiante;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnBuscarPrestamosFechas;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Button btnBuscarPrestamosEstudiante;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}
