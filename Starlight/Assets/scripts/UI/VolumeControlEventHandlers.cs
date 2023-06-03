using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControlEventHandlers : MonoBehaviour
{
    public GameObject uiManagerObject;
    public GameObject audioManagerObject;
    private UIActiveManager uiManager;
    private AudioManager audioManager;

    public Slider BgmSlider;
    public Slider SfxSlider;

    private void Start()
    {
        uiManager = uiManagerObject.GetComponent<UIActiveManager>();
        audioManager = audioManagerObject.GetComponent<AudioManager>();
    }

    public void BackButtonClickHandler()
    {
        uiManager.SetCurrentUiCanvas(UiCanvas.MainCanvas);
    }

    public void SetBgmVolume()
    {
        audioManager.SetBgmVolume(BgmSlider.value);
    }

    public void SetSfxVolume()
    {
        audioManager.SetSfxVolume(SfxSlider.value);
    }
}
