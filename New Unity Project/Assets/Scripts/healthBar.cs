using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public float Health; //valor entre 0 e 100
    public Image HealthAmount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthAmount.fillAmount = Health/100;
    }
}
