using UnityEngine;

public class resetView : MonoBehaviour {
    public Transform resetTransform;
    public GameObject player;
    public Camera playerHead;
    
    [ContextMenu("Reset View")]
    public void ResetView() {
        var rotationAngleY = resetTransform.rotation.eulerAngles.y - playerHead.transform.rotation.eulerAngles.y;
        player.transform.Rotate(0, rotationAngleY, 0);

        var distanceDiff = resetTransform.position - playerHead.transform.position;
        player.transform.position += distanceDiff;
    }
}
