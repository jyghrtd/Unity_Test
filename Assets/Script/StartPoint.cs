using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{

    public string startPoint; // 시작 위치
    private PlayerMove thePlayer;
    //private JoystickTest theStick;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMove>();
        //theStick = FindObjectOfType<JoystickTest>();

        if (startPoint == thePlayer.currentMapName)
        {
            thePlayer.transform.position = this.transform.position;
            //theStick.transform.position = 
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
