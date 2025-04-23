using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EquipmentSelect : MonoBehaviour {
    public Image item;
    public Image item2;
    public Image item3;
    public Image item4;
    public Image item5;
    public Sprite highlightedItem;
    public Sprite unselected;
    public Slider slider;
    private Image[] Items;
    public int counter;
   
    void Start(){
        slider.value = 1;
    
        Items = new Image[5];
        Items[0] = item;
        Items[1] = item2;
        Items[2] = item3;
        Items[3] = item4;
        Items[4] = item5;
    }

    void Update(){
        for (int i = 0; i < Items.Length; i++){
            if (slider.value-1 == counter && counter == i){
                Items[counter].sprite = highlightedItem;
            } else {
                Items[i].sprite = unselected;
            }
        }

        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)){
            if (slider.value > 1){
                slider.value -= 1;
                counter--;

            } else {
                slider.value = 5;
                counter = 4;
            }
        }

        if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow)){
            if (slider.value < 5){
                slider.value += 1;
                counter++;

            } else {
                slider.value = 1;
                counter = 0;
            } 
        }
    }

    /* Mouse Selection */
    public void Click1(){
        slider.value = 1;
        counter = 0;
    }

    public void Click2(){
        slider.value = 2;
        counter = 1;
    }

    public void Click3(){
        slider.value = 3;
        counter = 2;
    }

    public void Click4(){
        slider.value = 4;
        counter = 3;
    }

    public void Click5(){
        slider.value = 5;
        counter = 4;
    }
}