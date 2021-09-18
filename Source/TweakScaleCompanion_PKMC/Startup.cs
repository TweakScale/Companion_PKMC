/*
	This file is part of TweakScaleCompanion_PKMC
	© 2020-21 LisiasT : http://lisias.net <support@lisias.net>

	TweakScaleCompanion_PKMC is double licensed, as follows:

	* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
	* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	TweakScaleCompanion_PKMC is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with TweakScaleCompanion_PKMC. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with TweakScaleCompanion_PKMC. If not, see <https://www.gnu.org/licenses/>.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TweakScaleCompanion.PKMC
{
	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	internal class Startup : MonoBehaviour
	{
		private void Start()
		{
			Log.init();
			Log.force("Version {0}", Version.Text);

			try
			{
				KSPe.Util.Installation.Check<Startup>("TweakScaleCompanion_PKMC", "PKMC", Version.Vendor);
			}
			catch (KSPe.Util.InstallmentException e)
			{
				Log.error(e.ToShortMessage());
				KSPe.Common.Dialogs.ShowStopperAlertBox.Show(e);
			}

			this.checkConflicts();
			this.checkDependencies();
		}

		private void checkConflicts()
		{
			try
			{
				List<AssemblyLoader.LoadedAssembly> assemblies = AssemblyLoader.loadedAssemblies.Where(a => a.assembly.GetName().Name == "TweakScaleCompanion-NF").ToList();
				if (assemblies.Count > 0 || System.IO.Directory.Exists(KSPe.IO.Hierarchy.GAMEDATA.Solve("TweakScaleCompanion", "NF")))
					GUI.UnmetRequirementsShowStopperAlertBox.Show("Deprecated TweakScale Companion for Near Future (NF)");
			}
			catch (Exception e) when (e is NullReferenceException || e is InvalidOperationException)
			{
				GUI.UnmetRequirementsShowStopperAlertBox.Show("TweakScale v2.4.5 or superior");
			}
		}

		private void checkDependencies()
		{
			try
			{
				AssemblyLoader.LoadedAssembly assembly = AssemblyLoader.loadedAssemblies.Where(a => a.assembly.GetName().Name == "Scale").First();
				if (-1 == assembly.assembly.GetName().Version.CompareTo(new System.Version(2, 4, 5)) )
					GUI.UnmetRequirementsShowStopperAlertBox.Show("TweakScale v2.4.5 or superior");
			}
			catch (Exception e) when (e is NullReferenceException || e is InvalidOperationException)
			{
				GUI.UnmetRequirementsShowStopperAlertBox.Show("TweakScale v2.4.5 or superior");
			}
		}
	}
}
