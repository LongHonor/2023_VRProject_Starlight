using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mainAudioMixer;
    private float maxVolumnValue = 1;
    private float minVolumnValue = 0.001f;

    public void SetMainVolume(float value)
    {
        value = Mathf.Clamp(value, minVolumnValue, maxVolumnValue);
        mainAudioMixer.SetFloat("MainVolume", Mathf.Log10(value) * 20);
    }

    public void SetBgmVolume(float value)
    {
        value = Mathf.Clamp(value, minVolumnValue, maxVolumnValue);
        mainAudioMixer.SetFloat("BgmVolume", Mathf.Log10(value) * 20);
    }

    public void SetSfxVolume(float value)
    {
        value = Mathf.Clamp(value, minVolumnValue, maxVolumnValue);
        mainAudioMixer.SetFloat("SfxVolume", Mathf.Log10(value) * 20);
    }
}
