using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIActiveManager : MonoBehaviour
{
    private static UIActiveManager _instance;
    public static UIActiveManager Instance { get { return _instance; } }

    public GameObject mainCanvas;
    public GameObject descriptionCanvas;
    public GameObject volumeControlCanvas;

    private UiCanvas currentCanvas;

    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public void SetCurrentUiCanvas(UiCanvas uiCanvas)
    {
        currentCanvas = uiCanvas;

        InactiveAllUiCanvas();

        if (currentCanvas == UiCanvas.MainCanvas)
        {
            mainCanvas.SetActive(true);
        }
        else if (currentCanvas == UiCanvas.DescriptionCanvas)
        {
            descriptionCanvas.SetActive(true);
        }
        else if (currentCanvas == UiCanvas.VolumeControlCanvas)
        {
            volumeControlCanvas.SetActive(true);
        }
    }

    public void InactiveAllUiCanvas()
    {
        mainCanvas.SetActive(false);
        descriptionCanvas.SetActive(false);
        volumeControlCanvas.SetActive(false);
    }
}

public enum UiCanvas
{
    MainCanvas,
    DescriptionCanvas,
    VolumeControlCanvas,
}