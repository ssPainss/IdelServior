using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    private Dictionary<ResourcesTypeSO, int> _dicResourcesAmount;
    private void Awake()
    {
        _dicResourcesAmount = new Dictionary<ResourcesTypeSO, int>();
        ResourcesTypeListSO resourcesTypeListSO = Resources.Load<ResourcesTypeListSO>("ItemList");
        foreach (ResourcesTypeSO item in resourcesTypeListSO.ListResources)
        {
            _dicResourcesAmount[item] = 0;
        }
        TestResources();
    }

    private void TestResources()
    {
        foreach (ResourcesTypeSO item in _dicResourcesAmount.Keys)
        {
            Debug.Log(item.NameResources +"_" + _dicResourcesAmount[item]);
        }
    }
}
