using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject continueButton;
    void Start()
    {
        continueButton.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        continueButton.SetActive(true);
        ContinueScript.droppedTas = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        continueButton.SetActive(false);
    }
}
