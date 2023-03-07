namespace calculadora
{
    partial class Form1
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
            this.btn_ponto = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_somar = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_porcentagem = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_sete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.show_operations = new System.Windows.Forms.Label();
            this.show_results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ponto
            // 
            this.btn_ponto.BackColor = System.Drawing.Color.White;
            this.btn_ponto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ponto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ponto.Location = new System.Drawing.Point(209, 433);
            this.btn_ponto.Name = "btn_ponto";
            this.btn_ponto.Size = new System.Drawing.Size(54, 35);
            this.btn_ponto.TabIndex = 53;
            this.btn_ponto.Text = ",";
            this.btn_ponto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ponto.UseVisualStyleBackColor = false;
            this.btn_ponto.Click += new System.EventHandler(this.btn_ponto_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.Color.White;
            this.btn_igual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_igual.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.Location = new System.Drawing.Point(302, 390);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(54, 78);
            this.btn_igual.TabIndex = 52;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_somar
            // 
            this.btn_somar.BackColor = System.Drawing.Color.White;
            this.btn_somar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_somar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_somar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_somar.Location = new System.Drawing.Point(302, 332);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(54, 33);
            this.btn_somar.TabIndex = 51;
            this.btn_somar.Text = "+";
            this.btn_somar.UseVisualStyleBackColor = false;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.BackColor = System.Drawing.Color.White;
            this.btn_subtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_subtrair.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtrair.Location = new System.Drawing.Point(302, 266);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(54, 33);
            this.btn_subtrair.TabIndex = 50;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_subtrair.UseVisualStyleBackColor = false;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.BackColor = System.Drawing.Color.White;
            this.btn_multiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_multiplicar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(302, 206);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(54, 33);
            this.btn_multiplicar.TabIndex = 49;
            this.btn_multiplicar.Text = "x";
            this.btn_multiplicar.UseVisualStyleBackColor = false;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.BackColor = System.Drawing.Color.White;
            this.btn_dividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dividir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(302, 145);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(54, 33);
            this.btn_dividir.TabIndex = 48;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = false;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.White;
            this.btn_zero.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.Location = new System.Drawing.Point(116, 433);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(54, 55);
            this.btn_zero.TabIndex = 47;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.BackColor = System.Drawing.Color.White;
            this.btn_tres.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tres.Location = new System.Drawing.Point(209, 358);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(54, 55);
            this.btn_tres.TabIndex = 46;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = false;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.BackColor = System.Drawing.Color.White;
            this.btn_seis.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seis.Location = new System.Drawing.Point(209, 275);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(54, 55);
            this.btn_seis.TabIndex = 45;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = false;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.BackColor = System.Drawing.Color.White;
            this.btn_nove.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nove.Location = new System.Drawing.Point(209, 195);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(54, 55);
            this.btn_nove.TabIndex = 44;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = false;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.BackColor = System.Drawing.Color.White;
            this.btn_dois.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dois.Location = new System.Drawing.Point(116, 358);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(54, 55);
            this.btn_dois.TabIndex = 43;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = false;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.BackColor = System.Drawing.Color.White;
            this.btn_cinco.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinco.Location = new System.Drawing.Point(116, 275);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(54, 55);
            this.btn_cinco.TabIndex = 42;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = false;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.BackColor = System.Drawing.Color.White;
            this.btn_oito.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oito.Location = new System.Drawing.Point(116, 195);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(54, 55);
            this.btn_oito.TabIndex = 41;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = false;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_um
            // 
            this.btn_um.BackColor = System.Drawing.Color.White;
            this.btn_um.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_um.Location = new System.Drawing.Point(23, 358);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(54, 55);
            this.btn_um.TabIndex = 40;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = false;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.BackColor = System.Drawing.Color.White;
            this.btn_quatro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quatro.Location = new System.Drawing.Point(23, 275);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(54, 55);
            this.btn_quatro.TabIndex = 39;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = false;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_porcentagem
            // 
            this.btn_porcentagem.BackColor = System.Drawing.Color.White;
            this.btn_porcentagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_porcentagem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_porcentagem.Location = new System.Drawing.Point(209, 145);
            this.btn_porcentagem.Name = "btn_porcentagem";
            this.btn_porcentagem.Size = new System.Drawing.Size(54, 33);
            this.btn_porcentagem.TabIndex = 38;
            this.btn_porcentagem.Text = "%";
            this.btn_porcentagem.UseVisualStyleBackColor = false;
            this.btn_porcentagem.Click += new System.EventHandler(this.btn_porcentagem_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.BackColor = System.Drawing.Color.White;
            this.btn_backspace.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backspace.Location = new System.Drawing.Point(116, 145);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(54, 33);
            this.btn_backspace.TabIndex = 37;
            this.btn_backspace.Text = "CE";
            this.btn_backspace.UseVisualStyleBackColor = false;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_sete
            // 
            this.btn_sete.BackColor = System.Drawing.Color.White;
            this.btn_sete.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sete.Location = new System.Drawing.Point(23, 195);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(54, 55);
            this.btn_sete.TabIndex = 36;
            this.btn_sete.Text = "7";
            this.btn_sete.UseVisualStyleBackColor = false;
            this.btn_sete.Click += new System.EventHandler(this.btn_sete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(23, 145);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(54, 33);
            this.btn_clear.TabIndex = 35;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Calculadora";
            // 
            // show_operations
            // 
            this.show_operations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_operations.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_operations.Location = new System.Drawing.Point(20, 48);
            this.show_operations.Margin = new System.Windows.Forms.Padding(1);
            this.show_operations.Name = "show_operations";
            this.show_operations.Size = new System.Drawing.Size(336, 85);
            this.show_operations.TabIndex = 55;
            this.show_operations.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.show_operations.Click += new System.EventHandler(this.show_operations_Click);
            // 
            // show_results
            // 
            this.show_results.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_results.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_results.Location = new System.Drawing.Point(23, 48);
            this.show_results.Name = "show_results";
            this.show_results.Size = new System.Drawing.Size(333, 34);
            this.show_results.TabIndex = 56;
            this.show_results.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.show_results.Click += new System.EventHandler(this.show_results_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(386, 500);
            this.Controls.Add(this.show_results);
            this.Controls.Add(this.show_operations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ponto);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_porcentagem);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.btn_clear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ponto;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_nove;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_porcentagem;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_sete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label show_operations;
        private System.Windows.Forms.Label show_results;
        private System.Windows.Forms.Button btn_somar;
    }
}

