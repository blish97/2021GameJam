using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAnimal : MonoBehaviour
{
    public int num;
    public Pet pet;

    public void switchAnimal() {
        pet.changeSpriteAndAnimation(num);
    }
}
