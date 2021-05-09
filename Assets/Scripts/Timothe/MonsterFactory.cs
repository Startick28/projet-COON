﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory : MonoBehaviour
{

	public static MonsterFactory _instance;

	[SerializeField] private Monster originalMonster;

	private static Queue<Monster> deadMonsters = new Queue<Monster>();

	public Sprite type0;
	public Sprite type1;
	public Sprite type2;
	public Sprite type3;
	public Sprite type4;
	public Sprite type5;
	public Sprite type6;
	public Sprite type7;
	public Sprite type8;
	public Sprite type9;
	public Sprite type10;
	public Sprite type11;

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
			if (monster.type == 0)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type0;
			}
			if (monster.type == 1)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type1;
			}
			if (monster.type == 2)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type2;
			}
			if (monster.type == 3)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type3;
			}
			if (monster.type == 4)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type4;
			}
			if (monster.type == 5)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type5;
			}
			if (monster.type == 6)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type6;
			}
			if (monster.type == 7)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type7;
			}
			if (monster.type == 8)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type8;
			}
			if (monster.type == 9)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type9;
			}
			if (monster.type == 10)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type10;
			}
			if (monster.type == 11)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type11;
			}
		}
		else
		{
			monster = Instantiate(originalMonster, pos, Quaternion.identity);
			monster.type = type;
			if (monster.type == 0)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type0;
			}
			if (monster.type == 1)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type1;
			}
			if (monster.type == 2)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type2;
			}
			if (monster.type == 3)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type3;
			}
			if (monster.type == 4)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type4;
			}
			if (monster.type == 5)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type5;
			}
			if (monster.type == 6)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type6;
			}
			if (monster.type == 7)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type7;
			}
			if (monster.type == 8)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type8;
			}
			if (monster.type == 9)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type9;
			}
			if (monster.type == 10)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type10;
			}
			if (monster.type == 11)
			{
				monster.gameObject.GetComponent<SpriteRenderer>().sprite = type11;
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
