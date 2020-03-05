using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerMove thePlayer;
    private CameraController theCamera;

    

    public void LoadStart()
    {
        StartCoroutine(LoadWaitCoroutine());
    }

    IEnumerator LoadWaitCoroutine()
    {
        yield return new WaitForSeconds(0.5f);

        thePlayer = FindObjectOfType<PlayerMove>();
        theCamera = FindObjectOfType<CameraController>();

        //theCamera.target = GameObject.Find("Player");


    } 
}
