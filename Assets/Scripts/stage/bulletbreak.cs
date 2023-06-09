using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbreak : MonoBehaviour
{
    //生成されてから消えるまでの時間
    float deadTime = 5;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // call this function in update function
    // 一定の時間で消えるようにしてみた
    void destoryBulletByTime()
    {
        time += Time.deltaTime;
        if(time > deadTime)
        {
            Debug.Log("時間切れ");
            Destroy(gameObject);
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        destoryBulletByTime();
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
