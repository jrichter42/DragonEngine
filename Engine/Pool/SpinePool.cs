﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using DragonEngine.Entities;

namespace DragonEngine.Pool
{
    class SpinePool : Pool<SpineObject>
    {

        #region Singleton

        private static SpinePool mInstance;
        public static SpinePool Instance { get { if (mInstance == null) mInstance = new SpinePool(); return mInstance; } }

        #endregion

        #region Properties
        #endregion

        #region Getter & Setter
        #endregion

        #region Constructor

        public SpinePool()
            //:base()
        {
            //Initialize();
        }

        #endregion

        #region Methoden

        protected override SpineObject CreateInstance()
        {
            return new SpineObject("fluffy");
        }

        protected override void CleanUpInstance(SpineObject pObject)
        {
            pObject.CleanUp();
        }

        #endregion

    }
}
