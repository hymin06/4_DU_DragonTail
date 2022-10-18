using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    [SerializeField] private GameObject _grabObj;
    [SerializeField] private IsWeapon _grabScript;
    [SerializeField] private float _power;
    [SerializeField] private float _angle;
    [SerializeField] private Transform _grabPoint;
    [SerializeField] private Walk _walk;
    [SerializeField] private Vector3 MousePoint;
    [SerializeField] private Vector2 dir;
    public enum State
    {
        Idle,
        Holinding,
        SetAngle,
        Shoot
    }
    public State state;

    private void Awake()
    {
        _walk = GetComponent<Walk>();
        state = State.Idle;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<IsWeapon>())
        {
            state = State.Holinding;
            _grabObj = collision.gameObject;
            _grabScript = collision.gameObject.GetComponent<IsWeapon>();
            _grabScript.Grab();
        }
    }
    private void Update()
    {
        if (_grabObj)
        {
            _grabObj.transform.position = _grabPoint.position;
            MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _angle = Mathf.Atan2((MousePoint -transform.position).y, (MousePoint - transform.position ).x) * Mathf.Rad2Deg;
            _grabObj.transform.rotation = Quaternion.AngleAxis(_angle, Vector3.forward);
            if (Input.GetMouseButtonDown(0))
            {
                dir = (MousePoint - _grabPoint.transform.position).normalized;
                _grabScript.Shoot(dir);
                _grabScript = null;
                _grabObj = null;
            }
        }
    }
}
