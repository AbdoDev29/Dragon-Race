using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sound;
   

    private void Start()
    {
        foreach(Sound s in sound)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.loop = s.loop;
            s.audioSource.clip = s.audioClip;
            s.audioSource.volume = s.volume;
        }
    }

    public void PlaySound(string name)
    {
     

            foreach (Sound s in sound)
            {
                if (s.name == name)
                    s.audioSource.Play();
                else
                    s.audioSource.Stop();
            }
       
    }

}
