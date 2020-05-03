# TweakScale Companion :: Near Future Add'Ons

Adds (up to date) TweakScale /L patches for Near Future Add'Ons.


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

* TweakScale /L 2.3 or later
	+ **NOT** included
* Near Future Solar 1.1 or later
	+ **NOT** included , optional
* Module Manager 3.0.7 or later
	+ **NOT** included

