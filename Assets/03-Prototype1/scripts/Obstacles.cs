using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{
    
    public GameObject player;
    public GameObject GameOverUI;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnCollisionEnter(Collision collision){
        
        if(collision.gameObject.tag == "Player")
        {
            Destroy(player);
            GameOverUI.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
