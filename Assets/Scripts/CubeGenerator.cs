using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kanonji.Stash;

public class CubeGenerator : MonoBehaviour {

	[SerializeField] private int numInEdge;
	public int NumInEdge {
		get { return numInEdge; }
		private set { numInEdge = value; }
	}

	[SerializeField] private int spacing;
	public int Spacing {
		get { return spacing; }
		private set { spacing = value; }
	}

	[SerializeField] private GameObject originalGameObject;
	public GameObject OriginalGameObject {
		get { return originalGameObject; }
		private set { originalGameObject = value; }
	}

	void Start () {
		Generate();
	}

	protected void Generate() {
		var placeholder = new Placeholder(transform.position, new Vector3(NumInEdge, NumInEdge, NumInEdge), Spacing);
		foreach (var pos in placeholder) {
			Instantiate(OriginalGameObject, pos, Quaternion.identity);
		}
	}
}
