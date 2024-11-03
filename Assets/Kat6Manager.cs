using UnityEngine;

public class Kat6Manager : MonoBehaviour
{
    public ZeynepClothes zeynepClothes;

    public GameObject button;

    void Update()
    {
        if (zeynepClothes.zeynepOpen)
        {
            button.SetActive(true);
        }
    }
}
