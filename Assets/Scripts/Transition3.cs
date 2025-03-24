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
        //character = this.GetComponent<GameObject>();
        character = GameObject.FindWithTag("Player");
        
    }

    void Update(){
         
    }

    public void onClick(){
        Destroy(character);
        //Destroy(this.gameObject);
        //Destroy(anim);
        SceneManager.LoadScene("Main Screen");
        //anim.Play("Scene");
        //DontDestroyOnLoad(character);
        
    }
}