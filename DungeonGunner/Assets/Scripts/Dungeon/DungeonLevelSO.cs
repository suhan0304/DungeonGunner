using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonLevel_", menuName = "Scriptable Objects/Dungeon/Dungeon Level")]
public class DungeonLevelSO : ScriptableObject
{
    #region Header BASIC LEVEL DETAILS
    [Space(10)]
    [Header("BASIC LEVEL DETAILS")]
    #endregion Header BASIC LEVEL DETAILS
    #region Tooltip
    [Tooltip("The name for the level")]
    #endregion Tooltip

    public StringCollection levelName;

    #region Header ROOM TEMPLATES FOR LEVEL
    [Space(10)]
    [Header("ROOM TEMPLATES FOR LEVEL")]
    #endregion Header ROOM TEMPLATES FOR LEVEL
    #region Tooltip
    [Tooltip("Populate the list with the room templates that you want to be part of the level. You need to ensure that room templates are included for all room node types that are specified in the Room Node Graphs for the level.")]
    #endregion Tooltip

    public List<RoomTemplateSO> roomTemplateList;

    #region Header ROOM NODE GRAPHS FOR LEVEL
    [Space(10)]
    [Header("ROOM NODE GRAPHS FOR LEVEL")]
    #endregion Header ROOM NODE GRAPHS FOR LEVEL
    #region Tooltip
    [Tooltip("Populate this list with the room node graphs which should be randomly selected from for the level.")]
    #endregion Tooltip

    public List<RoomNodeGraphSO> roomNodeGraphList;

    #region Validation
#if UNITY_EDITOR

    // Validate scriptable object details eneterd


#endif
    #endregion Validation
}
