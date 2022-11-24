using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]GameObject _weapon;
    [SerializeField]GameObject _grabPoint;
    [SerializeField]Weapon _weaponsc;
    public float Power;
    [SerializeField] float angle;
    [SerializeField] Vector2 dir;

    void Update()
    {
        if (_weapon)
        {
            _weapon.transform.position = _grabPoint.transform.position;
            dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _grabPoint.transform.position;
            angle = Mathf.Atan2(dir.normalized.y, dir.normalized.x) * Mathf.Rad2Deg;
            _weapon.transform.rotation = Quaternion.Euler(0, 0, angle);
            if (Input.GetMouseButtonDown(0))
            {
                _weaponsc.Shooting(dir, Power);
                _weaponsc = null;
                _weapon = null;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Weapon>() && !collision.gameObject.GetComponent<Weapon>().IsShooting)
        {
            _weapon = collision.gameObject;
            _weaponsc = collision.gameObject.GetComponent<Weapon>();
            _weaponsc.Grab();
        }

    }
}
