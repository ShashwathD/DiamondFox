using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    public static DiamondManager instance;
    public TextMeshProUGUI text;
    int diamond;
    
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
	{
		instance = this;
	}
    }

    public void ChangeDiamond(int DiamondNumber)
    {
        diamond += DiamondNumber;
        text.text = diamond.ToString() + "/8";
    }
}
