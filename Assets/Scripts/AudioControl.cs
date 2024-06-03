using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    
    AudioSource audioSource;

    [SerializeField]
    AudioClip[] audioClips;
    int i = 0;
    void Start()
    {
       audioSource = GetComponent<AudioSource>(); 
        audioSource.clip = audioClips[i];
    }

    public void PlayNextTrack()
    {
        if(i != audioClips.Length - 1)
        {
            i++;
        }
        else
        {
            i = 0;
        }
        ChangeTrack();

    }
    public void PlayPrevTrack()
    {
        if (i == 0)
        {
            i = audioClips.Length - 1;
        }
        else
        {
            i--;
        }
        ChangeTrack();
    }
    private void ChangeTrack()
    {
        audioSource.Stop();
        audioSource.clip = audioClips[i];
        audioSource.Play();
    }
}
