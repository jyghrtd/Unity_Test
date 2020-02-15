using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{

    public string[] sentences;
    public Transform chatTransform; //말풍선 위치지정
    public GameObject chatBoxPrefab;//Chatbox 복제

    // Start is called before the first frame update
    private void Start()
    {
        Invoke("TalkNPC", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TalkNPC()
    {
        GameObject go = Instantiate(chatBoxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentences, chatTransform);
        Invoke("TalkNPC", 5f);
    }
}
