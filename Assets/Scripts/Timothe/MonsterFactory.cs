using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory : MonoBehaviour
{

	public static MonsterFactory _instance;

	[SerializeField] private Monster originalMonster;

	private static Queue<Monster> deadMonsters = new Queue<Monster>();

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

	public GameObject GetMonster(Vector3 pos)
	{

		Monster monster;

		if (deadMonsters.Count > 0)
		{
			monster = deadMonsters.Dequeue();
			monster.gameObject.SetActive(true);
		}
		else
		{
			monster = Instantiate(originalMonster, pos, Quaternion.identity);
		}
		return monster.gameObject;
	}

	public static void EndMonster(Monster monster)
	{
		monster.gameObject.SetActive(false);
		deadMonsters.Enqueue(monster);
	}

}
