using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAud : MonoBehaviour {

    AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
    }
}
