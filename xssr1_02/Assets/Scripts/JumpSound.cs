using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpSounds : MonoBehaviour
{

    AudioSource  JumpSoundPlayer;  

    // Start is called before the first frame update
    void Start()
    {
        JumpSoundPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("Player Jump");
    }
    private void PlayerFootstepSound()
    {
        JumpSoundPlayer.Play();
    }
}
