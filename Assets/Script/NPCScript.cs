using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCMove
{
    [Tooltip("NPCMove를 체크하면 NPC가 움직임")]
    public bool NPCmove;
    public string[] direction; //이동방향
    [Range(1, 5)] [Tooltip("1: 천천히 2: 조금 천천히 3: 보통 4: 빠르게 5: 연속적으로")]
    public int frequency; // 방향에 따른 이동속도
}

public class NPCScript : MovingObject
{
    [SerializeField]
    public NPCMove npc;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMove()
    {

    }
    public void SetNotMove()
    {

    }

     IEnumerator MoveCoroutine()
    {
        if(npc.direction.Length != 0)
        {
            for (int i = 0; i < npc.direction.Length; i++)
            {
                switch (npc.frequency)
                {
                    case 1:
                        yield return new WaitForSeconds(4f);
                        break;
                    case 2:
                        yield return new WaitForSeconds(3f);
                        break;
                    case 3:
                        yield return new WaitForSeconds(2f);
                        break;
                    case 4:
                        yield return new WaitForSeconds(1f);
                        break;
                    case 5:
                        break;
                }

                yield return new WaitUntil(() => NPCCanMove);
                base.Move(npc.direction[i]);

                if (i == npc.direction.Length - 1)
                    i = -1;
            }
        }
    }
}
