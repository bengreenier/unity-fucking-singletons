using System.Collections.Generic;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Sets
{
    public abstract class ScriptableObjectWithChildCount : ScriptableObject
    {
        public abstract int GetChildCount();
    }

    public abstract class SOSet<T> : ScriptableObjectWithChildCount
    {
        private List<T> list = new List<T>();
        
        public ICollection<T> Items
        {
            get
            {
                return this.list;
            }
        }
        
        public override int GetChildCount()
        {
            return this.Items.Count;
        }

        public void Add(T thing)
        {
            if (!Items.Contains(thing))
                Items.Add(thing);
        }

        public void Remove(T thing)
        {
            if (Items.Contains(thing))
                Items.Remove(thing);
        }
    }
}
