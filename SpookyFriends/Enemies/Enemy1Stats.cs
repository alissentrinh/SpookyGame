using Godot;
using System;

public class Enemy1Stats : Node
{
	// Declare member variables here. Examples:
	[Export] public int MAXHEALTH = 3;
	[Export] public int HEALTH = 1;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		HEALTH = MAXHEALTH;
	}
	
	[Signal] public delegate void NoHealth();
}
