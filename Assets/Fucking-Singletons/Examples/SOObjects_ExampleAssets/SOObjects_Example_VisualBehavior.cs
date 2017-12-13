using FuckingSingletons.ScriptableObjects.Primitives;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SOObjects_Example_VisualBehavior : MonoBehaviour
{
    public SOFloatReference GameTimer;

    private void Update()
    {
        this.GetComponent<Text>().text = GameTimer.Value + "s";
    }
}