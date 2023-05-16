using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("当たった");
            // 0.2秒後に消える
            Destroy(gameObject, 0.01f);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject, 0.01f);
        }
    }
}
