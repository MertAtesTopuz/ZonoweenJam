using UnityEngine;

public class ZeynepClothes : MonoBehaviour
{
    public GameObject PShirt;
    public GameObject PSkirt;
    public GameObject PHat;
    public GameObject PShose;

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
                case "PirateShirt":
                PShirt.SetActive(true);
                AllCheck();
                break;
                case "PirateSkirt":
                PSkirt.SetActive(true);
                AllCheck();
                break;
                case "PirateHat":
                PHat.SetActive(true);
                AllCheck();
                break;
                case "PirateShose":
                PShose.SetActive(true);
                AllCheck();
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
        if(PShirt.activeSelf == true && PSkirt.activeSelf == true && PHat.activeSelf == true && PShose.activeSelf == true )
        {
            audioSource.PlayOneShot(yippi);
        }
    }
}
