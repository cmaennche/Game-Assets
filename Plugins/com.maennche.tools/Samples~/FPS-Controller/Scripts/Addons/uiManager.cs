using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiManager : MonoBehaviour {
    public static uiManager self;

    public GameObject crosshair;
    public GameObject interactionPrompt;

    private void Awake() {
        self = this;
    }

    public void ToggleCrosshair(bool isOn = false) {
        crosshair.SetActive(isOn);
    }

    public void ToggleInteractionPrompt(bool isOn = false, string text = "") {
        if (isOn) {
            interactionPrompt.GetComponent<TextMeshProUGUI>().text = "E- " + text;
        }
        else {
            interactionPrompt.GetComponent<TextMeshProUGUI>().text = "";
        }
        interactionPrompt.SetActive(isOn);
    }
}
