When
{
	$cond = $MyLevel >= 10 && $MyLevel <= 16;
	Seq
	{
		$Name = "Control";
		$ID = 9595;
		QuestPickup
		{
			$NPC = "Semid";
			$Location = [-4148.84,-12530.8, 45.0959];
		}
		QuestGoal
		{
			Par
			{
				Until
				{
					$cond = $quest_09595.grinder.KillCount{"Quel'dorei Magewraith"} >= 1;
					quest_09595 : Par
					{
  						grinder : Pull
						{
							$Prio = 4;
							$Names = ["Quel'dorei Magewraith"];
						}
						Hotspots
						{
							$Prio = 5;
							$Order = "Random";
							$Locations = 
							[
								[-3238,-11922,8],
								[-3386,-11934,7],
								[-4961,-10854,2],
								[-5043,-10829,7],
							];
						}
					}
				}
			}
		}
		QuestHandin
		{
			$NPC = "Bati";
			$Location = [-4053.89,-11561, -138.533];
		}
	}
}