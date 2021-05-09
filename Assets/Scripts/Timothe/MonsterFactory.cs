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
			DontDestroyOnLoad(this.gameObject);

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
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.91961f, 0.03137f, 0.00000f);
        
            }

			if ((monster.type - 36) % 12 == 1)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.09804f, 0.36471f);

			}

			if ((monster.type - 36) % 12 == 2)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.09804f, 0.76863f);

			}

			if ((monster.type - 36) % 12 == 3)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.43922f, 0.09804f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 4)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.15294f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 5)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.49412f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 6)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.76078f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 7)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.77255f, 0.42745f);

			}

			if ((monster.type - 36) % 12 == 8)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.77255f, 0.10588f);

			}

			if ((monster.type - 36) % 12 == 9)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.42353f, 0.77255f, 0.09804f);

			}

			if ((monster.type - 36) % 12 == 10)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.76863f, 0.09804f);

			}

			if ((monster.type - 36) % 12 == 11)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.36471f, 0.09804f);

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
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.91961f, 0.03137f, 0.00000f);

			}

			if ((monster.type - 36) % 12 == 1)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.09804f, 0.36471f);

			}

			if ((monster.type - 36) % 12 == 2)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.09804f, 0.76863f);

			}

			if ((monster.type - 36) % 12 == 3)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.43922f, 0.09804f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 4)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3053874f, 0.2623709f, 0.8301887f);

			}

			if ((monster.type - 36) % 12 == 5)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.49412f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 6)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.76078f, 0.77255f);

			}

			if ((monster.type - 36) % 12 == 7)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.77255f, 0.42745f);

			}

			if ((monster.type - 36) % 12 == 8)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.09804f, 0.77255f, 0.10588f);

			}

			if ((monster.type - 36) % 12 == 9)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.42353f, 0.77255f, 0.09804f);

			}

			if ((monster.type - 36) % 12 == 10)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.76863f, 0.09804f);

			}

			if ((monster.type - 36) % 12 == 11)
			{
				randomNumber = Random.Range(0, 6);
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[randomNumber];
				monster.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77255f, 0.36471f, 0.09804f);

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
