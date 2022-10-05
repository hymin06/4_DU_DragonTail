using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] GameObject Weapon;
    [SerializeField] Weapons WpScript;
    [SerializeField] Transform GrabPos;
    private void Grab(GameObject weapon)
    {
        Weapon = weapon;
        WpScript = Weapon.GetComponent<Weapons>();
        WpScript.Grap(gameObject);
        Weapon.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Weapons>())
        {
            GrabPos = GameObject.Find("WeaponPos").transform;
            Grab(collision.gameObject);
        }
    }
    private void Update()
    {
        if (Weapon)
        {
            Weapon.transform.position = GrabPos.position;
            if (Input.GetKeyDown(KeyCode.C))
            {
                WpScript.Shoot(GetComponent<Walk>().LR);
                Weapon = null;
                WpScript = null;

            }
        }
    }
}
