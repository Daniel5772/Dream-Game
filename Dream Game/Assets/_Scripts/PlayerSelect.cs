using UnityEngine;
using Script.UnitSelection;

namespace Script.PlaerSelect
{
    public class PlayerSelect : MonoBehaviour
    {
        void Start()
        {
            UnitSelections.Instance.unitList.Add(this.gameObject);
        }

        void OnDestroy()
        {
            UnitSelections.Instance.unitList.Destroy(this.gameObject);
        }
    }

}

