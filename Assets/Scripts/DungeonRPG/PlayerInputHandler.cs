using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] PlayerCharacter player;
    [SerializeField] AnimationUpdater au;
    void Update()
    {
        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.W)){
            input.y += 1;
        }
        if(Input.GetKey(KeyCode.S)){
            input.y += -1;
        }
        
        if(Input.GetKey(KeyCode.A)){
            input.x += -1;
        }
        if(Input.GetKey(KeyCode.D)){
            input.x += 1;
        }
        if(Input.GetKeyDown(KeyCode.E)){
            player.CheckInteract();
        }
        if(Input.GetMouseButtonDown(0)){
            au.PlayerAttack();
            player.Attack();
        }
        if(input.x != 0){
            au.UpdateDirFloats(input.x,0);
        }
        else if(input.y != 0){
            au.UpdateDirFloats(0,input.y);
        }
        au.UpdateSpeed(input);
        player.MovePlayer(input);
    }
}
