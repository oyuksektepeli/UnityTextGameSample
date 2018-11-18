using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    [TextArea(15,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

	public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
	
}
