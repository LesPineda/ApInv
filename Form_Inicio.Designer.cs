namespace ApInv
{
    partial class Form_Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Agregar = new System.Windows.Forms.Label();
            this.label_Modificar = new System.Windows.Forms.Label();
            this.label_Consulta = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Consulta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(108, 41);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(237, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Administacion de Inventario y control de Cuentas";
            // 
            // label_Agregar
            // 
            this.label_Agregar.AutoSize = true;
            this.label_Agregar.Location = new System.Drawing.Point(46, 72);
            this.label_Agregar.Name = "label_Agregar";
            this.label_Agregar.Size = new System.Drawing.Size(72, 13);
            this.label_Agregar.TabIndex = 2;
            this.label_Agregar.Text = "label_Agregar";
            // 
            // label_Modificar
            // 
            this.label_Modificar.AutoSize = true;
            this.label_Modificar.Location = new System.Drawing.Point(46, 105);
            this.label_Modificar.Name = "label_Modificar";
            this.label_Modificar.Size = new System.Drawing.Size(78, 13);
            this.label_Modificar.TabIndex = 3;
            this.label_Modificar.Text = "label_Modificar";
            // 
            // label_Consulta
            // 
            this.label_Consulta.AutoSize = true;
            this.label_Consulta.Location = new System.Drawing.Point(46, 138);
            this.label_Consulta.Name = "label_Consulta";
            this.label_Consulta.Size = new System.Drawing.Size(76, 13);
            this.label_Consulta.TabIndex = 4;
            this.label_Consulta.Text = "label_Consulta";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(169, 72);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(84, 20);
            this.button_Agregar.TabIndex = 5;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.Button_Agregar_Click);
            // 
            // button_Modificar
            // 
            this.button_Modificar.Location = new System.Drawing.Point(169, 105);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(84, 20);
            this.button_Modificar.TabIndex = 6;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            // 
            // button_Consulta
            // 
            this.button_Consulta.Location = new System.Drawing.Point(169, 138);
            this.button_Consulta.Name = "button_Consulta";
            this.button_Consulta.Size = new System.Drawing.Size(84, 20);
            this.button_Consulta.TabIndex = 7;
            this.button_Consulta.Text = "Consulta";
            this.button_Consulta.UseVisualStyleBackColor = true;
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 269);
            this.Controls.Add(this.button_Consulta);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.label_Consulta);
            this.Controls.Add(this.label_Modificar);
            this.Controls.Add(this.label_Agregar);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Inicio";
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Form_Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Agregar;
        private System.Windows.Forms.Label label_Modificar;
        private System.Windows.Forms.Label label_Consulta;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Consulta;
    }
}