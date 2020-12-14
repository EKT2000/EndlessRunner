using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    public float JumpForce = 2;
    private Rigidbody2D _rigidbody;
    public static float jump_forward;

    public AudioSource jumpaudio;
   
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        jumpaudio = GetComponent<AudioSource>();
        jumpaudio.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < 0 && transform.position.y > -1)
        {
            _rigidbody.AddForce(new Vector2(jump_forward, 0), ForceMode2D.Impulse);
        }

        if ((Input.GetButtonDown("Jump") || Input.GetKey(KeyCode.RightArrow)) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {    
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            jumpaudio.Play();
        }
        
        if (PlayerHealth.PlayerAlive == false)
        {
            jumpaudio.enabled = false;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }

       if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(new Vector2(0, -30), ForceMode2D.Impulse);
        }
    }
}
