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
        speed = 10.0f;  // 弾の速度
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // クリックした座標の取得（スクリーン座標からワールド座標に変換）
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 向きの生成（Z成分の除去と正規化）
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

            // 弾（ゲームオブジェクト）の生成
            GameObject clone = Instantiate(bulletprefab, transform.position+(shotForward*3), Quaternion.identity);

            // 弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;

        }
    }
}
