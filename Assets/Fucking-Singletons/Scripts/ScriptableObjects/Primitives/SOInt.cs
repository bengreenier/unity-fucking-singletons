using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Primitives
{
    [CreateAssetMenu(menuName = Metadata.AssetMenuName + "Int", order = Metadata.AssetMenuOrdering.Primitives)]
    public class SOInt : SOObject<int>
    {
    }
}
