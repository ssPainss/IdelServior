using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName ="Sciptable/Building",fileName ="Tower",order = 1)]
public class BuildingTypeSO :ScriptableObject
{
    public string NameBuilding;
    public Transform Prefab;
}
