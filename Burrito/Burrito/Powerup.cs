﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Burrito
{
    public class PowerUp
    {
        public static int POWER_UP_SIZE = 30;
        protected Vector2 position;
        protected Vector2 size = new Vector2(POWER_UP_SIZE, POWER_UP_SIZE);//powerup size
        protected Rectangle rectHitBox;
        protected Texture2D texture;
     
        public PowerUp(int x, int y, Texture2D texture)
        {
            this.texture = texture;
            position = new Vector2(x, y);
            rectHitBox = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
        }

        //general draw method for powerups, pass in a texture in the subclass
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y),
                Color.White);
        }

        public Rectangle hitBox 
        {
            get { return rectHitBox; }
        }

        

    }
}