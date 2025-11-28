namespace serie6_sol_kms
{
    partial class FrmEx1
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
            lblAnimal = new Label();
            btnNewName = new Button();
            txtNewName = new TextBox();
            SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Location = new Point(240, 315);
            lblAnimal.Margin = new Padding(4, 0, 4, 0);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(59, 25);
            lblAnimal.TabIndex = 5;
            lblAnimal.Text = "label1";
            // 
            // btnNewName
            // 
            btnNewName.Location = new Point(240, 196);
            btnNewName.Margin = new Padding(4);
            btnNewName.Name = "btnNewName";
            btnNewName.Size = new Size(320, 64);
            btnNewName.TabIndex = 4;
            btnNewName.Text = "Renommer";
            btnNewName.UseVisualStyleBackColor = true;
            btnNewName.Click += new EventHandler(btnNewName_Click);
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(240, 114);
            txtNewName.Margin = new Padding(4);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(319, 31);
            txtNewName.TabIndex = 3;
            // 
            // frmEx1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAnimal);
            Controls.Add(btnNewName);
            Controls.Add(txtNewName);
            Name = "frmEx1";
            Text = "S6 - Exercice 1 - un Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimal;
        private Button btnNewName;
        private TextBox txtNewName;
    }
}