using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverse : MonoBehaviour
{
    public float point;
    // Start is called before the first frame update
    void Start()
    {
        
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

            if (shotForward.x < 0 & point > 0)
            {
                this.transform.eulerAngles = new Vector3(0, 0, 0);
                point = shotForward.x;
            }
            else if (shotForward.x > 0 & point < 0)
            {
                this.transform.eulerAngles = new Vector3(0, 180, 0);
                point = shotForward.x;
            }
        }
    }
}
