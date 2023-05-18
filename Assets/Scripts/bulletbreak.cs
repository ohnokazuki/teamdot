using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbreak : MonoBehaviour
{
    //¶¬‚³‚ê‚Ä‚©‚çÁ‚¦‚é‚Ü‚Å‚ÌŠÔ
    float deadTime = 5;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // call this function in update function
    // ˆê’è‚ÌŠÔ‚ÅÁ‚¦‚é‚æ‚¤‚É‚µ‚Ä‚İ‚½
    void destoryBulletByTime()
    {
        time += Time.deltaTime;
        if(time > deadTime)
        {
            Debug.Log("ŠÔØ‚ê");
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
        // Õ“Ë‚µ‚½‘Šè‚ÉPlayerƒ^ƒO‚ª•t‚¢‚Ä‚¢‚é‚Æ‚«
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("“–‚½‚Á‚½");
            // 0.2•bŒã‚ÉÁ‚¦‚é
            Destroy(gameObject, 0.01f);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject, 0.01f);
        }
    }
}
