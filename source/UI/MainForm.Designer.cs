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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elitismPercentage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.elitismOptions = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elitismPercentage)).BeginInit();
            this.elitismOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(199, 274);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(112, 23);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar algoritmo";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores Genéticos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // mutationComboBox
            // 
            this.mutationComboBox.DisplayMember = "Name";
            this.mutationComboBox.FormattingEnabled = true;
            this.mutationComboBox.Location = new System.Drawing.Point(40, 23);
            this.mutationComboBox.Name = "mutationComboBox";
            this.mutationComboBox.Size = new System.Drawing.Size(435, 21);
            this.mutationComboBox.TabIndex = 4;
            this.mutationComboBox.ValueMember = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // crossComboBox
            // 
            this.crossComboBox.DisplayMember = "Name";
            this.crossComboBox.FormattingEnabled = true;
            this.crossComboBox.Location = new System.Drawing.Point(40, 19);
            this.crossComboBox.Name = "crossComboBox";
            this.crossComboBox.Size = new System.Drawing.Size(435, 21);
            this.crossComboBox.TabIndex = 2;
            this.crossComboBox.ValueMember = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.DisplayMember = "Name";
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.Location = new System.Drawing.Point(40, 19);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(435, 21);
            this.selectionComboBox.TabIndex = 0;
            this.selectionComboBox.ValueMember = "null";
            this.selectionComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionOperatorChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.elitismOptions);
            this.groupBox2.Controls.Add(this.selectionComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 77);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Porcentaje de elitismo:";
            // 
            // elitismPercentage
            // 
            this.elitismPercentage.Location = new System.Drawing.Point(122, 4);
            this.elitismPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elitismPercentage.Name = "elitismPercentage";
            this.elitismPercentage.Size = new System.Drawing.Size(54, 20);
            this.elitismPercentage.TabIndex = 4;
            this.elitismPercentage.Tag = "";
            this.elitismPercentage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.elitismPercentage.ValueChanged += new System.EventHandler(this.ElitismOptionsChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "%";
            // 
            // elitismOptions
            // 
            this.elitismOptions.Controls.Add(this.label5);
            this.elitismOptions.Controls.Add(this.label4);
            this.elitismOptions.Controls.Add(this.elitismPercentage);
            this.elitismOptions.Location = new System.Drawing.Point(6, 46);
            this.elitismOptions.Name = "elitismOptions";
            this.elitismOptions.Size = new System.Drawing.Size(206, 25);
            this.elitismOptions.TabIndex = 7;
            this.elitismOptions.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.crossComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(16, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cruza";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mutationComboBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(16, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 58);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mutación";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Iniciar);
            this.Name = "MainForm";
            this.Text = "Implementación de Algoritmo Genético";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elitismPercentage)).EndInit();
            this.elitismOptions.ResumeLayout(false);
            this.elitismOptions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown elitismPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel elitismOptions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

