using TMPro;
using UnityEngine;

public class LevelList : MonoBehaviour
{
	public GameObject cellPrefab;
	public TextMeshProUGUI display;

	GameObject[] cells;

	public void Display( ActiveLevel[] activeLevels )
	{
		// Destroy any cells that already exist
		if( cells != null )
		{
			foreach( var cell in cells )
			{
				Destroy( cell );
			}
		}

		// Make a new array and populate it with cells
		cells = new GameObject[ activeLevels.Length ];
		for( int i = 0; i < activeLevels.Length; i++ )
		{
			var levelCellGameObject = Instantiate<GameObject>( cellPrefab, transform );
			cells[ i ] = levelCellGameObject;
			var levelCell = levelCellGameObject.GetComponent<LevelCell>();
			levelCell.parentList = this;
			levelCell.data = activeLevels[ i ];
			levelCell.Display();
		}
	}

	public void Success()
	{
		display.text = "Success";
	}

	public void Failure()
	{
		display.text = "Failure";
	}
}