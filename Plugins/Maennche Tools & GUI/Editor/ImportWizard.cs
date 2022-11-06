using UnityEditor;
using UnityEngine;

namespace maennche {
    public class ImportWizard : EditorWindow {
        [MenuItem("Tools/Maennche/Importer")]
        private static void ShowWindow() {
            var window = GetWindow<ImportWizard>();
            window.titleContent = new GUIContent("Importer");
            window.Show();
        }

        private void OnGUI() {
            GUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("FPS Controller");
            if (GUILayout.Button("Import")) {
                FileUtil.CopyFileOrDirectory("C:/Users/Summi/OneDrive/Game Assets/Plugins/Maennche Tools & GUI/Assets/FPS-Controller", "destpath/YourFileOrFolder");
            }
            GUILayout.EndHorizontal();
            // EditorGUILayout.Separator();
            GUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("FPS Controller");
            if (GUILayout.Button("Import")) {
                FileUtil.CopyFileOrDirectory("C:/Users/Summi/OneDrive/Game Assets/Plugins/Maennche Tools & GUI/Assets/FPS-Controller", "destpath/YourFileOrFolder");
            }
            GUILayout.EndHorizontal();
        }
    }
}