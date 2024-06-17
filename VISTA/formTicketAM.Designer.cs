namespace VISTA
{
    partial class formTicketAM
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
            label1 = new Label();
            lblAgregaroModificar = new Label();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            dtpFechaInicio = new DateTimePicker();
            cbTipoTicket = new ComboBox();
            cbEstado = new ComboBox();
            cbUrgencia = new ComboBox();
            txtDescripcion = new TextBox();
            cbCategoria = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            cbCodigoPc = new ComboBox();
            cbTecnico = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 29);
            label1.TabIndex = 0;
            label1.Text = "Crear Ticket";
            // 
            // lblAgregaroModificar
            // 
            lblAgregaroModificar.AutoSize = true;
            lblAgregaroModificar.Location = new Point(118, 43);
            lblAgregaroModificar.Name = "lblAgregaroModificar";
            lblAgregaroModificar.Size = new Size(147, 15);
            lblAgregaroModificar.TabIndex = 1;
            lblAgregaroModificar.Text = "Agregar o Modificar Ticket";
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(356, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(386, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(144, 94);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(236, 23);
            dtpFechaInicio.TabIndex = 5;
            // 
            // cbTipoTicket
            // 
            cbTipoTicket.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTicket.FormattingEnabled = true;
            cbTipoTicket.Location = new Point(144, 194);
            cbTipoTicket.Name = "cbTipoTicket";
            cbTipoTicket.Size = new Size(236, 23);
            cbTipoTicket.TabIndex = 6;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(145, 296);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(235, 23);
            cbEstado.TabIndex = 7;
            // 
            // cbUrgencia
            // 
            cbUrgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUrgencia.FormattingEnabled = true;
            cbUrgencia.Location = new Point(145, 342);
            cbUrgencia.Name = "cbUrgencia";
            cbUrgencia.Size = new Size(235, 23);
            cbUrgencia.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 447);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(252, 96);
            txtDescripcion.TabIndex = 11;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(144, 246);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(236, 23);
            cbCategoria.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 14;
            label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 197);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 15;
            label4.Text = "Tipo Ticket:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 249);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 16;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 299);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 17;
            label6.Text = "Estado Ticlet:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 345);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 18;
            label7.Text = "Urgencia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(22, 394);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 20;
            label9.Text = "Asignado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(22, 446);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 21;
            label10.Text = "Descripción:";
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(112, 567);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(83, 30);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(209, 567);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 30);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 143);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 24;
            label2.Text = "Código Pc:";
            // 
            // cbCodigoPc
            // 
            cbCodigoPc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodigoPc.FormattingEnabled = true;
            cbCodigoPc.Location = new Point(145, 140);
            cbCodigoPc.Name = "cbCodigoPc";
            cbCodigoPc.Size = new Size(235, 23);
            cbCodigoPc.TabIndex = 25;
            // 
            // cbTecnico
            // 
            cbTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(140, 395);
            cbTecnico.Name = "cbTecnico";
            cbTecnico.Size = new Size(240, 23);
            cbTecnico.TabIndex = 26;
            // 
            // formTicketAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 611);
            Controls.Add(cbTecnico);
            Controls.Add(cbCodigoPc);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(cbUrgencia);
            Controls.Add(cbEstado);
            Controls.Add(cbTipoTicket);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(lblAgregaroModificar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formTicketAM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTicketAM";
            Load += formTicketAM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAgregaroModificar;
        private Button btnMinimizar;
        private Button btnCerrar;
        private DateTimePicker dtpFechaInicio;
        private ComboBox cbTipoTicket;
        private ComboBox cbEstado;
        private ComboBox cbUrgencia;
        private TextBox txtDescripcion;
        private ComboBox cbCategoria;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private ComboBox cbCodigoPc;
        private ComboBox cbTecnico;
    }
}