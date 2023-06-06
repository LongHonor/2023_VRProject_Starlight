using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEditor.UIElements;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    private static puzzle instance = null;
    public GameObject drawerTop;
    public GameObject Buildings;
    public Material lightOff;

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

    public void TurnOffLights(GameObject go)
    //��������� ������Ʈ����Ʈ�� Ž���Ͽ� ������ �����ϴ� �Լ�
    {
        List<GameObject> childObjects = new List<GameObject>();
        go.gameObject.GetChildGameObjects(childObjects);

        if (childObjects != null)
        {
            foreach (GameObject gochildren in childObjects)
            {
                Debug.Log(gochildren.gameObject.name);
                TurnOffLights(gochildren);
                if (gochildren.gameObject.tag == "bluelight") 
                    gochildren.gameObject.GetComponent<MeshRenderer>().material = lightOff;
            }
        }
    }
}
