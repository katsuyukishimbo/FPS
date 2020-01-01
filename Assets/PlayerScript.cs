using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x  =  Input.GetAxisRaw("Horizontal");
 
        // 上下のキー入力を受け取る
        float z  =  Input.GetAxisRaw("Vertical");
    
        // 移動する向きを求める
        Vector3 direction = new Vector3 (x, 0, z).normalized;
    
        // 移動するスピードを求めて代入する
        GetComponent<Rigidbody>().velocity = direction * speed;
    }
}
