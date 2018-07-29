using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

    [SerializeField] private float interactRange;
    
    private InteractiveObject objInteract;
    private Camera cam;
    private RaycastHit hit;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
            if (hit.transform) {
                objInteract = hit.transform.GetComponent<InteractiveObject>();
            }

            if (objInteract)
            {
                objInteract.PerformAction();
            }
        }
	}
}
