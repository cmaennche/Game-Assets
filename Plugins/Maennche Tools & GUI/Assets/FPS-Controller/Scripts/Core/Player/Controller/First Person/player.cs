using Noesis;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Cursor = UnityEngine.Cursor;
using Transform = UnityEngine.Transform;

public class player : MonoBehaviour
{
    public static player self;

    public playerMode mode = playerMode.Interact;

    public new Transform camera;
    public Camera cam;
    public Transform playerObj;
    public Transform camHolder;
    public Transform orientation;
    public LayerMask groundMask;
    public PlayerInput playerInput;

    public firstPersonCameraMovement cameraMovement;
    public firstPersonMovement playerMovement;

    void Awake(){
        self = this;
        playerMovement = GetComponent<firstPersonMovement>();
    }

    private void Update() {
        if (playerInput.actions.FindAction("Pause").triggered) {
            cameraMovement.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            playerMovement.enabled = false;
        }

        Border spawnModeBorder = (Border)cam.GetComponent<NoesisView>().Content.FindName("spawnMode");
        if (playerInput.actions.FindAction("SwitchMode").triggered) {
            if (mode == playerMode.Grab) {
                mode = playerMode.Spawn;
                
            }else if (mode == playerMode.Spawn) {
                mode = playerMode.Interact;


            }else if (mode == playerMode.Interact) {
                mode = playerMode.Grab;
            }
        }

        Image grabIcon = (Image)cam.GetComponent<NoesisView>().Content.FindName("grabIcon");
        Image interactIcon = (Image)cam.GetComponent<NoesisView>().Content.FindName("interactIcon");
        Image spawnIcon = (Image)cam.GetComponent<NoesisView>().Content.FindName("spawnIcon");
        if (mode == playerMode.Grab) {
            GetComponent<playerSpawnInteraction>().enabled = false;
            GetComponent<playerGrabDropInteraction>().enabled = true;
            grabIcon.Visibility = Visibility.Visible;
            interactIcon.Visibility = Visibility.Hidden;
            spawnIcon.Visibility = Visibility.Hidden;
            spawnModeBorder.Visibility = Visibility.Hidden;
        }
        else if (mode == playerMode.Spawn) {
            GetComponent<playerSpawnInteraction>().enabled = true;
            GetComponent<playerGrabDropInteraction>().enabled = false;
            spawnModeBorder.Visibility = Visibility.Visible;
            grabIcon.Visibility = Visibility.Hidden;
            interactIcon.Visibility = Visibility.Hidden;
            spawnIcon.Visibility = Visibility.Visible;
        }else if (mode == playerMode.Interact) {
            GetComponent<playerSpawnInteraction>().enabled = false;
            GetComponent<playerGrabDropInteraction>().enabled = false;
            spawnModeBorder.Visibility = Visibility.Hidden;
            grabIcon.Visibility = Visibility.Hidden;
            interactIcon.Visibility = Visibility.Visible;
            spawnIcon.Visibility = Visibility.Hidden;
        }
    }
}

public enum playerMode {
    Interact,
    Grab,
    Spawn
}