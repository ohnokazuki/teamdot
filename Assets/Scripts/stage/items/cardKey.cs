using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.items.Add("card key");
            Destroy(gameObject);
            Debug.Log("Player get card key");
        }
    }
}
