using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ApplicationRobot
{
    public partial class Form1 : Form
    {
        private Square square;
        private PositionDisplayManager positionDisplayManager;
        private Turn turnManager;
        private Image squareImage;
        private const int squareSize = 50; // Taille du carr�
        private const int moveDistance = 10; // Distance de d�placement pour chaque clic

        public Form1()
        {
            InitializeComponent();
            positionDisplayManager = new PositionDisplayManager(labelPosition);
            turnManager = new Turn();
            squareImage = Image.FromFile(@"..\..\..\..\image\icon.png"); // Mettez � jour le chemin vers votre image
            // Initialiser le carr� au milieu de la pictureBox
            square = new Square(pictureBoxMap1.Width / 2, pictureBoxMap1.Height / 2, squareSize, turnManager);
            DrawSquare();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            square.Move(moveDistance, -90);
            DrawSquare();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            square.Move(moveDistance, 90);
            DrawSquare();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            square.Move(-moveDistance, 0);
            DrawSquare();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            square.Move(moveDistance, 0);
            DrawSquare();
        }
        private void buttonTurnRight_Click(object sender, EventArgs e)
        {
            turnManager.TurnRight(10); // Tourner de 10 degr�s vers la droite
            DrawSquare();
        }

        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            turnManager.TurnLeft(10); // Tourner de 10 degr�s vers la gauche
            DrawSquare();
        }

        private void DrawSquare()
        {
            // Cr�er un Bitmap bas� sur l'image de fond originale de la PictureBox
            Bitmap bmp = new Bitmap(pictureBoxMap1.BackgroundImage);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Pas besoin de faire g.Clear() car nous dessinons sur l'image de fond fra�chement cr��e

                // Cr�er une transformation pour la rotation et la translation
                Matrix transform = new Matrix();
                transform.RotateAt(turnManager.CurrentAngle, new PointF(square.X + squareImage.Width / 2.0f, square.Y + squareImage.Height / 2.0f));
                g.Transform = transform;

                // Dessiner l'image du carr�
                g.DrawImage(squareImage, square.X, square.Y, squareImage.Width, squareImage.Height);
            }

            // D�finir l'image du PictureBox avec le Bitmap mis � jour
            pictureBoxMap1.Image = bmp;

            // Mettre � jour le texte du label pour montrer la position actuelle
            positionDisplayManager.UpdatePosition(square.X, square.Y);
        }


    }
}