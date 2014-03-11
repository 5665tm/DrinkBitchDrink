// Created : 2014 03 02 2:39 PM : drink-bitch-drink-csharp : Assembly-CSharp-vs
// Changed : 2014 03 11 9:15 PM : Вадим Караваев

#define DEVELNOT
using UnityEngine;
using Random = System.Random;


public class DrinkBITCHES : MonoBehaviour
{
	public AudioClip Shot;
	public GameObject Txt2;
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
				_count = 10;
#else
				_count = 60;
#endif
				TextMesh txtRunGame = gameObject.GetComponent("TextMesh") as TextMesh;
				TextMesh txtTxt2 = Txt2.GetComponent("TextMesh") as TextMesh;
				txtTxt2.fontSize = 300;
				txtRunGame.fontSize = 300;
				txtRunGame.text = "DRINK!";
				txtTxt2.text = "DRINK!";
				audio.PlayOneShot(Shot);
			}
			else
			{
				TextMesh txtRunGame = gameObject.GetComponent("TextMesh") as TextMesh;
				TextMesh txtTxt2 = Txt2.GetComponent("TextMesh") as TextMesh;
				txtTxt2.fontSize = 300;
				txtRunGame.fontSize = 300;
				txtRunGame.text = "=[" + x + "]=";
				txtTxt2.text = "=[" + x + "]=";
			}
		}

#if DEVEL
		else if (_count > 5)
#else
		else if (_count > 55)
#endif
		{
			_count--;
		}
		else
		{
			_count--;
			TextMesh txtRunGame = gameObject.GetComponent("TextMesh") as TextMesh;
			TextMesh txtTxt2 = Txt2.GetComponent("TextMesh") as TextMesh;
			txtTxt2.fontSize = 200;
			txtRunGame.fontSize = 200;
			txtRunGame.text = "wait " + _count;
			txtTxt2.text = "wait " + _count;
		}
	}
}