using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonWallRunning : MonoBehaviour{
    [Header("Wallrunning")]
    public LayerMask wallMask;
    private LayerMask groundMask;
    public float wallRunForce;
    public float wallJumpUpForce;
    public float wallJumpSideForce;
    public float wallClimbSpeed;
    public float maxWallRunTime;
    private float wallRunTimer;

    [Header("Input")]
    public KeyCode upwardsRunKey = KeyCode.LeftShift;
    public KeyCode downwardsRunKey = KeyCode.LeftControl;
    private bool upwardsRunning;
    private bool downwardsRunning;
    private float horizontalInput;
    private float verticalInput;

    [Header("Detection")]
    public float wallCheckDistance;
    public float minJumpHeight;
    private RaycastHit leftWallHit;
    private RaycastHit rightWallHit;
    private bool wallLeft;
    private bool wallRight;


    [Header("Exiting")]
    private bool exitingWall;
    public float exitWallTime;
    private float exitWallTimer;

    [Header("Gravity")]
    public bool useGravity;
    public float gravityCounterForce;

    [Header("References")]
    private Transform orientation;
    private firstPersonMovement pm;
    private Rigidbody rb;


    private void Start(){
        groundMask = player.self.groundMask;
        orientation = player.self.orientation;
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<firstPersonMovement>();
    }

    private void Update(){
        CheckForWall();
        StateMachine();
    }

    private void FixedUpdate(){
        if(pm.isWallRunnning){
            WallRunningMovement();
        }
    }

    private void CheckForWall(){
        wallRight = Physics.Raycast(transform.position, orientation.right, out rightWallHit, wallCheckDistance, wallMask);
        wallLeft = Physics.Raycast(transform.position, -orientation.right, out leftWallHit, wallCheckDistance, wallMask);
    }

    private bool AboveGround(){
        return !Physics.Raycast(transform.position, Vector3.down, minJumpHeight, groundMask);
    }

    private void StateMachine(){
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        upwardsRunning = Input.GetKey(upwardsRunKey);
        downwardsRunning = Input.GetKey(downwardsRunKey);

        // State 1 - Wall Running
        if((wallLeft || wallRight) && verticalInput > 0 && AboveGround() && !exitingWall){
            if(!pm.isWallRunnning){
                StartWallRunning();
            }

            if(wallRunTimer > 0){
                wallRunTimer -= Time.deltaTime;
            }

            if(wallRunTimer <= 0 && pm.isWallRunnning){
                exitingWall = true;
                exitWallTimer = exitWallTime;
            }

            if(Input.GetKeyDown(pm.jumpKey)){
                WallJump();
            }
        }

        // State 2 - Exiting
        else if(exitingWall){
            if(pm.isWallRunnning){
                StopWallRunning();
            }
            if(exitWallTimer > 0){
                exitWallTimer -= Time.deltaTime;
            }
            if(exitWallTimer <= 0){
                exitingWall = false;
            }
        }

        // State 3 - None
        else{
            if(pm.isWallRunnning){
                StopWallRunning();
            }
        }
    }

    private void StartWallRunning(){
        pm.isWallRunnning = true;

        wallRunTimer = maxWallRunTime;
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // Camera Effects
        player.self.cameraMovement.DoFov(90f);
        if(wallLeft){
            player.self.cameraMovement.DoTilt(-5f);
        }
        if(wallRight){
            player.self.cameraMovement.DoTilt(5f);
        }
    }

    private void WallRunningMovement(){
        rb.useGravity = useGravity;

        Vector3 wallNormal = wallRight ? rightWallHit.normal : leftWallHit.normal;
        Vector3 wallForward = Vector3.Cross(wallNormal, transform.up);

        if((orientation.forward - wallForward).magnitude > (orientation.forward - -wallForward).magnitude){
            wallForward = -wallForward;
        }

        rb.AddForce(wallForward * wallRunForce, ForceMode.Force);

        if(upwardsRunning){
            rb.velocity = new Vector3(rb.velocity.x, wallClimbSpeed, rb.velocity.z);
        }
        if(downwardsRunning){
            rb.velocity = new Vector3(rb.velocity.x, -wallClimbSpeed, rb.velocity.z);
        }

        if(!(wallLeft && horizontalInput > 0) && !(wallRight && horizontalInput < 0)){
            rb.AddForce(-wallNormal * 100, ForceMode.Force);
        }

        if(useGravity){
            rb.AddForce(transform.up * gravityCounterForce, ForceMode.Force);
        }
    }

    private void StopWallRunning(){
        pm.isWallRunnning = false;

        // Reset Camera Effects
        player.self.cameraMovement.DoFov(80f);
        player.self.cameraMovement.DoTilt(0f);
    }

    private void WallJump(){

        exitingWall = true;
        exitWallTimer = exitWallTime;

        Vector3 wallNormal = wallRight ? rightWallHit.normal : leftWallHit.normal;

        Vector3 forceToApply = transform.up * wallJumpUpForce + wallNormal * wallJumpSideForce;

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(forceToApply, ForceMode.Impulse);
    }
}