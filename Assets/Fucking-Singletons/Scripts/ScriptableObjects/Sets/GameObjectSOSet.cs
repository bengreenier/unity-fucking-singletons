using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Sets
{
    [CreateAssetMenu(menuName = Metadata.AssetMenuName + "Sets/GO Set", order = Metadata.AssetMenuOrdering.Sets)]
    public class GameObjectSOSet : SOSet<GameObjectSOSetElement>
    {
    }
}
