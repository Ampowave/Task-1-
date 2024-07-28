using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBoxHandler : MonoBehaviour
{
    public Rigidbody2D boxRigidBody;
    public int JumpStrength = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Jump()
    {
        boxRigidBody.velocity += Vector2.up * JumpStrength;
    }
}
