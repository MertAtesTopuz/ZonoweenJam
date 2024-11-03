using UnityEngine;

public class kat7Manager : MonoBehaviour
{
    public HarunClothes harunClothes;
    public GameObject elevatorBtn;

    void Update()
    {
        if (harunClothes.harunOpen == true)
        {
            elevatorBtn.SetActive(true);
        }
    }
}
