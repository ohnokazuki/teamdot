using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{
    [SerializeField]
    string targetScene = "Start";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadStartScene()
    {
        var objs = GameObject.FindObjectsOfType<GameObject>();
        foreach (var obj in objs)
        {
            Destroy(obj);
        }
        SceneManager.LoadScene(targetScene);
    }
}
