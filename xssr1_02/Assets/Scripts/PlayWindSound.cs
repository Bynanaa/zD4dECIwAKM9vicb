using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWindSound : MonoBehaviour
{
    public AudioSource WindAudioSource;
    public AudioClip WindAudioClip;
    // Start is called before the first frame update
    void Start()
    {
        WindAudioSource =gameObject.AddComponent<AudioSource>();
        WindAudioSource.clip = WindAudioClip;
        WindAudioSource.loop = true;
        WindAudioSource.volume = 0.13F;
        WindAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
