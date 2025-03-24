using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class transitionLast : MonoBehaviour{
    public TMP_Text click;
    public GameObject character;
    public Animator anim;

    void Start(){
        anim.SetBool("Settings", false);
        
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Settings");
        anim.SetBool("Settings", true);
        DontDestroyOnLoad(character);
    }
}