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
        anim.SetBool("Equipment", false);
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Equipment");
        anim.SetBool("Equipment", true);
        DontDestroyOnLoad(character);
    }
}