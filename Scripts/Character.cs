using DSA.Extensions.Base;

namespace DSA.Extensions.Characters
{
	//NPC class
	[System.Serializable]
	public class Character : TraitedMonoBehaviour, IInteractable
	{
		public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Character; } }

		//used by the player to interact with game entities
		public virtual void Interact()
		{
			//calls interact method in all interactable traits
			TraitBase[] traits = GetArray();
			for (int i = 0; i < traits.Length; i++)
			{
				if (traits[i] is IInteractCallable)
				{
					IInteractCallable interactCallable = (IInteractCallable)traits[i];
					interactCallable.CallInteract();
				}
			}
		}
	}
}
