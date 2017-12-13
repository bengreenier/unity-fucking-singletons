using System;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects
{
    /// <summary>
    /// Representation of a <see cref="ScriptableObject"/> primitive
    /// </summary>
    /// <typeparam name="TObject">type of primitive</typeparam>
    public abstract class SOObject<TObject> : ScriptableObject
    {
        /// <summary>
        /// The stored primitive value
        /// </summary>
        public TObject Value;
    }
}