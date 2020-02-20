using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuEvent : MonoBehaviour
{

    public static MenuEvent instance;
    public GameObject SaveBtn;
    public bool isMenuOpened = false;

    public void OnClickMenuBtn()
    {
        isMenuOpened = !isMenuOpened;
    }

    

    void Update()
    {
        if (isMenuOpened)
        {
            SaveBtn.gameObject.SetActive(true);
        }
        else
        {
            SaveBtn.gameObject.SetActive(false);
        }
    }

    

}
