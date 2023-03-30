# TweakScale Companion :: Post Kerbin Mining Corporation Add'Ons :: Change Log

* 2023-0330: 2.2.1.1 (Lisias) for KSP >= 1.3
	+ Fixes a double-patching problem I created on NFLV due some left-overs I forgot to remove from some files.
		- Thanks to [Tsani](https://forum.kerbalspaceprogram.com/index.php?/profile/183018-tsani/) for the [heads up](https://forum.kerbalspaceprogram.com/index.php?/topic/179030-ksp-130-tweakscale-under-lisias-management-2471-2023-0324/&do=findComment&comment=4267399)! 
* 2023-0318: 2.2.1.0 (Lisias) for KSP >= 1.3
	+ Removes deprecated calls to KSPe. Minimum target is v2.5 now.
	+ Renders it compatible to TweakScale 2.4.7.0 and superior only.
* 2023-0304: 2.2.0.0 (Lisias) for KSP >= 1.3
	+ Adds Support for Far Future Technologies
* 2021-1016: 2.1.0.1 (Lisias) for KSP >= 1.3
	+ Fix a bug on patch. Thanks to AccidentalDissassemly!
	+ Closes issues:
		- [#5](https://github.com/net-lisias-ksp/TweakScaleCompanion_PKMC/issues/5) Missing curly braces in patch file
* 2021-1010: 2.1.0.0 (Lisias) for KSP >= 1.3
	+ Refactoring using the new KSPe.Light.TweakScale v2.4 facilities to allow it to be safely installed on rigs without it.
		- Lots of flexibility on packaging in the near future
* 2021-0919: 2.0.0.0 (Lisias) for KSP >= 1.3
	+ Rebranding the Companion from Near Future (NF) to Post Kerbin Mining Corporation (PKMC) 
	+ Small updates on the existing patches for Near Future
	+ Adds support for SSPX (Stockalike Station Parts Expansion Redux)
* 2021-0117: 1.0.0.0 (Lisias) for KSP >= 1.3
	+ TweakScale Companion for Near Future goes gold! #HURRAY
* 2020-1001: 0.0.4.1 (Lisias) for KSP >= 1.3
	+ Fixing a master bork on dependencies
		- Coding late night when you should be sleeping can be dangerous sometimes. 
* 2020-0927: 0.0.4.0 (Lisias) for KSP >= 1.3
	+ Another batch of patch revisions
		- Added missing Scale Exponents
		- Revised and fixed Cleaning Ups
		- Some parts had the scaling revised
	+ Added Show Stopper when using TweakScale 2.4.3.x or older
		- Only TweakScale 2.4.4 can overcome KSP "automatic updating" scheme that rendered TweakScale automatic Scaling fixes useless.
		- New Savegames are ok to go, but ongoing Savegames will risk corruption unless you use TweakScale 2.4.4. or newer!
	+ Since the patches are tied to NF Add'Ons and TweakScale, it's possible to be installed down to KSP 1.3 - as long it runs TweakScale 2.4.4 or newer and has a working NF Add'On available!
* 2020-0823: 0.0.3.2 (Lisias) for KSP >= 1.4
	+ Patches revision.
		- Suppressing some warnings on the `KSP.log`
* 2020-0726: 0.0.3.1 (Lisias) for KSP >= 1.4
	+ Patches revision.
		- Missing parts added
		- Reorganisation
		- Double checking with the lint tool.
* 2020-0614: 0.0.3.0 (Lisias) for KSP >= 1.4
	+ Added support for:
		- Near Future Aeronautics 
		- Near Future Construction
		- Near Future Electrical
		- Near Future Exploration
		- Near Future Construction
		- Near Future Launch Vehicles
		- Near Future Propulsion
		- Near Future SpaceCraft
* 2020-0511: 0.0.2.1 (Lisias) for KSP >= 1.4
	+ One more mistake fixed.
* 2020-0507: 0.0.2.0 (Lisias) for KSP >= 1.4
	+ Lots of mistakes fixed
	+ Added back legacy NFS support 
* 2020-0403: 0.0.1.1 (Lisias) for KSP >= 1.4 & NFS >= 1.1
	+ Renamed the package to TweakScaleCompanion_NF
* 2020-0112: 0.0.1.0 (Lisias) for KSP >= 1.4 * NFS >= 1.1
	+ Initial beta version for testing
