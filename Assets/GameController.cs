using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    void Update()
    {
        //GameObject[] sari = GameObject.FindGameObjectsWithTag("Sarı");
        //GameObject[] mavi = GameObject.FindGameObjectsWithTag("Mavi");
        //GameObject[] kirmizi = GameObject.FindGameObjectsWithTag("Kırmızı");
        //GameObject[] siyah = GameObject.FindGameObjectsWithTag("Siyah");

        GameObject[] sari = FindObsWithTag("Sarı");
        GameObject[] mavi = FindObsWithTag("Mavi");
        GameObject[] kirmizi = FindObsWithTag("Kırmızı");
        GameObject[] siyah = FindObsWithTag("Siyah");

        SameNumberCheck(sari, mavi, kirmizi, siyah);
        SideBySideCheck(sari);
        SideBySideCheck(mavi);
        SideBySideCheck(kirmizi);
        SideBySideCheck(siyah);
    }

    void SameNumberCheck(GameObject[] sari, GameObject[] mavi, GameObject[] kirmizi, GameObject[] siyah)
    {
        for (int i = 0; i < sari.Length; i++)
        {
            if (sari[i].transform.position.x + 1 == mavi[i].transform.position.x && sari[i].transform.position.y == mavi[i].transform.position.y && sari[i].transform.position.x - 1 == kirmizi[i].transform.position.x && sari[i].transform.position.y == kirmizi[i].transform.position.y ||
            sari[i].transform.position.x + 1 == mavi[i].transform.position.x && sari[i].transform.position.y == mavi[i].transform.position.y && sari[i].transform.position.x - 1 == siyah[i].transform.position.x && sari[i].transform.position.y == siyah[i].transform.position.y ||
            sari[i].transform.position.x + 1 == kirmizi[i].transform.position.x && sari[i].transform.position.y == kirmizi[i].transform.position.y && sari[i].transform.position.x - 1 == mavi[i].transform.position.x && sari[i].transform.position.y == mavi[i].transform.position.y ||
            sari[i].transform.position.x + 1 == kirmizi[i].transform.position.x && sari[i].transform.position.y == kirmizi[i].transform.position.y && sari[i].transform.position.x - 1 == siyah[i].transform.position.x && sari[i].transform.position.y == siyah[i].transform.position.y ||
            sari[i].transform.position.x + 1 == siyah[i].transform.position.x && sari[i].transform.position.y == siyah[i].transform.position.y && sari[i].transform.position.x - 1 == kirmizi[i].transform.position.x && sari[i].transform.position.y == kirmizi[i].transform.position.y ||
            sari[i].transform.position.x + 1 == siyah[i].transform.position.x && sari[i].transform.position.y == siyah[i].transform.position.y && sari[i].transform.position.x - 1 == mavi[i].transform.position.x && sari[i].transform.position.y == mavi[i].transform.position.y ||
            mavi[i].transform.position.x + 1 == sari[i].transform.position.x && mavi[i].transform.position.y == sari[i].transform.position.y && mavi[i].transform.position.x - 1 == kirmizi[i].transform.position.x && mavi[i].transform.position.y == kirmizi[i].transform.position.y ||
            mavi[i].transform.position.x + 1 == sari[i].transform.position.x && mavi[i].transform.position.y == sari[i].transform.position.y && mavi[i].transform.position.x - 1 == siyah[i].transform.position.x && mavi[i].transform.position.y == siyah[i].transform.position.y ||
            mavi[i].transform.position.x + 1 == kirmizi[i].transform.position.x && mavi[i].transform.position.y == kirmizi[i].transform.position.y && mavi[i].transform.position.x - 1 == sari[i].transform.position.x && mavi[i].transform.position.y == sari[i].transform.position.y ||
            mavi[i].transform.position.x + 1 == kirmizi[i].transform.position.x && mavi[i].transform.position.y == kirmizi[i].transform.position.y && mavi[i].transform.position.x - 1 == siyah[i].transform.position.x && siyah[i].transform.position.y == sari[i].transform.position.y ||
            mavi[i].transform.position.x + 1 == siyah[i].transform.position.x && mavi[i].transform.position.y == siyah[i].transform.position.y && mavi[i].transform.position.x - 1 == kirmizi[i].transform.position.x && mavi[i].transform.position.y == kirmizi[i].transform.position.y ||
            mavi[i].transform.position.x + 1 == siyah[i].transform.position.x && mavi[i].transform.position.y == siyah[i].transform.position.y && mavi[i].transform.position.x - 1 == sari[i].transform.position.x && mavi[i].transform.position.y == sari[i].transform.position.y ||
            kirmizi[i].transform.position.x + 1 == sari[i].transform.position.x && kirmizi[i].transform.position.y == sari[i].transform.position.y && kirmizi[i].transform.position.x - 1 == mavi[i].transform.position.x && kirmizi[i].transform.position.y == mavi[i].transform.position.y ||
            kirmizi[i].transform.position.x + 1 == sari[i].transform.position.x && kirmizi[i].transform.position.y == sari[i].transform.position.y && kirmizi[i].transform.position.x - 1 == siyah[i].transform.position.x && kirmizi[i].transform.position.y == siyah[i].transform.position.y ||
            kirmizi[i].transform.position.x + 1 == mavi[i].transform.position.x && kirmizi[i].transform.position.y == mavi[i].transform.position.y && kirmizi[i].transform.position.x - 1 == sari[i].transform.position.x && kirmizi[i].transform.position.y == sari[i].transform.position.y ||
            kirmizi[i].transform.position.x + 1 == mavi[i].transform.position.x && kirmizi[i].transform.position.y == mavi[i].transform.position.y && kirmizi[i].transform.position.x - 1 == siyah[i].transform.position.x && kirmizi[i].transform.position.y == siyah[i].transform.position.y ||
            kirmizi[i].transform.position.x + 1 == siyah[i].transform.position.x && kirmizi[i].transform.position.y == siyah[i].transform.position.y && kirmizi[i].transform.position.x - 1 == mavi[i].transform.position.x && kirmizi[i].transform.position.y == mavi[i].transform.position.y ||
            kirmizi[i].transform.position.x + 1 == siyah[i].transform.position.x && kirmizi[i].transform.position.y == siyah[i].transform.position.y && kirmizi[i].transform.position.x - 1 == sari[i].transform.position.x && kirmizi[i].transform.position.y == sari[i].transform.position.y ||
            siyah[i].transform.position.x + 1 == sari[i].transform.position.x && siyah[i].transform.position.y == sari[i].transform.position.y && siyah[i].transform.position.x - 1 == mavi[i].transform.position.x && siyah[i].transform.position.y == mavi[i].transform.position.y ||
            siyah[i].transform.position.x + 1 == sari[i].transform.position.x && siyah[i].transform.position.y == sari[i].transform.position.y && siyah[i].transform.position.x - 1 == kirmizi[i].transform.position.x && siyah[i].transform.position.y == kirmizi[i].transform.position.y ||
            siyah[i].transform.position.x + 1 == mavi[i].transform.position.x && siyah[i].transform.position.y == mavi[i].transform.position.y && siyah[i].transform.position.x - 1 == sari[i].transform.position.x && siyah[i].transform.position.y == sari[i].transform.position.y ||
            siyah[i].transform.position.x + 1 == mavi[i].transform.position.x && siyah[i].transform.position.y == mavi[i].transform.position.y && siyah[i].transform.position.x - 1 == kirmizi[i].transform.position.x && siyah[i].transform.position.y == kirmizi[i].transform.position.y ||
            siyah[i].transform.position.x + 1 == kirmizi[i].transform.position.x && siyah[i].transform.position.y == kirmizi[i].transform.position.y && siyah[i].transform.position.x - 1 == sari[i].transform.position.x && siyah[i].transform.position.y == sari[i].transform.position.y ||
            siyah[i].transform.position.x + 1 == kirmizi[i].transform.position.x && siyah[i].transform.position.y == kirmizi[i].transform.position.y && siyah[i].transform.position.x - 1 == mavi[i].transform.position.x && siyah[i].transform.position.y == mavi[i].transform.position.y)
            {
                Debug.Log("Aynı sayılar eşleşti");
            }
            //Debug.Log(sari[i]);
        }
    }

    void SideBySideCheck(GameObject[] order)
    {
        for (int i = 0; i < order.Length; i++)
        {
            //Debug.Log(order.Length);
            //Debug.Log(order[i]);
            if (i == 0 || i == 1 || i == 24 || i == 25)
            {
                //Debug.Log("the tehlike " + i);
                continue;
            }
            else if (order[i].transform.position.x + 1 == order[i + 2].transform.position.x && order[i].transform.position.y == order[i + 2].transform.position.y && order[i].transform.position.x - 1 == order[i - 2].transform.position.x && order[i].transform.position.y == order[i - 2].transform.position.y ||
            order[i].transform.position.x + 1 == order[i + 2].transform.position.x && order[i].transform.position.y == order[i + 2].transform.position.y && order[i].transform.position.x - 1 == order[i - 1].transform.position.x && order[i].transform.position.y == order[i - 1].transform.position.y || 
            order[i].transform.position.x + 1 == order[i + 1].transform.position.x && order[i].transform.position.y == order[i + 1].transform.position.y && order[i].transform.position.x - 1 == order[i - 2].transform.position.x && order[i].transform.position.y == order[i - 2].transform.position.y ||
            order[i].transform.position.x + 1 == order[i + 2].transform.position.x && order[i].transform.position.y == order[i + 1].transform.position.y && order[i].transform.position.x - 1 == order[i - 2].transform.position.x && order[i].transform.position.y == order[i - 2].transform.position.y)
            {
                Debug.Log("Yan yana");
            }
        }
        for (int i = 0; i < order.Length; i++)
        {
            //Debug.Log(order.Length);
            //Debug.Log(order[i]);
            if (i == 2 || i == 23 || i == 0 || i == 1 || i == 24 || i == 25)
            {
                //Debug.Log("the tehlike " + i);
                continue;
            }
            else if (order[i].transform.position.x + 1 == order[i + 3].transform.position.x && order[i].transform.position.y == order[i + 3].transform.position.y && order[i].transform.position.x - 1 == order[i - 2].transform.position.x && order[i].transform.position.y == order[i - 2].transform.position.y ||
            order[i].transform.position.x + 1 == order[i + 3].transform.position.x && order[i].transform.position.y == order[i + 3].transform.position.y && order[i].transform.position.x - 1 == order[i - 1].transform.position.x && order[i].transform.position.y == order[i - 1].transform.position.y || 
            order[i].transform.position.x + 1 == order[i + 1].transform.position.x && order[i].transform.position.y == order[i + 1].transform.position.y && order[i].transform.position.x - 1 == order[i - 3].transform.position.x && order[i].transform.position.y == order[i - 3].transform.position.y ||
            order[i].transform.position.x + 1 == order[i + 2].transform.position.x && order[i].transform.position.y == order[i + 1].transform.position.y && order[i].transform.position.x - 1 == order[i - 3].transform.position.x && order[i].transform.position.y == order[i - 3].transform.position.y)
            {
                Debug.Log("Yan yana");
            }
        }
    }

    GameObject[] FindObsWithTag(string tag)
    {
        GameObject[] foundObs = GameObject.FindGameObjectsWithTag(tag);
        Array.Sort(foundObs, CompareObNames);
        return foundObs;
    }
    int CompareObNames(GameObject x, GameObject y)
    {
        return x.name.CompareTo(y.name);
    }
}
