using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{
    public GameObject cubo;
    public GameObject rhino;

    private float timer;
    private bool col;
    private void Update() {
        if (col)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                cubo.SetActive(true);
                rhino.SetActive(true);
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
