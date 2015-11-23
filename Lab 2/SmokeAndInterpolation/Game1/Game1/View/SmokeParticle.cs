using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.View
{
    class SmokeParticle
    {

        private Random random;
        private Vector2 startPosition;
        private Vector2 smokePosition;
        private Vector2 velocity;
        private Vector2 smokeAcceleration;
        private float smokeFade;
        private float smokeRotation;
        private float smokeSpeedRotation;
        private float smokeLifeTime = 4;
        private float smokeMaxSize = 5.0f;
        private float smokeMinSize = 1.0f;
        private float smokeSimSec;
        private float smokeLife;
        private float smokeSize;

        
        public SmokeParticle(Random Random, Vector2 Startposition)
        {
            this.random = Random;
            this.startPosition = Startposition;
        }


            public Vector2 SmokePosition
            {
                get { return smokePosition; }
            }

            public float SmokeSize
            {
                get { return smokeSize; }
            }

            public float SmokeFade
            {
                get { return smokeFade; }
            }

            public float SmokeRotation
            {
                get { return smokeRotation; }
            }


        public void smokeSpot()
        {
            this.smokePosition = this.startPosition;
            smokeSimSec = 0;
            smokeSize = 0;

            smokeRotation = (float)(10 * (180.0 / Math.PI));
            smokeSpeedRotation = (float)(random.NextDouble() + 0.1);

            velocity = new Vector2((float)((random.NextDouble() * 2.0f - 1.0f) * 0.4f), (float)((random.NextDouble() * 2.0f - 1.0f) * 0.3f));
            velocity = velocity * ((float)random.NextDouble() * 0.3f);
            smokeAcceleration = new Vector2(0.0f, -0.3f);
        }


        public bool Update(float elapsedTime)
        {
            smokeSimSec += elapsedTime;
            smokeLife = smokeSimSec / smokeLifeTime;

            velocity = velocity + smokeAcceleration * elapsedTime;
            smokePosition = smokePosition + velocity * elapsedTime;

            smokeSize = smokeMinSize + smokeLife * smokeMaxSize;

            float beginSmoke = 1.0f, endSmoke = 0.0f;
            smokeFade = endSmoke * smokeLife + (1.0f - smokeLife) * beginSmoke;

            smokeRotation += smokeSpeedRotation * elapsedTime;

            if (smokeLife >= 1)
            {
                return true;
            }
            return false;
        }


    }
}
