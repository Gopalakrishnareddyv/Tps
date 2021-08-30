using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject gun;
    [SerializeField] GameObject coin;
    public static Gun instance;
    public bool isGun;
    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                
                if (Coin.coinInstance.isCoin)
                {
                    //this.gameObject.SetActive(true);
                    gun.SetActive(true);
                    coin.SetActive(false);
                    isGun = true;
                    //Debug.Log(isGun);
                }
                else
                {
                    Debug.Log("Go and Get a COin");
                }

            }
            else
            {

            }
        }
    }
}
