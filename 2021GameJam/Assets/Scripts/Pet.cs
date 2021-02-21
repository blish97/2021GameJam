using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pet : MonoBehaviour {

    public float currentHealth;
    private float maxHealth =  100.0f;
    public float currentHygiene;
    private float maxHygiene =  100.0f;
    public float lovePts;

    // reference to healthBar
    public HealthBar healthBar;
    public HygieneBar hygieneBar;

    private SpriteRenderer spriteRenderer;
    private Animator anim;

    // public AnimatorController[] spriteArray;


    // Start is called before the first frame update
    void Start()
    {
		healthBar.SetMaxHealth(maxHealth);
        hygieneBar.SetMaxHygiene(maxHygiene);
        InvokeRepeating("DecreaseHealth", 1f, 2f);
        InvokeRepeating("DecreaseHygiene", 1f, 2f);

        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        anim = this.gameObject.GetComponent<Animator>();
    }


    /**
    Changing animation and sprite to a different animal
    **/
    public void changeSpriteAndAnimation(int num) {
        switch (num) {
            case 0:
                
                break;
        }
    }



    /**
     Decreasing Health over time
    **/
    private void DecreaseHealth() {
        if (currentHealth > 0.0f) {
            currentHealth -= 0.5f;
        }
        healthBar.SetHealth(currentHealth);
    }

    /**
    Decreasing hygiene over time
    **/
    private void DecreaseHygiene() {
        if (currentHygiene > 0.0f) {
            currentHygiene -= 0.3f;
        }
        hygieneBar.SetHygiene(currentHygiene);
    }

    /**
    Increasing love poitns when certain thresholds are met
    **/
    private void IncreaseLovePts() {

    }
}
