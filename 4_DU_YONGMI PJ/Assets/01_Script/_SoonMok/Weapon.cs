using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public bool IsShooting;
    public bool IsStopped;

    [SerializeField] private int _playerLayer;
    [SerializeField] private int _weaponLayer;
    Rigidbody2D _rigidbody;
    Collider2D _collider;
    private void Awake()

    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
        _weaponLayer = LayerMask.NameToLayer("Weapon");
        _playerLayer = LayerMask.NameToLayer("Player");
    }
    void Update()
    {
        if (IsStopped)
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }
    public void Grab()
    {
        _collider.isTrigger = true;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.gravityScale = 0f;
        IsStopped = false;

    }
    public void Shooting(Vector2 dir, float Power)
    {
        Physics2D.IgnoreLayerCollision(_playerLayer, _weaponLayer, true);
        _rigidbody.AddForce(dir * Power, ForceMode2D.Impulse);
        IsShooting = true;
        _collider.isTrigger = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsShooting)
        {
            if (collision.gameObject.GetComponent<IsWall>())
            {
                Physics2D.IgnoreLayerCollision(_playerLayer, _weaponLayer, false);
                _rigidbody.velocity = Vector2.zero;
                IsShooting = false;
                IsStopped = true;
            }
        }

    }
}