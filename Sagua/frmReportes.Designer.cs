
namespace Sagua
{
    partial class frmReportes
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
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnPrestamosPorFecha = new System.Windows.Forms.Button();
            this.btnEquiposMasUtilizados = new System.Windows.Forms.Button();
            this.btnPrestamosPendientes = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEquipos
            // 
            this.btnEquipos.Location = new System.Drawing.Point(30, 30);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(200, 40);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.Text = "Listado General de Equipos";
            this.btnEquipos.UseVisualStyleBackColor = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnPrestamosPorFecha
            // 
            this.btnPrestamosPorFecha.Location = new System.Drawing.Point(30, 130);
            this.btnPrestamosPorFecha.Name = "btnPrestamosPorFecha";
            this.btnPrestamosPorFecha.Size = new System.Drawing.Size(200, 40);
            this.btnPrestamosPorFecha.TabIndex = 1;
            this.btnPrestamosPorFecha.Text = "Préstamos Realizados Por Fecha";
            this.btnPrestamosPorFecha.UseVisualStyleBackColor = true;
            this.btnPrestamosPorFecha.Click += new System.EventHandler(this.btnPrestamosPorFecha_Click);
            // 
            // btnEquiposMasUtilizados
            // 
            this.btnEquiposMasUtilizados.Location = new System.Drawing.Point(30, 190);
            this.btnEquiposMasUtilizados.Name = "btnEquiposMasUtilizados";
            this.btnEquiposMasUtilizados.Size = new System.Drawing.Size(200, 40);
            this.btnEquiposMasUtilizados.TabIndex = 2;
            this.btnEquiposMasUtilizados.Text = "Equipos Más Utilizados";
            this.btnEquiposMasUtilizados.UseVisualStyleBackColor = true;
            this.btnEquiposMasUtilizados.Click += new System.EventHandler(this.btnEquiposMasUtilizados_Click);
            // 
            // btnPrestamosPendientes
            // 
            this.btnPrestamosPendientes.Location = new System.Drawing.Point(30, 250);
            this.btnPrestamosPendientes.Name = "btnPrestamosPendientes";
            this.btnPrestamosPendientes.Size = new System.Drawing.Size(200, 40);
            this.btnPrestamosPendientes.TabIndex = 3;
            this.btnPrestamosPendientes.Text = "Préstamos Pendientes de Devolución";
            this.btnPrestamosPendientes.UseVisualStyleBackColor = true;
            this.btnPrestamosPendientes.Click += new System.EventHandler(this.btnPrestamosPendientes_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(30, 85);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(180, 85);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(104, 82);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(70, 20);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(243, 82);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(70, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnPrestamosPendientes);
            this.Controls.Add(this.btnEquiposMasUtilizados);
            this.Controls.Add(this.btnPrestamosPorFecha);
            this.Controls.Add(this.btnEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnPrestamosPorFecha;
        private System.Windows.Forms.Button btnEquiposMasUtilizados;
        private System.Windows.Forms.Button btnPrestamosPendientes;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}
