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

	public GameObject GetMonster(Monster originalMonster, Vector3 pos)
	{

		Monster monster;
		transform.position = pos;
		if (deadMonsters.Count > 0)
		{
			transform.position = pos;
			monster = deadMonsters.Dequeue();
			monster.gameObject.SetActive(true);
			monster = Instantiate(originalMonster, pos, Quaternion.identity);
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
