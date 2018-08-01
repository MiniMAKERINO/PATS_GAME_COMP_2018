using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimeControl : MonoBehaviour
{

    public Animator anim;
    AudioSource audio;

    private void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("DoggoAnimation");
        audio.Play();
    }
}
