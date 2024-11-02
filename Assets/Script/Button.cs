using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Sprite sprite;
    public Inventory inventory;
    public int isTrue;
    public void ButtonPressed()
    {
        inventory.SetSprite(sprite, isTrue);
    }

    
}
