namespace Github_csharp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_somar = new System.Windows.Forms.Button();
            this.lbl_alg = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_sub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBox1.Location = new System.Drawing.Point(212, 31);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(124, 37);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBox2.Location = new System.Drawing.Point(37, 31);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(124, 37);
            this.txtBox2.TabIndex = 0;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(37, 332);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(141, 48);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_limpar.Location = new System.Drawing.Point(37, 170);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(141, 48);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "c";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_somar
            // 
            this.btn_somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_somar.Location = new System.Drawing.Point(195, 170);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(141, 48);
            this.btn_somar.TabIndex = 1;
            this.btn_somar.Text = "+";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_alg
            // 
            this.lbl_alg.AutoSize = true;
            this.lbl_alg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_alg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_alg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_alg.Location = new System.Drawing.Point(176, 29);
            this.lbl_alg.Name = "lbl_alg";
            this.lbl_alg.Size = new System.Drawing.Size(2, 39);
            this.lbl_alg.TabIndex = 2;
            this.lbl_alg.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_res.Location = new System.Drawing.Point(37, 98);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(299, 49);
            this.lbl_res.TabIndex = 3;
            this.lbl_res.Text = "0";
            this.lbl_res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_res.Click += new System.EventHandler(this.lbl_res_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_sub.ForeColor = System.Drawing.Color.Black;
            this.btn_sub.Location = new System.Drawing.Point(195, 224);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(141, 48);
            this.btn_sub.TabIndex = 4;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(195, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(195, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Location = new System.Drawing.Point(37, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "</>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "&Par Ímpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus-icon-plus-svg-png-icon-download-1.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(378, 422);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_alg);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Label lbl_alg;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
    }
}

