using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    ShortAttackEnemy,
    LongAttackEnemy,
    Boss
}
[CreateAssetMenu(menuName = "Asset/EnemySO")]
public class EnemySO : ScriptableObject
{
    public EnemyType enemyType;
    public string name;
    public int hp;
    public int damage;
    public float normalMoveSpeed;
    public float AfterDetectMoveSpeed;
    public float DetectPlayerDistance;
    public float AttackRange;
    public float AttackDelay;
    public bool _isCollisionOther;
    public LayerMask isCollisionTrueLayer;

    
}
