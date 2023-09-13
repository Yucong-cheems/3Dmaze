using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        
        audioSource.Play();
    }

    public void StopAudio()
    {
        
        audioSource.Stop();
    }

    public void PauseAudio()
    {
        
        audioSource.Pause();
    }

    public void UnPauseAudio()
    {
       
        audioSource.UnPause();
    }

}
