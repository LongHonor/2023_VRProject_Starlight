using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControlEventHandlers : MonoBehaviour
{
    public GameObject uiManagerObject;
    private UIActiveManager uiManager;

    private void Start()
    {
        uiManager = uiManagerObject.GetComponent<UIActiveManager>();
    }

    public void BackButtonClickHandler()
    {
        uiManager.SetCurrentUiCanvas(UiCanvas.MainCanvas);
    }
}
