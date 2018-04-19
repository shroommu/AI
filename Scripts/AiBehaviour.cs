using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Made By Anthony Romrell
public class AiBehaviour : MonoBehaviour
{

	public NavMeshAgent Agent;
	public Animator Anims;
	public AiBrain Brain;
	public AiBase StartAiBase;


	void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
	}

	void Update () {
		Brain.AiBase.Navigate(Agent);
	}

	private void OnTriggerEnter(Collider other)
	{
		Anims.SetTrigger("Hunt");
	}
	
	private void OnEnable()
	{
		Brain.AiBase = StartAiBase;
	}
}
