// ******************************************************************************************** //
//	LeniPather:	 base handler																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

Par
{
	Defend
	{
		$Prio = 0;
	}

	Rest
	{
		$Prio = 1;
	}

	Danger
	{
		$Prio = 1;
		$DangerDistance = $VarDangerDistance;
	}

	Loot
	{
		$Prio = 2;
		$Skin = $VarSkin;
	}

	// Load harving handler
	//#include </base/harving.psc>

	// Load class handler
	//#include </classes/base.psc>

	// Alliance loading
	If
	{
		$cond = $MyFaction == "Alliance";
		Par
		{
			#include </base/alliance.psc>
		}
	}

	// Horde loading
	If
	{
		$cond = $MyFaction == "Horde";
		Par
		{
			#include </base/horde.psc>
		}
	}
}