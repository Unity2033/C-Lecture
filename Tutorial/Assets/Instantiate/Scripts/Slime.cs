using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] float speed = 1.0f;

    // FixedUpdate() : TimeStep에 설정된 값에 따라 일정한 간격으로
    // 호출되는 이벤트 함수입니다.
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // OnTriggerEnter : Trigger와 충돌했을 때 호출되는 이벤트 함수
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Attack", true);
    }

    // OnTriggerStay : Trigger와 충돌 중일 때 호출되는 이벤트 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Attack", false);
    }

}
