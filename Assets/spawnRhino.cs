using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRhino : MonoBehaviour
{
    public GameObject rhino;
    public GameObject[] doors;

    private float timer;
    private bool col;
    private void Update()
    {
        if (col)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                if (rhino.name == "Rhinoceros")
                {
                    rhino.GetComponent<RhinoMovement>().enabled=true;
                    for (int i = 0; i < doors.Length; i++)
                    {
                        doors[i].SetActive(false);
                    }
                }
                timer=0;
                col=false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            col=true;
        }
    }
}
