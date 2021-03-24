using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController current;

    public AudioClip sfx;
    public AudioClip anotherSfx;
    public AudioClip bgm;

    private AudioSource audioSource;



    void Start()
    {
        current = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }


    
}
