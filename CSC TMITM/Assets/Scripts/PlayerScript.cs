using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// If you use VisualStudio, you can add descriptions to variables/functions like this. This will make it easier to know what does what.
    /// </summary>
    int coolnessFactor = 10;

    private Animator anim;
    private string walking = "isWalking";


    // Start is called before the first frame update
    void Start()
    {
        // Get our components here
        anim = GetComponent<Animator>();

        anim.SetBool(walking, true); // This is how you set the current animation state

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
        
    }

    // FixedUpdate is called once every tick (or 0.02s). Use this for time-based functions.
    private void FixedUpdate()
    {
        coolnessFactor += 1;
    }
}
