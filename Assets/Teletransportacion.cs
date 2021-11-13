using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportacion : MonoBehaviour
{

    public GameObject enter;
    public GameObject exit;

    public void teleport(Collider player, GameObject door){
        if(player.gameObject.name=="Player"){
            if(player.GetComponent<PlayerMovement>().enabled){
                if(door.gameObject.name == enter.gameObject.name){
                    player.GetComponent<PlayerMovement>().enabled=false;
                    player.gameObject.transform.localPosition = exit.transform.position;
                }else{
                    player.GetComponent<PlayerMovement>().enabled=false;
                    player.gameObject.transform.localPosition = enter.transform.position;
                }
                
            }
            else{
                player.GetComponent<PlayerMovement>().enabled=true;
            }
            
        }

    }


}
