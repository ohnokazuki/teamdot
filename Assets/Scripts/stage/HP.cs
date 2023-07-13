using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HP : MonoBehaviour
{

    // max HP should be set
    float maxHP;
    float currentHP;

    [SerializeField]
    GameObject HP_G_bar, HP_empty_bar;
    //GameObject[] HP_bars;

    // scale setting
    [SerializeField] float scale = 1;
    Vector3 barScale;
    Vector3 newBarScale;

    float HP_rate;

    

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;

        //GameObject.Instantiate<GameObject>(HP_G_bar);
        //GameObject.Instantiate<GameObject>(HP_empty_bar);

        barScale =  HP_G_bar.transform.transform.localScale;
        Debug.Log("hp init " + barScale);
        HP_rate = 1;
    }

    public void initHP(float maxHP)
    {
        this.maxHP = maxHP;
        this.currentHP = maxHP;
    }

    // set hp when target hp is changed
    // if hp becane lower 0 return false that mean target is dead.
    public bool setHP(float hp)
    {
        currentHP = hp;

        HP_rate = currentHP / maxHP;
        newBarScale = barScale;
        newBarScale.x = barScale.x * HP_rate;
        // Debug.Log("set HP " + newBarScale + "\n" + barScale);
        HP_G_bar.transform.transform.localScale = newBarScale;

        if (currentHP > 0) return true;
        else return false;
    }


}
