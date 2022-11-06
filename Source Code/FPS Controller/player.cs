using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static player self;

    public new Transform camera;
    public new Transform playerObj;
    public new Transform camHolder;
    public Transform orientation;
    public LayerMask groundMask;

    public firstPersonCameraMovement cameraMovement;

    void Awake(){
        self = this;
    }
}
