using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class colorRandomizer : MonoBehaviour {
    private List<Color> colors;

    private void Awake() {
        // Black
        colors.Add(new Color(0, 0, 0));
        // White
        colors.Add(new Color(255, 255, 255));
        // Red
        colors.Add(new Color(255, 0, 0));
        // Green
        colors.Add(new Color(0, 255, 0));
        // Blue
        colors.Add(new Color(0, 0, 255));
        // Yellow
        colors.Add(new Color(255, 255, 0));
        // Orange
        colors.Add(new Color(255, 184, 0));
        // Cyan
        colors.Add(new Color(0, 255, 255));
        // Pink
        colors.Add(new Color(255, 0, 180));
        // Purple
        colors.Add(new Color(152, 0, 255));
    }

    private void Start() {
        Material mat = GetComponent<MeshRenderer>().material;

        int rand = (int)Mathf.Round(Random.Range(0, colors.Count));
        Debug.Log(transform.name + ": " + rand);
        mat.color = colors[rand];
    }
}