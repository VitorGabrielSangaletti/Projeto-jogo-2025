using UnityEngine;

public class coin : MonoBehaviour
{
    private float ponto = 0;
 
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            Debug.Log("colidiu");
            ponto += 10;
        
        }
         
    }

}
