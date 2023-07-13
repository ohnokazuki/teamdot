using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBarTest : MonoBehaviour
{
    HP HPBar;
    float hp;
    float maxHp;
    float delta;

    // Start is called before the first frame update
    void Start()
    {
        hp = 0; maxHp = 10; delta = 0.1f;
        HPBar = gameObject.GetComponentInChildren<HP>();
        // Debug.Log("Test script: " + HPBar.name + " is found");

        HPBar.initHP(maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < maxHp) hp += delta;
        else hp = 0;
        // Debug.Log("HP is " + hp);
        HPBar.setHP(hp);
    }
}
