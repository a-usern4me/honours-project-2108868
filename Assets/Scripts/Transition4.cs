using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Transition4 : MonoBehaviour {
    public TMP_Text click;

    void Start(){
        
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Status");
    }
}