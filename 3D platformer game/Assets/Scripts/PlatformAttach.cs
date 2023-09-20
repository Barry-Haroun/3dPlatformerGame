using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject Player;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogError(0);
        if (collision.gameObject == Player)
        {
        Debug.LogError(1);
            Player.transform.SetParent(transform);
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (Player.gameObject == Player)
        {
            Player.transform.SetParent(null);
        }
    }

    private void FixedUpdate()
    {
      
    }


}
