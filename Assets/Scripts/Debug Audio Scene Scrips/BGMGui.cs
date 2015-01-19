using UnityEngine;
using System.Collections;

public class BGMGui : MonoBehaviour {

    void OnGUI() {
        float w = Screen.width;
        float h = Screen.height;

        if (GUI.Button(new Rect(0, h - 60, w / 3, 60), "Start")) {
            AudioManager.PlayBGM("Morphlen Theme");
        }
        if (GUI.Button(new Rect(w / 3, h - 60, w / 3, 60), "Pause")) {
            AudioManager.PauseBGM();
        }
        if (GUI.Button(new Rect((2 * w) / 3, h - 60, w / 3, 60), "Stop")) {
            AudioManager.StopBGM();
        }
    }
}
