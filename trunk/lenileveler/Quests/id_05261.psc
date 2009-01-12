// ******************************************************************************************** //
//	LeniPather:	 Quest-05261 																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //


When
{
	$cond = $MyLevel >= 1 && $MyLevel <= 7 && QuestStatus("783") == "completed";
	Seq
	{
		$Name = "Eagan Peltskinner";
		$ID = 5261;
		QuestPickup
		{
			$NPC = "Deputy Willem";
			$Location = [-8932.9,-136.332, 83.1518];
		}
		QuestGoal
		{
			Par
			{
			}
		}
		QuestHandin
		{
			$NPC = "Eagan Peltskinner";
			$Location = [-8869,-163, 80.972];
		}
	}
}