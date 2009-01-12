When
{
	$cond = $MyLevel >= 60 && $MyLevel <= 65;
	Seq
	{
		$Name = "Warlord Krellian";
		$ID = 9362;
		QuestPickup
		{
			$NPC = "Archmage Xylem";
			$Location = [3984.59,-4763, 304.794];
		}
		QuestGoal
		{
			Par
			{
				Until
				{
					$cond = $ItemCount{"Prismatic Shell"} >= 1;
					Par
					{
						Pull
						{
							$Prio = 4;
							$Names = ["Warlord Krellian"];
						}
						Hotspots
						{
							$Prio = 5;
							$Locations = 
							[
								[ 3546.76, -5326, 134.253]
							];
						}
					}
				}
			}
		}
		QuestHandin
		{
			$NPC = "Archmage Xylem";
			$Location = [3984.59,-4763, 304.794];
		}
	}
}