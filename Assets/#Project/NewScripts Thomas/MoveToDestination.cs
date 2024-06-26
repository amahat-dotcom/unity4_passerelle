using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    private Vector3 start; 
    [SerializeField] private Vector3 end; 
    [SerializeField] private float speed;
    [SerializeField] private Color startColor = Color.yellow; //⭐️                                     //⭐️ Chgt de couleurs
    [SerializeField] private Color endColor = Color.green; //⭐️

    private float time; 
    private float chrono = 0f; 
    //private bool forward = true; // Direction du déplacement

    void Start() // Start is called before the first frame update
    {
        start = transform.position;
        time = Vector3.Distance(start, end) / speed; // temps total
        //GetComponent<Renderer>().material.color = startColor; //⭐️

    }

    // Update is called once per frame
    void Update()
    {
        chrono += Time.deltaTime; // à retenir 
        float ratio = chrono / time; 
            if (ratio >= 1.0f) //⏪️⏩️
             {
            //forward = !forward; //Inverser la direction ⏪️⏩️                                      // ⏪️⏩️ Aller-retour
            chrono = 0f; // ⏪️⏩️ Réinitialiser le chrono pour le prochain cycle

            // Inverser les positions de départ et de fin ⏪️⏩️
            Vector3 temp = start; 
            start = end;
            end = temp;

            // Inverser les couleurs ⏪️⏩️
            Color tempColor = startColor;
            startColor = endColor;
            endColor = tempColor;
        }

        transform.position = Vector3.Lerp(start, end, ratio); 
        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, ratio); //⭐️

    }
}
