using System.Collections;
using System.Collections.Generic;
using TD;
using UnityEngine;

namespace Manager
{
    public class ResourcesManager : MonoBehaviour
    {
        #region Properties
        private Dictionary<ResourcesTypeSO, int> _dicResourcesAmount;
        #endregion

        #region Unity
        private void Awake()
        {
            _dicResourcesAmount = new Dictionary<ResourcesTypeSO, int>();
            ResourcesTypeListSO resourcesTypeListSO = Resources.Load<ResourcesTypeListSO>(Constant.LIST_ITEM);
            foreach (ResourcesTypeSO item in resourcesTypeListSO.ListResources)
            {
                _dicResourcesAmount[item] = 0;
            }
            TestResources();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                ResourcesTypeListSO resourcesTypeListSO = Resources.Load<ResourcesTypeListSO>(Constant.LIST_ITEM);
                AddValueResources(resourcesTypeListSO.ListResources[0],2);
                TestResources();
            }
        }
        #endregion

        #region Method
        private void TestResources()
        {
            foreach (ResourcesTypeSO item in _dicResourcesAmount.Keys)
            {
                Debug.Log(item.NameResources + "_" + _dicResourcesAmount[item]);
            }
        }

        private void AddValueResources(ResourcesTypeSO resourcesTypeSO, int value)
        {
            _dicResourcesAmount[resourcesTypeSO] += value;
        }
        #endregion
    }
}