using Self.Story;
using UnityEngine;

namespace Self.Story
{
	[System.Serializable]
	public class VariableReference
	{
		public Variable variable;
	}

	public class SetVariableAction : BaseAction
	{
		[DisplayOnNode(1), SerializeReference]
		public VariableReference variableReference;
		
		[DisplayOnNode(2)]
		public string            variableValue;

		public override void Execute(BaseNode node)
		{
		}
	}
}