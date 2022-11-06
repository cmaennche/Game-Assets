using System.Collections;
using System.Collections.Generic;
using Noesis;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class mainMenuLogic : MonoBehaviour {
    void Start() {
        FrameworkElement gui = GetComponent<NoesisView>().Content;
        Viewbox vb = (Viewbox)gui.FindName("viewBox");
        vb.Height = GetComponent<Camera>().pixelHeight;
        vb.Width = GetComponent<Camera>().pixelWidth;

        Button playButton = (Button)gui.FindName("playButton");
        playButton.Click += playButtonOnClick;
        
        Button quitButton = (Button)gui.FindName("quitButton");
        quitButton.Click += quitButtonOnClick;
    }

    private void playButtonOnClick(object sender, RoutedEventArgs e) {
        FrameworkElement gui = GetComponent<NoesisView>().Content;
        Label connectingLabel = (Label)gui.FindName("connectingLabel");
        Image infoIcon = (Image)gui.FindName("infoIcon");
        Label usernameLabel = (Label)gui.FindName("usernameLabel");
        TextBox usernameField = (TextBox)gui.FindName("usernameField");
        Button playButton = (Button)gui.FindName("playButton");
        Button quitButton = (Button)gui.FindName("quitButton");
        
        // PhotonNetwork.NickName = usernameField.Text;

        connectingLabel.Visibility = Visibility.Visible;
        infoIcon.Visibility = Visibility.Hidden;
        usernameLabel.Visibility = Visibility.Hidden;
        usernameField.Visibility = Visibility.Hidden;
        playButton.Visibility = Visibility.Hidden;
        quitButton.Visibility = Visibility.Hidden;

        // PhotonNetwork.ConnectUsingSettings();
    }
    
    private void quitButtonOnClick(object sender, RoutedEventArgs e) {
        Application.Quit();
    }

    // public override void OnConnectedToMaster() {
    //     SceneManager.LoadScene("game");
    // }
}
