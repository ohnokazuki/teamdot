using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCurrentStage : MonoBehaviour
{
    [SerializeField]
    string currentStage = "Stage";
    [SerializeField]
    string nextStage = "Stage";

    // Start is called before the first frame update
    void Start()
    { 
        player.currentStage = currentStage;
        player.nextStage = nextStage;
        Debug.Log("The next stage is " + player.nextStage);

        player.movable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
