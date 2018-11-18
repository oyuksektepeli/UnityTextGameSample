using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTheFamily : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State storyText;

    State state;

    // Use this for initialization
    void Start ()
    {
        
        state = storyText;
        textComponent.text = state.GetStateStory();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageStates();	
	}

    private void ManageStates()
    {
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }

        }

        textComponent.text = state.GetStateStory();

        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    state = nextStates[0];
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    state = nextStates[1];       
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    state = nextStates[2];
        //}
        //else
        //{
        //    textComponent.text = state.GetStateStory();
        //}
    }
}
