using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.View
{
    class GameView
    {

        SpriteBatch spriteBatch;
        SplitterSystem particle;
        Camera camera;
        Texture2D particleTexture;
        float durationTime;


        public GameView(SpriteBatch spriteBatch, Texture2D particleTexture, Camera camera)
        {
            this.spriteBatch = spriteBatch;
            this.particleTexture = particleTexture;
            this.camera = camera;
            durationTime = 0;
        }


    }
}
