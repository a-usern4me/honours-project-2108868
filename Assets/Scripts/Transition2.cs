using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Transition2 : MonoBehaviour {
    public TMP_Text click;
    public GameObject character;
    public Animator anim;

    void Start(){
        anim.SetBool("Magic", false);
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Magic");
        anim.SetBool("Magic", true);
        DontDestroyOnLoad(character);
    }
}