using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutorialObjectScript : MonoBehaviour
{
    public GameObject TutorialTextObject;

    public int offsetTop = 2;

    public string TextToShow;

    TextMeshPro TextObject;


    
    void Start()
    {
      
         TextObject = TutorialTextObject.transform.Find("TextToShow").gameObject.GetComponent<TextMeshPro>();
         TextObject.SetText(TextToShow);  
    }


    public void showText() {
         TutorialTextObject.SetActive(true);
    }

    public void hideText() {
           TutorialTextObject.SetActive(false);
    }



}
