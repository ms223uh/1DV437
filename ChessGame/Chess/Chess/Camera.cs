using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Camera
    {

        int sizeOfTile = 64;
        int borderSize = 64;
        int visualX;
        int visualY;
        GraphicsDeviceManager graphics;

        public Camera(GraphicsDeviceManager Graphics)
        {
            graphics = Graphics;
        }

        public Rectangle whitePlayerRec(int x, int y)
        {
            visualX = borderSize + x * sizeOfTile;
            visualY = borderSize + y * sizeOfTile;

            return new Rectangle(visualX, visualY, sizeOfTile, sizeOfTile);
        }

        public Vector2 getCordinations(int xCord, int yCord)
        {
            visualX = borderSize + xCord * sizeOfTile;
            visualY = borderSize + yCord * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

    }
}
