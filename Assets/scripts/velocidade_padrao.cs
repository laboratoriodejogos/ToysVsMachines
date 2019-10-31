using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocidade_padrao : MonoBehaviour
{
    public Vector2 velocidade;

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocidade;
    }


}
