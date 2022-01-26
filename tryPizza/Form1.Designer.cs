
namespace tryPizza
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
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.glutenTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(553, 318);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 54);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(542, 163);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(184, 22);
            this.idTB.TabIndex = 2;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(542, 211);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(184, 22);
            this.nameTB.TabIndex = 3;
            // 
            // glutenTB
            // 
            this.glutenTB.Location = new System.Drawing.Point(542, 257);
            this.glutenTB.Name = "glutenTB";
            this.glutenTB.Size = new System.Drawing.Size(184, 22);
            this.glutenTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gluten Free:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glutenTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox glutenTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

