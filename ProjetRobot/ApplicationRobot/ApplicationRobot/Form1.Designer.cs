namespace ApplicationRobot
{
    partial class Form1
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
            pictureBoxMap1 = new PictureBox();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            labelPosition = new Label();
            buttonTurnLeft = new Button();
            buttonTurnRight = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMap1
            // 
            pictureBoxMap1.BackgroundImage = Properties.Resources.ModeleClasse2;
            pictureBoxMap1.Location = new Point(12, 12);
            pictureBoxMap1.Name = "pictureBoxMap1";
            pictureBoxMap1.Size = new Size(501, 499);
            pictureBoxMap1.TabIndex = 0;
            pictureBoxMap1.TabStop = false;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(613, 81);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(75, 40);
            buttonUp.TabIndex = 1;
            buttonUp.Text = "Haut";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(613, 155);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(75, 37);
            buttonDown.TabIndex = 2;
            buttonDown.Text = "Bas";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(532, 119);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(75, 37);
            buttonLeft.TabIndex = 3;
            buttonLeft.Text = "Gauche";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(694, 119);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(75, 37);
            buttonRight.TabIndex = 4;
            buttonRight.Text = "Droite";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(652, 294);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(100, 15);
            labelPosition.TabIndex = 5;
            labelPosition.Text = "Position actuelle :";
            // 
            // buttonTurnLeft
            // 
            buttonTurnLeft.Location = new Point(519, 38);
            buttonTurnLeft.Name = "buttonTurnLeft";
            buttonTurnLeft.Size = new Size(88, 40);
            buttonTurnLeft.TabIndex = 6;
            buttonTurnLeft.Text = "Tourner vers la gauche";
            buttonTurnLeft.UseVisualStyleBackColor = true;
            buttonTurnLeft.Click += buttonTurnLeft_Click;
            // 
            // buttonTurnRight
            // 
            buttonTurnRight.Location = new Point(694, 38);
            buttonTurnRight.Name = "buttonTurnRight";
            buttonTurnRight.Size = new Size(88, 40);
            buttonTurnRight.TabIndex = 7;
            buttonTurnRight.Text = "Tourner vers la droite";
            buttonTurnRight.UseVisualStyleBackColor = true;
            buttonTurnRight.Click += buttonTurnRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(buttonTurnRight);
            Controls.Add(buttonTurnLeft);
            Controls.Add(labelPosition);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(pictureBoxMap1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMap1;
        private Button buttonUp;
        private Button buttonDown;
        private Button buttonLeft;
        private Button buttonRight;
        private Label labelPosition;
        private Button buttonTurnLeft;
        private Button buttonTurnRight;
    }
}