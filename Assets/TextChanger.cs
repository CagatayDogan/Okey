using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public static string text;
    Text statement;
    void Start()
    {
        statement = GetComponent<Text>();
    }

    void Update()
    {
        statement.text = text;
    }
}
