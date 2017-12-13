using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FuckingSingletons.ScriptableObjects.Events
{
    [CreateAssetMenu(menuName = Metadata.AssetMenuName + "Event", order = Metadata.AssetMenuOrdering.Primitives)]
    public class SOEvent : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<SOEventListener> eventListeners =
            new List<SOEventListener>();

        public void Raise()
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(SOEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(SOEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }

    public abstract class SOEvent<TArg> : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<SOEventListener<TArg>> eventListeners =
            new List<SOEventListener<TArg>>();

        public void Raise(TArg arg)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(arg);
        }

        public void RegisterListener(SOEventListener<TArg> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(SOEventListener<TArg> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }

    public abstract class SOEvent<TArg1, TArg2> : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<SOEventListener<TArg1, TArg2>> eventListeners =
            new List<SOEventListener<TArg1, TArg2>>();

        public void Raise(TArg1 arg1, TArg2 arg2)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(arg1, arg2);
        }

        public void RegisterListener(SOEventListener<TArg1, TArg2> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(SOEventListener<TArg1, TArg2> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }

    public abstract class SOEvent<TArg1, TArg2, TArg3> : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<SOEventListener<TArg1, TArg2, TArg3>> eventListeners =
            new List<SOEventListener<TArg1, TArg2, TArg3>>();

        public void Raise(TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(arg1, arg2, arg3);
        }

        public void RegisterListener(SOEventListener<TArg1, TArg2, TArg3> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(SOEventListener<TArg1, TArg2, TArg3> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }

    public abstract class SOEvent<TArg1, TArg2, TArg3, TArg4> : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<SOEventListener<TArg1, TArg2, TArg3, TArg4>> eventListeners =
            new List<SOEventListener<TArg1, TArg2, TArg3, TArg4>>();

        public void Raise(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(arg1, arg2, arg3, arg4);
        }

        public void RegisterListener(SOEventListener<TArg1, TArg2, TArg3, TArg4> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(SOEventListener<TArg1, TArg2, TArg3, TArg4> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}
