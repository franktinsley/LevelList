using UnityEngine;

public class MockLevelGenerator : MonoBehaviour
{
	public int numberOfLevels = 8;
	public int absoluteMaxPlayers = 12;
	public int minMaxPlayers = 2;
	public int minCurrentPlayers = 1;

	string[] names =
	{
		"Lorem",
		"Ipsum",
		"Dolor",
		"Sit",
		"Amet",
		"Consectetur",
		"Adipiscing",
		"Elit",
		"Donec"
	};

	string[] descriptions =
	{
		"Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
		"Vivamus sollicitudin tortor nec lectus vulputate, euismod ullamcorper dui aliquet.",
		"Suspendisse a ultricies nisi.",
		"Aliquam accumsan eros at eros tristique, dignissim tempor felis pretium.",
		"Sed euismod cursus mi, at ullamcorper tortor congue et.",
		"In eleifend justo nec semper vehicula.",
		"Pellentesque fermentum, sapien eu pulvinar fringilla, urna dui cursus justo, et ultrices purus ligula eleifend purus."
	};

	void Start()
	{
		Generate();
	}

	public void Generate()
	{
		var randomLevels = new ActiveLevel[ numberOfLevels ];
		for( int i = 0; i < numberOfLevels; i++ )
		{
			randomLevels[ i ] = RandomLevel();
		}
		GetComponent<LevelList>().Display( randomLevels );
	}

	ActiveLevel RandomLevel()
	{
		int _maxPlayers = Random.Range( minMaxPlayers, absoluteMaxPlayers );

		return new ActiveLevel
		{
			name = names[ Random.Range( 0, names.Length ) ],
			description = descriptions[ Random.Range( 0, descriptions.Length ) ],
			numberOfPlayersInMatch = Random.Range( minCurrentPlayers, _maxPlayers + 1 ),
			maxPlayers = _maxPlayers
		};
	}
}