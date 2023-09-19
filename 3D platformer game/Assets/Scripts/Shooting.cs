using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RaycastHit hit;
            bool result = Physics.Raycast(transform.position, transform.forward, out hit, 50);

            if (result)
            {
                EnemyStats EnemyStats = hit.collider.GetComponent<EnemyStats>();
                if (EnemyStats != null)
                {
                    EnemyStats.TakeDamage(10);
                }
            }
        }
    }
}