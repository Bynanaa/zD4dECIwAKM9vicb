using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpSounds : MonoBehaviour
{
    public AudioSource JumpSoundSource;
    public AudioClip JumpAudioClip;
    void PlayerFootstepSound()
    {
        Debug.Log("Player Jump");
        JumpSoundSource.PlayOneShot(JumpAudioClip);

    }

    // Start is called before the first frame update
    void Start()
    {
      JumpSoundSource = gameObject.AddComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void jumpUp()
    {
    JumpSoundSource.PlayOneShot(JumpAudioClip);
    Debug.Log("Player Jump");
    }

}

