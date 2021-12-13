using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mafas_jump : MonoBehaviour
{
    public LayerMask layer;
    public bool IsGround;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, layer);

        if (hit.collider != null)
            IsGround = true;
        else
            IsGround = false;

        if (Input.GetKeyDown(KeyCode.Space) && IsGround == true)
            rb.velocity += new Vector2(0, 7f);
    }
}
