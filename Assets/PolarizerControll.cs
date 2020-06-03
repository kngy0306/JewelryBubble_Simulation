using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolarizerControll : MonoBehaviour {
    private GameObject polarizer;
    private GameObject cubeObject;
    public float rotateSpeed = 10.0f;

    void Start () {
        polarizer = GameObject.FindGameObjectWithTag ("Polarizer");
        cubeObject = GameObject.Find ("Cube");
        //(polarizer.transform.localEulerAngles.x)
    }

    void Update () {
        polarizerAngle ();
        polarizerRotate ();
    }

    // 観測角度
    private void polarizerAngle () {
        if (Input.GetKey ("space")) {
            Vector3 angle = new Vector3 (Input.GetAxis ("Mouse X") * rotateSpeed, Input.GetAxis ("Mouse Y") * 2, 0);
            polarizer.transform.RotateAround (cubeObject.transform.position, Vector3.right, angle.y);
        }
    }

    // 偏光版回転
    private void polarizerRotate () {
        if (Input.GetKey (KeyCode.RightArrow)) {
            Vector3 rotate = new Vector3 (0, rotateSpeed, 0);
            polarizer.transform.Rotate (0, rotate.y * 5f, 0);
        } else if (Input.GetKey (KeyCode.LeftArrow)) {
            Vector3 rotate = new Vector3 (0, -rotateSpeed, 0);
            polarizer.transform.Rotate (0, rotate.y * 5f, 0);
        }
    }
}