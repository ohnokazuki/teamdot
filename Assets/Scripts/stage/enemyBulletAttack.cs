using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletAttack : MonoBehaviour
{
    [SerializeField]
    public GameObject bulletprefab;

    float speed;
    float timer;

    [SerializeField]
    int interval = 1; //sec

    GameObject Aplayer;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;  // �e�̑��x
        timer = 0;

        Aplayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // copied from player.cs
        if(timer  > interval)
        {
            // �N���b�N�������W�̎擾�i�X�N���[�����W���烏�[���h���W�ɕϊ��j
            //Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Aplayer.transform.position);
            Vector3 mouseWorldPos = Aplayer.transform.position;

            // �����̐����iZ�����̏����Ɛ��K���j
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // �e�i�Q�[���I�u�W�F�N�g�j�̐���
            GameObject clone = Instantiate(bulletprefab, transform.position + (shotForward * 3), Quaternion.identity);

            // �e�ɑ��x��^����
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
            timer = 0;
        }

    }
}
