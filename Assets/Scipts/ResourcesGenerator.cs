using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesGenerator : MonoBehaviour
{
    #region Properties
    private float timer;
    [SerializeField] private float timermax =1;
    #endregion
    #region Unity
    #endregion
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer += timermax;
        }
    }
    #region Method
    #endregion
}
