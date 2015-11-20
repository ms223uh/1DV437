﻿using System;
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
            createParticle();
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

            particle.Draw(spriteBatch, camera, particleTexture);

            spriteBatch.End();
        }


    }
}
