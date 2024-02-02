using UnityEngine;
[System.Serializable]

public class Doorway
{
    public Vector2Int position;
    public Orientation orientation;
    public GameObject doorPrefab;

    #region Header
    [Header("The Uppder Left Position To Start Copying From")]
    #endregion
    public Vector2Int doorwayStartCopyPosition;

}
