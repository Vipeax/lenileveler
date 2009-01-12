// ******************************************************************************************** //
//	LeniPather:	 Quest-03104 																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

When
{
	$cond = $MyLevel >= 1 && $MyLevel <= 6 && QuestStatus("7") == "completed";
	Seq
	{
		$Name = "Glyphic Letter";
		$ID = 3104;
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
					$cond = $ItemCount{"Glyphic Letter"} >= 1;
					Par
					{
					}
				}
			}
		}
		QuestHandin
		{
			$NPC = "Khelden Bremen";
			$Location = [-8851,-188, 89.313];
		}
	}
}