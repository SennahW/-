using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]

public class Sound
{
    public string name;

    public AudioClip myClip;

    [Range(0f, 2f)]
    public float myVolume;
    [Range(0f, 3f)]
    public float myPitch;

    public bool myLoop;

    [HideInInspector]
    public AudioSource mySource;
}
