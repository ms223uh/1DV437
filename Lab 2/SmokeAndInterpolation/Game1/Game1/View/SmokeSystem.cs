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

            public SmokeSystem(Vector2 startPosition)
            {
                random = new Random();
                particleStartPosition = startPosition;
            }

            public void Draw(SpriteBatch sprite, Texture2D smokeTexture, Camera camera)
            {
                foreach (SmokeParticle particle in smokeArray)
                {
                    sprite.Draw(smokeTexture,
                                camera.getScreenCord(particle.SmokePosition),
                                smokeTexture.Bounds, new Color(particle.SmokeFade, particle.SmokeFade, particle.SmokeFade, particle.SmokeFade),
                                particle.SmokeRotation, new Vector2(smokeTexture.Bounds.Width / 2, smokeTexture.Bounds.Height),
                                particle.SmokeSize, SpriteEffects.None, 0);
                }
            }

            public void Update(float elapsedTime)
            {
                time += elapsedTime;
                if (time >= (float)delayTime / (float)numberOfParticles)
                {
                    addParticle();
                    time = 0;
                }

                foreach (SmokeParticle particle in smokeArray)
                {
                    if (particle.Update(elapsedTime))
                    {
                        particle.smokeSpot();
                    }
                }

            }

            public void addParticle()
            {
                if (smokeArray.Count <= numberOfParticles)
                {
                    SmokeParticle smoke = new SmokeParticle(random, particleStartPosition);
                    smoke.smokeSpot();
                    smokeArray.Add(smoke);
                }
            }

        }
    }

