using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using static System.IO.Directory;
using static System.IO.Path;

namespace maennche {
    public class SetupWizard : EditorWindow {
        public string projectName = "";
        public string authorName = "";
        public string versionNumber = "";
        
        public string rootNamespace = "";
        public int numberingScheme;
        
        
        string[] numberingScheme_options = new string[3] { "Prefab (1)", "Prefab.1", "Prefab_1" };
        
        [MenuItem("Tools/Maennche/Setup Wizard")]
        private static void openSetupWizard() {
            var window = GetWindow<SetupWizard>();
            window.titleContent = new GUIContent("Setup Wizard");
            window.Show();
        }

        private void OnGUI() {

            GUILayout.Label("Project Name:");
            GUILayout.BeginHorizontal();
            projectName = GUILayout.TextField(projectName);
            if (GUILayout.Button("Apply",  GUILayout.Width(60), GUILayout.Height(19))) {
                UnityEditor.PlayerSettings.productName = projectName;
            }
            GUILayout.EndHorizontal();
            
            GUILayout.Label("Author Name:");
            GUILayout.BeginHorizontal();
            authorName = GUILayout.TextField(authorName);
            if (GUILayout.Button("Apply",  GUILayout.Width(60), GUILayout.Height(19))) {
                UnityEditor.PlayerSettings.companyName = authorName;
            }
            GUILayout.EndHorizontal();
            
            GUILayout.Label("Version Number:");
            GUILayout.BeginHorizontal();
            versionNumber = GUILayout.TextField(versionNumber);
            if (GUILayout.Button("Apply",  GUILayout.Width(60), GUILayout.Height(19))) {
                UnityEditor.PlayerSettings.bundleVersion = versionNumber;
            }
            GUILayout.EndHorizontal();
            
            GUILayout.Space(15);
            GUILayout.Label("Root Namespace (Optional):");
            GUILayout.BeginHorizontal();
            rootNamespace = GUILayout.TextField(rootNamespace);
            if (GUILayout.Button("Apply",  GUILayout.Width(60), GUILayout.Height(19))) {
                if (rootNamespace.Length > 0)
                    UnityEditor.EditorSettings.projectGenerationRootNamespace = rootNamespace;
                else
                    UnityEditor.EditorSettings.projectGenerationRootNamespace = "";
            }
            GUILayout.EndHorizontal();
            
            
            GUILayout.Label("Numbering Scheme:");
            GUILayout.BeginHorizontal();
            numberingScheme = EditorGUILayout.Popup(GUIContent.none, numberingScheme, numberingScheme_options);
            if (GUILayout.Button("Apply",  GUILayout.Width(60), GUILayout.Height(19))) {
                if (numberingScheme == 0)
                    EditorSettings.gameObjectNamingScheme = EditorSettings.NamingScheme.SpaceParenthesis;
                else if (numberingScheme == 1)
                    EditorSettings.gameObjectNamingScheme = EditorSettings.NamingScheme.Dot;
                else if (numberingScheme == 2)
                    EditorSettings.gameObjectNamingScheme = EditorSettings.NamingScheme.Underscore;
            }
            GUILayout.EndHorizontal();
            
            

            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Create Folder Structure")) {
                Dir(projectName, "Scripts","Assets/Models/Materials/Textures","Assets/Models/Animations","Assets/Particles","Assets/Audio/SFX","Assets/Audio/Music","Data","Scenes","Assets/Imported Assets","Plugins","Prefabs");
                Refresh();
            }
            if (GUILayout.Button("Apply All")) {
                UnityEditor.PlayerSettings.companyName = authorName;
                UnityEditor.PlayerSettings.productName = projectName;
                UnityEditor.PlayerSettings.bundleVersion = versionNumber;
                if (rootNamespace.Length > 0)
                    UnityEditor.EditorSettings.projectGenerationRootNamespace = rootNamespace;
                else
                    UnityEditor.EditorSettings.projectGenerationRootNamespace = "";

                if (numberingScheme == 0)
                    EditorSettings.gameObjectNamingScheme = EditorSettings.NamingScheme.SpaceParenthesis;
                else if (numberingScheme == 1)
                    EditorSettings.gameObjectNamingScheme = EditorSettings.NamingScheme.Dot;
                else if (numberingScheme == 2)
                    EditorSettings.gameObjectNamingScheme = EditorSettings.NamingScheme.Underscore;
            }
        }

        public static void Dir(string root, params string[] dir) {
            var fullPath = Combine(dataPath, root);
            foreach (var newDirectory in dir) {
                CreateDirectory(Combine(fullPath, newDirectory));
            }
        }
    }
}