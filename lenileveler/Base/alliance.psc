// ******************************************************************************************** //
//	LeniPather:	 Alliance handler																//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

Par
{
	// Human leveling template
	If
	{
		$cond = ($VarLevelingFromRace == True && MyRace == "Human") || ($VarLevelingFromRace == False && $VarLevelingForcedRace == "Human");
		Par
		{
			#include </zones/esternn kingdom/elwynn forest/base.psc>
		}
	}
}