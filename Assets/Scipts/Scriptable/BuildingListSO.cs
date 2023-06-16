using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sciptable/BuildingList", fileName = "BuildingList", order = 1)]
public class BuildingListSO : ScriptableObject
{
    public List<BuildingTypeSO> ListBuilding;
}
