using System;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Manager : MonoBehaviour
{
    public Sound[] mySounds;

    public static Audio_Manager myInstance;
    
    void Awake()
    {
        if(myInstance == null)
        {
            myInstance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

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

    void Update()
    {
        if (CostumerSpawning.CurrentCostumers > 6)
        {
            for (int i = 0; i < mySounds.Length; i++)
            {
                GetComponent<AudioSource>().pitch = 1.5f;
            }
        }
        if (CostumerSpawning.CurrentCostumers == 5)
        {
            for (int i = 0; i < mySounds.Length; i++)
            {
                GetComponent<AudioSource>().pitch = 1.4f;
            }
        }
        if (CostumerSpawning.CurrentCostumers == 4)
        {
            for (int i = 0; i < mySounds.Length; i++)
            {
                GetComponent<AudioSource>().pitch = 1.3f;
            }
        }
        if (CostumerSpawning.CurrentCostumers == 3)
        {
            for (int i = 0; i < mySounds.Length; i++)
            {
                GetComponent<AudioSource>().pitch = 1.2f;
            }
        }
        if (CostumerSpawning.CurrentCostumers == 2)
        {
            for (int i = 0; i < mySounds.Length; i++)
            {
                GetComponent<AudioSource>().pitch = 1.1f;
            }
        }
        if (CostumerSpawning.CurrentCostumers == 1)
        {
            for (int i = 0; i < mySounds.Length; i++)
            {
                GetComponent<AudioSource>().pitch = 1f;
            }
        }
    }

    public void Play (string myName)
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
