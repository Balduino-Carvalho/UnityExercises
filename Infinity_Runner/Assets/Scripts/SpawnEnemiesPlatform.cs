using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesPlatform : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject currentEnemy;


    public List<Transform> points = new List<Transform>();    


    void Start()
    {
        CreateEnemy();
    }

    
    void Update()
    {
        
    }
    public void SpawnGroundEnemy()
    {
        //identifica se o inimigo foi destruído
        if (currentEnemy == null)
        {
            CreateEnemy();
        }
    }

    void CreateEnemy ()
    {
        int pos = Random.Range(0,points.Count);

        GameObject e = Instantiate (enemyPrefab, points[pos].position, points[pos].rotation);
        currentEnemy= e;
        
    }
}
