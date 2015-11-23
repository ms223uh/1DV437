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
        private Vector2 startPostion;
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
            this.startPostion = Startposition;
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






    }
}
