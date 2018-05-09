namespace ejercicio6
{
    partial class Form2
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
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.Tamaño = new System.Windows.Forms.Label();
            this.btnarreglo2 = new System.Windows.Forms.Button();
            this.lblistar1 = new System.Windows.Forms.ListBox();
            this.lblistar2 = new System.Windows.Forms.ListBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCon = new System.Windows.Forms.ListBox();
            this.btnbusqueda = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtpala = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbSelect = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttamaño
            // 
            this.txttamaño.Location = new System.Drawing.Point(6, 19);
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(145, 20);
            this.txttamaño.TabIndex = 0;
            // 
            // Tamaño
            // 
            this.Tamaño.AutoSize = true;
            this.Tamaño.Location = new System.Drawing.Point(163, 16);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(46, 13);
            this.Tamaño.TabIndex = 1;
            this.Tamaño.Text = "Tamaño";
            // 
            // btnarreglo2
            // 
            this.btnarreglo2.Location = new System.Drawing.Point(81, 45);
            this.btnarreglo2.Name = "btnarreglo2";
            this.btnarreglo2.Size = new System.Drawing.Size(167, 23);
            this.btnarreglo2.TabIndex = 3;
            this.btnarreglo2.Text = "Llenar Arreglo";
            this.btnarreglo2.UseVisualStyleBackColor = true;
            this.btnarreglo2.Click += new System.EventHandler(this.txtarreglo2_Click);
            // 
            // lblistar1
            // 
            this.lblistar1.FormattingEnabled = true;
            this.lblistar1.Location = new System.Drawing.Point(166, 89);
            this.lblistar1.Name = "lblistar1";
            this.lblistar1.Size = new System.Drawing.Size(145, 173);
            this.lblistar1.TabIndex = 4;
            // 
            // lblistar2
            // 
            this.lblistar2.FormattingEnabled = true;
            this.lblistar2.Location = new System.Drawing.Point(16, 89);
            this.lblistar2.Name = "lblistar2";
            this.lblistar2.Size = new System.Drawing.Size(144, 173);
            this.lblistar2.TabIndex = 5;
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(322, 89);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(102, 173);
            this.lbResultado.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txttamaño);
            this.groupBox1.Controls.Add(this.lblistar2);
            this.groupBox1.Controls.Add(this.lbResultado);
            this.groupBox1.Controls.Add(this.lblistar1);
            this.groupBox1.Controls.Add(this.Tamaño);
            this.groupBox1.Controls.Add(this.btnarreglo2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 274);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(359, 11);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCon);
            this.groupBox2.Controls.Add(this.btnbusqueda);
            this.groupBox2.Controls.Add(this.lblBuscar);
            this.groupBox2.Controls.Add(this.txtpala);
            this.groupBox2.Controls.Add(this.btnListar);
            this.groupBox2.Controls.Add(this.lbSelect);
            this.groupBox2.Location = new System.Drawing.Point(12, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 268);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbCon
            // 
            this.lbCon.FormattingEnabled = true;
            this.lbCon.Location = new System.Drawing.Point(191, 143);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(233, 82);
            this.lbCon.TabIndex = 5;
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Location = new System.Drawing.Point(236, 103);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnbusqueda.TabIndex = 4;
            this.btnbusqueda.Text = "Buscar";
            this.btnbusqueda.UseVisualStyleBackColor = true;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(351, 62);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(88, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Palabra a Buscar";
            // 
            // txtpala
            // 
            this.txtpala.Location = new System.Drawing.Point(173, 59);
            this.txtpala.Name = "txtpala";
            this.txtpala.Size = new System.Drawing.Size(172, 20);
            this.txtpala.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(173, 20);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbSelect
            // 
            this.lbSelect.FormattingEnabled = true;
            this.lbSelect.Location = new System.Drawing.Point(16, 20);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(144, 147);
            this.lbSelect.TabIndex = 0;
            this.lbSelect.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txttamaño;
        private System.Windows.Forms.Label Tamaño;
        private System.Windows.Forms.Button btnarreglo2;
        private System.Windows.Forms.ListBox lblistar1;
        private System.Windows.Forms.ListBox lblistar2;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbSelect;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbCon;
        private System.Windows.Forms.Button btnbusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtpala;
    }
}