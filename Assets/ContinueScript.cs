using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour
{
    public GameObject gameCamera;
    public static GameObject droppedTas;

    void OnMouseDown()
    {
        if (gameCamera.transform.position.x == 0.5)
        {
            Debug.Log("Player 1 to Player 2");
            gameCamera.transform.position = new Vector3(transform.position.x + 11.5f, transform.position.y, -10);
            droppedTas.transform.position = new Vector2(21, -7);
        }
        else if (gameCamera.transform.position.x == 20.5)
        {
            Debug.Log("Player 2 to Player 1");
            gameCamera.transform.position = new Vector3(transform.position.x + 11.5f, transform.position.y, -10);
            droppedTas.transform.position = new Vector2(41, -7);
        }
        else if (gameCamera.transform.position.x == 40.5)
        {
            Debug.Log("Player 3 to Player 4");
            gameCamera.transform.position = new Vector3(transform.position.x + 11.5f, transform.position.y, -10);
            droppedTas.transform.position = new Vector2(61, -7);
        }
        else if (gameCamera.transform.position.x == 60.5)
        {
            Debug.Log("Player 4 to Player 1");
            gameCamera.transform.position = new Vector3(transform.position.x - 68.5f, transform.position.y, -10);
            droppedTas.transform.position = new Vector2(1, -7);
        }
        Debug.Log("continue");
    }
}
