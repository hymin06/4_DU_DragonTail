using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] protected EnemySO _enemy;
    protected CapsuleCollider2D _enemyCollider;// enemy������ �޶�������
    protected Animator _animator;

    protected virtual void Awake()
    {
        _enemyCollider = GetComponent<CapsuleCollider2D>();
        _animator = GetComponent<Animator>();   
    }
}
