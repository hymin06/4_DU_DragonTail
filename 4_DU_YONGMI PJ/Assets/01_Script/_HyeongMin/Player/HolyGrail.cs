using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyGrail : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<EnemyMovement>())
        {
            Debug.LogError("grail true");
            EnemyMovement enemyMovement = col.GetComponent<EnemyMovement>();
            enemyMovement.holyGrailSpeedSlow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.GetComponent<EnemyMovement>())
        {
            Debug.LogError("grail false");
            EnemyMovement enemyMovement = col.GetComponent<EnemyMovement>();
            enemyMovement.holyGrailSpeedSlow = false;
        }
    }
}
