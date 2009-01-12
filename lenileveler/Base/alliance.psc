// ******************************************************************************************** //
//	LeniPather:	 Alliance handler																//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

Par
{

	Log 
	{
		$Text = "Loading alliance template";	
	}
	// Human leveling template
	If
	{
		$cond = ($VarLevelingFromRace == True && MyRace == "Human") || ($VarLevelingFromRace == False && $VarLevelingForcedRace == "Human");
		Par
		{
			Log 
			{
				$Text = "Loading human template";	
			}
			#include </zones/esternkingdom/elwynnforest/base.psc>
		}
	}
}