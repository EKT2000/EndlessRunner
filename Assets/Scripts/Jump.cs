using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float JumpForce = 2;
    private Rigidbody2D _rigidbody;
    private float jump_forward;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < 0 && transform.position.y > -1)
        {
            _rigidbody.AddForce(new Vector2(1, 0));
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {    

            _rigidbody.AddForce(new Vector2(jump_forward, JumpForce), ForceMode2D.Impulse);
        }
       
    }
}
