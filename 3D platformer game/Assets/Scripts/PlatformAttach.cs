using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("you enter");
        if (other.gameObject == Player)
        {
            other.transform.SetParent(transform);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("you exit");
        if (other.gameObject == Player)
        {
            other.transform.SetParent(null);
        }
    }

}
