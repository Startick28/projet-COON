using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory : MonoBehaviour
{

	public static MonsterFactory _instance;

	[SerializeField] private Monster originalMonster;

	public GameObject ennemiesContainer;

	private static Queue<Monster> deadMonsters = new Queue<Monster>();


	public Sprite[] spriteArray = new Sprite[6];

	void Awake()
	{

		if (_instance == null)
		{

			_instance = this;
			deadMonsters.Clear();

			//Rest of your Awake code

		}
		else
		{
			Destroy(this);
		}
	}

	public GameObject GetMonster(Vector3 pos, int type)
	{

		Monster monster;
		int randomNumber;


		if (deadMonsters.Count > 0)
		{
			monster = deadMonsters.Dequeue();
			monster.gameObject.SetActive(true);
			monster.transform.position = pos;
			monster.type = type;
			monster.transform.SetParent(ennemiesContainer.transform);
			
			if((monster.type-36)%12 == 0)
            {
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(209, 8, 0, 255);
        
            }

			if ((monster.type - 36) % 12 == 1)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 25, 93, 255);

			}

			if ((monster.type - 36) % 12 == 2)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 25, 196, 255);

			}

			if ((monster.type - 36) % 12 == 3)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(112, 25, 197, 255);

			}

			if ((monster.type - 36) % 12 == 4)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 39, 197, 255);

			}

			if ((monster.type - 36) % 12 == 5)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 126, 197, 255);

			}

			if ((monster.type - 36) % 12 == 6)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 194, 197, 255);

			}

			if ((monster.type - 36) % 12 == 7)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 197, 109, 255);

			}

			if ((monster.type - 36) % 12 == 8)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 197, 27, 255);

			}

			if ((monster.type - 36) % 12 == 9)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(108, 197, 25, 255);

			}

			if ((monster.type - 36) % 12 == 10)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 196, 25, 255);

			}

			if ((monster.type - 36) % 12 == 11)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 93, 25, 255);

			}

		}
		else
		{
			monster = Instantiate(originalMonster, pos, Quaternion.identity);
			monster.type = type;
			monster.transform.SetParent(ennemiesContainer.transform);

			if ((monster.type - 36) % 12 == 0)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(209, 8, 0, 255);

			}

			if ((monster.type - 36) % 12 == 1)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 25, 93, 255);

			}

			if ((monster.type - 36) % 12 == 2)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 25, 196, 255);

			}

			if ((monster.type - 36) % 12 == 3)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(112, 25, 197, 255);

			}

			if ((monster.type - 36) % 12 == 4)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 39, 197, 255);

			}

			if ((monster.type - 36) % 12 == 5)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 126, 197, 255);

			}

			if ((monster.type - 36) % 12 == 6)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 194, 197, 255);

			}

			if ((monster.type - 36) % 12 == 7)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 197, 109, 255);

			}

			if ((monster.type - 36) % 12 == 8)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(25, 197, 27, 255);

			}

			if ((monster.type - 36) % 12 == 9)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(108, 197, 25, 255);

			}

			if ((monster.type - 36) % 12 == 10)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 196, 25, 255);

			}

			if ((monster.type - 36) % 12 == 11)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(197, 93, 25, 255);

			}
		}
		return monster.gameObject;
	}

	public static void EndMonster(Monster monster)
	{
		monster.gameObject.SetActive(false);
		deadMonsters.Enqueue(monster);
	}

}
