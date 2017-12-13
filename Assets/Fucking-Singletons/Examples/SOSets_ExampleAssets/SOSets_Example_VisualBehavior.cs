using FuckingSingletons.ScriptableObjects.Sets;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SOSets_Example_VisualBehavior : MonoBehaviour
{
    public GameObjectSOSet SOSet;

    private void Update()
    {
        this.GetComponent<Text>().text = SOSet.Items.Count + " Elements";
    }
}