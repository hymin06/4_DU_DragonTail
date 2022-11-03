using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelManager : MonoBehaviour
{
    public int playerLevel;
    //
    public float exp;
    [SerializeField] private float maxExp;
    [SerializeField] private float increaseMaxExp;
    //

    void Update()
    {
        Test();
        LevelUp();
    }
    public void ExpGet(float increaseExp)
    {
        exp += increaseExp;
    }
    void Test()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ExpGet(1);
        }    
    }
    void LevelUp()
    {
        if(exp >= maxExp)
        {
            exp -= maxExp;
            playerLevel++;
            maxExp += increaseMaxExp;
        }
    }
}
