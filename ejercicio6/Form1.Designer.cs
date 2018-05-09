namespace ejercicio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lsbver = new System.Windows.Forms.ListBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lbver2 = new System.Windows.Forms.ListBox();
            this.txtVer9 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmultiplo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblista = new System.Windows.Forms.ListBox();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.Nombres = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 126);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbver
            // 
            this.lsbver.FormattingEnabled = true;
            this.lsbver.Location = new System.Drawing.Point(24, 19);
            this.lsbver.Name = "lsbver";
            this.lsbver.Size = new System.Drawing.Size(157, 147);
            this.lsbver.TabIndex = 2;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(179, 19);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(145, 23);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lbver2
            // 
            this.lbver2.FormattingEnabled = true;
            this.lbver2.Location = new System.Drawing.Point(17, 19);
            this.lbver2.Name = "lbver2";
            this.lbver2.Size = new System.Drawing.Size(146, 186);
            this.lbver2.TabIndex = 5;
            // 
            // txtVer9
            // 
            this.txtVer9.Location = new System.Drawing.Point(179, 217);
            this.txtVer9.Name = "txtVer9";
            this.txtVer9.Size = new System.Drawing.Size(145, 20);
            this.txtVer9.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtVer9);
            this.groupBox1.Controls.Add(this.lbver2);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 243);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.lsbver);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 175);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(187, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txthasta);
            this.groupBox3.Controls.Add(this.txtdesde);
            this.groupBox3.Controls.Add(this.btnlistar);
            this.groupBox3.Controls.Add(this.lista);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtmultiplo);
            this.groupBox3.Location = new System.Drawing.Point(364, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 339);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 102);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(206, 45);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(100, 20);
            this.txthasta.TabIndex = 6;
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(17, 45);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(100, 20);
            this.txtdesde.TabIndex = 5;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(85, 71);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(148, 23);
            this.btnlistar.TabIndex = 4;
            this.btnlistar.Text = "Agregar";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnAgregarlist_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(17, 109);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(289, 212);
            this.lista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Espacio del vector";
            // 
            // txtmultiplo
            // 
            this.txtmultiplo.Location = new System.Drawing.Point(17, 19);
            this.txtmultiplo.Name = "txtmultiplo";
            this.txtmultiplo.Size = new System.Drawing.Size(301, 20);
            this.txtmultiplo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLimpiar);
            this.groupBox4.Controls.Add(this.lblista);
            this.groupBox4.Controls.Add(this.txtTamano);
            this.groupBox4.Controls.Add(this.btnEnviar);
            this.groupBox4.Controls.Add(this.Nombres);
            this.groupBox4.Location = new System.Drawing.Point(281, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 276);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(275, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // lblista
            // 
            this.lblista.FormattingEnabled = true;
            this.lblista.Location = new System.Drawing.Point(32, 97);
            this.lblista.Name = "lblista";
            this.lblista.Size = new System.Drawing.Size(237, 173);
            this.lblista.TabIndex = 10;
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(19, 23);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(100, 20);
            this.txtTamano.TabIndex = 9;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(125, 68);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(246, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Agregar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(165, 23);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(46, 13);
            this.Nombres.TabIndex = 2;
            this.Nombres.Text = "Tamaño";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 651);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbver;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListBox lbver2;
        private System.Windows.Forms.TextBox txtVer9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmultiplo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.TextBox txtdesde;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.ListBox lblista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

