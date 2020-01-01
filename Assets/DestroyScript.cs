using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public int damage;          //当たった部位毎のダメージ量
    public GameObject Zombie3;   //敵オブジェクト
    public EnemyScript hp;   
    // Start is called before the first frame update
    void Start()
    {
        Zombie3 = GameObject.Find("Zombie3");   //敵情報を取得
        hp = Zombie3.GetComponent<EnemyScript>();      //HP情報を取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
                    //HPクラスのDamage関数を呼び出す
            hp.Damage(damage);
 
            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);
        // //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        // if (other.CompareTag("Shell")){
 
        //     //HPクラスのDamage関数を呼び出す
        //     hp.Damage(damage);
 
        //     //ぶつかってきたオブジェクトを破壊する.
        //     Destroy(other.gameObject);
        // }
    }
}
