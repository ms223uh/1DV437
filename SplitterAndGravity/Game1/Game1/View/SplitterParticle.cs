using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.View
{
    class SplitterParticle
    {

        private int seed;
        private Vector2 startPostion;
        private Vector2 particlePostion;
        private Vector2 velocity;


        public SplitterParticle(int seed, Vector2 startPositon)
        {
            this.seed = seed;
            this.startPostion = startPostion;
            this.particlePostion = new Vector2(startPositon.X, startPositon.Y);
            velocity = new Vector2(1, 0);
        }

        internal void Update(float elapsedTimeSeconds)
        {
            particlePostion = particlePostion + velocity * elapsedTimeSeconds;
        }

        internal void Draw(SpriteBatch spriteBatch, Camera camera, Texture2D particleTexture)
        {

        }

    }
}
