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
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Consulta = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(133, 12);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(348, 25);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Administacion de Inventario y Software";
            // 
            // button_Modificar
            // 
            this.button_Modificar.FlatAppearance.BorderSize = 0;
            this.button_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Modificar.Location = new System.Drawing.Point(0, 152);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(250, 40);
            this.button_Modificar.TabIndex = 6;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.Button_Modificar_Click);
            // 
            // button_Consulta
            // 
            this.button_Consulta.FlatAppearance.BorderSize = 0;
            this.button_Consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consulta.ForeColor = System.Drawing.Color.White;
            this.button_Consulta.Location = new System.Drawing.Point(0, 198);
            this.button_Consulta.Name = "button_Consulta";
            this.button_Consulta.Size = new System.Drawing.Size(250, 40);
            this.button_Consulta.TabIndex = 7;
            this.button_Consulta.Text = "Consulta";
            this.button_Consulta.UseVisualStyleBackColor = true;
            this.button_Consulta.Click += new System.EventHandler(this.Button_Consulta_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.ControlText;
            this.MenuVertical.Controls.Add(this.button_Consulta);
            this.MenuVertical.Controls.Add(this.button_Agregar);
            this.MenuVertical.Controls.Add(this.button_Modificar);
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
            this.PanelTitulo.Controls.Add(this.BtnRestaurar);
            this.PanelTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelTitulo.Controls.Add(this.BtnCerrar);
            this.PanelTitulo.Controls.Add(this.BtnMenu);
            this.PanelTitulo.Controls.Add(this.label_Titulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(250, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(750, 50);
            this.PanelTitulo.TabIndex = 9;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // PanelControl
            // 
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl.Location = new System.Drawing.Point(250, 50);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(750, 550);
            this.PanelControl.TabIndex = 10;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = global::ApInv.Properties.Resources.res;
            this.BtnRestaurar.Location = new System.Drawing.Point(692, 7);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 4;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::ApInv.Properties.Resources.minimazar;
            this.BtnMinimizar.Location = new System.Drawing.Point(661, 7);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = global::ApInv.Properties.Resources.maxi;
            this.BtnMaximizar.Location = new System.Drawing.Point(692, 7);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = global::ApInv.Properties.Resources.cerrar;
            this.BtnCerrar.Location = new System.Drawing.Point(723, 7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Image = global::ApInv.Properties.Resources.Mobile_Menu_Icon;
            this.BtnMenu.Location = new System.Drawing.Point(6, 9);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(35, 35);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // button_Agregar
            // 
            this.button_Agregar.FlatAppearance.BorderSize = 0;
            this.button_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Agregar.ForeColor = System.Drawing.Color.White;
            this.button_Agregar.Image = global::ApInv.Properties.Resources.producto;
            this.button_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Agregar.Location = new System.Drawing.Point(0, 92);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(250, 40);
            this.button_Agregar.TabIndex = 5;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.Button_Agregar_Click);
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
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Inicio";
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Form_Inicio_Load);
            this.MenuVertical.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Consulta;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnRestaurar;
    }
}