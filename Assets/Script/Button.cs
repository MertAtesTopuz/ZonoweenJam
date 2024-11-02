using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Sprite sprite;
    public Inventory inventory;
    public void ButtonPressed()
    {
        inventory.SetSprite(sprite);
    }

    
}
