using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public SpriteRenderer spriteMain, spriteRenderer1, spriteRenderer2, spriteRenderer3;
    public Sprite open;
    public List<bool> objItems = new List<bool>() {false, false};

    public void SetSprite(Sprite sprite, int objNumber)
    {
        if(spriteRenderer1.sprite == null)
        {
            spriteRenderer1.sprite = sprite;
        }
        else if(spriteRenderer2.sprite == null)
        {
            spriteRenderer2.sprite = sprite;
        }
        else if (spriteRenderer3.sprite == null)
        {
            spriteRenderer3.sprite = sprite;
        }

        if(objNumber != 0)
        {
            objItems[objNumber - 1] = true;
            if(objItems[0] == true && objItems[1] == true)
            {
                spriteMain.sprite = open;
            }
        }
        
    }
}
