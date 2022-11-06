using System;
using System.IO;
using System.Net;
using UnityEditor;
using UnityEngine;

namespace cmaennche {
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
                string githubToken = "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";
                var url = "https://github.com/cmaennche/Game-Assets/archive/FPSController-Basic.unitypackage";
                var path = Path.Combine(Application.dataPath, "FPSController.unitypackage");
                
                using (var client = new System.Net.Http.HttpClient()) {
                    var credentials = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", githubToken);
                    credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials));
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
                    var contents = client.GetByteArrayAsync(url).Result;
                    System.IO.File.WriteAllBytes(path, contents);
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