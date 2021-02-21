using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pet : MonoBehaviour {

    public float currentHealth;
    private float maxHealth =  100.0f;
    public float currentHygiene;
    private float maxHygiene =  100.0f;
    // public float lovePts;



    // reference to healthBar
    public HealthBar healthBar;
    public HygieneBar hygieneBar;




    // Start is called before the first frame update
    void Start()
    {
		healthBar.SetMaxHealth(maxHealth);
        hygieneBar.SetMaxHygiene(maxHygiene);
        InvokeRepeating("DecreaseHealth", 1f, 2f);
        InvokeRepeating("DecreaseHygiene", 1f, 2f);
    }


    /**
    Changing animation and sprite to a different animal
    **/



    /**
     Decreasing Health over time
    **/
    private void DecreaseHealth() {
        if (currentHealth > 0.0f) {
            currentHealth -= 0.5f;
        }
        healthBar.SetHealth(currentHealth);
    }

        // Decreasing Health over time
    private void DecreaseHygiene() {
        if (currentHygiene > 0.0f) {
            currentHygiene -= 0.3f;
        }
        hygieneBar.SetHygiene(currentHygiene);
    }

    //When click on the food button the health goes up 
    public void EatFood(){
        currentHealth += 10f;
        healthBar.SetHealth(currentHealth);
    }
 

    //when click on the soap bar the hygiene goes up 
    public void soapBar(){
        currentHygiene += 10f;
        hygieneBar.SetHygiene(currentHygiene);

    }

}
