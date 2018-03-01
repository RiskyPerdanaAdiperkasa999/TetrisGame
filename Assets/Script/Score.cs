using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

Text myText;

public static int score=0;

void Start(){
	myText = GetComponent<Text>();

}
void Update(){
	myText.text = "Score : " + score;
}
	
}
