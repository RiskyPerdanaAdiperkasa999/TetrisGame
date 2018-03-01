using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
 
    public void ketujuan(int yangdituju)
    {
		SceneManager.LoadScene(yangdituju);
		Score.score=0;
		

    }
    
}