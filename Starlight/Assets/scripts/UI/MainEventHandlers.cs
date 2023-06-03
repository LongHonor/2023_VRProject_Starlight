using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEventHandlers : MonoBehaviour
{
    public GameObject uiManagerObject;
    private UIActiveManager uiManager;

    private void Start()
    {
        uiManager = uiManagerObject.GetComponent<UIActiveManager>();
    }

    public void StartButtonClickHandler()
    {
        uiManager.InactiveAllUiCanvas();
    }

    public void DescriptionButtonClickHandler()
    {
        uiManager.SetCurrentUiCanvas(UiCanvas.DescriptionCanvas);
    }

    public void VolumeControlButtonClickHandler()
    {
        uiManager.SetCurrentUiCanvas(UiCanvas.VolumeControlCanvas);
    }

}
