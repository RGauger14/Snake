using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{

    public static GameAssets Instance;

    private void Awake()
    {
        Instance = this;
    }
  

    public Sprite snakeHeadSprite;
    public Sprite foodSprite;
}
