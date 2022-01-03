using System.Collections.Generic;
using UnityEngine;

namespace Script.UnitSelection
{
    public class UnitSelection : MonoBehaviour
    {
        public List<GameObject> unitList = new List<GameObject>();
        public List<GameObject> unitsSelected = new List<GameObject>();

        private static UnitSelections _instance;
        public static UnitSelections Instance 
        { 
            get
            {
                returne _instance;
            }
        }
    }
    void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void ClickSelect(GameObject unitToAdd)
    {

    }

    public void ShiftClickSelect(GameObject unitToAdd)
    {

    }

    public void Dragselect(GameObject unitToAdd)
    {

    }

    public void DeselectAll()
    {

    }

    public void Deselect(GameObject unitToDeselect)
    {

    }
}

