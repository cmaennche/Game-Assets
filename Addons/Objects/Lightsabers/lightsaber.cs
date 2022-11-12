using System.Collections.Generic;
using UnityEngine;

public class lightsaber : MonoBehaviour {
    public List<ParticleSystem> blades;

    public bool isIgnited = false;
    private void Update() {

        if (isIgnited) {
            foreach (var blade in blades) {
                blade.Play();
            }
        }
        else {
            foreach (var blade in blades) {
                blade.Stop();
            }
        }
    }
}
