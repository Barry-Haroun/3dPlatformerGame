using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener2 : MonoBehaviour
{

    public float open = 100f;
    public float range = 10f;

    public GameObject door2;
    public bool isOpening = false;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                StartCoroutine(OpenDoor2());
            }
        }
    }

    IEnumerator OpenDoor2()
    {
        isOpening = true;
        door2.GetComponent<Animator>().Play("DoorOpen2");
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(5.0f);
        door2.GetComponent<Animator>().Play("New State");
        isOpening = false;
    }

}