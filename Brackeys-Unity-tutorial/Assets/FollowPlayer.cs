using JetBrains.Annotations;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    // stores 3 floats as a vector
    /* instead of parenting which results a first person view and rotates on collision,
     this solution smoothly follows the reference object from behind */
    public Vector3 Offset = new Vector3(0,1,-5);
    void Update()
    {
        transform.position = Player.position + Offset;
    }
}
