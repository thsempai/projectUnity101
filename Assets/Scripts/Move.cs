using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
[Tooltip("Move speed.")]    
    public Vector3 speed = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    transform.position += speed * Time.deltaTime;
    Rotation rotation = GetComponent<Rotation>();
    
    if(rotation != null){
        rotation.speed = transform.position *20;}

    }
}
