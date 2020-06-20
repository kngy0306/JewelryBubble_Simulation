using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelC : MonoBehaviour {
    void Update () {
        polarizerRotate ();
    }

    // 偏光版回転
    private void polarizerRotate () {
        if (Input.GetKey (KeyCode.RightArrow)) {
            transform.Rotate (0, 0, -1f);
        } else if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.Rotate (0, 0, 1f);
        }
    }
}