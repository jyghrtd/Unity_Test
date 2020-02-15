using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    /*
    #region properties
    public Transform m_BaseObject; //원래 위치
    public Transform m_OtherObject; //이동 위치
    #endregion
    */

    public GameObject TargetObject;
    public GameObject ToObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") //CompareTag("Player"))
        {
            TargetObject = collision.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") //CompareTag("Player"))
        {
            StartCoroutine(TeleportRoutine());
        }
    }

    IEnumerator TeleportRoutine()
    {
        yield return null;
        TargetObject.transform.position = ToObject.transform.position;
    }
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
