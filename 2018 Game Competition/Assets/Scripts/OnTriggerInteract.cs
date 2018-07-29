using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerInteract : MonoBehaviour {
    public GameObject guiObject;


	// Use this for initialization
	void Start () {
        guiObject.SetActive(false);
	}

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MainCamera") {
            guiObject.SetActive(true);
        }
    }
    private void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }

}
