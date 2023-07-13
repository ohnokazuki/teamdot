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

    [SerializeField]
    GameObject Grid;

    Vector3Int target;
    Vector3 Acollider;

    [SerializeField]
    float scale;
    [SerializeField]
    float Unit;

    private void Start()
    {
        //doorTile = gameObject.GetComponent<Tilemap>();
    }

    Vector3 convertTileMapPosition(Vector3 playerPosition)
    {
        // 0,0,0
        // get grid position
        Vector3 GridTrans = Grid.transform.position;
        Vector3 tileMapPosition = new Vector3(playerPosition.x + GridTrans.x,playerPosition.y + GridTrans.y,playerPosition.z + GridTrans.z);
        return tileMapPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hey guys! I'm tile map collider!");
        Acollider = collision.transform.position;
        Acollider = convertTileMapPosition(Acollider);
        target.x = (int)Acollider.x; target.y = (int)Acollider.y + 1; target.z = (int)Acollider.z;
        Debug.Log("You touched " + target);
        Debug.Log("collision args " + Acollider);
        doorTile.SetTile(target,nothing);
    }


}
