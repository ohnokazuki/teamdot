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
