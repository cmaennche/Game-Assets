using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class lightsaberManager : MonoBehaviour {
    public GameObject holdingLeft = null;
    public GameObject holdingRight = null;

    // public InputActionManager InputActionManager;
    
    private void Update() {
        if (holdingLeft != null) {
            
            // if (InputActionManager.actionAssets[0].FindAction("LeftIgnite").inProgress) {
            //     holdingLeft.GetComponent<lightsaber>().isIgnited = true;
            // }
            // else {
            //     holdingLeft.GetComponent<lightsaber>().isIgnited = false;
            // }
        }
        
        if (holdingRight != null) {
            // if (InputActionManager.actionAssets[0].FindAction("RightIgnite").inProgress) {
            //     holdingRight.GetComponent<lightsaber>().isIgnited = true;
            // }
            // else {
            //     holdingRight.GetComponent<lightsaber>().isIgnited = false;
            // }
        }
    }

    // public void SetHoldingLeft(SelectEnterEventArgs args) {
    //     holdingLeft = args.interactableObject.transform.gameObject;
    // }
    //
    // public void SetHoldingRight(SelectEnterEventArgs args) {
    //     holdingRight = args.interactableObject.transform.gameObject;
    // }
    //
    // public void ClearHoldingLeft(SelectExitEventArgs args) {
    //     holdingLeft = null;
    // }
    //
    // public void ClearHoldingRight(SelectExitEventArgs args) {
    //     holdingRight = null;
    // }
}
