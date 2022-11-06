using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonMovement : MonoBehaviour
{
    [Header("Movement")]
    [Space]
    [Header("Speeds")]
    private float moveSpeed = 0f;
    [Space]
    public float walkSpeed = 7f;
    public float sprintSpeed = 12f;
    public float crouchSpeed = 5f;
    public float wallRunSpeed = 10f;
    

    [Header("Other")]
    public float groundDrag = 10;
    public float jumpForce = 12;
    public float jumpCooldown = 0.25f;
    public float airMultiplier = 0.4f;
    public bool isReadyToJump;


    [Header("Crouching")]
    public float crouchYScale;
    private float startYScale;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode crouchKey = KeyCode.C;
    

    [Header("Ground Check")]
    public float playerHeight = 2;
    private LayerMask groundMask;
    public bool isGrounded;

    [Header("Slope Handling")]
    public float maxSlopeAngle;
    private RaycastHit slopeHit;
    private bool exitingSlope;


    float horzontalInput;
    float verticalInput;
    Rigidbody rb;
    Vector3 moveDirection;

    public MovementState state;

    public enum MovementState{
        walking,
        sprinting,
        crouching,
        sliding,
        wallRunning,
        air
    }

    [Header("Is Action")]
    public bool isSliding;
    public bool isWallRunnning;

    void Start(){
        groundMask = player.self.groundMask;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        isReadyToJump = true;
        startYScale = transform.localScale.y;
    }

    void Update(){
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, groundMask);

        MyInput();
        SpeedControl();
        StateHandler();

        if(isGrounded){
            rb.drag = groundDrag;
        }else{
            rb.drag = 0;
        }
    }
    void FixedUpdate(){
        MovePlayer();
    }

    void MyInput(){
        horzontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(jumpKey) && isReadyToJump && isGrounded){
            isReadyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }


        // Start Crouching
        if(Input.GetKeyDown(crouchKey)){
            transform.localScale = new Vector3(transform.localScale.x, crouchYScale, transform.localScale.z);
            rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);
        }

        // Stop Crouching
        if(Input.GetKeyUp(crouchKey)){
            transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);
        }
    }

    private void StateHandler(){
        // Wall Running
        if(isWallRunnning){
            state = MovementState.wallRunning;
            moveSpeed = wallRunSpeed;
        }

        // Sliding
        if(isSliding){
            state = MovementState.sliding;
        }
        // Crounching
        else if(Input.GetKey(crouchKey)){
            state = MovementState.crouching;
            moveSpeed = crouchSpeed;
        }
        // Sprinting
        if(isGrounded && Input.GetKey(sprintKey)){
            state = MovementState.sprinting;
            moveSpeed = sprintSpeed;
        }
        // Walking
        else if(isGrounded){
            state = MovementState.walking;
            moveSpeed = walkSpeed;
        // Air
        } else {
            state = MovementState.air;
        }
    }

    void MovePlayer(){
        moveDirection = player.self.orientation.forward * verticalInput + player.self.orientation.right * horzontalInput;

        // On Slope
        if(OnSlope() && !exitingSlope){
            rb.AddForce(GetSlopeMoveDirection(moveDirection) * moveSpeed * 20f, ForceMode.Force);

            if(rb.velocity.y > 0){
                rb.AddForce(Vector3.down * 80f, ForceMode.Force);
            }
        }

        // On Ground
        if(isGrounded){
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        // In Air
        else if(!isGrounded){
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }

        if (!isWallRunnning){
            rb.useGravity = !OnSlope();
        }
    }

    void SpeedControl(){

        // Limiting speed on slopes
        if(OnSlope() && !exitingSlope){
            if(rb.velocity.magnitude > moveSpeed){
                rb.velocity = rb.velocity.normalized * moveSpeed;
            }
        }

        // Limiting speed on ground or in air
        else{
            Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

            // Limit velocity if needed
            if(flatVelocity.magnitude > moveSpeed){
                Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
                rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
            }
        }
    }

    void Jump(){
        exitingSlope = true;
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    void ResetJump(){
        isReadyToJump = true;
        exitingSlope = false;
    }

    public bool OnSlope(){
        if(Physics.Raycast(transform.position, Vector3.down, out slopeHit, playerHeight * 0.5f + 0.3f)){
            float angle = Vector3.Angle(Vector3.up, slopeHit.normal);
            return angle < maxSlopeAngle && angle != 0;
        }

        return false;
    }

    public Vector3 GetSlopeMoveDirection(Vector3 direction){
        return Vector3.ProjectOnPlane(direction, slopeHit.normal).normalized;
    }






}
