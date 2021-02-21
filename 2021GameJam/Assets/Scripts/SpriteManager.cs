using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public static SpriteManager Instance {get; private set;}

    private void Awake() {
        Instance = this;
    }

    public Sprite blackCatSprite;
    public Sprite moustacheCatSprite;
    public Sprite bunnySprite;  
    public Sprite longHairWhiteDogSprite;
    public Sprite orangeDogSprite;
    public Sprite blackDogSprite;
    public Sprite longHairGrayDogSprite;

}
