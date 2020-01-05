using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<GameObject> newPositions;
    public FloatVariable timer;
    
    private Transform sphere;
    private int place;
    private void Start()
    {
        place = 0;
        sphere = GetComponent<Transform>();
        sphere.position = new Vector3(newPositions[0].GetComponent<Transform>().position.x, sphere.position.y, newPositions[0].GetComponent<Transform>().position.z);
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer.value <= 0)
        {
            MoveNext();
        }
    }

    private void MoveNext()
    {
        place++;
        if (place >= newPositions.Count)
        {
            place = 0;
        }
        
        sphere.position = new Vector3(newPositions[place].GetComponent<Transform>().position.x, sphere.position.y, newPositions[place].GetComponent<Transform>().position.z);
    }
}
