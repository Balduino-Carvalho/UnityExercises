using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeCount;
    public float SpawnerTime = 5;
    public List<GameObject> Walls = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;
        if (TimeCount>=SpawnerTime)
        {
            Instantiate(Walls[Random.Range(0,Walls.Count)], transform.position, transform.rotation);

            TimeCount = 0f;
        }
    }
}
