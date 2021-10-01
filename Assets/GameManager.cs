using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public GameObject completeLevelUI;
    public PlayerControl player;
    public bool finishCollected;
    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        finishCollected = player.collectAll;
    }

    // Update is called once per frame
    void Update()
    {
        finishCollected = player.collectAll;
        if(finishCollected == true)
        {
            gate.SetActive(true);
        }
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
