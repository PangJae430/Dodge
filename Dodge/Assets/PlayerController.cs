using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;//이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;// 이동 속력

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        //위쪽 방향키 입력이 감지된 경우 z 방향 힘주기

        if(Input.GetKey(KeyCode.DownArrow)==true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        //아래쪽 방향키 입력이 감지된 경우 -z 방향 힘주기

        if (Input.GetKey(KeyCode.RightArrow)==true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        //오른쪽 방향키 입력이 감지된 경우 x 방향 힘주기

        if (Input.GetKey(KeyCode.LeftArrow)==true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        //왼쪽 방향키 입력이 감지된 경우 -x 방향 힘주기
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
    //자신의 게임 오브젝트를 비활성화
    //컴포넌트 활성화 / 비활성화 : enabled
}
