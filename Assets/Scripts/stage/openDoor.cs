using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    [SerializeField]
    List<string> doors = new List<string>();
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        doors.ForEach(door =>
        {
            if(collision.name == door)
            {
                GameObject targetDoor = collision.gameObject;
                if(targetDoor != null)
                {
                    targetDoor.SetActive(false);
                }
            }
        });
    }
}
