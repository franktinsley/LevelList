using UnityEngine;
using UnityEngine.UI;

public class PlayersIndicator : MonoBehaviour
{
	public GameObject dotPrefab;

	GameObject[] dots;

	// TODO: Make these methods properties and write a custom inspector

	public void SetMaxPlayers( int maxPlayers )
	{
		// Destroy any dots that already exist
		if( dots != null )
		{
			for( int i = 0; i < dots.Length; i++ )
			{
				Destroy( dots[ i ] );
			}
		}

		// Make a new array and populate it with dots
		dots = new GameObject[ maxPlayers ];
		for( int i = 0; i < maxPlayers; i++ )
		{
			dots[ i ] = Instantiate<GameObject>( dotPrefab, transform );
		}
	}

	public void SetCurrentPlayers( int currentPlayers )
	{
		// Change dot colors based on number of players
		for( int i = 0; i < dots.Length; i++ )
		{
			var dotImage = dots[ i ].GetComponent<Image>();
			dotImage.color = i < currentPlayers ? Color.black : Color.white;
		}
	}
}