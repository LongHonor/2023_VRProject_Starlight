using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject uiManagerObject;
    private UIActiveManager uiManager;
    private bool isGameOver;
<<<<<<< HEAD
    public GameObject player;
=======
    private bool goToOutdoorFlag = false;

>>>>>>> bfcd0fdd24fc63d9c80e63ef6f5144ac48425433
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
            isGameOver = gameOver();
        }
        else
        {
            if (!goToOutdoorFlag)
            {
                goToOutdoorFlag = true;
                uiManager.SetCurrentUiCanvas(UiCanvas.GoToOutdoorCanvas);
        }
        return false;
    }
}
}
