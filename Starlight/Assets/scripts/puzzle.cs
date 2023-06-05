using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    private static puzzle instance = null;
    public GameObject drawerTop;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject );
        }
    }

    public static puzzle Instance
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
    // Start is called before the first frame update
    public void OpenDrawer()
    {
        drawerTop.GetComponent<Transform>().Translate(0, 0, 0.8f);
    }
}
