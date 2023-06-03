using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayerByMobileUI : MonoBehaviour
{
    [SerializeField]
    string opration = "up";

    Transform playerTrns;
    float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerTrns = player.playerTrans;
        playerSpeed = player.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void movePlayer()
    {
        if(opration == "up")
        {
            playerTrns.position += playerTrns.up * playerSpeed * Time.deltaTime;
        }
        if (opration == "down")
        {
            playerTrns.position -= playerTrns.up * playerSpeed * Time.deltaTime;
        }
        if (opration == "left")
        {
            playerTrns.position += playerTrns.right * playerSpeed * Time.deltaTime;
        }
        if (opration == "right")
        {
            playerTrns.position -= playerTrns.right * playerSpeed * Time.deltaTime;
        }
    }
}
