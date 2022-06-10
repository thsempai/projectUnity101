using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Tooltip("Speed rotation")]
    public Vector3 speed = Vector3.zero;

    public GameObject target;
    public float distance = 0f;

    // Update is called once per frame
    void Update()
    {
        if(target == null || Vector3.Distance(
            transform.position, target.transform.position) <= distance){
        Vector3 rotation = transform.rotation.eulerAngles;
        rotation += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotation);}
    }
}
