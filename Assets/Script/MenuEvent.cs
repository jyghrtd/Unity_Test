using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuEvent : MonoBehaviour
{

    public static MenuEvent instance;
    public GameObject SaveBtn;
    public GameObject LoadBtn;
    public bool isMenuOpened = false;
    private SaveNLoad theSaveNLoad;

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

        if (isMenuOpened)
        {
            LoadBtn.gameObject.SetActive(true);
        }
        else
        {
            LoadBtn.gameObject.SetActive(false);
        }

        /*if (SaveBtn = input.GetMouseButton(0))
        {
            theSaveNLoad.CallSave;
        }
        if (LoadBtn = input.GetMouseButton(0))
        {
            theSaveNLoad.CallLoad;
        }*/
    }

    

}
