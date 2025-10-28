using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{


    public void StarGame()
    {
        SceneManager.LoadScene(1);

    }

    public void ActiveConfing(GameObject go)
    { 
    
        go.SetActive(true);
        
    }

    public void DisableCofig(GameObject go)

    { 
        go.SetActive(false); 
    
    
    }

    public void ActivePause(GameObject go)
    {
        Time.timeScale = 0;
        go.SetActive(true);

    }

    public void DisablePause(GameObject go)
    {
        Time.timeScale = 1;
        go.SetActive(false);
    
    }

    public void voltarmenu(GameObject go)
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
           
    }
















}
