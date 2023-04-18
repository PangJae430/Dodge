using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;//�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;// �̵� �ӷ�

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        //���� ����Ű �Է��� ������ ��� z ���� ���ֱ�

        if(Input.GetKey(KeyCode.DownArrow)==true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        //�Ʒ��� ����Ű �Է��� ������ ��� -z ���� ���ֱ�

        if (Input.GetKey(KeyCode.RightArrow)==true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        //������ ����Ű �Է��� ������ ��� x ���� ���ֱ�

        if (Input.GetKey(KeyCode.LeftArrow)==true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        //���� ����Ű �Է��� ������ ��� -x ���� ���ֱ�
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
    //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
    //������Ʈ Ȱ��ȭ / ��Ȱ��ȭ : enabled
}
