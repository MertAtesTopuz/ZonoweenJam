using UnityEngine;

public class Inventory : MonoBehaviour
{
    public SpriteRenderer spriteRenderer1, spriteRenderer2;
    void Start()
    {
        
    }

    
    public void SetSprite(Sprite sprite)
    {
        if(spriteRenderer1.sprite == null)
        {
            spriteRenderer1.sprite = sprite;
        }
        else if(spriteRenderer2.sprite == null)
        {
            spriteRenderer2.sprite = sprite;
        }
        
    }
}
