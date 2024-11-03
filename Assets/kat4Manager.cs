using UnityEngine;

public class kat4Manager : MonoBehaviour
{
    public YagmurClothes yagmurClothes;
    public ElifClothes elifClothes;

    public GameObject elevatorBtn;

    void Update()
    {
        if (yagmurClothes.yagmurOpen == true && elifClothes.elifOpen == true)
        {
            elevatorBtn.SetActive(true);
        }
    }
}
