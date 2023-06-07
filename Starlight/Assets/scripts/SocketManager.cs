using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SocketManager : MonoBehaviour
{
    private static SocketManager instance = null;
    private bool blueFlag;
    private bool redFlag;
    private bool yellowFlag;
    private bool drawerFlag;

    public GameObject green;
    public AudioSource drawAudio;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static SocketManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    private void Start()
    {
        redFlag = false;
        blueFlag = false;
        yellowFlag = false;
        drawerFlag = false;
    }

    public void changeState(string name)
    {
        if (name == "blueflag")
        {
            blueFlag = !blueFlag;
        }
        else if (name == "redflag") redFlag = !redFlag;
        else yellowFlag = !yellowFlag;
    }

    public bool GreenMatChange()
    {
        if(redFlag &&  blueFlag && yellowFlag)
        {
            Material mymat = green.GetComponent<MeshRenderer>().sharedMaterial;
            mymat.SetColor("_EmissionColor", Color.black);
            return true;
        }

        return false;
    }

    public void CheckFlags()
    {
        Debug.Log("yellow" + yellowFlag + " " + "blue" + blueFlag);
        if(yellowFlag && blueFlag)
        {
            puzzle.Instance.OpenDrawer();
            drawAudio.Play();
            drawerFlag = true;
        }
    }

    public void Update()
    {
        if(!drawerFlag) CheckFlags();
    }
}
