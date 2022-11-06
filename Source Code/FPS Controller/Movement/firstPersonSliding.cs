using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonSliding : MonoBehaviour{
    private Transform orientation;
    private Transform playerObj;
    private Rigidbody rb;
    private firstPersonMovement pm;

    [Header("Sliding")]
    public float maxSlideTime = 0.75f;
    public float slideForce = 200f;
    private float slideTimer;

    public float slideYScale = 0.5f;
    private float startYScale;

    [Header("Input")]
    public KeyCode slideKey = KeyCode.LeftControl;
    private float horizontalInput;
    private float verticalInput;

    private void Start(){
        orientation = player.self.orientation;
        playerObj = player.self.playerObj;
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<firstPersonMovement>();
        startYScale = playerObj.localScale.y;
    }

    private void Update(){
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(slideKey) && (horizontalInput != 0 || verticalInput != 0)){
            StartSliding();
        }

        if(Input.GetKeyUp(slideKey) && pm.isSliding){
            StopSliding();
        }
    }

    private void FixedUpdate(){
        if(pm.isSliding){
            SlidingMovement();
        }
    }

    private void StartSliding(){
        pm.isSliding = true;
        playerObj.localScale = new Vector3(playerObj.localScale.x, slideYScale, playerObj.localScale.z);
        rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);

        slideTimer = maxSlideTime;
    }

    private void SlidingMovement(){
        Vector3 inputDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        // Normal Sliding
        if(!pm.OnSlope() || rb.velocity.y > -0.1f){
            rb.AddForce(inputDirection.normalized * slideForce, ForceMode.Force);
            slideTimer -= Time.deltaTime;
        }
        // Sliding on a Slope
        else{
            rb.AddForce(pm.GetSlopeMoveDirection(inputDirection) * slideForce, ForceMode.Force);
        }

        if(slideTimer <= 0){
            StopSliding();
        }
    }

    private void StopSliding(){
        pm.isSliding = false;
        playerObj.localScale = new Vector3(playerObj.localScale.x, startYScale, playerObj.localScale.z);
    }
}