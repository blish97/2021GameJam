using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    public float MoveSpeed = 10;
    public float JumpForce = 3;
    private Rigidbody2D rb;
    private Animator anim;

    void Awake(){
        anim = GetComponent<Animator>();
    }
    void Start()
    {

        rb = GetComponent<Rigidbody2D>(); 


    }
    void Update()
    {
        
        
        //Move Left and right

        Vector3 frameMovement = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, 0);
        transform.Translate(frameMovement * Time.deltaTime);



        //Updates where the player is facing
        if (frameMovement.x != 0){
            transform.localScale = new Vector3(Mathf.Sign(frameMovement.x), 1, 1);
        }

        anim.SetBool("isLeft", frameMovement.x != 0);
       
        //Player Jump
        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.x) < 0.001){

            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        
    }
}
