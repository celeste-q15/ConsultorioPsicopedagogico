namespace ConsultorioPsicopedagogico
{
    partial class Agregar_Turnos
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
            this.turno_date = new System.Windows.Forms.DateTimePicker();
            this.truno_time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.conc_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // turno_date
            // 
            this.turno_date.CalendarForeColor = System.Drawing.Color.Purple;
            this.turno_date.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.turno_date.CalendarTitleBackColor = System.Drawing.Color.Thistle;
            this.turno_date.CalendarTitleForeColor = System.Drawing.Color.Purple;
            this.turno_date.CalendarTrailingForeColor = System.Drawing.Color.Thistle;
            this.turno_date.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turno_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.turno_date.Location = new System.Drawing.Point(285, 124);
            this.turno_date.Name = "turno_date";
            this.turno_date.Size = new System.Drawing.Size(139, 27);
            this.turno_date.TabIndex = 0;
            this.turno_date.Value = new System.DateTime(2025, 4, 15, 23, 45, 6, 0);
            // 
            // truno_time
            // 
            this.truno_time.CalendarForeColor = System.Drawing.Color.Purple;
            this.truno_time.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.truno_time.CalendarTitleBackColor = System.Drawing.Color.Thistle;
            this.truno_time.CalendarTitleForeColor = System.Drawing.Color.Purple;
            this.truno_time.CalendarTrailingForeColor = System.Drawing.Color.Thistle;
            this.truno_time.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold);
            this.truno_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.truno_time.Location = new System.Drawing.Point(430, 124);
            this.truno_time.Name = "truno_time";
            this.truno_time.Size = new System.Drawing.Size(114, 27);
            this.truno_time.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "ASIGNAR TURNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA Y HORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONCURRENTE";
            // 
            // conc_txt
            // 
            this.conc_txt.BackColor = System.Drawing.Color.Thistle;
            this.conc_txt.ForeColor = System.Drawing.Color.Purple;
            this.conc_txt.Location = new System.Drawing.Point(285, 225);
            this.conc_txt.Name = "conc_txt";
            this.conc_txt.Size = new System.Drawing.Size(259, 22);
            this.conc_txt.TabIndex = 5;
            // 
            // Agregar_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(660, 498);
            this.Controls.Add(this.conc_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.truno_time);
            this.Controls.Add(this.turno_date);
            this.Name = "Agregar_Turnos";
            this.Text = "Agregar_Turnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker turno_date;
        private System.Windows.Forms.DateTimePicker truno_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox conc_txt;
    }
}