
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.lblAlcool = new System.Windows.Forms.Label();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.txtPosto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsAlc = new System.Windows.Forms.TextBox();
            this.tctConsGas = new System.Windows.Forms.TextBox();
            this.rdoCombustivel = new System.Windows.Forms.RadioButton();
            this.rdoConsumo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rdoConsumo);
            this.panel1.Controls.Add(this.rdoCombustivel);
            this.panel1.Controls.Add(this.tctConsGas);
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
            // lblGasolina
            // 
            this.lblGasolina.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGasolina.Location = new System.Drawing.Point(116, 174);
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
            this.txtPosto.Size = new System.Drawing.Size(308, 23);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(64, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 115);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 100);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Posto A";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Posto B";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(346, 72);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posto C";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Consumo Gasolina:";
            // 
            // txtConsAlc
            // 
            this.txtConsAlc.Location = new System.Drawing.Point(315, 39);
            this.txtConsAlc.Name = "txtConsAlc";
            this.txtConsAlc.Size = new System.Drawing.Size(62, 23);
            this.txtConsAlc.TabIndex = 11;
            // 
            // tctConsGas
            // 
            this.tctConsGas.Location = new System.Drawing.Point(315, 67);
            this.tctConsGas.Name = "tctConsGas";
            this.tctConsGas.Size = new System.Drawing.Size(61, 23);
            this.tctConsGas.TabIndex = 12;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Ta Compensando...";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rdoConsumo;
        private System.Windows.Forms.RadioButton rdoCombustivel;
        private System.Windows.Forms.TextBox tctConsGas;
        private System.Windows.Forms.TextBox txtConsAlc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}