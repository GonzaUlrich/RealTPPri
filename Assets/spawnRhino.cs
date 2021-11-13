using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRhino : MonoBehaviour
{
    public GameObject rhino;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player"){
            rhino.SetActive(true);
        }
    }
}
