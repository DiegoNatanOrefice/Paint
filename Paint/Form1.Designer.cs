namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCor = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dropper = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.paint_bucket = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCor);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.dropper);
            this.panel1.Controls.Add(this.eraser);
            this.panel1.Controls.Add(this.paint_bucket);
            this.panel1.Controls.Add(this.pencil);
            this.panel1.Controls.Add(this.brush);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 180);
            this.panel1.TabIndex = 0;
            // 
            // btnCor
            // 
            this.btnCor.BackColor = System.Drawing.Color.Black;
            this.btnCor.FlatAppearance.BorderSize = 0;
            this.btnCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCor.Location = new System.Drawing.Point(27, 45);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(90, 90);
            this.btnCor.TabIndex = 7;
            this.btnCor.UseVisualStyleBackColor = false;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(1803, 95);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(1803, 45);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dropper
            // 
            this.dropper.BackColor = System.Drawing.Color.Transparent;
            this.dropper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropper.BackgroundImage")));
            this.dropper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dropper.FlatAppearance.BorderSize = 0;
            this.dropper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropper.Location = new System.Drawing.Point(1507, 45);
            this.dropper.Name = "dropper";
            this.dropper.Size = new System.Drawing.Size(90, 90);
            this.dropper.TabIndex = 4;
            this.dropper.UseVisualStyleBackColor = false;
            this.dropper.Click += new System.EventHandler(this.dropper_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.Transparent;
            this.eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraser.BackgroundImage")));
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraser.FlatAppearance.BorderSize = 0;
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser.Location = new System.Drawing.Point(1211, 45);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(90, 90);
            this.eraser.TabIndex = 3;
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // paint_bucket
            // 
            this.paint_bucket.BackColor = System.Drawing.Color.Transparent;
            this.paint_bucket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paint_bucket.BackgroundImage")));
            this.paint_bucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paint_bucket.FlatAppearance.BorderSize = 0;
            this.paint_bucket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paint_bucket.Location = new System.Drawing.Point(915, 45);
            this.paint_bucket.Name = "paint_bucket";
            this.paint_bucket.Size = new System.Drawing.Size(90, 90);
            this.paint_bucket.TabIndex = 2;
            this.paint_bucket.UseVisualStyleBackColor = false;
            this.paint_bucket.Click += new System.EventHandler(this.paint_bucket_Click);
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.Transparent;
            this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pencil.FlatAppearance.BorderSize = 0;
            this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil.Location = new System.Drawing.Point(619, 45);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(90, 90);
            this.pencil.TabIndex = 1;
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // brush
            // 
            this.brush.BackColor = System.Drawing.Color.Transparent;
            this.brush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brush.BackgroundImage")));
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brush.FlatAppearance.BorderSize = 0;
            this.brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brush.Location = new System.Drawing.Point(323, 45);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(90, 90);
            this.brush.TabIndex = 0;
            this.brush.UseVisualStyleBackColor = false;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(0, 225);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1920, 855);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btnFullScreen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 45);
            this.panel2.TabIndex = 8;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.White;
            this.btnFullScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.BackgroundImage")));
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Location = new System.Drawing.Point(1858, 5);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(35, 35);
            this.btnFullScreen.TabIndex = 1;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feito com 🖤 por Diego Natan Orefice :D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button dropper;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button paint_bucket;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFullScreen;
    }
}