﻿using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private Systems _systems;

	// Use this for initialization
	void Start ()
	{
		var contexts = Contexts.sharedInstance;
//		_systems = new Feature("Systems").Add(
			// Add your features here			
//		);

		_systems.Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		_systems.Execute();
		_systems.Cleanup();
	}
}
