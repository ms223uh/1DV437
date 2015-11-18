using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ball.View 
{
    class BallView
    {
        Model.BallSimulation ballSimulation;
        Camera camera;
        Texture2D ballTexture;
        Texture2D gameBox;

        public BallView(Model.BallSimulation ballSim, Camera viewCamera, GraphicsDevice graphics, Texture2D psyBall)
        {
            ballSimulation = ballSim;
            camera = viewCamera;
            ballTexture = psyBall;

            gameBox = new Texture2D(graphics, 1, 1);
            gameBox.SetData(new[] { Color.OrangeRed });

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            float psyBallScale = camera.ballScale(ballSimulation.simBallRadius(), ballTexture.Bounds.Width);

            spriteBatch.Begin();

            spriteBatch.Draw(gameBox, camera.gameArea(), Color.OrangeRed);
            spriteBatch.Draw(ballTexture,
                             camera.screenCord(ballSimulation.simBallPosition()),
                             ballTexture.Bounds,
                             Color.White, 0,
                             new Vector2(ballTexture.Bounds.Width / 2, ballTexture.Height / 2),
                             psyBallScale, SpriteEffects.None, 0
                );

            spriteBatch.End();
        }

    }
}
