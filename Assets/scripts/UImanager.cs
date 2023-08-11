using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UImanager : MonoBehaviour
{
    public GameObject OptionsPanel;
    public void OptionPanel(){
        Time.timeScale = 0;
        OptionsPanel.SetActive(true);
    }
    public void Return(){
       Time.timeScale = 1;
        OptionsPanel.SetActive(false); 
    }
    public void BackMainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("menuPrincipal");
    }
}
