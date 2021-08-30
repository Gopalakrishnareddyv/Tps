using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject coin;
    public static Coin coinInstance;
    public bool isCoin;
    private void Awake()
    {
        coinInstance = this;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                this.gameObject.SetActive(false);
                coin.SetActive(true);
                isCoin = true;
            }
        }
    }
}
