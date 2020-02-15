using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public int speed;
    private Vector2 vector;
    public int walkCount;
    protected int currentWalkCount;

    protected bool NPCCanMove = true;

    protected void Move(string _dir)
    {
        StartCoroutine(MoveCoroutine(_dir));
    }

    IEnumerator MoveCoroutine(string _dir)
    {
        NPCCanMove = false;

        vector.Set(0, 0);
        switch (_dir)
        {
            case "UP":
                vector.y = 1f;
                break;
            case "DOWN":
                vector.y = -1f;
                break;
            case "RIGHT":
                vector.x = 1f;
                break;
            case "LEFT":
                vector.x = -1f;
                break;
        }

        while(currentWalkCount < walkCount)
        {
            transform.Translate(vector.x * speed, vector.y * speed, 0); 
            currentWalkCount++;
            yield return new WaitForSeconds(0.01f);
        }
        currentWalkCount = 0;

        NPCCanMove = true;
    }
}
