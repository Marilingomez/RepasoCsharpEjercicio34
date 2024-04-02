namespace RepasoCsharpEjercicio34
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
            txtnumero = new TextBox();
            label1 = new Label();
            mostrar = new Button();
            SuspendLayout();
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(59, 110);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(125, 27);
            txtnumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 77);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 2;
            label1.Text = "Por favor ingrese un numero";
            // 
            // mostrar
            // 
            mostrar.Location = new Point(60, 156);
            mostrar.Name = "mostrar";
            mostrar.Size = new Size(134, 29);
            mostrar.TabIndex = 3;
            mostrar.Text = "mostrar numero";
            mostrar.UseVisualStyleBackColor = true;
            mostrar.Click += mostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mostrar);
            Controls.Add(label1);
            Controls.Add(txtnumero);
            Name = "Form1";
            Text = "Ejercicio 34";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnumero;
        private Label label1;
        private Button mostrar;
    }
}
