// ******************************************************************************************** //
//	LeniPather:	 Quest-00783 																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

When
{
	$cond = $MyLevel >= 1 && $MyLevel <= 6;
	Seq
	{
		$Name = "A Threat Within";
		$ID = 783;
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
			$NPC = "Marshal McBride";
			$Location = [-8902.49,-162.678, 81.9404];
		}
	}
}