using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public GameObject socket;

    private static Color OriginalColorRed;
    private static Color OriginalColorBlue;
    private static Color OriginalColorYellow;

    public void MatChangeOn()
    {
        Material mymat = GetComponent<MeshRenderer>().sharedMaterial;
        
        //파랑색 미니어쳐가 소켓1에 장착된 경우
        if (socket.name == "miniature1_Socket" && gameObject.CompareTag("bluelight"))
        {
            mymat.SetColor("_EmissionColor", OriginalColorBlue);
            SocketManager.Instance.changeState("blueflag");
        }

        //노랑색 미니어쳐가 소켓2에 장착된 경우
        if (socket.name == "miniature2_Socket" && gameObject.CompareTag("yellowlight"))
        {
            mymat.SetColor("_EmissionColor", OriginalColorYellow);
            SocketManager.Instance.changeState("yellowflag");
        }

        //빨강색 미니어쳐가 소켓3에 장착된 경우 
        if (socket.name == "miniature3_Socket" && gameObject.CompareTag("redlight"))
        {
            mymat.SetColor("_EmissionColor", OriginalColorRed);
            SocketManager.Instance.changeState("redflag");
        }

    }
    public void MatChangeOff()
    {
        Material mymat = GetComponent<MeshRenderer>().sharedMaterial;

        //파랑색 미니어쳐가 소켓1에 장착된 경우
        if (socket.name == "miniature1_Socket" && gameObject.CompareTag("bluelight"))
        {
            OriginalColorBlue = mymat.GetColor("_EmissionColor");
            mymat.SetColor("_EmissionColor", Color.black);
            SocketManager.Instance.changeState("blueflag");
        }

        //노랑색 미니어쳐가 소켓2에 장착된 경우
        if (socket.name == "miniature2_Socket" && gameObject.CompareTag("yellowlight"))
        {
            OriginalColorYellow = mymat.GetColor("_EmissionColor");
            mymat.SetColor("_EmissionColor", Color.black);
            SocketManager.Instance.changeState("yellowflag");
        }

        //빨강색 미니어쳐가 소켓3에 장착된 경우 
        if (socket.name == "miniature3_Socket" && gameObject.CompareTag("redlight"))
        {
            OriginalColorRed = mymat.GetColor("_EmissionColor");
            mymat.SetColor("_EmissionColor", Color.black);
            SocketManager.Instance.changeState("redflag");
        }


    }
}
