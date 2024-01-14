using Godot;

namespace D_RTS.Scripts;

public partial class Unit : CharacterBody2D
{
	[Export] private int _health = 100;
	[Export] private int _damage = 20;
	[Export] public float Speed = 300.0f;
	[Export] private float _range = 20f;
	[Export] private float _atkSpeed = 0.5f;
	[Export] private bool _isPlayer;
	
	[Export]
	private CharacterBody2D _target;
	[Export]
	private NavigationAgent2D _navigationAgent2D;
	[Export]
	private Sprite2D _sprite;

	public override void _Ready()
	{
		
	}

	public void TakeDamage(int damage)
	{
		var hp = Mathf.Clamp(_health - damage, 0, _health);
		_health = hp;

		if (hp <= 0)
		{
			QueueFree();
		}
	}
}