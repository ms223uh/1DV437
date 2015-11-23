using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.View
{
    class SmokeSystem
    {

        private List<SmokeParticle> smokeArray = new List<SmokeParticle>(numberOfParticles);
        private Vector2 particleStartPosition;
        private Random random;
        private const int numberOfParticles = 100;
        private float delayTime = 4;
        private float time;


        public SmokeSystem(Vector2 startPostionParticle)
        {
            random = new Random();
            this.particleStartPosition = startPostionParticle;
        }



    }
}
