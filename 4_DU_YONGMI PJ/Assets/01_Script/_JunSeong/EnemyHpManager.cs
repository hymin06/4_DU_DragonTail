using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpManager : EnemyBase
{
    int hp;
    int damage;

    private void Awake()
    {
        this.hp = _enemy.HP();
        this.damage = _enemy.Damage();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�� â�� �¾����� �Ǳ����
        //��ֹ��� �ִٸ� ��ֹ��� �¾����� �Ǳ���
    }


}
