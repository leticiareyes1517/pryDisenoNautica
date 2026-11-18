namespace pryDisenoNautica
{
    partial class frmalquileres
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblnombre = new Label();
            lbldni = new Label();
            lblembarcacion = new Label();
            lblhoras = new Label();
            txtnombre = new TextBox();
            txtdni = new TextBox();
            txthoras = new TextBox();
            grpturno = new GroupBox();
            rbttarde = new RadioButton();
            rbtmañana = new RadioButton();
            chksocio = new CheckBox();
            btncalcular = new Button();
            btnlimpiar = new Button();
            grpdatos = new GroupBox();
            cbodni = new ComboBox();
            grpimporte = new GroupBox();
            txttotal = new Label();
            txtdescuento = new Label();
            txtsubtotal = new Label();
            lbltotal = new Label();
            lbldescuento = new Label();
            lblsubtotal = new Label();
            grpturno.SuspendLayout();
            grpdatos.SuspendLayout();
            grpimporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.FlatStyle = FlatStyle.Flat;
            lblnombre.Location = new Point(22, 28);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Location = new Point(22, 69);
            lbldni.Name = "lbldni";
            lbldni.Size = new Size(30, 15);
            lbldni.TabIndex = 1;
            lbldni.Text = "DNI:";
            // 
            // lblembarcacion
            // 
            lblembarcacion.AutoSize = true;
            lblembarcacion.Location = new Point(22, 110);
            lblembarcacion.Name = "lblembarcacion";
            lblembarcacion.Size = new Size(79, 15);
            lblembarcacion.TabIndex = 2;
            lblembarcacion.Text = "Embarcación:";
            // 
            // lblhoras
            // 
            lblhoras.AutoSize = true;
            lblhoras.Location = new Point(10, 140);
            lblhoras.Name = "lblhoras";
            lblhoras.Size = new Size(76, 15);
            lblhoras.TabIndex = 3;
            lblhoras.Text = "Horas (1 a 6):";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(101, 22);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(198, 23);
            txtnombre.TabIndex = 4;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(101, 67);
            txtdni.MaxLength = 8;
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(110, 23);
            txtdni.TabIndex = 5;
            txtdni.KeyPress += txtdni_KeyPress;
            // 
            // txthoras
            // 
            txthoras.Location = new Point(101, 137);
            txthoras.MaxLength = 6;
            txthoras.Name = "txthoras";
            txthoras.Size = new Size(40, 23);
            txthoras.TabIndex = 6;
            txthoras.KeyPress += txthoras_KeyPress;
            // 
            // grpturno
            // 
            grpturno.Controls.Add(rbttarde);
            grpturno.Controls.Add(rbtmañana);
            grpturno.Location = new Point(22, 178);
            grpturno.Name = "grpturno";
            grpturno.Size = new Size(311, 58);
            grpturno.TabIndex = 7;
            grpturno.TabStop = false;
            grpturno.Text = "Turno";
            // 
            // rbttarde
            // 
            rbttarde.AutoSize = true;
            rbttarde.Location = new Point(151, 22);
            rbttarde.Name = "rbttarde";
            rbttarde.Size = new Size(54, 19);
            rbttarde.TabIndex = 1;
            rbttarde.TabStop = true;
            rbttarde.Text = "Tarde";
            rbttarde.UseVisualStyleBackColor = true;
            // 
            // rbtmañana
            // 
            rbtmañana.AutoSize = true;
            rbtmañana.Location = new Point(27, 22);
            rbtmañana.Name = "rbtmañana";
            rbtmañana.Size = new Size(68, 19);
            rbtmañana.TabIndex = 0;
            rbtmañana.TabStop = true;
            rbtmañana.Text = "Mañana";
            rbtmañana.UseVisualStyleBackColor = true;
            // 
            // chksocio
            // 
            chksocio.AutoSize = true;
            chksocio.Location = new Point(29, 242);
            chksocio.Name = "chksocio";
            chksocio.Size = new Size(158, 19);
            chksocio.TabIndex = 8;
            chksocio.Text = "Socio del club (5 % extra)";
            chksocio.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(29, 267);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(114, 23);
            btncalcular.TabIndex = 9;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(170, 267);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(114, 23);
            btnlimpiar.TabIndex = 10;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // grpdatos
            // 
            grpdatos.Controls.Add(cbodni);
            grpdatos.Controls.Add(txthoras);
            grpdatos.Controls.Add(lblhoras);
            grpdatos.Controls.Add(txtdni);
            grpdatos.Controls.Add(txtnombre);
            grpdatos.Location = new Point(12, 2);
            grpdatos.Name = "grpdatos";
            grpdatos.Size = new Size(335, 318);
            grpdatos.TabIndex = 11;
            grpdatos.TabStop = false;
            grpdatos.Text = "Datos del alquiler";
            // 
            // cbodni
            // 
            cbodni.FormattingEnabled = true;
            cbodni.Items.AddRange(new object[] { "Kayak Simple", "Kayak Doble", "Kayak SUP" });
            cbodni.Location = new Point(101, 103);
            cbodni.Name = "cbodni";
            cbodni.Size = new Size(121, 23);
            cbodni.TabIndex = 7;
            // 
            // grpimporte
            // 
            grpimporte.Controls.Add(txttotal);
            grpimporte.Controls.Add(txtdescuento);
            grpimporte.Controls.Add(txtsubtotal);
            grpimporte.Controls.Add(lbltotal);
            grpimporte.Controls.Add(lbldescuento);
            grpimporte.Controls.Add(lblsubtotal);
            grpimporte.Location = new Point(12, 326);
            grpimporte.Name = "grpimporte";
            grpimporte.Size = new Size(332, 135);
            grpimporte.TabIndex = 12;
            grpimporte.TabStop = false;
            grpimporte.Text = "Importe";
            // 
            // txttotal
            // 
            txttotal.AutoSize = true;
            txttotal.FlatStyle = FlatStyle.System;
            txttotal.Location = new Point(101, 97);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(37, 15);
            txttotal.TabIndex = 5;
            txttotal.Text = "$ 0,00";
            // 
            // txtdescuento
            // 
            txtdescuento.AutoSize = true;
            txtdescuento.FlatStyle = FlatStyle.System;
            txtdescuento.Location = new Point(101, 66);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(26, 15);
            txtdescuento.TabIndex = 4;
            txtdescuento.Text = "0 %";
            // 
            // txtsubtotal
            // 
            txtsubtotal.AutoSize = true;
            txtsubtotal.FlatStyle = FlatStyle.System;
            txtsubtotal.Location = new Point(101, 32);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(37, 15);
            txtsubtotal.TabIndex = 3;
            txtsubtotal.Text = "$ 0,00";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(10, 97);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(78, 15);
            lbltotal.TabIndex = 2;
            lbltotal.Text = "Total a pagar:";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(10, 66);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(66, 15);
            lbldescuento.TabIndex = 1;
            lbldescuento.Text = "Descuento:";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(10, 32);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(54, 15);
            lblsubtotal.TabIndex = 0;
            lblsubtotal.Text = "Subtotal:";
            // 
            // frmalquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 475);
            Controls.Add(grpimporte);
            Controls.Add(btnlimpiar);
            Controls.Add(btncalcular);
            Controls.Add(chksocio);
            Controls.Add(lblembarcacion);
            Controls.Add(lbldni);
            Controls.Add(lblnombre);
            Controls.Add(grpturno);
            Controls.Add(grpdatos);
            Name = "frmalquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAlquileres";
            grpturno.ResumeLayout(false);
            grpturno.PerformLayout();
            grpdatos.ResumeLayout(false);
            grpdatos.PerformLayout();
            grpimporte.ResumeLayout(false);
            grpimporte.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lbldni;
        private Label lblembarcacion;
        private Label lblhoras;
        private TextBox txtnombre;
        private TextBox txtdni;
        private TextBox txthoras;
        private GroupBox grpturno;
        private RadioButton rbttarde;
        private RadioButton rbtmañana;
        private CheckBox chksocio;
        private Button btncalcular;
        private Button btnlimpiar;
        private GroupBox grpdatos;
        private GroupBox grpimporte;
        private Label lbltotal;
        private Label lbldescuento;
        private Label lblsubtotal;
        private ComboBox cbodni;
        private Label txtsubtotal;
        private Label txttotal;
        private Label txtdescuento;
    }
}
