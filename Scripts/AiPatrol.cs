using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Hunt", menuName = "Ai/Function/Patrol")]
public class AiPatrol : AiBase
{
	private int i = 0;

	public GameAction GameAction;
	
	public List<Transform> PatrolPoints { get ; set; }

	private void OnEnable()
	{
		PatrolPoints.Clear();
		GameAction.Call += Call;
	}

	private void Call(object obj)
	{
		PatrolPoints.Add(obj as Transform);
	}


	public override void Navigate(NavMeshAgent ai)
	{	
		if (ai.remainingDistance < 1)
		{
			ChangePatrolPoint();
		}
		
		ai.destination = PatrolPoints[i].position;
	}

	private void ChangePatrolPoint()
	{
		if (i < PatrolPoints.Count-1)
			i++;
		else
			i = 0;
	}
}