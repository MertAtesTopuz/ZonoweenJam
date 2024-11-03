using UnityEngine;

public class ElifClothes : MonoBehaviour
{
    public GameObject NShirt;
    public GameObject NPants;
    public GameObject NNecles;
    public GameObject NBandana;
    public GameObject NKimono;

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
                case "NarutoShirt":
                NShirt.SetActive(true);
                AllCheck();
                break;
                case "NarutoPants":
                NPants.SetActive(true);
                AllCheck();
                break;
                case "NarutoNeckles":
                NNecles.SetActive(true);
                AllCheck();
                break;
                case "NarutoBandana":
                NBandana.SetActive(true);
                AllCheck();
                break;
                case "NarutoKimono":
                NKimono.SetActive(true);
                AllCheck();
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
        if(NShirt.activeSelf == true && NPants.activeSelf == true && NNecles.activeSelf == true && NBandana.activeSelf == true && NKimono.activeSelf == true)
        {
            
        }
    }
}
