using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// If you use VisualStudio, you can add descriptions to variables/functions like this. This will make it easier to know what does what.
    /// </summary>
    int coolnessFactor = 10;

    private Animator anim;
    private string walking = "isWalking";

    [SerializeField]
    private float speed = 5.0f;
    private Rigidbody2D rigidBody;
    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        // Get our components here
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();

        // For all coders
        Debug.Log("Use Debug.Log() for debugging (obviously)");
        Debug.LogWarning("Use Debug.LogWarning() when something that isn't supposed to happen happens, but isn't a major issue");
        Debug.LogError("Use Debug.LogError() when something goes horribly wrong and needs to be fixed");
        // This is all pretty obvious but it is also easy to forget to do
        // Also I mainly did this so this document isn't just empty
    }

    // Update is called once per frame. Use this for animated functions.
    void Update()
    {
        PlayerAnimation();
    }

    // FixedUpdate is called once every tick (or 0.02s). Use this for time-based functions.
    private void FixedUpdate()
    {
        coolnessFactor += 1;

        transform.position += new Vector3(moveInput.x, 0f, 0f) * Time.fixedDeltaTime * speed; // position method

        // We can use this method below for force-based movement, but we will also have to add a couple other things (including a "breaking" sprite)
        //rigidBody.AddForce(3f * speed * Time.fixedDeltaTime * new Vector2(moveInput.x, 0f), ForceMode2D.Impulse);
    }

    private void OnMove (InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    ///<summary> This function will control our player's animations </summary>
    private void PlayerAnimation()
    {
        if (moveInput.x == 0)
        {
            anim.SetBool(walking, false);
        } else if (moveInput.x == 1)
        {
            anim.SetBool(walking, true);
            transform.localScale = new Vector3(1, 1, 1);
        } else if (moveInput.x == -1)
        {
            anim.SetBool(walking, true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
