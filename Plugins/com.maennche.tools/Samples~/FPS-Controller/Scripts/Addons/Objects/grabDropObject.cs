using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabDropObject : MonoBehaviour
{
    private Rigidbody rb;
    private Transform grabPoint;

    private void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    public void Grab(Transform objectGrabPoint){
        this.grabPoint = objectGrabPoint;
        rb.useGravity = false;
    }

    public void Drop(){
        this.grabPoint = null;
        rb.useGravity = true;
    }

    private void FixedUpdate(){
        if(grabPoint != null){
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, grabPoint.position, Time.deltaTime * lerpSpeed);
            rb.MovePosition(newPosition);
        }
    }
}
