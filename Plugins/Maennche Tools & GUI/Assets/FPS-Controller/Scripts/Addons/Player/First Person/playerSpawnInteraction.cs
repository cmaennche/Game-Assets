using System;
using System.Collections.Generic;
using Noesis;
using UnityEngine;
using Transform = UnityEngine.Transform;

public class playerSpawnInteraction : MonoBehaviour
{
    public Transform spawnPoint;
    public int spawnModeIndex = 1;

    [Header("References")]
    public List<spawnMode> spawnModes;

    private grabDropObject grabbedObject;

    private void Update(){
        Label spawnModeLabel = (Label)player.self.cam.GetComponent<NoesisView>().Content.FindName("spawnModeLabel");
        spawnModeLabel.Content = spawnModeIndex;
        if (player.self.playerInput.actions.FindAction("ChangeSpawnMode").ReadValue<Vector2>().y < 0) {
            if (spawnModeIndex == spawnModes.Count) {
                spawnModeIndex = 1;
            }
            else {
                spawnModeIndex++;
            }
        }else if (player.self.playerInput.actions.FindAction("ChangeSpawnMode").ReadValue<Vector2>().y > 0) {
            if (spawnModeIndex == 1) {
                spawnModeIndex = spawnModes.Count;
            }
            else {
                spawnModeIndex--;
            }
        }
        
        if(player.self.playerInput.actions.FindAction("Interact").triggered){
            GameObject obj = Instantiate(spawnModes[spawnModeIndex-1].prefab, spawnPoint.position, Quaternion.identity);
        }
        
    }
    
    [Serializable]
    public struct spawnMode {
        public string name;
        public GameObject prefab;
    }
}