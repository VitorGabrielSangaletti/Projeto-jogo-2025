using UnityEngine;
using TMPro;

public class Gamemaneger : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;

    public TextMeshProUGUI textPontos;

    public void AddPontos(int qtd) 
    {
        pontos += qtd;

        if (pontos < 0)
        {
            pontos = 0;
        }

        textPontos.text = "Pontos: " + pontos;
        Debug.Log("Pontos: " +  pontos);

    }

    public void PerdeVidas(int vida)
    {
        vidas -= vida;
        Debug.Log("Vidas: " + vidas);

        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<Player>().ReiniciarPosicao();
        if (vidas <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
        }
    }
}
