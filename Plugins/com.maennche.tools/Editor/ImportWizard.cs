using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace cmaennche {
    public class ImportWizard : EditorWindow {
        [MenuItem("Tools/Maennche/Importer")]
        private static void ShowWindow() {
            var window = GetWindow<ImportWizard>();
            window.titleContent = new GUIContent("Importer");
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
            Debug.Log("There are " + customPackages.Length + " custom unitypackages in this directory.");
            Debug.Log("There are " + sdkPackages.Length + " sdk unitypackages in this directory.");
            EditorGUILayout.LabelField("Custom Packages ( " + customPackages.Length + " )", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("SDK Packages ( " + sdkPackages.Length + " )", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel();
            if (GUILayout.Button("Import")) {
                Process.Start();
            }
            GUILayout.EndHorizontal();
            
            
            EditorGUILayout.LabelField("SDK Packages ( " + sdkPackages.Length + " )", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel();
            if (GUILayout.Button("Import")) {
                Process.Start();
            }
            GUILayout.EndHorizontal();
        }
    }
}