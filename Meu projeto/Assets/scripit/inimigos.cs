using UnityEngine;

public class inimigos : MonoBehaviour
{
    public Gamemaneger gameManeger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManeger.PerdeVidas(1);
        }
    }
}
