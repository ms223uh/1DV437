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

        Texture2D smokeTexture;
        Vector2 smokePosition;
        Vector2 smokeDirection;
        float smokeRadius;
        float smokeColor;
        float smokeLife;

        public SmokeParticle(Texture2D SmokeTexture, Vector2 SmokePosition, Vector2 SmokeDirection,
                             float SmokeRadius, float SmokeColor, float SmokeLife)
        {
            this.smokeTexture = SmokeTexture;
            this.smokePosition = SmokePosition;
            this.smokeDirection = SmokeDirection;
            this.smokeRadius = SmokeRadius;
            this.smokeColor = SmokeColor;
            this.smokeLife = SmokeLife;
        }



    }
}
