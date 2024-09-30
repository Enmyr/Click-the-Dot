// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Click the Dot");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
            //target = Color.White;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            bool isClicking = Input.IsMouseButtonPressed(MouseInput.Left);
            if (isClicking == true)
            {
                DrawTarget();
            }
        }
        void DrawTarget()
        {
            Vector2 targetPos = new Vector2();
            targetPos = Random.Vector2(360, 360);

            Draw.FillColor = Color.OffWhite;
            Draw.Circle(targetPos, 80);
        }
    }
}
