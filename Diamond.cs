using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public int DiamondNumber = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
	if (other.gameObject.CompareTag("Player"))
	{
		DiamondManager.instance.ChangeDiamond(DiamondNumber);
	}
     
    }
}