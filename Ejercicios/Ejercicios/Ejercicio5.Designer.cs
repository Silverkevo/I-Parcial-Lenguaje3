namespace Ejercicios
{
    partial class Ejercicio5
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
            this.HornearPizzaButton = new System.Windows.Forms.Button();
            this.HornearPizzaAsinButon = new System.Windows.Forms.Button();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2Textbox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HornearPizzaButton
            // 
            this.HornearPizzaButton.Location = new System.Drawing.Point(53, 49);
            this.HornearPizzaButton.Name = "HornearPizzaButton";
            this.HornearPizzaButton.Size = new System.Drawing.Size(108, 23);
            this.HornearPizzaButton.TabIndex = 0;
            this.HornearPizzaButton.Text = "Hornear Pizza";
            this.HornearPizzaButton.UseVisualStyleBackColor = true;
            this.HornearPizzaButton.Click += new System.EventHandler(this.HornearPizzaButton_Click);
            // 
            // HornearPizzaAsinButon
            // 
            this.HornearPizzaAsinButon.Location = new System.Drawing.Point(312, 49);
            this.HornearPizzaAsinButon.Name = "HornearPizzaAsinButon";
            this.HornearPizzaAsinButon.Size = new System.Drawing.Size(188, 23);
            this.HornearPizzaAsinButon.TabIndex = 1;
            this.HornearPizzaAsinButon.Text = "Hornear Pizza Asincrono";
            this.HornearPizzaAsinButon.UseVisualStyleBackColor = true;
            this.HornearPizzaAsinButon.Click += new System.EventHandler(this.HornearPizzaAsinButon_Click);
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(161, 176);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Numero1TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2";
            // 
            // Numero2Textbox
            // 
            this.Numero2Textbox.Location = new System.Drawing.Point(161, 231);
            this.Numero2Textbox.Name = "Numero2Textbox";
            this.Numero2Textbox.Size = new System.Drawing.Size(100, 22);
            this.Numero2Textbox.TabIndex = 4;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(348, 176);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero2Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.HornearPizzaAsinButon);
            this.Controls.Add(this.HornearPizzaButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearPizzaButton;
        private System.Windows.Forms.Button HornearPizzaAsinButon;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2Textbox;
        private System.Windows.Forms.Button CalcularButton;
    }
}