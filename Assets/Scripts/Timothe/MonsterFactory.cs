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

	public GameObject GetMonster(Monster originalMonster, Vector3 pos, int type)
	{

		Monster monster;

		if (deadMonsters.Count > 0)
		{
			monster = deadMonsters.Dequeue();
			monster.gameObject.SetActive(true);
			monster.transform.position = pos;
			monster.type = type;
		}
		else
		{
			monster = Instantiate(originalMonster, pos, Quaternion.identity);
			monster.type = type;
		}
		return monster.gameObject;
	}

	public static void EndMonster(Monster monster)
	{
		monster.gameObject.SetActive(false);
		deadMonsters.Enqueue(monster);
	}

}
