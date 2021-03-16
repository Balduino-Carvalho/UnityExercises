using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float Vel;
    void Start()
    {
        Destroy (gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (-Vector3.forward*Vel*Time.deltaTime);
    }
}
