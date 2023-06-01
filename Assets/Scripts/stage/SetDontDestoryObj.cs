using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDontDestoryObj : MonoBehaviour
{
    List<GameObject> objs;
    
    // Avoid to remove any obj in GameScene when game clear scene is loaded.
    void Start()
    {
        objs = new List<GameObject>();
        foreach (GameObject obj in UnityEngine.Object.FindObjectsOfType<GameObject>())
        {
                objs.Add (obj);
                DontDestroyOnLoad (obj);
                //Debug.Log("find obj in GameScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
