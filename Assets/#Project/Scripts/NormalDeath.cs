using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDeath : MonoBehaviour, IDie
{
    public void Die()
        {
        Debug.Log("I am dying normally!"); 
        Destroy(gameObject); //game en minsucule car c'est l'objet pas la Class
        }
}
