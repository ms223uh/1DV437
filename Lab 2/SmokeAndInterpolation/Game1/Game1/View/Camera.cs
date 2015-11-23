using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.View
{
    class Camera
    {

        private float cordX;
        private float cordY;

        public Camera(Viewport viewPort)
        {
            cordX = viewPort.Width / 2;
            cordY = viewPort.Height / 2;
        }


        public float getSmokeScale(float radius, int smokeWidth)
        {
            return (radius * 2.0f) * (float)cordX / (float)smokeWidth;
        }


        public Vector2 getScreenCord(Vector2 screenPosition)
        {
            int screenX = (int)((screenPosition.X * cordX));
            int screenY = (int)((screenPosition.Y * cordY));
            return new Vector2(screenX, screenY);
        }

        public Rectangle getRectangle(float x, float y)
        {
            return new Rectangle((int)(cordX * x), (int)(cordY * y), 64, 64);
        }




    }
}
