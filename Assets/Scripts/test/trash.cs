using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class trash : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Tilemap tilemap;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var test = GetComponent<TilemapCollider2D> ();
        Vector3 coass = test.transform.localScale;
        coass.x = 10;
        coass.y = 10;
        test.transform.localScale = coass;
    }
}
