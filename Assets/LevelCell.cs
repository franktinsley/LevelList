using TMPro;
using UnityEngine;

public class LevelCell : MonoBehaviour
{
	public TextMeshProUGUI nameLabel;
	public TextMeshProUGUI descriptionLabel;
	public PlayersIndicator playersIndicator;
	[ HideInInspector ]
	public LevelList parentList;
	public ActiveLevel data;

	public void Display()
	{
		nameLabel.text = data.name;
		descriptionLabel.text = data.description;
		playersIndicator.SetMaxPlayers( data.maxPlayers );
		playersIndicator.SetCurrentPlayers( data.numberOfPlayersInMatch );
	}

	public void OnClick()
	{
		if( data.numberOfPlayersInMatch < data.maxPlayers )
		{
			parentList.Success();
		}
		else
		{
			parentList.Failure();
		}
	}
}