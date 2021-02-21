using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pet : MonoBehaviour {

    public float currentHealth;
    private float maxHealth =  100.0f;
    public float currentHygiene;
    private float maxHygiene =  100.0f;
    public GameObject allAnimals;
    public float lovePts;



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

        allAnimals = GameObject.FindGameObjectWithTag("Pets");
    }



    /**
    Changing animation and sprite to a different animal
    **/

    public void ChangeAnimal(int num){
        foreach(GameObject animal in allAnimals){
            if(animal.GameObject.activeSelf){
                animal.GameObject.SetActive(false);
                            }

        }

        switch (num)
        {
            case 0:
                allAnimals.transform.Find("BlackCat").SetActive(true);
                break;

            case 1:
                allAnimals.transform.Find("WhiteCat").SetActive(true);
                break;

            case 2:
            allAnimals.transform.Find("Bun").SetActive(true);
            break;

            case 3:
                allAnimals.transform.Find("GingerDoggo").SetActive(true);
                break;
            
            case 4:
                allAnimals.transform.Find("GreyDog").SetActive(true);
                break;

            case 5:
                allAnimals.transform.Find("BalckDog").SetActive(true);
                break;
            
            case 16:
                allAnimals.transform.Find("GangstaDog").SetActive(true);
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
