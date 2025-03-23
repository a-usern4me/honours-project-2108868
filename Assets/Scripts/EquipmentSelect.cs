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
        if (slider.value <= 1){
            slider.value = 1;
            counter = 0;
        }

        if (slider.value >= 5){
            slider.value = 5;
            counter = 4;
        }

        if (slider.value-1 == counter){
            Items[counter].sprite = highlightedItem;
        } else {
            Items[counter].sprite = unselected;
        }

        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)){
            slider.value -= 1;
            counter--;
            Items[counter+1].sprite = unselected;
        }

        if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow)){
            slider.value += 1;
            counter++;
            Items[counter-1].sprite = unselected;
        }
    }
}