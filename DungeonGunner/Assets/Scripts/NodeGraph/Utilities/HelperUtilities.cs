using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperUtilities
{
    /// <summary>
    /// Empty String Debug check 
    ///���ڿ�(stringToCheck)�� �����̸� Log ����ϰ� True �������ִ� �˻��
    /// <returns></returns>
    public static bool ValidateCheckEmptyString(Object thisObject, string fieldName, string stringToCheck)
    {
        if(stringToCheck == "")
        {
            Debug.Log(fieldName + " is empty and must contain a value in object " + thisObject.name.ToString());
            return true;
        }
        return false;
    }
}
