using Godot;
using System;

public class GhostPlayer : Node
{
    public Vector2 GlobalPosition { get; internal set; }

    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
       //GetNode<AnimationPlayer("AnimationPlayer").Play("FadeOut");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
