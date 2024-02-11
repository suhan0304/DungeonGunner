using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOtherComponent : MonoBehaviour
{
    private void Start()
    {
        TestGameManager.Instance.TestMethod();
    }
}
