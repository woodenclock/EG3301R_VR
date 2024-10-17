using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextSwitcher : MonoBehaviour {
    
    public TextMeshProUGUI[] texts;         // Array to hold all TEXT elements
    public Button[] buttons;                // Array to hold all BUTTON elements
    private int currentIndex = 0;           // Keeps track of which text/button currently visible


    // Start is called before the first frame update
    void Start() {
        
        // Hide all texts except 1st
        for (int i = 1; i < texts.Length; i++) {
            texts[i].gameObject.SetActive(false);
        }

        // Hide all buttons except 1st
        for (int i = 0; i < buttons.Length; i++) {
            buttons[i].gameObject.SetActive(false);
        }

        texts[0].gameObject.SetActive(true);    // Show the first text
        //buttons[0].gameObject.SetActive(true);  // Show the first button
    }


    // This function will be called when button is clicked
    public void OnButtonClick() {

        // Hide the current text and button
        texts[currentIndex].gameObject.SetActive(false);
        buttons[currentIndex].gameObject.SetActive(false);

        // Move to the next text
        currentIndex++;

        // Check if we have more text to display
        if (currentIndex < texts.Length) {
            // Show the next text and button
            texts[currentIndex].gameObject.SetActive(true);
            buttons[currentIndex].gameObject.SetActive(true);
        }
    }
}
