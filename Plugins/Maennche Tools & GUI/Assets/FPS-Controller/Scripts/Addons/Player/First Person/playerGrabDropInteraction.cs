using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGrabDropInteraction : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private Transform objectGrabPoint;
    public LayerMask grabDropLayer;
    public float maxDistance = 2f;

    private grabDropObject grabbedObject;

    private void Update(){
        
        if(Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit, maxDistance, grabDropLayer)){
            
            if(!grabbedObject && hit.transform.TryGetComponent(out grabDropObject grabDropObj)){
                uiManager.self.ToggleInteractionPrompt(true, "Pick up");
            }
            else if(grabbedObject) {
                uiManager.self.ToggleInteractionPrompt(true, "Drop");
            }
            else {
                uiManager.self.ToggleInteractionPrompt(false);
            }
            if(player.self.playerInput.actions.FindAction("Interact").triggered){
                if(grabbedObject == null){
                    if(hit.transform.TryGetComponent(out grabDropObject grabDropObject)){
                        grabDropObject.Grab(objectGrabPoint);
                        grabbedObject = grabDropObject;
                    }
                }else{
                    grabbedObject.Drop();
                    grabbedObject = null;
                }
            }
        }
    }
}
