using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game1.View
{
    class GameView
    {

        SpriteBatch spriteBatch;
        SplitterSystem particle;
        Camera camera2;
        Texture2D particleTexture;
        float durationTime;
        private Camera camera;
        private Texture2D texture2D;

        public GameView(SpriteBatch spriteBatch, Texture2D particleTexture, Camera camera2)
        {
            this.spriteBatch = spriteBatch;
            this.particleTexture = particleTexture;
            this.camera2 = camera2;
            durationTime = 0;
            createParticle();
        }

        public GameView(SpriteBatch spriteBatch, Camera camera, Texture2D texture2D)
        {
            this.spriteBatch = spriteBatch;
            this.camera = camera;
            this.texture2D = texture2D;
        }

        public void createParticle()
        {
            Vector2 startPosition = new Vector2(0.5f, 0.5f);
            particle = new SplitterSystem(startPosition);
        }


        public void Draw(float elapsedTime)
        {
            durationTime += elapsedTime;
            if(durationTime > 2)
            {
                createParticle();
                durationTime = 0;
            }

            particle.Update(elapsedTime);

            spriteBatch.Begin();

            particle.Draw(spriteBatch, camera2, particleTexture);

            spriteBatch.End();
        }


    }
}
