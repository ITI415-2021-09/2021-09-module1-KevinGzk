using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{

    public void Back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
