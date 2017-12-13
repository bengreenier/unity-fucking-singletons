using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Primitives
{
    [CreateAssetMenu(menuName = Metadata.AssetMenuName + "Bool", order = Metadata.AssetMenuOrdering.Primitives)]
    public class SOBool : SOObject<bool>
    {
    }
}
