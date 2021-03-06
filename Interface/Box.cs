﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DragonEngine.Entities;
using Microsoft.Xna.Framework;

namespace DragonEngine.Interface
{
    public class Box : InterfaceObject
    {
        #region Properties
        #endregion

        #region Getter & Setter
        #endregion

        #region Constructor
        public Box(Vector2 pPosition, Rectangle pRectangle)
            : base(pPosition, pRectangle)
        {
            mCollisionBox = pRectangle;
        }
        #endregion

        #region Methods

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            //// return wenn Dropdown nicht gezeigt wird
            if (!IsVisible) return;

            // Draw Outlines
            spriteBatch.Draw(mTexture, Position - new Vector2(1, 1), mOutlineRectangle, mOutlineColor);

            // Draw Box
            spriteBatch.Draw(mTexture, Position, mDrawRectangle, mDrawColor);
            // Draw Selected Hover
            if (mHover)
                spriteBatch.Draw(mTexture, mHoverRectangle, mHoverColor);
        }
        #endregion
    }
}
