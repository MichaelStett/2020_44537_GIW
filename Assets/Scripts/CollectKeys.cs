using UnityEngine;
using System.Collections;

public class CollectKeys : MonoBehaviour
{
	public static bool key = false;

	void CollectKey() => key = true;
}
