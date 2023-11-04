using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject [ ] enemyPrefabs;
    [SerializeField] Transform  [ ] createPositions;

    void Start()
    {
        StartCoroutine(CreateRoutine());
    }

    IEnumerator CreateRoutine()
    {
        yield return new WaitForSeconds(5f);

        Debug.Log("Create Enemy");
    }
}
