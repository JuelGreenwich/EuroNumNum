using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {
        /*if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);*/

        foreach(Sound s in sounds)
        {
            s.soundSource = gameObject.AddComponent<AudioSource>();
            s.soundSource.clip = s.clip;

            s.soundSource.volume = s.volume;
            s.soundSource.pitch = s.pitch;
            s.soundSource.loop = s.loop;
        }
    }

    void Start()
    {
        PlayAudio("Theme");
    }

    public void PlayAudio (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.soundSource.Play();
    }
}
