using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToOutdoorEventHandlers : MonoBehaviour
{
    public GameObject uiManagerObject;
    private UIActiveManager uiManager;
    public GameObject player;
    public Material nightMat;

    private void Start()
    {
        uiManager = uiManagerObject.GetComponent<UIActiveManager>();
    }

    public void ConfirmButtonClickHandler()
    {
        player.transform.localPosition = Vector3.zero;
        player.transform.position = new Vector3(-140, 73, 210);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, -45f, 0);
        RenderSettings.skybox = nightMat;
        uiManager.InactiveAllUiCanvas();
    }
}
