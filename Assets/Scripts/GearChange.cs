using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearChange : MonoBehaviour {
    private Image gear;
   
    void Start(){
        gear = this.GetComponent<Image>();
    }


    void Update(){
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            gear.transform.Rotate(0.0f, 0.0f, 0.5f);
            //gear.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            //Debug.Log("Working");
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            gear.transform.Rotate(0.0f, 0.0f, -0.5f);
        }
        
    }
}