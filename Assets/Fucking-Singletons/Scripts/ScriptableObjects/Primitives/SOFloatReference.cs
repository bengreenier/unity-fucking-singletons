using System;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Primitives
{
    [Serializable]
    public class SOFloatReference : SOReference<SOFloat, float>
    {

        #region implicit conversion (you need to copy and specialize this for derived classes)

        /// <summary>
        /// Raw operator
        /// </summary>
        /// <remarks>
        /// Allows us to treat the instance as if it's TRaw type for data access
        /// </remarks>
        /// <param name="reference">the reference to operate on</param>
        public static implicit operator float(SOFloatReference reference)
        {
            return reference.Value;
        }

        #endregion
    }
}
