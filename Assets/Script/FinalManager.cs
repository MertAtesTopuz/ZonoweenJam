using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class FinalManager : MonoBehaviour
{
    public GameObject Mert, Umut, Elif, Yagmur, Zeynep, Isa, Jury, Arda1, Arda2, Arda3;
    public TextMeshPro JuryText1, JuryText2, JuryText3;

    public int ActionNumber = 0;
    public IEnumerator Final()
    {
        yield return new WaitForSeconds(5);
        Mert.SetActive(true);
        Umut.SetActive(true);
        yield return new WaitForSeconds(5);
        JuryText1.text = "10";
        yield return new WaitForSeconds(2);
        JuryText2.text = "10";
        yield return new WaitForSeconds(3);
        JuryText3.text = "2";
        yield return new WaitForSeconds(5);
        JuryText1.text = "";
        JuryText2.text = "";
        JuryText3.text = "";
        Mert.SetActive(false);
        Umut.SetActive(false);

        yield return new WaitForSeconds(5);
        Elif.SetActive(true);
        Yagmur.SetActive(true);
        yield return new WaitForSeconds(5);
        JuryText1.text = "10";
        yield return new WaitForSeconds(2);
        JuryText2.text = "10";
        yield return new WaitForSeconds(3);
        JuryText3.text = "2";
        yield return new WaitForSeconds(5);
        JuryText1.text = "";
        JuryText2.text = "";
        JuryText3.text = "";
        Elif.SetActive(false);
        Yagmur.SetActive(false);

        yield return new WaitForSeconds(5);
        Zeynep.SetActive(true);
        yield return new WaitForSeconds(5);
        JuryText1.text = "10";
        yield return new WaitForSeconds(2);
        JuryText2.text = "10";
        yield return new WaitForSeconds(3);
        JuryText3.text = "2";
        yield return new WaitForSeconds(5);
        JuryText1.text = "";
        JuryText2.text = "";
        JuryText3.text = "";
        Zeynep.SetActive(false);

        yield return new WaitForSeconds(5);
        Isa.SetActive(true);
        yield return new WaitForSeconds(5);
        JuryText1.text = "10";
        yield return new WaitForSeconds(2);
        JuryText2.text = "10";
        yield return new WaitForSeconds(3);
        JuryText3.text = "2";
        yield return new WaitForSeconds(5);
        JuryText1.text = "";
        JuryText2.text = "";
        JuryText3.text = "";
        Isa.SetActive(false);

        yield return new WaitForSeconds(3);
        Arda1.SetActive(true);
        yield return new WaitForSeconds(2);
        Arda2.SetActive(true);
        yield return new WaitForSeconds(2);
        Arda3.SetActive(true);
        yield return new WaitForSeconds(2);
        
    }
    void Start()
    {
        
    }

    public void GADDayum()
    {
        switch (ActionNumber)
        {
            case 1:
            ActionNumber++;
            break;
            case 2:
            ActionNumber++;
            break;
            
        }
    } 
}
