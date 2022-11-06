using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class firstPersonCameraMovement : MonoBehaviour
{
    public float sensX;
    public float sensY;

    float xRotation;
    float yRotation;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update(){
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        player.self.camHolder.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        player.self.orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    public void DoFov(float endValue){
        GetComponent<Camera>().DOFieldOfView(endValue, 0.25f);
    }

    public void DoTilt(float zTilt){
        transform.DOLocalRotate(new Vector3(0, 0, zTilt), 0.25f);
    }
}
