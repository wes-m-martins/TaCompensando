
namespace taCompensando
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVlrAbast = new System.Windows.Forms.TextBox();
            this.rdoConsumo = new System.Windows.Forms.RadioButton();
            this.rdoCombustivel = new System.Windows.Forms.RadioButton();
            this.txtConsGas = new System.Windows.Forms.TextBox();
            this.txtConsAlc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.lblAlcool = new System.Windows.Forms.Label();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.txtPosto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtVlrAbast);
            this.panel1.Controls.Add(this.rdoConsumo);
            this.panel1.Controls.Add(this.rdoCombustivel);
            this.panel1.Controls.Add(this.txtConsGas);
            this.panel1.Controls.Add(this.txtConsAlc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblGasolina);
            this.panel1.Controls.Add(this.lblAlcool);
            this.panel1.Controls.Add(this.txtGasolina);
            this.panel1.Controls.Add(this.txtAlcool);
            this.panel1.Controls.Add(this.txtPosto);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 235);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quanto vai R$?:";
            // 
            // txtVlrAbast
            // 
            this.txtVlrAbast.Location = new System.Drawing.Point(315, 10);
            this.txtVlrAbast.Name = "txtVlrAbast";
            this.txtVlrAbast.Size = new System.Drawing.Size(62, 23);
            this.txtVlrAbast.TabIndex = 15;
            // 
            // rdoConsumo
            // 
            this.rdoConsumo.AutoSize = true;
            this.rdoConsumo.Location = new System.Drawing.Point(208, 115);
            this.rdoConsumo.Name = "rdoConsumo";
            this.rdoConsumo.Size = new System.Drawing.Size(144, 19);
            this.rdoConsumo.TabIndex = 14;
            this.rdoConsumo.TabStop = true;
            this.rdoConsumo.Text = "Calcular por Consumo";
            this.rdoConsumo.UseVisualStyleBackColor = true;
            // 
            // rdoCombustivel
            // 
            this.rdoCombustivel.AutoSize = true;
            this.rdoCombustivel.Location = new System.Drawing.Point(27, 115);
            this.rdoCombustivel.Name = "rdoCombustivel";
            this.rdoCombustivel.Size = new System.Drawing.Size(159, 19);
            this.rdoCombustivel.TabIndex = 13;
            this.rdoCombustivel.TabStop = true;
            this.rdoCombustivel.Text = "Calcular por Combustível";
            this.rdoCombustivel.UseVisualStyleBackColor = true;
            // 
            // txtConsGas
            // 
            this.txtConsGas.Location = new System.Drawing.Point(315, 67);
            this.txtConsGas.Name = "txtConsGas";
            this.txtConsGas.Size = new System.Drawing.Size(61, 23);
            this.txtConsGas.TabIndex = 12;
            // 
            // txtConsAlc
            // 
            this.txtConsAlc.Location = new System.Drawing.Point(315, 39);
            this.txtConsAlc.Name = "txtConsAlc";
            this.txtConsAlc.Size = new System.Drawing.Size(62, 23);
            this.txtConsAlc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Consumo Gasolina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Consumo Álcool:";
            // 
            // lblGasolina
            // 
            this.lblGasolina.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGasolina.Location = new System.Drawing.Point(153, 169);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(261, 31);
            this.lblGasolina.TabIndex = 8;
            this.lblGasolina.Text = "Tá Compensando:   Gasolina";
            this.lblGasolina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGasolina.Visible = false;
            this.lblGasolina.Leave += new System.EventHandler(this.lblGasolina_Leave);
            // 
            // lblAlcool
            // 
            this.lblAlcool.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlcool.Location = new System.Drawing.Point(139, 174);
            this.lblAlcool.Name = "lblAlcool";
            this.lblAlcool.Size = new System.Drawing.Size(233, 31);
            this.lblAlcool.TabIndex = 7;
            this.lblAlcool.Text = "Tá Compensando:   Álcool";
            this.lblAlcool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlcool.Visible = false;
            this.lblAlcool.Leave += new System.EventHandler(this.lblAlcool_Leave);
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(112, 70);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(70, 23);
            this.txtGasolina.TabIndex = 6;
            // 
            // txtAlcool
            // 
            this.txtAlcool.Location = new System.Drawing.Point(112, 41);
            this.txtAlcool.Name = "txtAlcool";
            this.txtAlcool.Size = new System.Drawing.Size(70, 23);
            this.txtAlcool.TabIndex = 5;
            // 
            // txtPosto
            // 
            this.txtPosto.Location = new System.Drawing.Point(69, 10);
            this.txtPosto.Name = "txtPosto";
            this.txtPosto.Size = new System.Drawing.Size(135, 23);
            this.txtPosto.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(23, 163);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 42);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Gasolina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Álcool:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posto:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 277);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Ta Compensando...";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAlcool;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.TextBox txtAlcool;
        private System.Windows.Forms.TextBox txtPosto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.RadioButton rdoConsumo;
        private System.Windows.Forms.RadioButton rdoCombustivel;
        private System.Windows.Forms.TextBox txtConsGas;
        private System.Windows.Forms.TextBox txtConsAlc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVlrAbast;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}