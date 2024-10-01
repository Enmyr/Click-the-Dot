// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        int hitScore = 0;
        bool isClicking = false;
        Vector2 targetPos;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Click the Dot");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
            targetPos = Random.Vector2(200, 200, 200, 200);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            //bool isClicking = Input.IsMouseButtonPressed(MouseInput.Left);
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                targetPos = Random.Vector2(20, 380, 20, 380);
                hitScore++;
                isClicking = true;
            }
            DrawTarget();
        }
        void DrawTarget()
        {
            Draw.FillColor = Color.Black;
            Draw.Circle(targetPos, 55);
        }
    }
}
