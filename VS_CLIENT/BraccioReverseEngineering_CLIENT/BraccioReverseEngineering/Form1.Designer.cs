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
            this.grpMotor1 = new System.Windows.Forms.GroupBox();
            this.btn1Open = new System.Windows.Forms.Button();
            this.btn1Close = new System.Windows.Forms.Button();
            this.grpMotor2 = new System.Windows.Forms.GroupBox();
            this.btn2Down = new System.Windows.Forms.Button();
            this.btn2Up = new System.Windows.Forms.Button();
            this.grpMotor3 = new System.Windows.Forms.GroupBox();
            this.grpMotor4 = new System.Windows.Forms.GroupBox();
            this.grpMotor5 = new System.Windows.Forms.GroupBox();
            this.btn3Down = new System.Windows.Forms.Button();
            this.btn3Up = new System.Windows.Forms.Button();
            this.btn4Down = new System.Windows.Forms.Button();
            this.btn4Up = new System.Windows.Forms.Button();
            this.btn5Left = new System.Windows.Forms.Button();
            this.btn5Right = new System.Windows.Forms.Button();
            this.grpMotor1.SuspendLayout();
            this.grpMotor2.SuspendLayout();
            this.grpMotor3.SuspendLayout();
            this.grpMotor4.SuspendLayout();
            this.grpMotor5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVelocità
            // 
            this.txtVelocità.Location = new System.Drawing.Point(601, 341);
            this.txtVelocità.Multiline = true;
            this.txtVelocità.Name = "txtVelocità";
            this.txtVelocità.Size = new System.Drawing.Size(115, 27);
            this.txtVelocità.TabIndex = 5;
            // 
            // lblVelocità
            // 
            this.lblVelocità.AutoSize = true;
            this.lblVelocità.Location = new System.Drawing.Point(598, 325);
            this.lblVelocità.Name = "lblVelocità";
            this.lblVelocità.Size = new System.Drawing.Size(81, 13);
            this.lblVelocità.TabIndex = 6;
            this.lblVelocità.Text = "Velocità (0-100)";
            // 
            // grpMotor1
            // 
            this.grpMotor1.Controls.Add(this.btn1Open);
            this.grpMotor1.Controls.Add(this.btn1Close);
            this.grpMotor1.Location = new System.Drawing.Point(15, 40);
            this.grpMotor1.Name = "grpMotor1";
            this.grpMotor1.Size = new System.Drawing.Size(112, 108);
            this.grpMotor1.TabIndex = 7;
            this.grpMotor1.TabStop = false;
            this.grpMotor1.Text = "Motore 1";
            // 
            // btn1Open
            // 
            this.btn1Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Open.Location = new System.Drawing.Point(21, 58);
            this.btn1Open.Name = "btn1Open";
            this.btn1Open.Size = new System.Drawing.Size(75, 23);
            this.btn1Open.TabIndex = 13;
            this.btn1Open.Text = "<>";
            this.btn1Open.UseVisualStyleBackColor = true;
            // 
            // btn1Close
            // 
            this.btn1Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Close.Location = new System.Drawing.Point(21, 29);
            this.btn1Close.Name = "btn1Close";
            this.btn1Close.Size = new System.Drawing.Size(75, 23);
            this.btn1Close.TabIndex = 12;
            this.btn1Close.Text = "><";
            this.btn1Close.UseVisualStyleBackColor = true;
            this.btn1Close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1Close_KeyDown);
            this.btn1Close.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn1Close_KeyUp);
            // 
            // grpMotor2
            // 
            this.grpMotor2.Controls.Add(this.btn2Down);
            this.grpMotor2.Controls.Add(this.btn2Up);
            this.grpMotor2.Location = new System.Drawing.Point(133, 40);
            this.grpMotor2.Name = "grpMotor2";
            this.grpMotor2.Size = new System.Drawing.Size(112, 108);
            this.grpMotor2.TabIndex = 8;
            this.grpMotor2.TabStop = false;
            this.grpMotor2.Text = "Motore 2";
            // 
            // btn2Down
            // 
            this.btn2Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Down.Location = new System.Drawing.Point(19, 58);
            this.btn2Down.Name = "btn2Down";
            this.btn2Down.Size = new System.Drawing.Size(75, 23);
            this.btn2Down.TabIndex = 15;
            this.btn2Down.Text = "V";
            this.btn2Down.UseVisualStyleBackColor = true;
            // 
            // btn2Up
            // 
            this.btn2Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Up.Location = new System.Drawing.Point(19, 29);
            this.btn2Up.Name = "btn2Up";
            this.btn2Up.Size = new System.Drawing.Size(75, 23);
            this.btn2Up.TabIndex = 14;
            this.btn2Up.Text = "^";
            this.btn2Up.UseVisualStyleBackColor = true;
            // 
            // grpMotor3
            // 
            this.grpMotor3.Controls.Add(this.btn3Down);
            this.grpMotor3.Controls.Add(this.btn3Up);
            this.grpMotor3.Location = new System.Drawing.Point(251, 40);
            this.grpMotor3.Name = "grpMotor3";
            this.grpMotor3.Size = new System.Drawing.Size(112, 108);
            this.grpMotor3.TabIndex = 9;
            this.grpMotor3.TabStop = false;
            this.grpMotor3.Text = "Motore 3";
            // 
            // grpMotor4
            // 
            this.grpMotor4.Controls.Add(this.btn4Down);
            this.grpMotor4.Controls.Add(this.btn4Up);
            this.grpMotor4.Location = new System.Drawing.Point(369, 40);
            this.grpMotor4.Name = "grpMotor4";
            this.grpMotor4.Size = new System.Drawing.Size(112, 108);
            this.grpMotor4.TabIndex = 10;
            this.grpMotor4.TabStop = false;
            this.grpMotor4.Text = "Motore 4";
            // 
            // grpMotor5
            // 
            this.grpMotor5.Controls.Add(this.btn5Left);
            this.grpMotor5.Controls.Add(this.btn5Right);
            this.grpMotor5.Location = new System.Drawing.Point(487, 40);
            this.grpMotor5.Name = "grpMotor5";
            this.grpMotor5.Size = new System.Drawing.Size(112, 108);
            this.grpMotor5.TabIndex = 11;
            this.grpMotor5.TabStop = false;
            this.grpMotor5.Text = "Motore 5";
            // 
            // btn3Down
            // 
            this.btn3Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Down.Location = new System.Drawing.Point(19, 57);
            this.btn3Down.Name = "btn3Down";
            this.btn3Down.Size = new System.Drawing.Size(75, 23);
            this.btn3Down.TabIndex = 17;
            this.btn3Down.Text = "V";
            this.btn3Down.UseVisualStyleBackColor = true;
            // 
            // btn3Up
            // 
            this.btn3Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Up.Location = new System.Drawing.Point(19, 28);
            this.btn3Up.Name = "btn3Up";
            this.btn3Up.Size = new System.Drawing.Size(75, 23);
            this.btn3Up.TabIndex = 16;
            this.btn3Up.Text = "^";
            this.btn3Up.UseVisualStyleBackColor = true;
            // 
            // btn4Down
            // 
            this.btn4Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Down.Location = new System.Drawing.Point(19, 57);
            this.btn4Down.Name = "btn4Down";
            this.btn4Down.Size = new System.Drawing.Size(75, 23);
            this.btn4Down.TabIndex = 19;
            this.btn4Down.Text = "V";
            this.btn4Down.UseVisualStyleBackColor = true;
            // 
            // btn4Up
            // 
            this.btn4Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Up.Location = new System.Drawing.Point(19, 28);
            this.btn4Up.Name = "btn4Up";
            this.btn4Up.Size = new System.Drawing.Size(75, 23);
            this.btn4Up.TabIndex = 18;
            this.btn4Up.Text = "^";
            this.btn4Up.UseVisualStyleBackColor = true;
            // 
            // btn5Left
            // 
            this.btn5Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Left.Location = new System.Drawing.Point(19, 57);
            this.btn5Left.Name = "btn5Left";
            this.btn5Left.Size = new System.Drawing.Size(75, 23);
            this.btn5Left.TabIndex = 21;
            this.btn5Left.Text = "<";
            this.btn5Left.UseVisualStyleBackColor = true;
            // 
            // btn5Right
            // 
            this.btn5Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Right.Location = new System.Drawing.Point(19, 28);
            this.btn5Right.Name = "btn5Right";
            this.btn5Right.Size = new System.Drawing.Size(75, 23);
            this.btn5Right.TabIndex = 20;
            this.btn5Right.Text = ">";
            this.btn5Right.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMotor5);
            this.Controls.Add(this.grpMotor4);
            this.Controls.Add(this.grpMotor3);
            this.Controls.Add(this.grpMotor2);
            this.Controls.Add(this.grpMotor1);
            this.Controls.Add(this.lblVelocità);
            this.Controls.Add(this.txtVelocità);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMotor1.ResumeLayout(false);
            this.grpMotor2.ResumeLayout(false);
            this.grpMotor3.ResumeLayout(false);
            this.grpMotor4.ResumeLayout(false);
            this.grpMotor5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVelocità;
        private System.Windows.Forms.Label lblVelocità;
        private System.Windows.Forms.GroupBox grpMotor1;
        private System.Windows.Forms.Button btn1Open;
        private System.Windows.Forms.Button btn1Close;
        private System.Windows.Forms.GroupBox grpMotor2;
        private System.Windows.Forms.Button btn2Down;
        private System.Windows.Forms.Button btn2Up;
        private System.Windows.Forms.GroupBox grpMotor3;
        private System.Windows.Forms.GroupBox grpMotor4;
        private System.Windows.Forms.GroupBox grpMotor5;
        private System.Windows.Forms.Button btn3Down;
        private System.Windows.Forms.Button btn3Up;
        private System.Windows.Forms.Button btn4Down;
        private System.Windows.Forms.Button btn4Up;
        private System.Windows.Forms.Button btn5Left;
        private System.Windows.Forms.Button btn5Right;
    }
}

