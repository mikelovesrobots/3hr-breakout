using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static AudioPlayer instance;
    public AudioSource[] blockAudioSources;
    public AudioSource paddleAudioSource;
    public AudioSource wallAudioSource;
    public AudioSource loseAudioSource;

    void Awake()
    {
        instance = this;
    }

    public void PlayBlockSound(int blockLevel)
    {
        blockAudioSources[blockLevel - 1].Play();
    }

    public void PlayPaddleSound()
    {
        paddleAudioSource.Play();
    }

    public void PlayWallSound()
    {
        wallAudioSource.Play();
    }

    public void PlayLoseSound()
    {
        loseAudioSource.Play();
    }
}
