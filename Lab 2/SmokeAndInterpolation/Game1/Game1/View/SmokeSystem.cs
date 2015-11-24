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
        Texture2D smokeTexture;
        public int maxSmokeParticle;
        float spawnNextParticle;
        float lastParticle;
        LinkedList<SmokeParticle> activeSmokeParticles;
        Random random;

        public SmokeSystem()
        {
            activeSmokeParticles = new LinkedList<SmokeParticle>();
        }


        public void Update(float elapsedTime)
        {
            LinkedListNode<SmokeParticle> smokeNode = activeSmokeParticles.First;

            while(smokeNode != null)
            {
                bool particleIsAlive = smokeNode.Value.Update(elapsedTime);
                smokeNode = smokeNode.Next;
                if (!particleIsAlive)
                {
                    if (smokeNode == null)
                    {
                        activeSmokeParticles.RemoveLast();
                    }
                    else
                    {
                        activeSmokeParticles.Remove(smokeNode.Previous);
                    }
                }
            }

        }


        public void Draw(SpriteBatch spritebatch)
        {
            LinkedListNode<SmokeParticle> smokeNode = activeSmokeParticles.First;
            while (smokeNode != null)
            {
                smokeNode.Value.Draw(spritebatch, scale, offsett);
                smokeNode = smokeNode.Next;
            }
        }


    }

}

