using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform firePoint;

    public float shootTime;
    private float shootCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootCount += Time.deltaTime;

        if(shootCount >= shootTime)
        {
            //joga bomba
            Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
            shootCount = 0f;
        }
    }
}
