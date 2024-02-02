using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Room_", menuName = "Scriptable Objects/Dungeon/Room")]
public class RoomTemplateSO : ScriptableObject
{
    [HideInInspector] public string guid;

    #region Header Room PREFAB

    [Space(10)]
    [Header("ROOM PREFAB")]

    #endregion Header Room PREFAB

    #region Tooltip

    [Tooltip("The gameobejct prefab for the room (this will contain all the tilemaps for the room and environment game objects")]

    #endregion Tooltip

    public GameObject prefab;

    [HideInInspector] public GameObject previousPrefab; // this is used to regenrate the guid if the so is copied and the prefab is changed

    [Space(10)]

    #region Header ROOM CONFIGURATION

    [Space(10)]
    [Header("ROOM CONFIGURATION")]

    #endregion Header Room CONFIGURATION

    #region Tooltip

    #endregion Tooltip

}