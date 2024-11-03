using UnityEngine;

public class MertClothes : MonoBehaviour
{
    public GameObject OBShirt;
    public GameObject OBPants;
    public GameObject OBTie;
    public GameObject OBGlass;
    public GameObject OBShose;
    public GameObject OBGun;

    public bool mertOpen;
    
    public AudioSource audioSource;
    public AudioClip yippi;

    void OnTriggerEnter2D(Collider2D other)
    {
       Item item = other.GetComponent<InventoryItem>().item;

       if (item != null)
       {
            switch (item.name)
            {
                case "OrayBeyPants":
                OBPants.SetActive(true);
                AllCheck();
                break;
                case "OrayBeyTie":
                OBTie.SetActive(true);
                AllCheck();
                break;
                case "OrayBeyGlass":
                OBGlass.SetActive(true);
                AllCheck();
                break;
                case "OrayBeyShose":
                OBShose.SetActive(true);
                AllCheck();
                break;
                case "OrayBeyGun":
                OBGun.SetActive(true);
                AllCheck();
                break;
                case "OrayBeyShirt":
                OBShirt.SetActive(true);
                AllCheck();
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
        if(OBShirt.activeSelf == true && OBPants.activeSelf == true && OBTie.activeSelf == true && OBGlass.activeSelf == true && OBShose.activeSelf == true&&OBGun.activeSelf == true)
        {
            mertOpen = true;
        }
    }
}
