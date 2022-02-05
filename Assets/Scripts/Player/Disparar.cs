using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public float speed;
    private float timeBtwShots;
    public float startTimeBtwShots;

    public Transform puntero;
    public GameObject projectile;

    public LayerMask enemies;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Shot();
        }
    }

    // Update is called once per frame
    void Shot()
    {
        Instantiate(projectile, puntero.position, Quaternion.identity );
    }
}