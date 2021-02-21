using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    public float MoveSpeed = 2;
    public float JumpForce = 3;
    private Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>(); 

        
        
    }


    void Update()
    {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0)* Time.deltaTime * MoveSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001){

            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        }
        
    }
}
