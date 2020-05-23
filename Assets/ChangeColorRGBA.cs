using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorRGBA : MonoBehaviour {

    private GameObject mainCamera;
    public int angle, color_red, color_green, color_blue;

    private string[] strR;
    private string[] strG;
    private string[] strB;

    void Start (){
        mainCamera = Camera.main.gameObject;

        string fileR = "C:/Users/kona/image_red.txt";
        string fileG = "C:/Users/kona/image_green.txt";
        string fileB = "C:/Users/kona/image_blue.txt";

        StreamReader srR = new StreamReader(fileR);
        StreamReader srG = new StreamReader(fileG);
        StreamReader srB = new StreamReader(fileB);

        while (srR.Peek() >= 0)
        {
            strR = srR.ReadLine().Split(' ');
            strG = srG.ReadLine().Split(' ');
            strB = srB.ReadLine().Split(' ');
        }
        Debug.Log(strR[0]);
        Debug.Log(strG[0]);

        srR.Close();
        srG.Close();
        srB.Close();
    }

    void Update () {
        angle = (int)mainCamera.transform.localEulerAngles.x;

        if (0 > angle || angle > 90) {
            Color color = new Color32(255, 255, 255, 0);
            GetComponent<Renderer>().material.color = color;
        } else {
            color_red = int.Parse(strR[angle]);
            color_green = int.Parse(strG[angle]);
            color_blue = int.Parse(strB[angle]);

            Color color = new Color32((byte)color_red, (byte)color_green, (byte)color_blue, 1);
            GetComponent<Renderer>().material.color = color;
        }
        
    }
}