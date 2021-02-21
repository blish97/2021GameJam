using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    public float MoveSpeed = 10;
    public float JumpForce = 3;
    private Rigidbody2D rb;
    private Animator anim;

    public float direction;
    public float _posX;

    void Awake(){
        anim = GetComponent<Animator>();
    }
    void Start()
    {

        rb = GetComponent<Rigidbody2D>(); 
         someScale = transform.localScale.x; 
            direction = 1;
         _posX = transform.position.x;


    }

    float someScale;


    void Update()
    {

        
        
        //Move Left and right
        Vector3 frameMovement = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, 0);
        transform.Translate(frameMovement * Time.deltaTime);

        
        //Updates where the player is facing
   
if (transform.position.x < _posX)
         {
             Debug.Log("Moving left - " + transform.position.x);
             if (direction == 1)
             {
                 transform.localScale = new Vector2(-someScale, transform.localScale.y);
                 
                 direction = -1;
             }
         }
         else
         {
             Debug.Log("Moving right - " + transform.position.x);
             if (direction == -1)
             {
                  transform.localScale = new Vector2(someScale, transform.localScale.y);
                  
                 direction = 1;
             }
         }
 
         _posX = transform.position.x;




        anim.SetBool("isLeft", frameMovement.x != 0);


    
       
        //Player Jump
        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.x) < 0.001){

            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        
    }
}
