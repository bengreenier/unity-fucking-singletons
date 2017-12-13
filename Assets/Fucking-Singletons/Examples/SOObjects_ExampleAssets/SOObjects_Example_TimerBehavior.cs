using FuckingSingletons.ScriptableObjects;
using FuckingSingletons.ScriptableObjects.Primitives;
using UnityEngine;

public class SOObjects_Example_TimerBehavior : MonoBehaviour
{
    public SOFloatReference GameTimer;

    private void Start()
    {
        // reset it at start
        this.GameTimer.Value = 0f;
    }

    private void Update()
    {
        // tick it upward
        this.GameTimer.Value += Time.deltaTime;
    }
}