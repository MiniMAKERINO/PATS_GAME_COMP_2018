using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour {

    [SerializeField] private Vector3 openPos, closedPos;

    [SerializeField] private float animTime;

    [SerializeField] private bool isOpen = false;

    private Hashtable iTweenArgs;

	void Start () {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPos);
        iTweenArgs.Add("time", animTime);
        iTweenArgs.Add("islocal", true) ;
	}

    public void PerformAction() {
        {
            if (isOpen) {
                iTweenArgs["position"] = closedPos;
            } else {
                iTweenArgs["position"] = openPos;
            }

            isOpen = !isOpen;

            iTween.MoveTo(gameObject, iTweenArgs);
        }
    }
}
