using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbreak : MonoBehaviour
{
    //��������Ă��������܂ł̎���
    float deadTime = 5;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // call this function in update function
    // ���̎��Ԃŏ�����悤�ɂ��Ă݂�
    void destoryBulletByTime()
    {
        time += Time.deltaTime;
        if(time > deadTime)
        {
            Debug.Log("���Ԑ؂�");
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
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("��������");
            // 0.2�b��ɏ�����
            Destroy(gameObject, 0.01f);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject, 0.01f);
        }
    }
}
