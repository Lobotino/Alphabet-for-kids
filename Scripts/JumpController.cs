using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    
    public float jumpMod = 5;
    
    public bool isJumped;
    
    private void OnCollisionStay2D(Collision2D other)
    {
        isJumped = false;
    }
}
