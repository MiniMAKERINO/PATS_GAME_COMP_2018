using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour {

    public GameObject TPobject;
    public GameObject TPLocation;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") ;
        {
            TPobject.transform.position = TPLocation.transform.position;
        }
    }
}
