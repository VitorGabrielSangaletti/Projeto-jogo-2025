using UnityEngine;

public class coin : MonoBehaviour

{
    public Gamemaneger gameManager;
  
 
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
            gameManager.AddPontos(10);
            Destroy(gameObject);
            
        
        }
         
    }

}
