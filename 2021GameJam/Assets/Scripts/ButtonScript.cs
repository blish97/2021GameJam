using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
 
 public Text TextField;
 public GameObject image;

 public void SetText(string text){
     
     image.gameObject.SetActive(true);
     TextField.gameObject.SetActive(true);
     TextField.text = text;
 }

void Update () {

     if (Input.GetKeyDown(KeyCode.Space))
    {
     image.gameObject.SetActive(false);
     TextField.gameObject.SetActive(false);
    }
    
}
}
