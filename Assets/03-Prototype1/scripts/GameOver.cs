using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public GameObject gameoverUI;
    public GameObject player;

    void Update()
    {
        if(player.transform.position.y <= -5)
        {
            Destroy(player);
            GameoverUI();
        }
    }

    void GameoverUI()
    {
        gameoverUI.SetActive(true);
    }


}
