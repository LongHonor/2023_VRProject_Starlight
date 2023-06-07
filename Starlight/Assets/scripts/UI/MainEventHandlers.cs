using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class MainEventHandlers : MonoBehaviour
{
    public GameObject uiManagerObject;
    public XRDeviceSimulator simulator;
    private UIActiveManager uiManager;
    private float[] originalSimulatgorTranslateSpeed = { 0, 0, 0 };

    private void Start()
    {
        uiManager = uiManagerObject.GetComponent<UIActiveManager>();
        originalSimulatgorTranslateSpeed[0] = simulator.keyboardXTranslateSpeed;
        originalSimulatgorTranslateSpeed[1] = simulator.keyboardYTranslateSpeed;
        originalSimulatgorTranslateSpeed[2] = simulator.keyboardZTranslateSpeed;
        simulator.keyboardXTranslateSpeed = 0;
        simulator.keyboardYTranslateSpeed = 0;
        simulator.keyboardZTranslateSpeed = 0;
    }

    public void StartButtonClickHandler()
    {
        uiManager.InactiveAllUiCanvas();
        simulator.keyboardXTranslateSpeed = originalSimulatgorTranslateSpeed[0];
        simulator.keyboardYTranslateSpeed = originalSimulatgorTranslateSpeed[1];
        simulator.keyboardZTranslateSpeed = originalSimulatgorTranslateSpeed[2];
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
