using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throw_away : MonoBehaviour
{
    public Rigidbody2D island_rb2D;
    public Rigidbody2D bn;
    bool mouse_click = false;
    public float range = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouse_click == true)
        {
            //tas_rb2D.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mouse_location = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mouse_location, bn.position) > range)
            {
                island_rb2D.position = bn.position + (mouse_location - bn.position).normalized * range;
            }
            else
            {
                island_rb2D.position = mouse_location;
            }
        }
    }
    void OnMouseDown()
    {
        mouse_click = true;
        island_rb2D.isKinematic = true;
    }
    void OnMouseUp()
    {
        mouse_click = false;
        island_rb2D.isKinematic = false;
        launch();
    }
    void launch()
    {
        Destroy(GetComponent<SpringJoint2D>(), 0.05f);
    }
}
