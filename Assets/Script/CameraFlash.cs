using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFlash : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color color;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }
    public void Flash()
    {
        print("ehe");
        spriteRenderer.color = new Color(255f, 255f, 255f, 0f);
        
    }
}
