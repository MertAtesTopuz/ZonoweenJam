using UnityEngine;

public class HarunClothes : MonoBehaviour
{
    public GameObject JTunic;
    public GameObject JScarf;
    public GameObject JBread;
    public GameObject JWine;
    public GameObject JBelt;

    public bool harunOpen=false;

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
                AllCheck();
                break;
                case "JesusScarf":
                JScarf.SetActive(true);
                AllCheck();
                break;
                case "JesusBread":
                JBread.SetActive(true);
                AllCheck();
                break;
                case "JesusWine":
                JWine.SetActive(true);
                AllCheck();
                break;
                case "JesusBelt":
                JBelt.SetActive(true);
                AllCheck();
                break;
            }
            Destroy(other.gameObject);
       }
    }

    private void AllCheck()
    {
       if(JBelt.activeSelf == true && JBread.activeSelf == true && JScarf.activeSelf == true && JTunic.activeSelf == true && JWine.activeSelf == true)
        {
            harunOpen = true;
        }
    }
}
