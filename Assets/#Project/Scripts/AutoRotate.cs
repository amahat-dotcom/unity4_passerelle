using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour

{
    [SerializeField] float rotationSpeed = 8;
    [SerializeField] Space space;
    [HideInInspector] public bool debug; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, space); 
    }
}
