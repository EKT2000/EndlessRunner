using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck : MonoBehaviour
{
    private BoxCollider2D PlayerCollider;
    private SpriteRenderer OrderinLayer;

    private Rigidbody2D _RigidBody;
    public static float duckforce = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCollider = GetComponent<BoxCollider2D>();
        OrderinLayer = GetComponent<SpriteRenderer>();
        _RigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2)
        {
            if (Input.GetKeyDown("c"))
            {
                PlayerCollider.size = new Vector2(0.2f, 0.1f);
                PlayerCollider.offset = new Vector2(0, 0.05f);
                OrderinLayer.sortingOrder = 0;
                _RigidBody.AddForce(new Vector2(0, -duckforce), ForceMode2D.Impulse);
            }

            if (Input.GetKeyUp("c"))
            {
                PlayerCollider.size = new Vector2(0.2f, 0.24f);
                PlayerCollider.offset = new Vector2(0, 0);
                OrderinLayer.sortingOrder = 1;
                //_RigidBody.AddForce(new Vector2(0, duckforce), ForceMode2D.Impulse);
            }
        }
    }
}
