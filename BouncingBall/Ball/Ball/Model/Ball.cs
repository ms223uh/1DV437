using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ball.Model
{
    class Ball
    {
        Vector2 ballPosition;
        Vector2 ballSpeed;
        float ballRadius = 0.05f;
        float velocity = 0.09f;

        public Ball()
        {
            ballPosition = new Vector2(0.4f, 0.1f);
            ballSpeed = new Vector2(velocity, velocity);
        }

        public void updateBallPosition(float time)
        {
            ballPosition.X = +ballSpeed.X * time;
            ballPosition.Y = +ballSpeed.Y * time;
        }


        public void updateVelocity(float velocityValue)
        {
            velocity = +velocityValue;
        }

        public Vector2 getBallPosition()
        {
            return ballPosition;
        }

        public void setBallSpeedX()
        {
            if (ballSpeed.X < 0)
            {
                ballSpeed.X = velocity;
            }
            else
            {
                ballSpeed.X = -ballSpeed.X;
            }
        }

        public void setBallSpeedY()
        {
            if (ballSpeed.Y < 0)
            {
                ballSpeed.Y = velocity;
            }
            else
            {
                ballSpeed.Y = -ballSpeed.Y;
            }
        }

        public float getBallRadius()
        {
            return ballRadius;
        }


    }
}
