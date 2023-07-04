using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HP : MonoBehaviour
{

    // max HP should be set
    static public float maxHP;
    static public float currentHP;

    [SerializeField]
    GameObject HP_G_bar, HP_empty_bar;
    //GameObject[] HP_bars;

    // scale setting
    [SerializeField] float scale = 1;
    Vector3 barScale;

    float HP_rate;

    

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        //HP_bars = GameObject.
        //foreach (GameObject bars in HP_bars)
        //{
        //    if(bars.name  == "HP(G)") HP_G_bar = bars;
        //    if(bars.name  == "HP(empty)") HP_empty_bar = bars;

        //    Debug.Log(bars.name + " is found");
        //}


        GameObject.Instantiate<GameObject>(HP_G_bar);
        GameObject.Instantiate<GameObject>(HP_empty_bar);

        barScale =  HP_G_bar.transform.transform.localScale;
        HP_rate = 1;
    }


    // set hp when target hp is changed
    // if hp becane lower 0 return false that mean target is dead.
    public bool setHP(float hp)
    {
        currentHP += hp;
        if(currentHP > 0) return true;
        else return false;

        HP_rate = currentHP / maxHP;
        HP_G_bar.transform.transform.localScale = new Vector3(barScale.x * HP_rate, barScale.y, barScale.z);
    }


}
