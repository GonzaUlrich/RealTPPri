using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoMovement : MonoBehaviour
{
    private GameObject player;
    [Range(0.0f,10f)]
    [SerializeField]
    private float movementSpeed =3;
    public Animator animator;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if(dist>16){
            Vector3 targetPostition = new Vector3( player.transform.position.x, 
                                        this.transform.position.y, 
                                        player.transform.position.z ) ;
            this.transform.LookAt( targetPostition ) ;
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

            animator.SetFloat("Speed",1);
            animator.SetBool("Attack",false);
        }else{
            animator.SetBool("Attack",true);
            animator.SetFloat("Speed",0);
        }
        
    }
}
