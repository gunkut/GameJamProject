using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public Transform follow_mafas;
    Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - follow_mafas.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = follow_mafas.position + distance;
    }
}
