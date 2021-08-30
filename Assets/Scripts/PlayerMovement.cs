using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float turnSpeed;
    CharacterController characterController;
    Animator playerAnimator;
    //[SerializeField] int bulletCount;
    float fireRate=0;
    [SerializeField] Text bulletText;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerAnimator=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        Fire();
    }
    public void PlayerMove()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizontal, 0, vertical);
        playerAnimator.SetFloat("PlayerSpeed", vertical);
        transform.Rotate(Vector3.up, horizontal * turnSpeed);
        characterController.SimpleMove(transform.forward*vertical*playerSpeed);
    }
    void Fire()
    {
        fireRate += Time.deltaTime;
        bulletText.text = "Bullets " + BulletPooling.bulletIstance.bulletCount;
        if (Input.GetMouseButtonDown(0))
        {
            if (fireRate >= 1 && BulletPooling.bulletIstance.bulletCount <= 50&&Gun.instance.isGun)
            {
                BulletPooling.bulletIstance.BulletSpawn();
                fireRate = 0f;
            }
            
        }
    }
}
