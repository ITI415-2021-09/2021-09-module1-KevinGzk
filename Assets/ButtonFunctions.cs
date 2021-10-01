using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    
    public GameObject tutorialUI;

    public void Retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void CloseTutorial(){
        tutorialUI.SetActive(false);
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
