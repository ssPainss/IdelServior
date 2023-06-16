using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sciptable/ResourcesListType", fileName = "ResourcesListType", order = 1)]
public class ResourcesTypeListSO : ScriptableObject
{
    public List<ResourcesTypeSO> ListResources;
}
