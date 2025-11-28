namespace serie6_sol_kms
{
    partial class FrmEx2
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
            lblWouf = new Label();
            groupBox2 = new GroupBox();
            lblPoids = new Label();
            btnAboyer = new Button();
            lblTaille = new Label();
            lblNom = new Label();
            groupBox1 = new GroupBox();
            numPoids = new NumericUpDown();
            label2 = new Label();
            numTaille = new NumericUpDown();
            label3 = new Label();
            btnCreer = new Button();
            txtNom = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPoids).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTaille).BeginInit();
            SuspendLayout();
            // 
            // lblWouf
            // 
            lblWouf.AutoSize = true;
            lblWouf.Location = new Point(23, 288);
            lblWouf.Margin = new Padding(4, 0, 4, 0);
            lblWouf.Name = "lblWouf";
            lblWouf.Size = new Size(59, 25);
            lblWouf.TabIndex = 5;
            lblWouf.Text = "label2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblWouf);
            groupBox2.Controls.Add(lblPoids);
            groupBox2.Controls.Add(btnAboyer);
            groupBox2.Controls.Add(lblTaille);
            groupBox2.Controls.Add(lblNom);
            groupBox2.Location = new Point(470, 102);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(358, 346);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chien présent dans le programme";
            // 
            // lblPoids
            // 
            lblPoids.AutoSize = true;
            lblPoids.Location = new Point(23, 101);
            lblPoids.Margin = new Padding(4, 0, 4, 0);
            lblPoids.Name = "lblPoids";
            lblPoids.Size = new Size(55, 25);
            lblPoids.TabIndex = 3;
            lblPoids.Text = "Poids";
            // 
            // btnAboyer
            // 
            btnAboyer.Location = new Point(23, 214);
            btnAboyer.Margin = new Padding(4);
            btnAboyer.Name = "btnAboyer";
            btnAboyer.Size = new Size(294, 42);
            btnAboyer.TabIndex = 2;
            btnAboyer.Text = "Aboyer";
            btnAboyer.UseVisualStyleBackColor = true;
            btnAboyer.Click += btnAboyer_Click;
            // 
            // lblTaille
            // 
            lblTaille.AutoSize = true;
            lblTaille.Location = new Point(23, 156);
            lblTaille.Margin = new Padding(4, 0, 4, 0);
            lblTaille.Name = "lblTaille";
            lblTaille.Size = new Size(49, 25);
            lblTaille.TabIndex = 1;
            lblTaille.Text = "Taille";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(23, 37);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 25);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numPoids);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numTaille);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCreer);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(71, 102);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(341, 346);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Créer un nouveau chien";
            // 
            // numPoids
            // 
            numPoids.Location = new Point(119, 95);
            numPoids.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPoids.Name = "numPoids";
            numPoids.Size = new Size(185, 31);
            numPoids.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 5;
            label2.Text = "Poids";
            // 
            // numTaille
            // 
            numTaille.Location = new Point(119, 150);
            numTaille.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTaille.Name = "numTaille";
            numTaille.Size = new Size(185, 31);
            numTaille.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 3;
            label3.Text = "Taille";
            // 
            // btnCreer
            // 
            btnCreer.Location = new Point(36, 214);
            btnCreer.Margin = new Padding(4);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(268, 42);
            btnCreer.TabIndex = 2;
            btnCreer.Text = "Créer";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(119, 37);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(185, 31);
            txtNom.TabIndex = 1;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // FrmEx2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 568);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmEx2";
            Text = "Série 6 - Exercice 2 :  un Chien";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPoids).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTaille).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWouf;
        private GroupBox groupBox2;
        private Button btnAboyer;
        private Label lblTaille;
        private Label lblNom;
        private GroupBox groupBox1;
        private Button btnCreer;
        private TextBox txtNom;
        private Label label1;
        private NumericUpDown numTaille;
        private Label label3;
        private Label lblPoids;
        private NumericUpDown numPoids;
        private Label label2;
    }
}