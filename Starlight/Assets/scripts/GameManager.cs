using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject uiManagerObject;
    private UIActiveManager uiManager;
    private bool isGameOver;
    public GameObject player;

    private bool goToOutdoorFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = uiManagerObject.GetComponent<UIActiveManager>();
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!isGameOver) Debug.Log(isGameOver);
        if (!isGameOver)
        {
            Debug.Log(isGameOver);
            isGameOver = gameOver();
        }
        else
        {
            if (!goToOutdoorFlag)
            {
                goToOutdoorFlag = true;
                uiManager.SetCurrentUiCanvas(UiCanvas.GoToOutdoorCanvas);
            }
        }
    }

    private bool gameOver()
    {
        return SocketManager.Instance.GreenMatChange();
    }
}
