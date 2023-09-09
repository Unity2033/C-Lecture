using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    public Stat()
    {
        Debug.Log("Stat ����");
    }
}

public class Player : MonoBehaviour
{
    #region ���� ������
    // Ŭ���� ������ ���ԵǾ� �ִ� �Ӽ��� ���� ������
    // �����ϴ� �������Դϴ�.
    Stat stat = new Stat();

    // public
    // Ŭ���� ���ο� �ڱⰡ ����ϰ� �ִ� Ŭ���� �׸���
    // Ŭ���� �ܺο����� ������ ����ϴ� �������Դϴ�.
    public int health = 100;

    // private
    // Ŭ���� ���ο����� ������ �Ͽ��ϴ� �������Դϴ�.
    private float speed;

    // ���� �����ڸ� �������� ������ �⺻ ���� ������(private)�� �����˴ϴ�.
    Vector3 direction;

    #endregion

    // Start( ) : ���� ������Ʈ�� �����Ǿ��� ��, �� �� ���� ȣ��Ǹ�
    //            ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ����� �ʽ��ϴ�.
    private void Start()
    {
        speed = 5.0f;
    }

    // Start( ) : �� �����Ӹ��� ����Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void Update()
    {
        // P = P0 + vt
        // Input.GetAxis : -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ��Դϴ�.
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // ������ ����ȭ
        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime);
    }

}
