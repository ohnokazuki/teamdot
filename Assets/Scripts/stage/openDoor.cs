using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class openDoor : MonoBehaviour
{

    Tile doorTile;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hey guys! I'm tile map collider!");
    }


}
