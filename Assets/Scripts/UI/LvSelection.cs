using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LvSelection : MonoBehaviour
{
    public Button[] lvlButtons;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 3);

        for (int i = 0; i < lvlButtons.Length; i++)
        {

            if(i + 3 > levelAt)
            {
                lvlButtons[i].interactable = false;
                lvlButtons[i].transform.Find("Text").gameObject.SetActive(false);
                lvlButtons[i].transform.Find("Lock").gameObject.SetActive(true);
            }
            else
            {
                lvlButtons[i].interactable = true;
                lvlButtons[i].transform.Find("Text").gameObject.SetActive(true);
                lvlButtons[i].transform.Find("Lock").gameObject.SetActive(false);
                
            }
            
        }


    }

}
