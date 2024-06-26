using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    enum Direction{
        right, up, forward
    }
    [SerializeField]private Direction direction = Direction.forward;  
    [SerializeField] private float speed = 1f; 
    [SerializeField] private Color color = Color.red;  //Objet à 4 vecteurs  RGBA, proportion de couleurs de 1 à 0

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = color; //Start ne se fait qu'une seule fois au démarrage de l'objet
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.forward; 
        //transform.position += transform.forward * Time.deltaTime * speed; // fait avancer l'objet de 1 en avant en LOCAL (selon son axe) à chaque frame
        //Vector3 pos = new[1, 3, 5]; //fait déplacer l'objet dans le WORLD 
        //Vector3.forward //variable statique 
        switch(direction){
            case Direction.forward:
                dir = transform.forward; break;
           case Direction.up:
                dir = transform.up; break;
            case Direction.right:
                dir = transform.right; break;
            default:
                dir = Vector3.zero;
                Debug.LogWarning($"{dir} is not handled."); 
            break;
        }
        transform.position += dir * Time.deltaTime * speed; // fait avancer l'objet de 1 en avant en LOCAL (selon son axe) à chaque frame
        
    }
}
