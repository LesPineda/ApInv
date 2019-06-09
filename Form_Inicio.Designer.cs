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
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Agregar = new System.Windows.Forms.Label();
            this.label_Modificar = new System.Windows.Forms.Label();
            this.label_Consulta = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Consulta = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(447, 181);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(237, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Administacion de Inventario y control de Cuentas";
            // 
            // label_Agregar
            // 
            this.label_Agregar.AutoSize = true;
            this.label_Agregar.Location = new System.Drawing.Point(385, 212);
            this.label_Agregar.Name = "label_Agregar";
            this.label_Agregar.Size = new System.Drawing.Size(72, 13);
            this.label_Agregar.TabIndex = 2;
            this.label_Agregar.Text = "label_Agregar";
            // 
            // label_Modificar
            // 
            this.label_Modificar.AutoSize = true;
            this.label_Modificar.Location = new System.Drawing.Point(385, 245);
            this.label_Modificar.Name = "label_Modificar";
            this.label_Modificar.Size = new System.Drawing.Size(78, 13);
            this.label_Modificar.TabIndex = 3;
            this.label_Modificar.Text = "label_Modificar";
            // 
            // label_Consulta
            // 
            this.label_Consulta.AutoSize = true;
            this.label_Consulta.Location = new System.Drawing.Point(385, 278);
            this.label_Consulta.Name = "label_Consulta";
            this.label_Consulta.Size = new System.Drawing.Size(76, 13);
            this.label_Consulta.TabIndex = 4;
            this.label_Consulta.Text = "label_Consulta";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(508, 212);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(84, 20);
            this.button_Agregar.TabIndex = 5;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.Button_Agregar_Click);
            // 
            // button_Modificar
            // 
            this.button_Modificar.Location = new System.Drawing.Point(508, 245);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(84, 20);
            this.button_Modificar.TabIndex = 6;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.Button_Modificar_Click);
            // 
            // button_Consulta
            // 
            this.button_Consulta.Location = new System.Drawing.Point(508, 278);
            this.button_Consulta.Name = "button_Consulta";
            this.button_Consulta.Size = new System.Drawing.Size(84, 20);
            this.button_Consulta.TabIndex = 7;
            this.button_Consulta.Text = "Consulta";
            this.button_Consulta.UseVisualStyleBackColor = true;
            this.button_Consulta.Click += new System.EventHandler(this.Button_Consulta_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.ControlText;
            this.MenuVertical.Controls.Add(this.Logo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 600);
            this.MenuVertical.TabIndex = 8;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelTitulo.Controls.Add(this.BtnMenu);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(250, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(750, 50);
            this.PanelTitulo.TabIndex = 9;
            // 
            // PanelControl
            // 
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl.Location = new System.Drawing.Point(250, 50);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(750, 550);
            this.PanelControl.TabIndex = 10;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Image = global::ApInv.Properties.Resources.Mobile_Menu_Icon;
            this.BtnMenu.Location = new System.Drawing.Point(6, 9);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(35, 35);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ApInv.Properties.Resources.IMO2;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(232, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button_Consulta);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.label_Consulta);
            this.Controls.Add(this.label_Modificar);
            this.Controls.Add(this.label_Agregar);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Inicio";
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Form_Inicio_Load);
            this.MenuVertical.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Agregar;
        private System.Windows.Forms.Label label_Modificar;
        private System.Windows.Forms.Label label_Consulta;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Consulta;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.Panel PanelControl;
    }
}