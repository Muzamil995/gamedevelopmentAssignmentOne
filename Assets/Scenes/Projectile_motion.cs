using UnityEngine;

public class Projectile_motion : MonoBehaviour
{

    [SerializeField] GameObject [] gameObject;


    Rigidbody [] rb;
    

     void Start()

    {
        rb = new Rigidbody[gameObject.Length];

        for( int i=0; i < gameObject.Length; i++)
        {
            rb[i] = gameObject[i].GetComponent<Rigidbody>();
            rb[i].useGravity = false;
        }
        
    }
     
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < gameObject.Length; i++)
        {
             
            rb[i].useGravity = true;
        }
    }

}//falling,flying,reload,rotation script 
