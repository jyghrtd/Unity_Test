﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveEvent : MonoBehaviour
{
<<<<<<< HEAD
    public void OnClickSaveBtn()
    {
        Debug.Log("Clicked Save Button");
=======
    private SaveNLoad theSaveNLoad;

    public void OnClickSaveBtn()
    {
        Debug.Log("Clicked Save Button");
        theSaveNLoad.CallSave();
>>>>>>> jun_bran
    }

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        
=======
        theSaveNLoad = FindObjectOfType<SaveNLoad>();
>>>>>>> jun_bran
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
        /*if (Input.GetMouseButtonDown(0))
        {
            theSaveNLoad.CallSave();
        }*/
>>>>>>> jun_bran
    }
}
