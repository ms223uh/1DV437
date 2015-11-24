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

        private Camera camera;
        private SpriteBatch spriteBatch;
        private Texture2D smokeTexture;
        private SmokeSystem smokeSystem;

        public GameView(SpriteBatch sprite, Camera cam, Texture2D smokey)
        {
            this.camera = cam;
            this.spriteBatch = sprite;
            this.smokeTexture = smokey;
        }

        public void Draw()
        {
            spriteBatch.Begin();

            smokeSystem.Draw(spriteBatch, smokeTexture, camera);

            spriteBatch.End();
        }

        public void Update(float elapsedTime)
        {
            smokeSystem.Update(elapsedTime);
        }


    }
}
