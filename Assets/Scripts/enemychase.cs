using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemychase : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;
    public float speed;
    public int enemyhp;
    void Start()
    {
        //speed = 0.05f;
        target = GameObject.Find("Player");
    }

    void Update()
    {
        if (target.GetComponent<player>().isArea == true)
        {
            GetComponent<Renderer>().material.color = Color.red;
            // transform.LookAt(target.transform);
            //transform.position += transform.forward * speed;
            Vector3 enemyForward = Vector3.Scale((target.transform.position - transform.position), new Vector3(1, 1, 0)).normalized;
            this.GetComponent<Rigidbody2D>().velocity = enemyForward * speed;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
            Vector3 enemyForward = Vector3.Scale((target.transform.position - transform.position), new Vector3(1, 1, 0)).normalized;
            this.GetComponent<Rigidbody2D>().velocity = enemyForward * 0;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemyhp--;
        }
        if (enemyhp <= 0)
        {
            Destroy(this.gameObject, 0.01f);
        }
    }
}
