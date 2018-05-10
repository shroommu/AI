
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Made By Anthony Romrell
public class NewStuff : MonoBehaviour
{
	public GameAction AddToList;
	public List<GameObject> GameObjectList;
	public GameObject GOParent;
	public List<GameObject> GameObjectListHigh;
	public List<float> GameObjectFloats;
	
	private void Awake()
	{
		
		AddToList.Call += AddThisToList;
		
		Invoke(nameof(RunThis), 2);
	}


	private void AddThisToList(object go)
	{
		GameObjectList.Add(go as GameObject);
	}


	private void RunThis()
	{
		GOParent = GameObjectList.Single(go => go.GetComponent<ParentObject>());
		GameObjectListHigh = GameObjectList.Where(go => go.transform.position.y > 0.1f).ToList();
		GameObjectFloats = GameObjectList.Select(go => go.transform.position.y).ToList();

		
		
	}
}