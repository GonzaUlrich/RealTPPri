using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTP : MonoBehaviour
{
    Teletransportacion parentScript;
    private void Start() {
        parentScript = this.transform.parent.GetComponent<Teletransportacion>();

    }
    private void OnTriggerEnter(Collider other) {
        
        parentScript.teleport(other,gameObject);
    }
}
