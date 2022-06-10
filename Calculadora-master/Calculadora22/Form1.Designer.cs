namespace Calculadora22
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
            this.Resultado = new System.Windows.Forms.TextBox();
            this.btnuno = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnpotencia = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnmasomenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultado.Location = new System.Drawing.Point(12, 12);
            this.Resultado.MaxLength = 21;
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(341, 50);
            this.Resultado.TabIndex = 0;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnuno
            // 
            this.btnuno.Location = new System.Drawing.Point(14, 317);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(45, 45);
            this.btnuno.TabIndex = 1;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btndos
            // 
            this.btndos.Location = new System.Drawing.Point(86, 317);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(45, 45);
            this.btndos.TabIndex = 2;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btntres
            // 
            this.btntres.Location = new System.Drawing.Point(156, 317);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(45, 45);
            this.btntres.TabIndex = 3;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btncuatro
            // 
            this.btncuatro.Location = new System.Drawing.Point(14, 248);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(45, 45);
            this.btncuatro.TabIndex = 4;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btncinco
            // 
            this.btncinco.Location = new System.Drawing.Point(86, 248);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(45, 45);
            this.btncinco.TabIndex = 5;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnseis
            // 
            this.btnseis.Location = new System.Drawing.Point(156, 248);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(45, 45);
            this.btnseis.TabIndex = 6;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnsiete
            // 
            this.btnsiete.Location = new System.Drawing.Point(14, 183);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(45, 45);
            this.btnsiete.TabIndex = 7;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnocho
            // 
            this.btnocho.Location = new System.Drawing.Point(86, 183);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(45, 45);
            this.btnocho.TabIndex = 8;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnnueve
            // 
            this.btnnueve.Location = new System.Drawing.Point(156, 183);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(45, 45);
            this.btnnueve.TabIndex = 9;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(156, 80);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(45, 45);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "<--";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Location = new System.Drawing.Point(86, 80);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(45, 45);
            this.btnborrartodo.TabIndex = 11;
            this.btnborrartodo.Text = "C";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(14, 80);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(45, 45);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.button12_Click);
            // 
            // btncero
            // 
            this.btncero.Location = new System.Drawing.Point(86, 378);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(45, 45);
            this.btncero.TabIndex = 13;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnpotencia
            // 
            this.btnpotencia.Location = new System.Drawing.Point(308, 183);
            this.btnpotencia.Name = "btnpotencia";
            this.btnpotencia.Size = new System.Drawing.Size(45, 45);
            this.btnpotencia.TabIndex = 15;
            this.btnpotencia.Tag = "²";
            this.btnpotencia.Text = "x²";
            this.btnpotencia.UseVisualStyleBackColor = true;
            this.btnpotencia.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(238, 183);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(45, 45);
            this.btnraiz.TabIndex = 14;
            this.btnraiz.Tag = "√";
            this.btnraiz.Text = "√";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Location = new System.Drawing.Point(308, 248);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(45, 45);
            this.btnmultiplicacion.TabIndex = 17;
            this.btnmultiplicacion.Tag = "X";
            this.btnmultiplicacion.Text = "X";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.clickOperador);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(238, 248);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(45, 45);
            this.btndivision.TabIndex = 16;
            this.btndivision.Tag = "/";
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(308, 317);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(45, 45);
            this.btnresta.TabIndex = 19;
            this.btnresta.Tag = "-";
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(238, 317);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(45, 45);
            this.btnsuma.TabIndex = 18;
            this.btnsuma.Tag = "+";
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(238, 378);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(115, 45);
            this.btnigual.TabIndex = 20;
            this.btnigual.Tag = "=";
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(156, 378);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(45, 45);
            this.btnpunto.TabIndex = 21;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btnmasomenos
            // 
            this.btnmasomenos.Location = new System.Drawing.Point(14, 378);
            this.btnmasomenos.Name = "btnmasomenos";
            this.btnmasomenos.Size = new System.Drawing.Size(45, 45);
            this.btnmasomenos.TabIndex = 22;
            this.btnmasomenos.Text = "+/-";
            this.btnmasomenos.UseVisualStyleBackColor = true;
            this.btnmasomenos.Click += new System.EventHandler(this.btnmasomenos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 469);
            this.Controls.Add(this.btnmasomenos);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnpotencia);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.Resultado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cal. by Dawil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Resultado;
        private Button btnuno;
        private Button btndos;
        private Button btntres;
        private Button btncuatro;
        private Button btncinco;
        private Button btnseis;
        private Button btnsiete;
        private Button btnocho;
        private Button btnnueve;
        private Button btnback;
        private Button btnborrartodo;
        private Button btnborrar;
        private Button btncero;
        private Button btnpotencia;
        private Button btnraiz;
        private Button btnmultiplicacion;
        private Button btndivision;
        private Button btnresta;
        private Button btnsuma;
        private Button btnigual;
        private Button btnpunto;
        private Button btnmasomenos;
    }
}