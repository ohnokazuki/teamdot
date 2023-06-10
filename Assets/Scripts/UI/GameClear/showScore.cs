using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Aplayer = GameObject.FindGameObjectWithTag("Player");
        Text textScore = gameObject.GetComponent<Text>();
        textScore.text = player.killedEnemy.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
