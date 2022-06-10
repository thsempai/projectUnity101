using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{

    public float speed = 1f;
    public GameObject maxYPosition;
    public GameObject minYPosition;
    private float factor = -1f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * factor, 0) * Time.deltaTime; 
        if(minYPosition != null && transform.position.y <= minYPosition.transform.position.y){
            factor = 1f;
        }
        else if (maxYPosition != null && transform.position.y >= maxYPosition.transform.position.y){
            factor = -1f;
        }
    }
}
