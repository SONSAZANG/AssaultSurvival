using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject playerPrefab;
    
    void EnemySpawn()
    {
        Instantiate(enemyPrefab, gameObject.transform); 
    }

    private void Start()
    {
        InvokeRepeating("EnemySpawn", 0f, 1f);
    }
}
