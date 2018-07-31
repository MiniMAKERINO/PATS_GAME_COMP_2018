using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour {

    public Component DoorHere;
    public GameObject ToEnable;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayDelayed(120.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            ToEnable.SetActive(true);
            DoorHere.GetComponent<InteractiveObject>().enabled = true;
            Destroy(gameObject);
        }

    }
}
