﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace DragonEngine
{
    static class EngineSettings
    {
        #region Properties
        
        public static bool IsDebug = false;

        public static int WindowHeight = 480;
        public static int WindowWidth = 640;

        public static ContentManager EngineContent;
        public static GraphicsDeviceManager Graphics;
        public static GameTime Time;
        #endregion

        #region Methoden


        /// <summary>
        /// Setzt die auflösung wie sie gewünscht ist.
        /// </summary>
        public static void SetResolution()
        {
            Graphics.PreferredBackBufferHeight = WindowHeight;
            Graphics.PreferredBackBufferWidth = WindowWidth;
            Graphics.ApplyChanges();

        }

        public static void SetResolution(int pWidth, int pHeight)
        {
            WindowHeight = pHeight;
            WindowWidth = pWidth;

            SetResolution();
        }
        #endregion
    }
}
