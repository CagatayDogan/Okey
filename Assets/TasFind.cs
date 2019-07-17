using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasFind : MonoBehaviour
{
    public static Vector2 posLeft;
    public static Vector2 posRight;
    public static int value;
    public static string comeName;

    void Update()
    {
        if (posRight.x == transform.position.x && posRight.y == transform.position.y)
        {
            Debug.Log(comeName + " sağında " + gameObject.name);
        }
        if (posLeft.x == transform.position.x && posLeft.y == transform.position.y)
        {
            Debug.Log(comeName + " solunda " + gameObject.name);
        }       
    }
}
