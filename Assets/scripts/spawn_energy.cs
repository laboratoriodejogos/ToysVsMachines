using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_energy : MonoBehaviour

{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 10, 10);

    }

        private void spawn()
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }

}
