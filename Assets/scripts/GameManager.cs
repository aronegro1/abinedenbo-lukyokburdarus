using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
public   void EndGame()
    {
        Restart();
    }
 void Restart (){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
}
