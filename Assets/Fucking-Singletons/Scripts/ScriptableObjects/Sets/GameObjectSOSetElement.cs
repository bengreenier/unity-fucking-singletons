using System;
using System.Collections.Generic;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Sets
{
    public class GameObjectSOSetElement : MonoBehaviour, IEquatable<GameObjectSOSetElement>
    {
        public GameObjectSOSet SOSet;

        private void OnEnable()
        {
            SOSet.Add(this);
        }

        private void OnDisable()
        {
            SOSet.Remove(this);
        }
        
        public bool Equals(GameObjectSOSetElement other)
        {
            if (other == null)
            {
                return false;
            }

            // we want to compare the game objects
            return this.gameObject.GetInstanceID() == other.gameObject.GetInstanceID();
        }
    }
}
