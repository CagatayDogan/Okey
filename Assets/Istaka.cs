using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Istaka : MonoBehaviour
{
    public Transform m_NewTransform;
    BoxCollider2D m_Collider;
    Vector2 m_Point;
    public static GameObject[] taslar;
    GameObject[] istakadakiTaslar;
    int j;
    void Start()
    {
        m_Collider = GetComponent<BoxCollider2D>();
        j = 0;
        istakadakiTaslar = new GameObject[105];
    }

    void Update()
    {
        for (int i = 0; i < taslar.Length; i++)
        {
            m_Point = taslar[i].transform.position;
            if (m_Collider.bounds.Contains(m_Point))
            {
                istakadakiTaslar[j] = taslar[i];
                Debug.Log("Bounds contain the point : " + m_Point);
                j++;
            }
        }
    }
}
