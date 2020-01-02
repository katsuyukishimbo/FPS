using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject flash;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;
    // Start is called before the first frame update
    Renderer _renderer;
    void Start()
    {
        _renderer = flash.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
             _renderer.enabled = false;
            shotInterval += 1;
 
            if (shotInterval % 5 == 0 && shotCount > 0)
            {
                shotCount -= 1;
 
                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
 
                Destroy(bullet, 3.0f);
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            shotCount = 30;
           
        }
    }
}
