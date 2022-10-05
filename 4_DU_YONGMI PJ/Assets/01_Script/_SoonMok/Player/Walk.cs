using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private LayerMask _layerMask2;
    [SerializeField] private float _boxX;
    [SerializeField] private float _boxY;
    [SerializeField] private float jumppower;
    [SerializeField] private float speed;
    [SerializeField] private BoxCollider2D col;
    [SerializeField] private Collider2D col2;
    [SerializeField] private RaycastHit2D downpan;
    [SerializeField] private float gravity;
    [SerializeField] private bool JumpOk;
    Rigidbody2D rigibody;

    public int LR;

    private void Awake()
    {
        col = GetComponentsInChildren<BoxCollider2D>()[1];
        rigibody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        CheckGround();
        Move(Input.GetAxisRaw("Horizontal"));
        Jump(jumppower);
    }
    void Move(float x)
    {
        if(x != 0)
        {
            LR = (int)x;
        }
        rigibody.velocity = new Vector2(x * speed, rigibody.velocity.y);
    }
    void Jump(float JumpPow)
    {
        if (DownJump())
        {

            if (Input.GetKeyDown(KeyCode.X) && Input.GetKey(KeyCode.DownArrow))
            {
                StartCoroutine(DownStair());
                rigibody.AddForce(new Vector2(0, -JumpPow), ForceMode2D.Impulse);
            }
        }
        if (JumpOk)
        {

            if (Input.GetKeyDown(KeyCode.X))
            {
                rigibody.AddForce(new Vector2(0, JumpPow), ForceMode2D.Impulse);
            }
        }
    }
    void CheckGround()
    {
        RaycastHit2D hit = Physics2D.BoxCast(col.bounds.center, col.size, 0f, Vector2.down, 0.1f, _layerMask);
        RaycastHit2D hit2 = Physics2D.BoxCast(col.bounds.center, col.size, 0f, Vector2.down, 0.1f, _layerMask2);
        if (hit || hit2
            )
        {
            JumpOk = true;
            Debug.Log(hit);
            Debug.Log(hit2);
        }
        else
        {
            rigibody.velocity += Vector2.down * gravity * Time.deltaTime;
            JumpOk = false;
        }
    }
    bool DownJump()
    {
        downpan = Physics2D.BoxCast(col.bounds.center, col.size, 0f, Vector2.down, 0.1f, _layerMask2);
        if (downpan)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    IEnumerator DownStair()
    {
        col2= downpan.collider;
        col2.isTrigger = true;
        yield return new WaitForSeconds(0.5f);
        col2.isTrigger = false;
    }
}
