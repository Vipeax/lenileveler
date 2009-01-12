// ******************************************************************************************** //
//	LeniPather:	 Quest-00021 																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

When
{
    $cond = $MyLevel >= 3 && $MyLevel <= 10 && QuestStatus("15") == "completed";
    Seq
    {
        $Name = "Skirmish at Echo Ridge";
        $ID = 21;
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
                    $cond = $var1.grinder.KillCount{"Kobold Laborer"} >= 12;
                    var1:Par
                    {
                        grinder : Pull
                        {
                            $Prio = 4;
                            $Names = ["Kobold Laborer"];
                        }
                        Hotspots
                        {
                            $Prio = 5;
                            $Locations = [
								[ -8654, -128, 89.25], [ -8644, -133, 87.248], 
								[ -8635, -146, 86.235], [ -8635, -111, 86.841], 
								[ -8624, -145, 86.496], [ -8613, -161, 85.946], 
								[ -8603, -142, 88.642], [ -8594, -171, 87.154], 
								[ -8585, -147, 90.228], [ -8582, -171, 91.062], 
								[ -8560, -216, 85.277], [ -8552, -153, 87.952], 
								[ -8534, -199, 83.681]
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
			$Reward = 1; 
			If { $cond= $MyClass == "Druid"; 	$Reward = 1; }
			If { $cond= $MyClass == "Hunter"; 	$Reward = 1; }
			If { $cond= $MyClass == "Mage"; 	$Reward = 3; }
	        If { $cond= $MyClass == "Paladin"; 	$Reward = 2; }
			If { $cond= $MyClass == "Priest"; 	$Reward = 3; }
			If { $cond= $MyClass == "Rogue"; 	$Reward = 1; }
			If { $cond= $MyClass == "Shaman"; 	$Reward = 1; }
			If { $cond= $MyClass == "Warlock"; 	$Reward = 3; }
			If { $cond= $MyClass == "Warrior"; 	$Reward = 2; }
        }
    }
}