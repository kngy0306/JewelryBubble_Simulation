using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class TextManager : MonoBehaviour {
 
    private int rotateAngle;
    public GameObject score_object = null;
    private GameObject polarizer;
 
      void Start () {
          polarizer = GameObject.FindGameObjectWithTag ("Polarizer");
      }
 
      void Update () {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text> ();
        // テキストの表示を入れ替える

        rotateAngle = (int) polarizer.transform.localEulerAngles.y;
        score_text.text = "偏光版角度 " + rotateAngle + "°";
      }
}