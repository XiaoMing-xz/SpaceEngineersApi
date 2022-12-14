using System;
using System.Collections.Generic;
using System.Text;
using Sandbox.Game.Entities.Cube;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using VRage.Collections;
using VRage.Game;

namespace Sandbox.Game.Gui
{
	public interface ITerminalAction : Sandbox.ModAPI.Interfaces.ITerminalAction
	{
		new string Id { get; }

		new string Icon { get; }

		new StringBuilder Name { get; }

		void Apply(MyTerminalBlock block);

		void WriteValue(MyTerminalBlock block, StringBuilder appendTo);

		bool IsEnabled(MyTerminalBlock block);

		bool IsValidForToolbarType(MyToolbarType toolbarType);

		bool IsValidForGroups();

		/// <summary>
		/// This collection contains the names, types and default values of any available parameter for this action.
		/// </summary>
		ListReader<TerminalActionParameter> GetParameterDefinitions();

		/// <summary>
		/// If available, this method will show any dialogs required to retrieve user arguments
		/// for the given action.
		/// </summary>
		/// <param name="callback">The callback to run when any dialog is complete</param>
		/// <param name="parameters">The parameters collection to be filled. This list will be cleared of any existing items.</param>
		void RequestParameterCollection(IList<TerminalActionParameter> parameters, Action<bool> callback);

		/// <summary>
		/// Applies the action with the given parameter list.
		/// </summary>
		/// <param name="block"></param>
		/// <param name="parameters"></param>
		void Apply(MyTerminalBlock block, ListReader<TerminalActionParameter> parameters);
	}
}
