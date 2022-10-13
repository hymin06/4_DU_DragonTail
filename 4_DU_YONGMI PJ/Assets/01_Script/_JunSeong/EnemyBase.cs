using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyBase : MonoBehaviour
{
    [SerializeField] protected EnemySO _enemy;
    protected CapsuleCollider2D _enemyCollider;// enemy모양따라 달라질예정

    private void Awake()
    {
        _enemyCollider = GetComponent<CapsuleCollider2D>();
    }
}
