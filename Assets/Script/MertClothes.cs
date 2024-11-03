using UnityEngine;

public class MertClothes : MonoBehaviour
{
    public GameObject OBShirt;
    public GameObject OBPants;
    public GameObject OBTie;
    public GameObject OBGlass;
    public GameObject OBShose;
    public GameObject OBGun;

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
                break;
                case "OrayBeyTie":
                OBTie.SetActive(true);
                break;
                case "OrayBeyGlass":
                OBGlass.SetActive(true);
                break;
                case "OrayBeyShose":
                OBShose.SetActive(true);
                break;
                case "OrayBeyGun":
                OBGun.SetActive(true);
                break;
                case "OrayBeyShirt":
                OBShirt.SetActive(true);
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
        if(OBPants.activeSelf == true && OBShirt.activeSelf == true && OBTie.activeSelf == true && OBGlass.activeSelf == true && OBShose.activeSelf == true && OBGun.activeSelf == true)
        {
            audioSource.PlayOneShot(yippi);
        }
    }
}
