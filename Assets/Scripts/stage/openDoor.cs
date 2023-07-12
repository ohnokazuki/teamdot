using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class openDoor : MonoBehaviour
{
    [SerializeField]
    Tilemap doorTile;

    [SerializeField]
    TileBase nothing;

    Vector3Int target;
    Vector3 Acollider;

    private void Start()
    {
        //doorTile = gameObject.GetComponent<Tilemap>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hey guys! I'm tile map collider!");
        Acollider = collision.transform.position;
        Acollider = Camera.main.ScreenToWorldPoint(Acollider);
        target.x = (int)Acollider.x; target.y = (int)Acollider.y + 1; target.z = (int)Acollider.z;
        Debug.Log("You touched " + target);
        Debug.Log("collision args " + Acollider);
        doorTile.SetTile(target,nothing);
    }


}
