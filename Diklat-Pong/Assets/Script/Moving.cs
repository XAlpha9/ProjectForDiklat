using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Vector2 speed;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        speed.x = Random.Range(4, -4);
        speed.y = Random.Range(4, -4);
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
}
