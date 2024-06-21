using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public bool isGrounded = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LayerMask.NameToLayer("Ground") == collision.gameObject.layer)
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (LayerMask.NameToLayer("Ground") == collision.gameObject.layer)
        {
            isGrounded = false;
        }
    }
}