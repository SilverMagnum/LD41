using UnityEngine;

public class GambitLoading: MonoBehaviour {
	public void Save() {
		/*BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/cellInfo.dat");
		
		PlayerData data = new PlayerData();
		data.health = health;
		data.experience = experience;
		
		bf.Serialize(file, data);
		file.Close();*/
	}
	
	public void Load() {
		/*
		if(File.Exists(Application.persistentDataPath + "/cellInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/cellInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();
			
			health = data.health;
			experience = data.experience;
		}*/
	}
	
	/*
	I'll have to make some function that is called when a new object in the
	dropdown menu is selected. Theoretically, this should affect which entities
	exist in the game.
	*/
}
