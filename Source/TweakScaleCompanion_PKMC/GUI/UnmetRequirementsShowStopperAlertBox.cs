﻿/*
	This file is part of TweakScaleCompanion_PKMC
	© 2020-2025 LisiasT : http://lisias.net <support@lisias.net>

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
using UnityEngine;

namespace TweakScaleCompanion.PKMC.GUI
{
	internal class UnmetRequirementsShowStopperAlertBox
	{
		private const string URL = "https://ksp.lisias.net/add-ons/TweakScaleCompanion/Support/PKMC/unmet-requirements";
		private static readonly string MSG = @"Unfortunately TweakScale Companion for Post Kerbin Mining Corporation (PKMC) is unable to safely proceed due unmet requiments!

You need to have {0} installed, otherwise this Companion may fail to install itself and/or work correctly and KSP will inject bad information on your savegames' PKMC parts with TweakScale.

If you decide to proceed, do it with caution.";

		private static readonly string AMSG = @"go to TweakScale Companion Program's page, look for the dependencies for PKMC, download and install {0} and restart KSP (it will close now)";

		internal static void Show(string failedRequirement)
		{
			KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
				string.Format(MSG, failedRequirement),
				string.Format(AMSG, failedRequirement),
				() => { KSPe.Util.CkanTools.OpenURL(URL); Application.Quit(); }
			);
			Log.detail("\"Houston, we have a Problem!\" about {0} unmet dependency was displayed", failedRequirement);
		}
    }
}

