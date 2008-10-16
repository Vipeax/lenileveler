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
	#include </base/harving.psc>

	// Load talent handler
	#include </base/talent.psc>


	// Alliance loading
	If
	{
		$cond = ($MyRace == "Human" || $MyRace == "Dwarf" || $MyRace == "Gnome" || $MyRace == "NightElf" || $MyRace == "Dranei");
		#include </base/alliance.psc>
	}

	// Horde loading
	If
	{
		$cond = ($MyRace == "Undead" || $MyRace == "Tauren" || $MyRace == "Orc" || $MyRace == "Troll" || $MyRace == "BloodElf");
		#include </base/horde.psc>
	}
}