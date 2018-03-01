using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class quit : MonoBehaviour
{
 public Button Buton;
  
    void Start()
    {
        Button btn = Buton.GetComponent<Button>();
        btn.onClick.AddListener(setat);
    }
    void setat()
    {
		Application.Quit();

    }
    

            
        

}