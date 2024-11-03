using UnityEngine;

public class HarunClothes : MonoBehaviour
{
    public GameObject JTunic;
    public GameObject JScarf;
    public GameObject JBread;
    public GameObject JWine;

    void OnTriggerEnter2D(Collider2D other)
    {
       Item item = other.GetComponent<InventoryItem>().item;

       if (item != null)
       {
        print(item);
            switch (item.name)
            {
                case "JesusTunic":
                JTunic.SetActive(true);
                break;
                case "JesusScarf":
                JScarf.SetActive(true);
                break;
                case "JesusBread":
                JBread.SetActive(true);
                break;
                case "JesusWine":
                JWine.SetActive(true);
                break;
            }
            Destroy(other.gameObject);
       }
    }
}
