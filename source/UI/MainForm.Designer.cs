namespace UI
{
    partial class MainForm
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mutationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crossComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(206, 190);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(112, 23);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar algoritmo";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mutationComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.crossComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectionComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores Genéticos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mutación";
            // 
            // mutationComboBox
            // 
            this.mutationComboBox.FormattingEnabled = true;
            this.mutationComboBox.Items.AddRange(new object[] {
            "Simple",
            "Adaptativa por Convergencia",
            "Adaptativa por Temperatura - Descendente",
            "Adaptativa por Temperatura - Ascendente"});
            this.mutationComboBox.Location = new System.Drawing.Point(73, 110);
            this.mutationComboBox.Name = "mutationComboBox";
            this.mutationComboBox.Size = new System.Drawing.Size(436, 21);
            this.mutationComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cruza";
            // 
            // crossComboBox
            // 
            this.crossComboBox.FormattingEnabled = true;
            this.crossComboBox.Items.AddRange(new object[] {
            "Simple",
            "Multipunto",
            "Binomial - Máscara complemento",
            "Binomial - Máscara doble",
            "Binomial - Al azar"});
            this.crossComboBox.Location = new System.Drawing.Point(73, 72);
            this.crossComboBox.Name = "crossComboBox";
            this.crossComboBox.Size = new System.Drawing.Size(436, 21);
            this.crossComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selección";
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.Items.AddRange(new object[] {
            "Torneo (Elitismo)",
            "Ranking",
            "Ruleta",
            "Control sobre número esperado"});
            this.selectionComboBox.Location = new System.Drawing.Point(73, 36);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(436, 21);
            this.selectionComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Iniciar);
            this.Name = "MainForm";
            this.Text = "Implementación de Algoritmo Genético";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mutationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox crossComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectionComboBox;
    }
}

