using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeCounter : MonoBehaviour{

public Text totalLifes;

public int lifes = 3;
    private void Update(){
        totalLifes.text= lifes.ToString();
    }
    
    public void MinusLife(){
        lifes--;
        Debug.Log(lifes);
    }
    public void AddLife(){
        lifes++;
    }
}