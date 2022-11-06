using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCameraHolder : MonoBehaviour
{
    void Update(){
        transform.position = player.self.camera.position;
    }
}
