using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode UpKey, DownKey;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(UpKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(DownKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
