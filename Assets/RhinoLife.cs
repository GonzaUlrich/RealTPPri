using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoLife : MonoBehaviour
{
    [SerializeField]
    [Range(0,10)]
    private int life = 3;

    public Animator anim;
    public void GetDamage(){
        life--;
        if(life<=0){
            Dead();
        }
    } 
    private void Dead(){
        Debug.Log("ME MORI");
        anim.SetBool("Dead",true);
        gameObject.GetComponent<RhinoMovement>().enabled=false;
    }
}
