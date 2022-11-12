using System;
using UnityEngine;

public class foot : MonoBehaviour {
    public LayerMask terrainLayer;
    public Transform body;
    public foot otherFoot;
    public float speed = 5, stepDistance = .3f, stepLength = .3f, stepHeight = .3f;
    public Vector3 footPositionOffset, footRotationOffset;

    private float footSpacing, lerp;
    private Vector3 oldPosition, currentPosition, newPosition;
    private Vector3 oldNormal, currentNormal, newNormal;
    private bool isFirstStep = true;

    void Start() {
        footSpacing = transform.localPosition.x;
        currentPosition = newPosition = oldPosition = transform.position;
        currentNormal = newNormal = oldNormal = transform.up;
        lerp = 1;
    }

    void Update() {
        transform.position = currentPosition + footPositionOffset;
        transform.rotation = Quaternion.LookRotation(currentNormal) * Quaternion.Euler(footRotationOffset);

        Ray ray = new Ray(body.position + (body.right * footSpacing) + (Vector3.up * 2), Vector3.down);

        if (Physics.Raycast(ray, out RaycastHit hit, 10f, terrainLayer.value)) {
            if (isFirstStep || (Vector3.Distance(newPosition, hit.point) > stepDistance && !otherFoot.IsMoving() && !IsMoving())) {
                lerp = 0;
                int direction = body.InverseTransformPoint(hit.point).z > body.InverseTransformPoint(newPosition).z ? 1:-1;
                newPosition = hit.point + (body.forward * (direction * stepLength));
                newNormal = hit.normal;
            }
        }

        if (lerp < 1) {
            Vector3 tempPosition = Vector3.Lerp(oldPosition, newPosition, lerp);
            tempPosition.y += Mathf.Sin(lerp * Mathf.PI) * stepHeight;

            currentPosition = tempPosition;
            currentNormal = Vector3.Lerp(oldNormal, newNormal, lerp);
            lerp += Time.deltaTime * speed;
        }
        else {
            oldPosition = newPosition;
            oldNormal = newNormal;
        }
    }

    public bool IsMoving() {
        return lerp < 1;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(newPosition, 0.1f);
    }
}
