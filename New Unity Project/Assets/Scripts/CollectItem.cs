using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    // Start is called before the first frame update
    public int CoinCount;
    public Text CoinCounter;

    void Update()
    {
        CoinCounter.text ="X " + CoinCount.ToString ();
    }
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            CoinCount +=10;
            Destroy(collision.gameObject);
        }
    }
}
