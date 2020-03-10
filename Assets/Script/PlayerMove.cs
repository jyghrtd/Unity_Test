using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    static public PlayerMove instance;
    private SaveNLoad theSaveNLoad;

    public string currentMapName; //transferMap 스크립트의 transferMapName변수값 저장
    public string currentSceneName; //현재 한 신에 맵 여러개 안 만들었음

    public int speed;

    private Rigidbody2D rigidBody;
    private Vector2 vector;


    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vector.x = Input.GetAxisRaw("Horizontal");
        vector.y = Input.GetAxisRaw("Vertical");

        rigidBody.velocity = vector.normalized * speed;
    }
}
