using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver;
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
            isGameOver = SocketManager.Instance.GreenMatChange();
        }
        else
        {

        }
    }
}
