using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextStage : MonoBehaviour
{
    //[SerializeField]
    //string targetStage = "Stage";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadStage()
    {
        // do not destory property is attached to all stage gameobjs so destory gameobjs manually.
        var test = GameObject.FindObjectsOfType<GameObject>();
        foreach (var t in test)
        {
            if(player.nextStage == "End" && t.name == "Player")
            {                    
                    continue;
            }

            Destroy(t);
        }

        if(player.nextStage != "End")
        {
            SceneManager.LoadScene(player.nextStage);
        }
        else
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}
