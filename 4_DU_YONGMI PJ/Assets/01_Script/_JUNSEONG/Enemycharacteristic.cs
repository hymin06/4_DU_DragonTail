using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycharacteristic : MonoBehaviour
{
    [SerializeField] EnemySO _enemy;
    private void Awake()
    {
        switch (_enemy.enemyType)
        {
            case EnemyType.NormalEnemy:
                break;
            case EnemyType.ShieldEnemy:
                //���常�� Ư���� �ִ� �Լ� ȣ��
                break;
            case EnemyType.Boss:
                //�������� Ư���� �ִ� �Լ� ȣ��
                break;
            default:
                Debug.Log("�������� �ʴ� �� Ÿ���̾�!");
                break;
        }
    }

    void ShieldEnemy()
    {

    }

    void Boss()
    {

    }
}
