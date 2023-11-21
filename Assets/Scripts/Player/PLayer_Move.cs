using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Move : Player
{
    Vector2 _moveInput;

    private void Update()
    {        
    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");
    _moveInput = new Vector2(moveX, moveY).normalized;
        move(moveX, moveY);
    }

    public void move(float X, float Y)
    {
        _PlayerRb.MovePosition(_PlayerRb.position + _moveInput * _movSpeed);
    }
}
