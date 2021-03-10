using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    [SerializeField]
    private Transform respawn;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player")) 
            col.transform.position = respawn.position;
    }

}
