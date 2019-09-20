using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    interface IBlendable
    {
        /// <summary>
        /// Blends the object
        /// </summary>
        /// <returns>A corresponding string for the blend</returns>
        string Blend();
    }
}
