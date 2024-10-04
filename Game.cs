// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;

// The namespace your code is in.
namespace Game10003
{
    /// Your game code goes inside this class!
    public class Game
    {
        // Variables, Floats, Bools, Intigers, and Vectors
        int hitScore = 0;
        int cRadius = 60;
        int checkRadius = 65;
        bool isClicking = false;
        bool isOverlap = false;
        bool retryLocation = false;
        Vector2 targetPos;
        Vector2 fake1;
        Vector2 fake2;
        Vector2 fake3;
        Vector2 fake4;
        Vector2 fake5;
        Vector2 fake6;
        Vector2 fake7;
        Vector2 fake8;
        Vector2 fake9;
        Vector2 fake10;
        float targetX;
        float targetY;

        /// Setup runs once before the game loop begins.
        public void Setup()
        {
            Window.SetTitle("Click the Dot");
            Window.SetSize(600, 600);
            Window.TargetFPS = 60;
            // Sets the starting locations of the dots.
            targetPos = Random.Vector2(300, 300, 300, 300);
            fake1 = Random.Vector2(1000, 1000, 1000, 1000);
            fake2 = Random.Vector2(1000, 1000, 1000, 1000);
            fake3 = Random.Vector2(1000, 1000, 1000, 1000);
            fake4 = Random.Vector2(1000, 1000, 1000, 1000);
            fake5 = Random.Vector2(1000, 1000, 1000, 1000);
            fake6 = Random.Vector2(4000, 4000, 4000, 4000);
            fake7 = Random.Vector2(4000, 4000, 4000, 4000);
            fake8 = Random.Vector2(4000, 4000, 4000, 4000);
            fake9 = Random.Vector2(4000, 4000, 4000, 4000);
            fake10 = Random.Vector2(4000, 4000, 4000, 4000);
        }

        /// Updates run every frame.
        public void Update()
        {
            float MouseX = Input.GetMouseX();
            float MouseY = Input.GetMouseY();
            float targetX = targetPos.X;
            float targetY = targetPos.Y;
            float X2 = (MouseX - targetX) * (MouseX - targetX);
            float Y2 = (MouseY - targetY) * (MouseY - targetY);
            float DistanceFromTargetCenter = (float)Math.Sqrt(X2 + Y2);

            Window.ClearBackground(Color.OffWhite);
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                if (DistanceFromTargetCenter <= cRadius)
                {
                    isClicking = true;
                }
                else
                {
                    isClicking = false;
                }
            }
            else
            {
                isClicking = false;
            }
            if (isClicking == true)
            {
                // Set the random X and Y coordinates of the target dot and the five decoy dots
                targetPos = Random.Vector2(30, 570, 30, 570);
                fake1 = Random.Vector2(30, 570, 30, 570);
                fake2 = Random.Vector2(30, 570, 30, 570);
                fake3 = Random.Vector2(30, 570, 30, 570);
                fake4 = Random.Vector2(30, 570, 30, 570);
                fake5 = Random.Vector2(30, 570, 30, 570);
                if (hitScore >= 15)
                {
                    fake6 = Random.Vector2(30, 570, 30, 570);
                    fake7 = Random.Vector2(30, 570, 30, 570);
                    fake8 = Random.Vector2(30, 570, 30, 570);
                    if (hitScore >= 35)
                    {
                        fake9 = Random.Vector2(30, 570, 30, 570);
                        fake10 = Random.Vector2(30, 570, 30, 570);
                    }
                }
                if (cRadius >= 10)
                {
                    hitScore++;
                    cRadius--;
                    checkRadius--;
                }
                else
                {
                    cRadius = 0;
                }
            }
            // Calls the function to draw the dots
            DrawTarget();
            DrawFakeouts();
        }
        public static class Text
        {

        }
        void DrawTarget()
        {
            // Draws the target dot
            Draw.FillColor = Color.Black;
            Draw.Circle(targetPos, cRadius);
        }
        void DrawFakeouts()
        {
            // Draws up to 10 of the decoy dots
            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake1, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake2, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake3, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake4, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake5, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake6, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake7, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake8, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake9, cRadius);

            Draw.FillColor = Color.DarkGray;
            Draw.Circle(fake10, cRadius);

        }
    }
}