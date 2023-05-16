using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmaterial : MonoBehaviour
{
    public GameObject bulletprefab;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;  // �e�̑��x
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �N���b�N�������W�̎擾�i�X�N���[�����W���烏�[���h���W�ɕϊ��j
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // �����̐����iZ�����̏����Ɛ��K���j
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // �e�i�Q�[���I�u�W�F�N�g�j�̐���
            GameObject clone = Instantiate(bulletprefab, transform.position+(shotForward*3), Quaternion.identity);

            // �e�ɑ��x��^����
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

        }
    }
}
