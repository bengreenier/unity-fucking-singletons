using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Primitives
{
    [CreateAssetMenu(menuName = Metadata.AssetMenuName + "String", order = Metadata.AssetMenuOrdering.Primitives)]
    public class SOString : SOObject<string>
    {
    }
}
