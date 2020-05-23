using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraControll : MonoBehaviour
{
    private GameObject mainCamera;              //メインカメラ格納用
    private GameObject cubeObject;            //回転の中心となるプレイヤー格納用
    public float rotateSpeed = 0.1f;            //回転の速さ
 
    void Start()
    {
        //メインカメラと被写体をそれぞれ取得
        mainCamera = Camera.main.gameObject;
        cubeObject = GameObject.Find("Cube");

        // 角度取得↓
        Debug.Log(mainCamera.transform.localEulerAngles.x);
    }
 
    void Update()
    {
        rotateCamera();
    }
 
    private void rotateCamera()
    {
        //Vector3でX,Y方向の回転の度合いを定義
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);
 
        // transform.RotateAround()をしようしてメインカメラを回転させる
        if(Input.GetKey("space")){  // 観測方向
            // RotateAround(中心のobj, 軸, 角度)
            mainCamera.transform.RotateAround(cubeObject.transform.position, Vector3.up, angle.x);
        }else{ // 観測角度
        //if(mainCamera.transform.rotation.z > -0.8f){    カメラの動き制限やろうとした
            mainCamera.transform.RotateAround(cubeObject.transform.position, Vector3.right, angle.y);
        //}    
        }
    }
}