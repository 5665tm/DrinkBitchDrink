// Created : 2014 03 02 2:39 PM : DrinkBitchDrink-csharp : Assembly-CSharp-vs
// Changed : 2014 03 04 6:07 PM : Вадим Караваев

using UnityEngine;
using Random = System.Random;


public class DrinkBITCHES : MonoBehaviour
{
	public AudioClip Shot;
	private int _count;

	private void FixedUpdate()
	{
		Random rnd = new Random();
#if DEVEL
		int x = rnd.Next(40, 50);
#else
		int x = rnd.Next(0, 60);
#endif
		if (_count == 0)
		{
			if (x == 42)
			{
#if DEVEL
				_count = 5;
#else
				_count = 60;
#endif
				TextMesh txtRunGame = gameObject.GetComponent("TextMesh") as TextMesh;
				txtRunGame.text = "DRINK![" + _count + "]";
				audio.PlayOneShot(Shot);
			}
			else
			{
				TextMesh txtRunGame = gameObject.GetComponent("TextMesh") as TextMesh;
				txtRunGame.text = "число[" + x + "]";
			}
		}
		else
		{
			_count--;
			TextMesh txtRunGame = gameObject.GetComponent("TextMesh") as TextMesh;
			txtRunGame.text = "DRINK![" + _count + "]";
		}
	}
}