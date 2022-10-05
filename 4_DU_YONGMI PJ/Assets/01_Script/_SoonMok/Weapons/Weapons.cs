using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public bool Isgrabbed;
    public bool IsStopped;
    public float ShootPower;

    [SerializeField] Collider2D _thisCollider;
    [SerializeField] Rigidbody2D _thisRigidbody;
    [SerializeField] LayerMask _wallLayer;
    [SerializeField] LayerMask _enemyLayer;

    private void OnEnable()
    {
        _thisCollider = GetComponent<BoxCollider2D>();
        _thisRigidbody = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<IsWall>() && !Isgrabbed)
        {
            Debug.Log("asdf");
            _thisCollider.isTrigger = false;
            _thisRigidbody.velocity = Vector2.zero;
            _thisRigidbody.gravityScale = 5f;
            IsStopped = true;
        } 
    }

    public void Shoot(float LR)
    {
        transform.parent = null;
        _thisCollider.isTrigger = true;
        Isgrabbed = false;
        _thisRigidbody.gravityScale = 1f;
        _thisRigidbody.AddForce(new Vector2(ShootPower * LR * 10, 0));
    }
    public void Grap(GameObject Player)
    {
        _thisCollider.isTrigger = true;
        transform.parent = Player.transform;
        transform.position = GameObject.Find("WeaponPos").transform.position;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _thisRigidbody.gravityScale = 0;
        _thisRigidbody.freezeRotation = true;
        Isgrabbed = true;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position = Vector3.zero;
        }
        //if (Input.GetKeyDown(KeyCode.K))
        //{

        //}
        //if (Input.GetKeyDown(KeyCode.K))
        //{

        //}
    }
}
