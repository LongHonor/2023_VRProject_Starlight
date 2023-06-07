using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!isGameOver) Debug.Log(isGameOver);
        if (!isGameOver)
        {
            isGameOver = gameOver();
        }
        else
        {

        }
    }

    private bool gameOver()
    {
        if (SocketManager.Instance.GreenMatChange())
        //if(true)
        {
            player.transform.localPosition = Vector3.zero;
            player.transform.position = new Vector3(-150, 73, 200);
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
            player.transform.rotation = Quaternion.Euler(0, -45f, 0);
            return true;
        }
        return false;
    }
}
