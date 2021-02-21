using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pet : MonoBehaviour {
    public new string name;
    public string description;

    // public Animation animation;
    // public Sprite sprite;

    public float currentHealth;
    public float maxHealth =  100.0f;
    public float currentHygiene;
    public float maxHygiene =  100.0f;
    // public float lovePts;


    // reference to healthBar
    public HealthBar healthBar;
    public HygieneBar hygieneBar;




    // Start is called before the first frame update
    void Start()
    {
		healthBar.SetMaxHealth(maxHealth);
        InvokeRepeating("DecreaseHealth", 1f, 2f);
        InvokeRepeating("DecreaseHygiene", 1f, 2f);
    }



    // /**
    // Extra methods used to control the stat decrease; MUST CALL
    // **/
    // public void StopStatDecrease() {
    //     CancelInvoke();
    // }

    // public void StartStatDecrease() {
    //     InvokeRepeating("DecreaseHealth", 1f, 2f);
    //     InvokeRepeating("DecreaseHygiene", 1f, 2f);
    // }




    // Decreasing Health over time
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
}
