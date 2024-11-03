using UnityEngine;

public class UmitClothes : MonoBehaviour
{
    public GameObject KShirt;
    public GameObject KBelt;
    public GameObject KHat;
    public GameObject KShose;
    public GameObject KPants;
    public GameObject KGuitar;

    public bool umitOpen =false;

    public AudioSource audioSource;
    public AudioClip yippi;

    void OnTriggerEnter2D(Collider2D other)
    {
       Item item = other.GetComponent<InventoryItem>().item;

       if (item != null)
       {
        print(item);
            switch (item.name)
            {
                case "KovboyShirt":
                KShirt.SetActive(true);
                AllCheck();
                break;
                case "KovboyBelt":
                KBelt.SetActive(true);
                AllCheck();
                break;
                case "KovboyHat":
                KHat.SetActive(true);
                AllCheck();
                break;
                case "KovboyShose":
                KShose.SetActive(true);
                AllCheck();
                break;
                case "KovboyPants":
                KPants.SetActive(true);
                AllCheck();
                break;
                case "KovboyGuitar":
                KGuitar.SetActive(true);
                AllCheck();
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
       if(KBelt.activeSelf == true && KGuitar.activeSelf == true && KHat.activeSelf == true && KPants.activeSelf == true && KShirt.activeSelf == true && KShose.activeSelf == true)
        {
            umitOpen = true;
        }
    }
}
