using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePrefabRandom : MonoBehaviour
{
    public AudioSource TreeRustleSource;
    public AudioClip TreeRustleClip;
    // Start is called before the first frame update
    void Start()
    {
        TreeRustleSource =gameObject.AddComponent<AudioSource>();
        TreeRustleSource.clip = TreeRustleClip;
        TreeRustleSource.loop = true;
        TreeRustleSource.volume = Random.Range(0.8f, 1.0f);
        TreeRustleSource.pitch = Random.Range(0.8f, 1.2f);
        TreeRustleSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}