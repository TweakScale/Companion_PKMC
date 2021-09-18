source ../CONFIG.inc

PACKAGE=TweakScaleCompanion.PKMC
TARGETDIR="TweakScaleCompanion/PKMC"
TARGETBINDIR="$TARGETDIR/"
PROJECTSDIR="$PACKAGE/"
DLLS="TweakScaleCompanion_PKMC"

PROJECT_BRANCH=`git branch | grep \* | cut -d ' ' -f2`
if [ "$PROJECT_BRANCH" == "master" ] ; then
	# Release mode
	PROJECT_STATE=""
else
	# PreRelease mode
	PROJECT_STATE=""
fi

VERSION=$( cat $PACKAGE.version | tr '\n' ' ' | sed -n -E 's/^.*?"VERSION\":\{.*"MAJOR":([0-9]+?),.*?"MINOR":([0-9]+?),.*?"PATCH":([0-9]+?),.*?"BUILD":([0-9]+?).*?\}.*$/\1.\2.\3.\4/p' )
