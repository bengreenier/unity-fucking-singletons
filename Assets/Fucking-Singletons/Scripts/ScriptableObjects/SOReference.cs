using System;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects
{
    /// <summary>
    /// A reference to a primitive either as a constant or a <see cref="SOObject{TObject}"/>
    /// </summary>
    /// <typeparam name="TObject">Serializable type dervived from <see cref="SOObject{TObject}"/></typeparam>
    /// <typeparam name="TRaw">type of primitive</typeparam>
    public abstract class SOReference<TObject, TRaw> where TObject : SOObject<TRaw>
    {
        /// <summary>
        /// Indicates if the primitive reference is using a constant value
        /// </summary>
        public bool UseConstant = false;

        /// <summary>
        /// Reference to constant value
        /// </summary>
        public TRaw Constant;

        /// <summary>
        /// Reference to object value
        /// </summary>
        public TObject SOObject;

        /// <summary>
        /// Accessor that abstracts constant or object access
        /// </summary>
        /// <remarks>
        /// This should be used to access the underlying reference
        /// </remarks>
        public TRaw Value
        {
            get
            {
                return this.UseConstant ? this.Constant : this.SOObject.Value;
            }

            set
            {
                if (this.UseConstant)
                {
                    this.Constant = value;
                }
                else
                {
                    this.SOObject.Value = value;
                }
            }
        }

        #region implicit conversion (you need to copy and specialize this for derived classes)

        /// <summary>
        /// Raw operator
        /// </summary>
        /// <remarks>
        /// Allows us to treat the instance as if it's TRaw type for data access
        /// </remarks>
        /// <param name="reference">the reference to operate on</param>
        public static implicit operator TRaw(SOReference<TObject, TRaw> reference)
        {
            return reference.Value;
        }

        #endregion
    }
}