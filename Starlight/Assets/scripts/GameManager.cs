using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private static GameManger instance == null;

    public MiniatureManager miniature;
    public bool isGameOver;

    private void awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad();
        }
        else
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onClickStartButton()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) ;
    }
}
