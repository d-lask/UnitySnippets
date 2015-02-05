using System;
using UnityEngine;

/// <summary>
/// Put this script on a gameobject with a collider and 
/// subscribe to the delegates to receive notifications of the different collider events!
/// </summary>
public class ColliderEvents : MonoBehaviour 
{
	public Action<Collision> CollisionEnter = delegate { };
    public Action<Collision> CollisionStay = delegate { };
    public Action<Collision> CollisionExit = delegate { };

    public Action<Collider> TriggerEnter = delegate { };
    public Action<Collider> TriggerStay = delegate { };
    public Action<Collider> TriggerExit = delegate { };

	void OnCollisionEnter(Collision other)
	{
		CollisionEnter(other);
	}
	
	void OnCollisionStay(Collision other)
	{
		CollisionStay(other);
	}
	
	void OnCollisionExit(Collision other)
	{
		CollisionExit(other);
	}

	void OnTriggerEnter(Collider other)
	{
		TriggerEnter(other);
	}

	void OnTriggerStay(Collider other)
	{
		TriggerStay(other);
	}

	void OnTriggerExit(Collider other)
	{
		TriggerExit(other);
	}
}
