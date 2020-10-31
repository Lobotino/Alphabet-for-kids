using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D playerBody;

    public JumpController jumpCollider;

    public float speed = 1;

    public Button rightClick;
    
    public void OnRightClick()
    {
        var position = playerBody.position;
        playerBody.MovePosition(new Vector2(position.x + speed, position.y));
    }

    public void OnLeftClick()
    {
        var position = playerBody.position;
        playerBody.MovePosition(new Vector2(position.x - speed, position.y));
    }

    public void OnJumpClick()
    {
        if (!jumpCollider.isJumped)
        {
            playerBody.AddForce(Vector2.up * jumpCollider.jumpMod, ForceMode2D.Impulse);
            jumpCollider.isJumped = true;
        }
    }
}