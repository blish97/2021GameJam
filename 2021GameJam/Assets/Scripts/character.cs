﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character: MonoBehaviour
{
    public float speed;
    public bool MoveRight;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
        if(MoveRight){
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2 (1, 1);
        }
        else{
             transform.Translate(2 * Time.deltaTime * speed, 0, 0);
             transform.localScale = new Vector2 (-1, 1);
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D trigger ){
        if(trigger.gameObject.CompareTag("turn")){
            if(MoveRight){
                MoveRight = false;
            }
            else{
                MoveRight = true;
            }
        }
    }
}
