using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ButtonHandler : MonoBehaviour
{
    GameObject[] all;
    GameObject currentObject;
    int index;
    int theOkey;
    GameObject okeyObject;
    GameObject okeyObject2;

    public void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");

        all = FindGameObjectsWithTags(new string[] { "Sarı", "Mavi", "Kırmızı", "Siyah" });

        index = Random.Range(0, all.Length);
        currentObject = all[index];

        Taslar script = currentObject.GetComponent<Taslar>();

        print(currentObject.name + " Değer: " + script.number);
        currentObject.transform.position = new Vector2(7, -7);
        if (currentObject.tag == "Sarı")
        {
            if (script.number == 12)
            {
                theOkey = 1;
                TextChanger.text = "Okey: Sarı " + theOkey;
                if (GameObject.Find($"Sari.{theOkey}") != null || GameObject.Find($"Sari.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Sari.{theOkey}");
                    okeyObject2 = GameObject.Find($"Sari.{theOkey} (1)");
                    Debug.Log("1");
                }
            }
            else
            {
                theOkey = script.number + 2;
                TextChanger.text = "Okey: Sarı " + theOkey;
                if (GameObject.Find($"Sari.{theOkey}") != null || GameObject.Find($"Sari.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Sari.{theOkey}");
                    okeyObject2 = GameObject.Find($"Sari.{theOkey} (1)");
                    Debug.Log("2");
                }
                else if (GameObject.Find($"Sari{theOkey}") != null || GameObject.Find($"Sari{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Sari{theOkey}");
                    okeyObject2 = GameObject.Find($"Sari{theOkey} (1)");
                    Debug.Log("3");
                }
            }
        }
        if (currentObject.tag == "Mavi")
        {
            if (script.number == 25)
            {
                theOkey = 1;
                TextChanger.text = "Okey: Mavi " + theOkey;
                if (GameObject.Find($"Mavi.{theOkey}") != null || GameObject.Find($"Mavi.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Mavi.{theOkey}");
                    okeyObject2 = GameObject.Find($"Mavi.{theOkey} (1)");
                    Debug.Log("4");
                }
            }
            else
            {
                theOkey = script.number - 11;
                TextChanger.text = "Okey: Mavi " + theOkey;
                if (GameObject.Find($"Mavi.{theOkey}") != null || GameObject.Find($"Mavi.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Mavi.{theOkey}");
                    okeyObject2 = GameObject.Find($"Mavi.{theOkey} (1)");
                    Debug.Log("5");
                }
                else if (GameObject.Find($"Mavi{theOkey}") != null || GameObject.Find($"Mavi{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Mavi{theOkey}");
                    okeyObject2 = GameObject.Find($"Mavi{theOkey} (1)");
                    Debug.Log("6");
                }
            }
        }
        if (currentObject.tag == "Siyah")
        {
            if (script.number == 38)
            {
                theOkey = 1;
                TextChanger.text = "Okey: Siyah " + theOkey;
                if (GameObject.Find($"Siyah.{theOkey}") != null || GameObject.Find($"Siyah.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Siyah.{theOkey}");
                    okeyObject2 = GameObject.Find($"Siyah.{theOkey} (1)");
                    Debug.Log("7");
                }
            }
            else
            {
                theOkey = script.number - 24;
                TextChanger.text = "Okey: Siyah " + theOkey;
                if (GameObject.Find($"Siyah.{theOkey}") != null || GameObject.Find($"Siyah.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Siyah.{theOkey}");
                    okeyObject2 = GameObject.Find($"Siyah.{theOkey} (1)");
                    Debug.Log("8");
                }
                else if (GameObject.Find($"Siyah{theOkey}") != null || GameObject.Find($"Siyah{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Siyah{theOkey}");
                    okeyObject2 = GameObject.Find($"Siyah{theOkey} (1)");
                    Debug.Log("9");
                }
            }
        }
        if (currentObject.tag == "Kırmızı")
        {
            if (script.number == 51)
            {
                theOkey = 1;
                TextChanger.text = "Okey: Kırmızı " + theOkey;
                if (GameObject.Find($"Kirmizi.{theOkey}") != null || GameObject.Find($"Kirmizi.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Kirmizi.{theOkey}");
                    okeyObject2 = GameObject.Find($"Kirmizi.{theOkey} (1)");
                    Debug.Log("10");
                }
            }
            else
            {
                theOkey = script.number - 37;
                TextChanger.text = "Okey: Kırmızı " + theOkey;
                if (GameObject.Find($"Kirmizi.{theOkey}") != null || GameObject.Find($"Kirmizi.{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Kirmizi.{theOkey}");
                    okeyObject2 = GameObject.Find($"Kirmizi.{theOkey} (1)");
                    Debug.Log("11");
                }
                else if (GameObject.Find($"Kirmizi{theOkey}") != null || GameObject.Find($"Kirmizi{theOkey} (1)") != null)
                {
                    okeyObject = GameObject.Find($"Kirmizi{theOkey}");
                    okeyObject2 = GameObject.Find($"Kirmizi{theOkey} (1)");
                    Debug.Log("12");
                }
            }
        }
        //Dağıtılıcak taşlardan, "okey" taşını çıkartıyor
        var numbersList = all.ToList();
        numbersList.Remove(currentObject);
        numbersList.Add(GameObject.Find("SahteOkey"));
        numbersList.Add(GameObject.Find("SahteOkey (1)"));
        var remainingAll = numbersList.ToArray();

        //Istaka.taslar = remainingAll;

        int[] randomNumbers = new int[105];
        //1. Oyuncu dizilim
        for (int i = 0; i < 15; i++)
        {
            int random = Random.Range(0, remainingAll.Length);
            for (int j = 0; j < 15; j++)
            {
                if (randomNumbers[j] == random)
                {
                    Debug.Log("Eski random: " + random);
                    random = Random.Range(0, remainingAll.Length);
                    //randomNumbers[j] = random;
                    Debug.Log("Yeni random: " + random);
                    j = -1;
                }
            }
            Debug.Log("Random: " + random);
            randomNumbers[i] = random;
            GameObject tahtaObject = remainingAll[random];
            tahtaObject.transform.position = new Vector2(-8 + i, -11);
            //tahtaObject.transform.position = new Vector2(-8, -11);
            Debug.Log(tahtaObject.name);
        }
        //2. Oyuncu dizilim
        for (int i = 15; i < 29; i++)
        {
            int random = Random.Range(0, remainingAll.Length);
            for (int j = 0; j < 29; j++)
            {
                if (randomNumbers[j] == random)
                {
                    Debug.Log("Eski random: " + random);
                    random = Random.Range(0, remainingAll.Length);
                    Debug.Log("Yeni random: " + random);
                    j = -1;
                }
            }
            Debug.Log("Random: " + random);
            randomNumbers[i] = random;
            GameObject tahtaObject = remainingAll[random];
            tahtaObject.transform.position = new Vector2(i - 3, -11);
            Debug.Log(tahtaObject.name);
        }
        //3. Oyuncu dizilim
        for (int i = 29; i < 43; i++)
        {
            int random = Random.Range(0, remainingAll.Length);
            for (int j = 0; j < 44; j++)
            {
                if (randomNumbers[j] == random)
                {
                    Debug.Log("Eski random: " + random);
                    random = Random.Range(0, remainingAll.Length);
                    Debug.Log("Yeni random: " + random);
                    j = -1;
                }
            }
            Debug.Log("Random: " + random);
            randomNumbers[i] = random;
            GameObject tahtaObject = remainingAll[random];
            tahtaObject.transform.position = new Vector2(i + 3, -11);
            Debug.Log(tahtaObject.name);
        }
        //4. Oyuncu dizilim
        for (int i = 43; i < 57; i++)
        {
            int random = Random.Range(0, remainingAll.Length);
            for (int j = 0; j < 57; j++)
            {
                if (randomNumbers[j] == random)
                {
                    Debug.Log("Eski random: " + random);
                    random = Random.Range(0, remainingAll.Length);
                    Debug.Log("Yeni random: " + random);
                    j = -1;
                }
            }
            Debug.Log("Random: " + random);
            randomNumbers[i] = random;
            GameObject tahtaObject = remainingAll[random];
            tahtaObject.transform.position = new Vector2(i + 9, -11);
            Debug.Log(tahtaObject.name);
        }

        //GameController controll = GameObject.Find("GameController").GetComponent<GameController>();
        //controll.GameStart();

        GameObject.Find("SahteOkey").tag = okeyObject.tag;
        GameObject.Find("SahteOkey").name = okeyObject.name;
        GameObject.Find("SahteOkey (1)").tag = okeyObject.tag;
        GameObject.Find("SahteOkey (1)").name = okeyObject.name;

        okeyObject.name = "Okey";
        okeyObject.tag = "Okey";
        okeyObject2.name = "Okey (1)";
        okeyObject2.tag = "Okey";

        TasCek.randomNumbers = randomNumbers;
        TasCek.remainingAll = remainingAll;

        Destroy(gameObject);
    }

    GameObject[] FindGameObjectsWithTags(params string[] tags)
    {
        var all = new List<GameObject>();

        foreach (string tag in tags)
        {
            var temp = GameObject.FindGameObjectsWithTag(tag).ToList();
            all = all.Concat(temp).ToList();
        }

        return all.ToArray();
    }
}