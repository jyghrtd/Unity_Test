using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEvent : MonoBehaviour
{
    private SaveNLoad theSaveNLoad;

    public void OnClickLoadBtn()
    {
        Debug.Log("Clicked Load Button");
        theSaveNLoad.CallLoad();
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
            theSaveNLoad.CallLoad();
        }*/
    }
}
