namespace BraccioReverseEngineering
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVelocità = new System.Windows.Forms.TextBox();
            this.lblVelocità = new System.Windows.Forms.Label();
            this.btn1Open = new System.Windows.Forms.Button();
            this.btn1Close = new System.Windows.Forms.Button();
            this.btn2Down = new System.Windows.Forms.Button();
            this.btn2Up = new System.Windows.Forms.Button();
            this.btn3Down = new System.Windows.Forms.Button();
            this.btn3Up = new System.Windows.Forms.Button();
            this.btn4Down = new System.Windows.Forms.Button();
            this.btn4Up = new System.Windows.Forms.Button();
            this.btn5Left = new System.Windows.Forms.Button();
            this.btn5Right = new System.Windows.Forms.Button();
            this.rTxtConsole = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVelocità
            // 
            this.txtVelocità.Location = new System.Drawing.Point(269, 142);
            this.txtVelocità.Multiline = true;
            this.txtVelocità.Name = "txtVelocità";
            this.txtVelocità.Size = new System.Drawing.Size(115, 27);
            this.txtVelocità.TabIndex = 5;
            this.txtVelocità.Text = "1";
            // 
            // lblVelocità
            // 
            this.lblVelocità.AutoSize = true;
            this.lblVelocità.Location = new System.Drawing.Point(284, 126);
            this.lblVelocità.Name = "lblVelocità";
            this.lblVelocità.Size = new System.Drawing.Size(81, 13);
            this.lblVelocità.TabIndex = 6;
            this.lblVelocità.Text = "Velocità (0-100)";
            // 
            // btn1Open
            // 
            this.btn1Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Open.Location = new System.Drawing.Point(69, 116);
            this.btn1Open.Name = "btn1Open";
            this.btn1Open.Size = new System.Drawing.Size(75, 23);
            this.btn1Open.TabIndex = 13;
            this.btn1Open.Text = "<>";
            this.btn1Open.UseVisualStyleBackColor = true;
            this.btn1Open.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1Open_MouseDown);
            this.btn1Open.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn1Close
            // 
            this.btn1Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Close.Location = new System.Drawing.Point(150, 116);
            this.btn1Close.Name = "btn1Close";
            this.btn1Close.Size = new System.Drawing.Size(75, 23);
            this.btn1Close.TabIndex = 12;
            this.btn1Close.Text = "><";
            this.btn1Close.UseVisualStyleBackColor = true;
            this.btn1Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1Close_MouseDown);
            this.btn1Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn2Down
            // 
            this.btn2Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Down.Location = new System.Drawing.Point(29, 58);
            this.btn2Down.Name = "btn2Down";
            this.btn2Down.Size = new System.Drawing.Size(75, 23);
            this.btn2Down.TabIndex = 15;
            this.btn2Down.Text = "V";
            this.btn2Down.UseVisualStyleBackColor = true;
            this.btn2Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn2Down_MouseDown);
            this.btn2Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn2Up
            // 
            this.btn2Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Up.Location = new System.Drawing.Point(29, 29);
            this.btn2Up.Name = "btn2Up";
            this.btn2Up.Size = new System.Drawing.Size(75, 23);
            this.btn2Up.TabIndex = 14;
            this.btn2Up.Text = "^";
            this.btn2Up.UseVisualStyleBackColor = true;
            this.btn2Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn2Up_MouseDown);
            this.btn2Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn3Down
            // 
            this.btn3Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Down.Location = new System.Drawing.Point(110, 58);
            this.btn3Down.Name = "btn3Down";
            this.btn3Down.Size = new System.Drawing.Size(75, 23);
            this.btn3Down.TabIndex = 17;
            this.btn3Down.Text = "V";
            this.btn3Down.UseVisualStyleBackColor = true;
            this.btn3Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn3Down_MouseDown);
            this.btn3Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn3Up
            // 
            this.btn3Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Up.Location = new System.Drawing.Point(110, 29);
            this.btn3Up.Name = "btn3Up";
            this.btn3Up.Size = new System.Drawing.Size(75, 23);
            this.btn3Up.TabIndex = 16;
            this.btn3Up.Text = "^";
            this.btn3Up.UseVisualStyleBackColor = true;
            this.btn3Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn3Up_MouseDown);
            this.btn3Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn4Down
            // 
            this.btn4Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Down.Location = new System.Drawing.Point(191, 58);
            this.btn4Down.Name = "btn4Down";
            this.btn4Down.Size = new System.Drawing.Size(75, 23);
            this.btn4Down.TabIndex = 19;
            this.btn4Down.Text = "V";
            this.btn4Down.UseVisualStyleBackColor = true;
            this.btn4Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn4Down_MouseDown);
            this.btn4Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn4Up
            // 
            this.btn4Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Up.Location = new System.Drawing.Point(191, 29);
            this.btn4Up.Name = "btn4Up";
            this.btn4Up.Size = new System.Drawing.Size(75, 23);
            this.btn4Up.TabIndex = 18;
            this.btn4Up.Text = "^";
            this.btn4Up.UseVisualStyleBackColor = true;
            this.btn4Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn4Up_MouseDown);
            this.btn4Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn5Left
            // 
            this.btn5Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Left.Location = new System.Drawing.Point(69, 87);
            this.btn5Left.Name = "btn5Left";
            this.btn5Left.Size = new System.Drawing.Size(75, 23);
            this.btn5Left.TabIndex = 21;
            this.btn5Left.Text = "<";
            this.btn5Left.UseVisualStyleBackColor = true;
            this.btn5Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn5Left_MouseDown);
            this.btn5Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // btn5Right
            // 
            this.btn5Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Right.Location = new System.Drawing.Point(150, 87);
            this.btn5Right.Name = "btn5Right";
            this.btn5Right.Size = new System.Drawing.Size(75, 23);
            this.btn5Right.TabIndex = 20;
            this.btn5Right.Text = ">";
            this.btn5Right.UseVisualStyleBackColor = true;
            this.btn5Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn5Right_MouseDown);
            this.btn5Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventStop);
            // 
            // rTxtConsole
            // 
            this.rTxtConsole.Location = new System.Drawing.Point(23, 202);
            this.rTxtConsole.Name = "rTxtConsole";
            this.rTxtConsole.ReadOnly = true;
            this.rTxtConsole.Size = new System.Drawing.Size(359, 142);
            this.rTxtConsole.TabIndex = 12;
            this.rTxtConsole.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Console";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "E";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 354);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2Down);
            this.Controls.Add(this.btn3Down);
            this.Controls.Add(this.btn2Up);
            this.Controls.Add(this.btn4Up);
            this.Controls.Add(this.btn3Up);
            this.Controls.Add(this.btn4Down);
            this.Controls.Add(this.btn5Left);
            this.Controls.Add(this.btn1Open);
            this.Controls.Add(this.btn5Right);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtConsole);
            this.Controls.Add(this.lblVelocità);
            this.Controls.Add(this.txtVelocità);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVelocità;
        private System.Windows.Forms.Label lblVelocità;
        private System.Windows.Forms.Button btn1Open;
        private System.Windows.Forms.Button btn1Close;
        private System.Windows.Forms.Button btn2Down;
        private System.Windows.Forms.Button btn2Up;
        private System.Windows.Forms.Button btn3Down;
        private System.Windows.Forms.Button btn3Up;
        private System.Windows.Forms.Button btn4Down;
        private System.Windows.Forms.Button btn4Up;
        private System.Windows.Forms.Button btn5Left;
        private System.Windows.Forms.Button btn5Right;
        private System.Windows.Forms.RichTextBox rTxtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

