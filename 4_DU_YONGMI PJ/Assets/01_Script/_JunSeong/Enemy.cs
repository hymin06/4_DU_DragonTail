using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] EnemySO enemySO;
    int hp;
    int damage;
    float speed;

    Vector2 dir;

    public LayerMask layerMask;
    //LayerMask collisionAfterChangeDirLayer;
    CapsuleCollider2D capsuleCollider;
    Rigidbody2D rigid;

    public bool _isPlayerWatchRight;
    private void Awake()
    {
        this.hp = enemySO.hp;
        this.damage = enemySO.damage;
        this.speed = enemySO.normalMoveSpeed;
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        rigid = GetComponent<Rigidbody2D>();

        //collisionAfterChangeDirLayer = enemySO.isCollisionTrueLayer;
    }

    private void Update()
    {
        BasicEnemyMove();
        if(enemySO.enemyType == EnemyType.ShortAttackEnemy)
        {
            ShortAttackEnemyMove();
        }
        else if(enemySO.enemyType == EnemyType.LongAttackEnemy)
        {
            LongAttackEnemyMove();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            Debug.Log("isIn");
            if (_isPlayerWatchRight)
            {
                _isPlayerWatchRight = false;
            }
            else
            {
                _isPlayerWatchRight = true; 
            }
        }
    }

    void BasicEnemyMove()
    {
        if (_isPlayerWatchRight)
        {
            dir = Vector2.right;
            
        }
        else
        {
            dir = Vector2.left;
        }
        rigid.velocity = new Vector2(dir.x * speed, rigid.velocity.y);
    }

    void ShortAttackEnemyMove()
    {

        ShortShootRay(dir);
    }

    void ShortShootRay(Vector2 dir)
    {
        RaycastHit2D detectPlayer = Physics2D.Raycast(capsuleCollider.bounds.center, dir,
            enemySO.DetectPlayerDistance, layerMask);
        Debug.DrawRay(capsuleCollider.bounds.center, dir * enemySO.DetectPlayerDistance, Color.green);
        if(detectPlayer)
        {
            speed = enemySO.AfterDetectMoveSpeed;
        }
        else
        {
            speed = enemySO.normalMoveSpeed;
        }
    }

    
    void LongAttackEnemyMove()
    {

    }
}
