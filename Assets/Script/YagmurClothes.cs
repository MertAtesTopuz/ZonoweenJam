using UnityEngine;

public class YagmurClothes : MonoBehaviour
{
    public GameObject SSuit;
    public GameObject SShose;

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
                case "SharkSuit":
                SSuit.SetActive(true);
                AllCheck();
                break;
                case "SharkShose":
                SShose.SetActive(true);
                AllCheck();
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
        if(SSuit.activeSelf == true && SShose.activeSelf == true)
        {
            audioSource.PlayOneShot(yippi);
        }
    }
}
