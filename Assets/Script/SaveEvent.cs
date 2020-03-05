using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveEvent : MonoBehaviour
{
    private SaveNLoad theSaveNLoad;

    public void OnClickSaveBtn()
    {
        Debug.Log("Clicked Save Button");
        theSaveNLoad.CallSave();
    }

    // Start is called before the first frame update
    void Start()
    {
        theSaveNLoad = FindObjectOfType<SaveNLoad>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            theSaveNLoad.CallSave();
        }*/
    }
}
