using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class transitionLast : MonoBehaviour{
    public TMP_Text click;

    void Start(){
        
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Settings");
    }
}