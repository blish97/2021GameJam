using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PetTypes")]
public class PetTypes : ScriptableObject
{
    public new string name;
    [TextArea(10, 100)]
    public string description;

    public Sprite sprite;
    public Animator animations;
}
