using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카메라를 조작하는 클래스
public class CameraController : MonoBehaviour
{
    static public CameraController instance;

    #region properties
    public Transform m_PlayerTransform; // 플레이어
    //public Transform ControllerTransform; //컨트롤러
    private Transform m_Transform; // 게임 오브젝트의 가장 기본적인 변수
    #endregion

    #region Method
    // Start is called before the first frame update = Update()가 호출되기 전 한번 실행
    void Start()
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

        // 변수에 값을 할당한다.
        m_Transform = transform;
    }

    // Update is called once per frame = 매 프레임마다 한번씩 계속해서 호출된다.
    void Update()
    {
        FollowPlayer();
        //FollowController();
    }

    // 카메라가 플레이어를 따라간다.
    private void FollowPlayer()
    {
        //플레이어 위치를 가져와 카메라 위치를 설정
        //m_Transform.position = m_PlayerTransform.position;

        // 플레이어의 z값은 따라가지 않는다.
        m_Transform.position = new Vector3(m_PlayerTransform.position.x, m_PlayerTransform.position.y, m_Transform.position.z);
    }
    #endregion

   /* private void FollowController()
    {
        ControllerTransform.position = new Vector3(m_PlayerTransform.position.x + 7, m_PlayerTransform.y - 3.5, ControllerTransform.z);
    }*/
}
