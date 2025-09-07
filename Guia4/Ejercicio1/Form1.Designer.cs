namespace Ejercicio1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            cmbProductos = new ComboBox();
            btnBorrarProducto = new Button();
            btnCerrarPresupuesto = new Button();
            btnIniciarPresupuesto = new Button();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            lbDireccion = new Label();
            lbNombre = new Label();
            groupBox2 = new GroupBox();
            rbMesa = new RadioButton();
            rbBanco = new RadioButton();
            tbGrosor = new TextBox();
            tbLargo = new TextBox();
            tbCodigo = new TextBox();
            tbAncho = new TextBox();
            tbpBase = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnImportar = new Button();
            btnExportar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbProductos);
            groupBox1.Controls.Add(btnBorrarProducto);
            groupBox1.Controls.Add(btnCerrarPresupuesto);
            groupBox1.Controls.Add(btnIniciarPresupuesto);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(lbDireccion);
            groupBox1.Controls.Add(lbNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(15, 223);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(115, 23);
            cmbProductos.TabIndex = 7;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Location = new Point(150, 215);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(87, 45);
            btnBorrarProducto.TabIndex = 6;
            btnBorrarProducto.Text = "Borrar Producto";
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnCerrarPresupuesto
            // 
            btnCerrarPresupuesto.Location = new Point(150, 136);
            btnCerrarPresupuesto.Name = "btnCerrarPresupuesto";
            btnCerrarPresupuesto.Size = new Size(87, 51);
            btnCerrarPresupuesto.TabIndex = 5;
            btnCerrarPresupuesto.Text = "Cerrar Presupuesto";
            btnCerrarPresupuesto.UseVisualStyleBackColor = true;
            btnCerrarPresupuesto.Click += btnCerrarPresupuesto_Click;
            // 
            // btnIniciarPresupuesto
            // 
            btnIniciarPresupuesto.Location = new Point(15, 136);
            btnIniciarPresupuesto.Name = "btnIniciarPresupuesto";
            btnIniciarPresupuesto.Size = new Size(87, 51);
            btnIniciarPresupuesto.TabIndex = 4;
            btnIniciarPresupuesto.Text = "Iniciar Presupuesto";
            btnIniciarPresupuesto.UseVisualStyleBackColor = true;
            btnIniciarPresupuesto.Click += btnIniciarPresupuesto_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(95, 88);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(100, 23);
            tbDireccion.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(95, 40);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 2;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(15, 96);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(60, 15);
            lbDireccion.TabIndex = 1;
            lbDireccion.Text = "Direccion:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(15, 43);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbMesa);
            groupBox2.Controls.Add(rbBanco);
            groupBox2.Controls.Add(tbGrosor);
            groupBox2.Controls.Add(tbLargo);
            groupBox2.Controls.Add(tbCodigo);
            groupBox2.Controls.Add(tbAncho);
            groupBox2.Controls.Add(tbpBase);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Location = new Point(285, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 196);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            // 
            // rbMesa
            // 
            rbMesa.AutoSize = true;
            rbMesa.Location = new Point(117, 39);
            rbMesa.Name = "rbMesa";
            rbMesa.Size = new Size(53, 19);
            rbMesa.TabIndex = 18;
            rbMesa.Text = "Mesa";
            rbMesa.UseVisualStyleBackColor = true;
            // 
            // rbBanco
            // 
            rbBanco.AutoSize = true;
            rbBanco.Location = new Point(16, 39);
            rbBanco.Name = "rbBanco";
            rbBanco.Size = new Size(58, 19);
            rbBanco.TabIndex = 17;
            rbBanco.Text = "Banco";
            rbBanco.UseVisualStyleBackColor = true;
            // 
            // tbGrosor
            // 
            tbGrosor.Location = new Point(255, 149);
            tbGrosor.Name = "tbGrosor";
            tbGrosor.Size = new Size(100, 23);
            tbGrosor.TabIndex = 16;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(255, 115);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(100, 23);
            tbLargo.TabIndex = 15;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(92, 151);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 14;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(92, 115);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 13;
            // 
            // tbpBase
            // 
            tbpBase.Location = new Point(92, 81);
            tbpBase.Name = "tbpBase";
            tbpBase.Size = new Size(100, 23);
            tbpBase.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 154);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Grosor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 118);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 11;
            label7.Text = "Largo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 154);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 118);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Ancho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Precio Base:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(384, 118);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(87, 51);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(335, 227);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(175, 36);
            btnImportar.TabIndex = 13;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(589, 228);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(161, 36);
            btnExportar.TabIndex = 14;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 287);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guia 4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbProductos;
        private Button btnBorrarProducto;
        private Button btnCerrarPresupuesto;
        private Button btnIniciarPresupuesto;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private Label lbDireccion;
        private Label lbNombre;
        private GroupBox groupBox2;
        private TextBox tbGrosor;
        private TextBox tbLargo;
        private TextBox tbCodigo;
        private TextBox tbAncho;
        private TextBox tbpBase;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAgregar;
        private Button btnImportar;
        private Button btnExportar;
        private RadioButton rbMesa;
        private RadioButton rbBanco;
    }
}
