// ******************************************************************************************** //
//	LeniPather:	 Quest-00015 																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

When
{
	$cond = $MyLevel >= 1 && $MyLevel <= 8 && QuestStatus("7") == "completed";
	Seq
	{
		$Name = "Investigate Echo Ridge";
		$ID = 15;
		QuestPickup
		{
			$NPC = "Marshal McBride";
			$Location = [-8902.49,-162.678, 81.9404];
		}
		QuestGoal
		{
			Par
			{
				Until
				{
					$cond = KillCount{"Kobold Worker"} >= 10;
					Par
					{
  						Pull
						{
							$Prio = 4;
							$Names = ["Kobold Worker"];
						}
						Hotspots
						{
							$Prio = 5;
							$Locations = [
								[ -8795, -108, 83.073], [ -8790, -124, 82.994], 
								[ -8787, -252, 82.661], [ -8770, -118, 83.495], 
								[ -8770, -102, 87.125], [ -8765, -183, 84.088], 
								[ -8763, -158, 82.828], [ -8755, -129, 83.029], 
								[ -8735, -103, 87.046], [ -8724, -139, 86.919], 
								[ -8723, -208, 89.648], [ -8717, -105, 87.423]
							];
						}
					}
				}
			}
		}
		QuestHandin
		{
			$NPC = "Marshal McBride";
			$Location = [-8902.49,-162.678, 81.9404];
		}
	}
}