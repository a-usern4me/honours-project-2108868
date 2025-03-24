using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleSelect : MonoBehaviour {
    public Button skillChoice;
    //public ParticleSystem particle; 


    void Start(){
        skillChoice = this.GetComponent<Button>();
        //particle = this.GetComponent<ParticleSystem>();
        
    }

    void Update(){
        //particle.Play();

        
    }

    public void onClick(){
        //particle.Play();
        Debug.Log("Working");

    }
}