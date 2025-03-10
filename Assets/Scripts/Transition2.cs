using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Transition2 : MonoBehaviour {
    public TMP_Text click;

    void Start(){
        
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Magic");
    }
}