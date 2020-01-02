using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public int damage;
    public GameObject Zombie3;
    public EnemyScript hp;   
    // Start is called before the first frame update
    void Start()
    {
        Zombie3 = GameObject.Find("Zombie3");
        hp = Zombie3.GetComponent<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        hp.Damage(damage);

        Destroy(other.gameObject);
    }
}
