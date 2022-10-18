using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsWeapon : MonoBehaviour
{
    [SerializeField] private LayerMask _mask1;
    [SerializeField] private LayerMask _mask2;
    [SerializeField] private BoxCollider2D _collider;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _power;
    [SerializeField] private bool _shooting;
    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void Grab()
    {
        Debug.Log("Ω√¿€");
        _collider.isTrigger = true;
        _rigidbody.velocity = Vector2.zero;
        _shooting = false;
        Debug.Log("≥°");
    }

    public void Shoot(Vector2 dir)
    {
        _shooting = true;
        _rigidbody.gravityScale = 0;
        _rigidbody.AddForce(dir * _power, ForceMode2D.Impulse);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.GetComponent<IsWall>() && _shooting)
        {
            _rigidbody.velocity = Vector2.zero;
            _collider.isTrigger = false;
            _shooting =false;
        }
    }
}
