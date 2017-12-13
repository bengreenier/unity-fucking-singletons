using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Primitives
{
    [CreateAssetMenu(menuName = Metadata.AssetMenuName + "Float", order = Metadata.AssetMenuOrdering.Primitives)]
    public class SOFloat : SOObject<float>
    {
    }
}
