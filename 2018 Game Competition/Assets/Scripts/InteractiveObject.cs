using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour {

    // SerializeField means that it will show up in inspector

    [SerializeField] private Vector3 openPos, closedPos;

    [SerializeField] private float animTime;

    [SerializeField] private bool isOpen = false;

    private enum MovementType {Rotate, Slide};

    [SerializeField] private MovementType movementType;

    private Hashtable iTweenArgs;

	void Start () {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPos);
        iTweenArgs.Add("time", animTime);
        iTweenArgs.Add("islocal", true) ;
	}

    public void PerformAction() {
            if (isOpen) {
                iTweenArgs["position"] = closedPos;
                iTweenArgs["rotation"] = closedPos;
            } else {
                iTweenArgs["position"] = openPos;
                iTweenArgs["rotation"] = openPos;
               }

            isOpen = !isOpen; // Inverts the current position

            switch(movementType){
                // For rotating the object
                case MovementType.Rotate:
                    iTween.MoveTo(gameObject, iTweenArgs);
                    break;
                // For sliding the object
                case MovementType.Slide:
                    iTween.RotateTo(gameObject, iTweenArgs);
                    break;
            }

     }
}
