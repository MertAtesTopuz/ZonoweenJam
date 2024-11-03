using UnityEngine;

public class Kat2Manager : MonoBehaviour
{
    public MertClothes mertClothes;
    public UmitClothes umitClothes;
    public GameObject eleButton;

    void Update()
    {
        if (mertClothes.mertOpen && umitClothes.umitOpen)
        {
            eleButton.SetActive(true);
        }
    }
}
