using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps_script_xssr : MonoBehaviour
{
    public AudioSource footstepsAudioSource;
    public AudioClip[] FootstepsAudioClip;
    // Start is called before the first frame update
    void Start()
    {
        footstepsAudioSource = gameObject.AddComponent<AudioSource>();
       // footstersAudioSource.clip = FootstepsAudioClip;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
     void PlayerFootstepSound()
    {
        int clipIndex;
        clipIndex = Random.Range(0, 4);
        footstepsAudioSource.volume =Random.Range(0.8f, 1.0f);
        footstepsAudioSource.pitch = Random.Range(0.8f, 1.2f);
     
        footstepsAudioSource.PlayOneShot(FootstepsAudioClip[clipIndex]);
       Debug.Log("Шаг" + clipIndex +" "+ footstepsAudioSource.pitch);
    }
}
