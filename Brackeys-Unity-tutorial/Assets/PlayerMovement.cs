using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to Player's Rigidbody component, drag the instance in the editor
    public Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started...");
    }

    // Use FixedUpdate instead of Update because of physics
    void FixedUpdate()
    {
        // add force on z axis, use fixedDeltaTime instead of deltaTime because of FixedUpdate
        Rb.AddForce(0, 0, 2000*Time.fixedDeltaTime);
    }
}
