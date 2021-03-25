using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    //lista dos prefabs das plataformas
    public List<GameObject> platforms = new List<GameObject>();

    //lista das plataformas geradas na cena
    private List<Transform> currentPlatforms = new List<Transform>();
    public float offset;

    private Transform player;
    private Transform currentPlaformPoint;
    private int platformIndex;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i<platforms.Count; i++)
        {
           Transform p = Instantiate(platforms[i],new Vector2 (i*30,0), transform.rotation).transform;
           currentPlatforms.Add(p);
            offset +=30f;
        }

        currentPlaformPoint = currentPlatforms[platformIndex].GetComponent<Platform>().finalPoint;
    }

    
    void Update()
    {
        Move();
    }

    void Move ()
    {
        //salvando a diferença da posição x do player e do final point da plataforma atual
        float distance = player.position.x - currentPlaformPoint.position.x;

        //reciclar a plataforma
        if (distance >= 1)
        {
            Recycle (currentPlatforms[platformIndex].gameObject);
            platformIndex++;
            if(platformIndex > currentPlatforms.Count -1)
            {
                platformIndex = 0;
            }

            currentPlaformPoint = currentPlatforms[platformIndex].GetComponent<Platform>().finalPoint;
        }
    }

    public void Recycle(GameObject platform)
    {
        platform.transform.position = new Vector2(offset, 0f);
        offset +=30f;
    }
}
