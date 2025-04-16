namespace ConsultorioPsicopedagogico.CPresentacion
{
    partial class Turnos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concurrente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarturno_btn = new System.Windows.Forms.Button();
            this.editarturno_btn = new System.Windows.Forms.Button();
            this.eliminarturno_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Concurrente,
            this.Contacto,
            this.Tutor});
            this.dataGridView1.Location = new System.Drawing.Point(49, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 529);
            this.dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 15;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.Width = 125;
            // 
            // Concurrente
            // 
            this.Concurrente.HeaderText = "Concurrente";
            this.Concurrente.MinimumWidth = 6;
            this.Concurrente.Name = "Concurrente";
            this.Concurrente.Width = 350;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.MinimumWidth = 6;
            this.Contacto.Name = "Contacto";
            this.Contacto.Width = 165;
            // 
            // Tutor
            // 
            this.Tutor.HeaderText = "Tutor";
            this.Tutor.MinimumWidth = 6;
            this.Tutor.Name = "Tutor";
            this.Tutor.Width = 350;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "TURNOS ASIGNADOS";
            // 
            // agregarturno_btn
            // 
            this.agregarturno_btn.Location = new System.Drawing.Point(644, 32);
            this.agregarturno_btn.Name = "agregarturno_btn";
            this.agregarturno_btn.Size = new System.Drawing.Size(132, 43);
            this.agregarturno_btn.TabIndex = 2;
            this.agregarturno_btn.Text = "AGREGAR";
            this.agregarturno_btn.UseVisualStyleBackColor = true;
            // 
            // editarturno_btn
            // 
            this.editarturno_btn.Location = new System.Drawing.Point(814, 32);
            this.editarturno_btn.Name = "editarturno_btn";
            this.editarturno_btn.Size = new System.Drawing.Size(132, 43);
            this.editarturno_btn.TabIndex = 3;
            this.editarturno_btn.Text = "EDITAR";
            this.editarturno_btn.UseVisualStyleBackColor = true;
            // 
            // eliminarturno_btn
            // 
            this.eliminarturno_btn.Location = new System.Drawing.Point(986, 32);
            this.eliminarturno_btn.Name = "eliminarturno_btn";
            this.eliminarturno_btn.Size = new System.Drawing.Size(132, 43);
            this.eliminarturno_btn.TabIndex = 4;
            this.eliminarturno_btn.Text = "ELIMINAR";
            this.eliminarturno_btn.UseVisualStyleBackColor = true;
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 657);
            this.Controls.Add(this.eliminarturno_btn);
            this.Controls.Add(this.editarturno_btn);
            this.Controls.Add(this.agregarturno_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Turnos";
            this.Text = "Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concurrente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarturno_btn;
        private System.Windows.Forms.Button editarturno_btn;
        private System.Windows.Forms.Button eliminarturno_btn;
    }
}