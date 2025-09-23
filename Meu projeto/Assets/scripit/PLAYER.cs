using UnityEngine;

public class Player : MonoBehaviour
{
    // onde declara as variaveis
    //variavel publica pode mudar no unity, mas se for privada apenas sera mudada na programação

    //andar
    public Animator anim;
    private Rigidbody2D rigi;
    public float speed;
    //------------------------

    public float jumpForce = 5f;
    public bool isGround; //variavel pra ver se o player ta no chão

    //aqui eu declarei e no start eu defino o valor sla foi oque a professora disse




    void Start()
    {    //void start é onde declara as coisas e etc tipo o void setup

        anim = GetComponent<Animator>(); //defino minha variavel e chamo no Animator
        rigi = GetComponent<Rigidbody2D>();  //defino minha variavel e chamo no Rigibody

    }

    //igual o void loop
    void Update()
    {
        Move();
        Jump();
        //tem que definir os void aqui

    }
    void Move() //void para movimentação
    {
        float teclas = Input.GetAxis("Horizontal");
        rigi.linearVelocity = new Vector2(teclas * speed, rigi.linearVelocity.y);

        if ((teclas > 0) && (isGround = true)) 
        {
            transform.eulerAngles = new Vector2(0, 0);
            anim.SetInteger("transition", 1);
        }

        if ((teclas < 0) && (isGround = true)) 
        {
            transform.eulerAngles = new Vector2(0, 180);
            anim.SetInteger("transition", 1);
        }

        if ((teclas == 0) && (isGround = true)) 
        {
            anim.SetInteger("transition", 0);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            //se a tecla estiver baixo(precionada) tlg?
            rigi.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            isGround = false;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "isGround")
        {
            isGround = true;
            Debug.Log("esta no chão");
        }
    }


}
