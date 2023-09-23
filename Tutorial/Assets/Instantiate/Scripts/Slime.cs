using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] float speed = 1.0f;

    // FixedUpdate() : TimeStep�� ������ ���� ���� ������ ��������
    // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // OnTriggerEnter : Trigger�� �浹���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Attack", true);
    }

    // OnTriggerStay : Trigger�� �浹 ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Attack", false);
    }

}
