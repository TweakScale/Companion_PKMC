# TweakScale Companion :: Post Kerbin Mining Corporation Add'Ons

Adds (up to date) TweakScale /L patches for Post Kerbin Mining Corporation Add'Ons, including Near Future ones.


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/TweakScaleCompanion/NFS` of existant
	+ Delete `<KSP_ROOT>/GameData/TweakScaleCompanion/NF`
* Extract the package's `GameData/` folder into your KSP's as follows:
	+ `<PACKAGE>/GameData/TweakScaleCompanion/NF` --> `<KSP_ROOT>/GameData/TweakScaleCompanion`
		- Overwrite any preexisting file.

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[TweakScale]
			[Plugins]
				KSPe.Light.TweakScale.dll
				Scale.dll
			[patches]
				...
			CHANGE_LOG.md
			DefaultScales.cfg
			Examples.cfg
			LICENSE
			NOTICE
			README.md
			ScaleExponents.cfg
			TweakScale.version
			documentation.txt
		999_Scale_Redist.dll
		ModuleManager.dll
		...
		[TweakScaleCompanion]
			[...]
			[NF]
				[NFS]
					...
				CHANGE_LOG.md
				LICENSE*
				NOTICE
				README.md
				[patches]
					...
			[...]
	KSP.log
	PastDatabase.cfg
	...
```


### Dependencies

* TweakScale /L 2.4.5 or later
	+ **NOT** included
* Near Future Add'Ons, optinals (**not included**) - but at least one is recommeded! :)
	+ Near Future Aeronautics 
	+ Near Future Construction
	+ Near Future Electrical
	+ Near Future Exploration
	+ Near Future Construction
	+ Near Future Launch Vehicles
	+ Near Future Propulsion
	+ Near Future Solar
	+ Near Future SpaceCraft
* Module Manager 3.1.3 or later
	+ **NOT** included
