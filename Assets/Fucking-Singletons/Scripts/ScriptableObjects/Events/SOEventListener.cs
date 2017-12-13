using System;
using UnityEngine;
using UnityEngine.Events;

namespace FuckingSingletons.ScriptableObjects.Events
{
    public class SOEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public SOEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }

    public abstract class SOEventListener<TArg> : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public SOEvent<TArg> Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<TArg> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(TArg arg)
        {
            Response.Invoke(arg);
        }
    }

    public abstract class SOEventListener<TArg1, Targ2> : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public SOEvent<TArg1, Targ2> Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<TArg1, Targ2> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(TArg1 arg1, Targ2 arg2)
        {
            Response.Invoke(arg1, arg2);
        }
    }

    public abstract class SOEventListener<TArg1, TArg2, TArg3> : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public SOEvent<TArg1, TArg2, TArg3> Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<TArg1, TArg2, TArg3> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            Response.Invoke(arg1, arg2, arg3);
        }
    }

    public abstract class SOEventListener<TArg1, TArg2, TArg3, TArg4> : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public SOEvent<TArg1, TArg2, TArg3, TArg4> Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<TArg1, TArg2, TArg3, TArg4> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            Response.Invoke(arg1, arg2, arg3, arg4);
        }
    }
}
