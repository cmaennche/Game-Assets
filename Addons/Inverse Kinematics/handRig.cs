using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class handRig : MonoBehaviour {
    public GameObject followObject;
    public float followSpeed = 30;
    public float rotateSpeed = 100;
    public Vector3 positionOffset;
    public Vector3 rotationOffset;
    private Transform followTarget;
    private Rigidbody body;

    private void Start() {
        followTarget = followObject.transform;
        body = GetComponent<Rigidbody>();
        body.collisionDetectionMode = CollisionDetectionMode.Continuous;
        body.interpolation = RigidbodyInterpolation.Interpolate;
        body.mass = 20f;

        body.position = followTarget.position;
        body.rotation = followTarget.rotation;
    }

    private void Update() {
        PhysicsMove();
    }

    void PhysicsMove() {
        var positionWishOffset = followTarget.TransformPoint(positionOffset);
        var distance = Vector3.Distance(positionWishOffset, transform.position);
        body.velocity = (positionWishOffset - transform.position).normalized * (followSpeed * distance);

        var rotationWishOffset = followTarget.rotation * Quaternion.Euler(rotationOffset);
        var quaternion = rotationWishOffset * Quaternion.Inverse(body.rotation);
        quaternion.ToAngleAxis(out float angle, out Vector3 axis);
        body.angularVelocity = axis * (angle * Mathf.Deg2Rad * rotateSpeed);
    }
}
