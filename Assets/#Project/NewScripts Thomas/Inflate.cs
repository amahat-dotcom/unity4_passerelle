using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
 
 
public class Inflate : MonoBehaviour
{
    [SerializeField] float scale = 2f;
    [SerializeField] float time = 2f;
    private float chrono;
    private bool isInflating = false;
    private Transform otherTransform;
    private void Update()
    {
        if (isInflating)
        {
            chrono += Time.deltaTime;
            float ratio = chrono / time;
            otherTransform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * scale, ratio);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isInflating = true;
        otherTransform = other.transform;
    }
    private void OnTriggerExit(Collider other)
    {
 
    }
}