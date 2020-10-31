using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetScript : MonoBehaviour
{
    private AlphabetCounter counter;
    
    private Rigidbody2D rb2d;

    private bool isCollected;
    
    void Start()
    {
        counter = GameObject.Find("GameController").GetComponent<AlphabetCounter>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isCollected && transform.position.y > 300)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!isCollected)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 20);
            isCollected = true;
            counter.onCollected();
        }
    }
}
