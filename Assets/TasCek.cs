using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasCek : MonoBehaviour
{
    public static int[] randomNumbers;
    public static GameObject[] remainingAll;
    int random;

    void OnMouseDown()
    {
        for (int i = 57; i < 105; i++)
        {
            random = Random.Range(0, remainingAll.Length);
            for (int j = 0; j < 105; j++)
            {
                if (randomNumbers[j] == random)
                {
                    Debug.Log("Eski random: " + random);
                    random = Random.Range(0, remainingAll.Length);
                    Debug.Log("Yeni random: " + random);
                    j = -1;
                }
            }
            randomNumbers[i] = random;
        }
        GameObject cekObject = remainingAll[random];
        cekObject.transform.position = new Vector2(-1, -7);
    }
}
