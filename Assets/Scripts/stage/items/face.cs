using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class face : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.items.Add("strong face");
            Destroy(gameObject);
            Debug.Log("Player get strong face");

            GameObject Aplayer = collision.gameObject;

        }
    }
}
