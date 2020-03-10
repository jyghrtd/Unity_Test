using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{

    public static DatabaseManager instance; //강좌에서 넣으래서 넣었지 당장의 용도를 모름

    private void Awake() //강좌에서 넣으래서 넣었지 당장의 용도를 모름
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    public string[] varName;
    public float[] var;

    public string[] switchName;
    public bool[] switches;

}
