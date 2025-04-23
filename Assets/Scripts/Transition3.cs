using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Transition3 : MonoBehaviour {
    public TMP_Text click;
    public GameObject character;
    public Animator anim;

    void Start(){
        anim.SetBool("Status", false);
    }

    void Update(){
        
    }

    public void onClick(){
        SceneManager.LoadScene("Status");
        anim.SetBool("Status", true);
        DontDestroyOnLoad(character);
    }
}