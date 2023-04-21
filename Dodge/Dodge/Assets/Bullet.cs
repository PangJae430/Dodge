using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // ź�� �̵� �ӷ�
    // �̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigidbody;

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        // bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }
}
