using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour
{
    private BuildingTypeSO buildingType;
    private BuildingListSO buildingList;
    private Camera camera; 


    private void Start()
    {
        camera = Camera.main;
        buildingList = Resources.Load<BuildingListSO>(typeof(BuildingListSO).Name);
        buildingType = buildingList.ListBuilding[0];
    }


    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(buildingType.Prefab, GetMouseWorldPosition(), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            buildingType = buildingList.ListBuilding[0];
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            buildingType = buildingList.ListBuilding[1];
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        return mousePosition;
    }
}
