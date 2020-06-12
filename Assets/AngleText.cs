using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleText : MonoBehaviour {

    public GameObject angle_object = null;
    private GameObject mainCamera;
    private int angle;

    void Start () {
        mainCamera = Camera.main.gameObject;
    }

    void Update () {
        angle = (int) mainCamera.transform.localEulerAngles.x;
        Text angle_text = angle_object.GetComponent<Text> ();
        angle_text.text = "観測角度 " + angle + "°";
    }
}