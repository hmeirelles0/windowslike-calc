namespace prjCalculadoraRadio
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnVirg = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdoCos = new System.Windows.Forms.RadioButton();
            this.rdoSen = new System.Windows.Forms.RadioButton();
            this.lblVisor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplay.Location = new System.Drawing.Point(19, 30);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(330, 38);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Wheat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(187, 427);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(78, 62);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(271, 427);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(78, 62);
            this.btnMais.TabIndex = 2;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(271, 359);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(78, 62);
            this.btnMenos.TabIndex = 3;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(271, 291);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(78, 62);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(271, 223);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(78, 62);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnVirg
            // 
            this.btnVirg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVirg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirg.Location = new System.Drawing.Point(271, 89);
            this.btnVirg.Name = "btnVirg";
            this.btnVirg.Size = new System.Drawing.Size(78, 62);
            this.btnVirg.TabIndex = 6;
            this.btnVirg.Text = ",";
            this.btnVirg.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(103, 427);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(78, 62);
            this.btnZero.TabIndex = 7;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMaisMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(19, 427);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(78, 62);
            this.btnMaisMenos.TabIndex = 8;
            this.btnMaisMenos.Text = "+ / -";
            this.btnMaisMenos.UseVisualStyleBackColor = false;
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(103, 359);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(78, 62);
            this.btnDois.TabIndex = 9;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(187, 359);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(78, 62);
            this.btnTres.TabIndex = 10;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.Location = new System.Drawing.Point(19, 359);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(78, 62);
            this.btnUm.TabIndex = 11;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.Location = new System.Drawing.Point(19, 291);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(78, 62);
            this.btnQuatro.TabIndex = 12;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(103, 291);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(78, 62);
            this.btnCinco.TabIndex = 13;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(187, 291);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(78, 62);
            this.btnSeis.TabIndex = 14;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.Location = new System.Drawing.Point(19, 223);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(78, 62);
            this.btnSete.TabIndex = 15;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.Location = new System.Drawing.Point(103, 223);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(78, 62);
            this.btnOito.TabIndex = 16;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.Location = new System.Drawing.Point(187, 223);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(78, 62);
            this.btnNove.TabIndex = 17;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(21, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 62);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdoCos
            // 
            this.rdoCos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdoCos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCos.Location = new System.Drawing.Point(271, 157);
            this.rdoCos.Name = "rdoCos";
            this.rdoCos.Size = new System.Drawing.Size(77, 62);
            this.rdoCos.TabIndex = 19;
            this.rdoCos.TabStop = true;
            this.rdoCos.Text = "Cos";
            this.rdoCos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoCos.UseVisualStyleBackColor = false;
            this.rdoCos.Click += new System.EventHandler(this.rdoCos_Click);
            // 
            // rdoSen
            // 
            this.rdoSen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdoSen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSen.Location = new System.Drawing.Point(21, 155);
            this.rdoSen.Name = "rdoSen";
            this.rdoSen.Size = new System.Drawing.Size(77, 62);
            this.rdoSen.TabIndex = 21;
            this.rdoSen.TabStop = true;
            this.rdoSen.Text = "Sen";
            this.rdoSen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSen.UseVisualStyleBackColor = false;
            this.rdoSen.Click += new System.EventHandler(this.rdoSen_Click);
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVisor.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.ForeColor = System.Drawing.Color.White;
            this.lblVisor.Location = new System.Drawing.Point(105, 153);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(160, 62);
            this.lblVisor.TabIndex = 23;
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(361, 501);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.rdoSen);
            this.Controls.Add(this.rdoCos);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnVirg);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnVirg;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdoCos;
        private System.Windows.Forms.RadioButton rdoSen;
        private System.Windows.Forms.Label lblVisor;
    }
}

