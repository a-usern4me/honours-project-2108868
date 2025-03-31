using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour {
    public TMP_Text exitButton; 

    void Start(){
        
    }

    void Update(){
        
    }

    public void OnClick(){
        Debug.Log("Goodbye!");
        Application.Quit();
    }
}