using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class colorRandomizer : MonoBehaviour {

    public List<Color> colors;
    
    private void Start() {
        Material mat = GetComponent<MeshRenderer>().material;
        
        int rand = (int)Mathf.Round(Random.Range(0, colors.Count));
        Debug.Log(transform.name + ": " + rand);
        mat.color = colors[rand];

    }
}