using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private int maxHp;
    [SerializeField] private int hp;

    void Update()
    {
        Test();
        if(hp > maxHp)
        {
            hp = maxHp;
        }
        if(hp <= 0)
        {
            Die();
        }
    }
    public void HpDamaged(int damage)
    {
        hp -= damage;
    }
    public void HpHeal(int heal)
    {
        if(!(hp == maxHp) || !(hp + heal > maxHp))
        {
            hp += heal;

        }
    }
    //
    void Test()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HpDamaged(1);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            HpHeal(1);
        }
    }
    //
    public void Die()
    {

    }
}
