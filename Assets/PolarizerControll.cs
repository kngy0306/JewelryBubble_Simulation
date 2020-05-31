using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolarizerControll : MonoBehaviour
{
    private GameObject polarizer;
    private GameObject cubeObject;
    public float rotateSpeed = 10.0f;

    void Start()
    {
        polarizer = GameObject.FindGameObjectWithTag("Polarizer");
        cubeObject = GameObject.Find("Cube");
        //(polarizer.transform.localEulerAngles.x)
    }

    void Update()
    {
        rotateCamera();
    }

    private void rotateCamera(){
        if(Input.GetKey("space")){
            Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * 2, 0);
            polarizer.transform.RotateAround(cubeObject.transform.position, Vector3.right, angle.y);
        }
    }
}
