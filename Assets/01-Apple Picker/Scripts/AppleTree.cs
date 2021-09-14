using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection;
    public float secondsBetweenAppleDrop = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //dropping appes every seconds
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrop);
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing direction
        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move to the right
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = - Mathf.Abs(speed); //move to the left
        }
    }

    void FixedUpdate()
    {
        if(Random.value < chanceToChangeDirection)
        {
            speed *= -1; // change direction
        }
    }
}
