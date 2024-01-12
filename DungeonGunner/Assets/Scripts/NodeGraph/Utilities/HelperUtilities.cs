using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperUtilities
{
    /// <summary>
    /// Empty String Debug check 
    ///문자열(stringToCheck)이 공백이면 Log 출력하고 True 리턴해주는 검사기
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
