using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerMainMenu : MonoBehaviour
{
    public Sound[] mySounds;

    void Awake()
    {
        foreach (Sound s in mySounds)
        {
            s.mySource = gameObject.AddComponent<AudioSource>();
            s.mySource.clip = s.myClip;

            s.mySource.volume = s.myVolume;
            s.mySource.pitch = s.myPitch;
            s.mySource.loop = s.myLoop;
        }
    }

    void Start()
    {
        Play("Main Menu");
    }

    public void Play(string myName)
    {
        Sound s = Array.Find(mySounds, sound => sound.name == myName);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.mySource.Play();
    }
}
