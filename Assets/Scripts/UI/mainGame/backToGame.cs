using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToGame : MonoBehaviour
{
    [SerializeField]
    string targetGameObj = "pauseMenu";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestoryPauseMenu()
    {
        Debug.Log("Working " + targetGameObj);
        //SceneManager.UnloadSceneAsync(targetGameObj);
        var canvas = GameObject.FindGameObjectsWithTag(targetGameObj);
        for(int i = 0; i < canvas.Length; i++)
        {
            canvas[i].gameObject.SetActive(false);
        }

    }
}
