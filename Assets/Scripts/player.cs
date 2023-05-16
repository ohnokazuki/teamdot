using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool isArea;
    public float speed = 5.0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Operation();
        rb.velocity = Vector2.zero;
    }

    void Operation()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= transform.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.right * speed * Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "DangerArea")
        {
            isArea = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "DangerArea")
        {
            isArea = false;
        }
    }
}
