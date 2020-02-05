using System;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Manager : MonoBehaviour
{
    public Sound[] mySounds;

    public static Audio_Manager myInstance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if(myInstance == null)
        {
            myInstance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
            

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
        Play("Theme");
    }

    public void Play (string myName)
    {
        Sound s = Array.Find(mySounds, sound => sound.name == myName);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        if(PauseMenu.GameIsPaused)
        {
            s.mySource.pitch *= .5f;
        }
        s.mySource.Play();
    }

}
