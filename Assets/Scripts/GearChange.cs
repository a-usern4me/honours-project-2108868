using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearChange : MonoBehaviour {
    private Image gear;
    private float scroll;
   
    void Start(){
        gear = this.GetComponent<Image>();
    }

    void Update(){
        scroll = Input.GetAxis("Mouse ScrollWheel");

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            gear.transform.Rotate(0.0f, 0.0f, 0.5f);
            //Debug.Log("Working");
        }
        
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            gear.transform.Rotate(0.0f, 0.0f, -0.5f);
            
        }

        if (scroll > 0f){
            gear.transform.Rotate(0.0f, 0.0f, -5f);
        } 

        if (scroll < 0f){
            gear.transform.Rotate(0.0f, 0.0f, 5f);
        }
        
    }
}