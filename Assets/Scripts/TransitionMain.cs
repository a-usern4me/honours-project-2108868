using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TransitionMain : MonoBehaviour {
    public TMP_Text click;
    public GameObject character;
    public Animator anim;

    void Start(){
        character = GameObject.FindWithTag("Player"); 
    }

    void Update(){
        if(Input.GetKey("escape")){
            onClick();
        }
    }

    public void onClick(){
        Destroy(character);
        SceneManager.LoadScene("Main Screen");
    }
}