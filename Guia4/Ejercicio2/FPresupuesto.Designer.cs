namespace Ejercicio2
{
    partial class FPresupuesto
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
            lsbResultado = new ListBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 12);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(376, 379);
            lsbResultado.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(156, 397);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 429);
            Controls.Add(btnAceptar);
            Controls.Add(lsbResultado);
            Name = "FPresupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPresupuesto";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        public ListBox lsbResultado;
    }
}