using DSA.Extensions.Base;

namespace DSA.Extensions.Characters
{
	//Manages NPCs
	//Will likely be extended later as more NPC functionality added
	public class CharacterManager : ManagerBase
	{
		public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Character; } }

		private Character[] characters;

		public override void Initialize()
		{
			base.Initialize();
		}

		//Find all characters and pass them to other managers as a traited object
		public override void Load()
		{
			characters = FindObjectsOfType<Character>();
			for (int i = 0; i < characters.Length; i++)
			{
				RaiseTraitsFound(characters[i]);
			}
		}
	}
}