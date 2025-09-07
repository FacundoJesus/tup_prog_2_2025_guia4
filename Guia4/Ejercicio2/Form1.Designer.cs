namespace Ejercicio2
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
            btnAgregarProducto = new Button();
            tbGrosor = new TextBox();
            tbLargo = new TextBox();
            tbCodigo = new TextBox();
            tbAncho = new TextBox();
            tbPrecioBase = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            rbMesa = new RadioButton();
            rbBanco = new RadioButton();
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
            groupBox1.Size = new Size(284, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(18, 207);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(139, 23);
            cmbProductos.TabIndex = 7;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Location = new Point(179, 197);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(81, 40);
            btnBorrarProducto.TabIndex = 6;
            btnBorrarProducto.Text = "Borrar Producto";
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnCerrarPresupuesto
            // 
            btnCerrarPresupuesto.Location = new Point(179, 122);
            btnCerrarPresupuesto.Name = "btnCerrarPresupuesto";
            btnCerrarPresupuesto.Size = new Size(81, 53);
            btnCerrarPresupuesto.TabIndex = 5;
            btnCerrarPresupuesto.Text = "Cerrar Presupuesto";
            btnCerrarPresupuesto.UseVisualStyleBackColor = true;
            btnCerrarPresupuesto.Click += btnCerrarPresupuesto_Click;
            // 
            // btnIniciarPresupuesto
            // 
            btnIniciarPresupuesto.Location = new Point(18, 122);
            btnIniciarPresupuesto.Name = "btnIniciarPresupuesto";
            btnIniciarPresupuesto.Size = new Size(81, 53);
            btnIniciarPresupuesto.TabIndex = 4;
            btnIniciarPresupuesto.Text = "Iniciar Presupuesto";
            btnIniciarPresupuesto.UseVisualStyleBackColor = true;
            btnIniciarPresupuesto.Click += btnIniciarPresupuesto_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(109, 69);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(151, 23);
            tbDireccion.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(109, 27);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(151, 23);
            tbNombre.TabIndex = 2;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(18, 72);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(60, 15);
            lbDireccion.TabIndex = 1;
            lbDireccion.Text = "Dirección:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(18, 30);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregarProducto);
            groupBox2.Controls.Add(tbGrosor);
            groupBox2.Controls.Add(tbLargo);
            groupBox2.Controls.Add(tbCodigo);
            groupBox2.Controls.Add(tbAncho);
            groupBox2.Controls.Add(tbPrecioBase);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(rbMesa);
            groupBox2.Controls.Add(rbBanco);
            groupBox2.Location = new Point(311, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(263, 156);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(81, 40);
            btnAgregarProducto.TabIndex = 10;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // tbGrosor
            // 
            tbGrosor.Location = new Point(241, 103);
            tbGrosor.Name = "tbGrosor";
            tbGrosor.Size = new Size(103, 23);
            tbGrosor.TabIndex = 16;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(241, 69);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(103, 23);
            tbLargo.TabIndex = 15;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(65, 133);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(103, 23);
            tbCodigo.TabIndex = 14;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(65, 103);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(103, 23);
            tbAncho.TabIndex = 13;
            // 
            // tbPrecioBase
            // 
            tbPrecioBase.Location = new Point(65, 69);
            tbPrecioBase.Name = "tbPrecioBase";
            tbPrecioBase.Size = new Size(103, 23);
            tbPrecioBase.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 108);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Grosor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 72);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 11;
            label7.Text = "Largo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 108);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Ancho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Precio B:";
            // 
            // rbMesa
            // 
            rbMesa.AutoSize = true;
            rbMesa.Location = new Point(109, 27);
            rbMesa.Name = "rbMesa";
            rbMesa.Size = new Size(53, 19);
            rbMesa.TabIndex = 1;
            rbMesa.TabStop = true;
            rbMesa.Text = "Mesa";
            rbMesa.UseVisualStyleBackColor = true;
            // 
            // rbBanco
            // 
            rbBanco.AutoSize = true;
            rbBanco.Location = new Point(6, 27);
            rbBanco.Name = "rbBanco";
            rbBanco.Size = new Size(58, 19);
            rbBanco.TabIndex = 0;
            rbBanco.TabStop = true;
            rbBanco.Text = "Banco";
            rbBanco.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            btnImportar.Enabled = false;
            btnImportar.Location = new Point(311, 220);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(81, 40);
            btnImportar.TabIndex = 8;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Enabled = false;
            btnExportar.Location = new Point(574, 220);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(81, 40);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 281);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            Load += Form1_Load;
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
        private RadioButton rbBanco;
        private Button btnImportar;
        private Button btnExportar;
        private TextBox tbGrosor;
        private TextBox tbLargo;
        private TextBox tbCodigo;
        private TextBox tbAncho;
        private TextBox tbPrecioBase;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private RadioButton rbMesa;
        private Button btnAgregarProducto;
    }
}
