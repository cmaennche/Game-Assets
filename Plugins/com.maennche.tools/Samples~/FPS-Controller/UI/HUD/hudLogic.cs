using System.Collections;
using System.Collections.Generic;
using Noesis;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Canvas = Noesis.Canvas;

public class hudLogic : MonoBehaviour {

    public GameObject lobbyMenuCamera;
    public FrameworkElement gui;

    void Start() {
        gui = GetComponent<NoesisView>().Content;
        Viewbox vb = (Viewbox)gui.FindName("viewBox");
        vb.Height = GetComponent<Camera>().pixelHeight;
        vb.Width = GetComponent<Camera>().pixelWidth;

        Button leaveButton = (Button)gui.FindName("leaveButton");
        if (SceneManager.GetActiveScene().name == "game_unnetworked") {
            Canvas np = (Canvas)gui.FindName("networkedPanel");
            np.Visibility = Visibility.Hidden;
            leaveButton.Visibility = Visibility.Hidden;
        }
        else {
            leaveButton.Click += leaveButtonOnClick;
        }
        
    }
    
    private void leaveButtonOnClick(object sender, RoutedEventArgs e) {
        
    }
}
