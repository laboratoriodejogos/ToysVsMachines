using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sangue : MonoBehaviour
{
    [SerializeField]
    private int curhp = 5;

    public void dano(int n)
    {
        curhp -= n;

        if (curhp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
