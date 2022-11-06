using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using UnityEditor;
using UnityEngine;

namespace maennche {
    public class ImportWizard : EditorWindow {
        [MenuItem("Tools/Maennche/Import Wizard")]
        private static void ShowWindow() {
            var window = GetWindow<ImportWizard>();
            window.titleContent = new GUIContent("Import Wizard");
            window.Show();
        }

        private void OnGUI() {
            // GUILayout.BeginHorizontal();
            // EditorGUILayout.PrefixLabel("FPS Controller");
            // if (GUILayout.Button("Import")) {
            //     Process.Start("C:/Users/Summi/OneDrive/Game Assets/Packages/Custom/FPSController-Basic.unitypackage");
            // }
            // GUILayout.EndHorizontal();
            
            string[] customPackages = Directory.GetFiles(@"C:\Users\Summi\OneDrive\Game Assets\Packages\Custom\", "*.unitypackage");
            string[] sdkPackages = Directory.GetFiles(@"C:\Users\Summi\OneDrive\Game Assets\Packages\SDKs\", "*.unitypackage");
            // Debug.Log("There are " + customPackages.Length + " custom unitypackages in this directory.");
            // Debug.Log("There are " + sdkPackages.Length + " sdk unitypackages in this directory.");
            
            EditorGUILayout.LabelField("Custom Packages ( " + customPackages.Length + " )", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("Basic FPS Controller");
            if (GUILayout.Button("Import")) {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/cmaennche/Game-Assets/blob/main/Packages/Custom/basicFpsController.unitypackage?raw=true", Path.Combine(Application.dataPath, "FPSController.unitypackage"));
                    AssetDatabase.Refresh();
                    Process.Start(Path.Combine(Application.dataPath, "FPSController.unitypackage"));
                    // File.Delete(Path.Combine(Application.dataPath, "FPSController.unitypackage"));
                }
            }
            GUILayout.EndHorizontal();
            
            
            EditorGUILayout.LabelField("SDK Packages ( " + sdkPackages.Length + " )", EditorStyles.boldLabel);
            // GUILayout.BeginHorizontal();
            // EditorGUILayout.PrefixLabel();
            // if (GUILayout.Button("Import")) {
            //     Process.Start();
            // }
            // GUILayout.EndHorizontal();
        }
    }
}