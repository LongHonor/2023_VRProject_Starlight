using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Material dayMat;
    public Material nightMat;
    public GameObject dayLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.7f);
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 80, 20), "Day"))
        {
            RenderSettings.skybox = dayMat;
            dayLight.SetActive(true);

        }
        if (GUI.Button(new Rect(5, 35, 80, 20), "Night"))
        {
            RenderSettings.skybox = nightMat;
            dayLight.SetActive(false);

        }
    }
}
