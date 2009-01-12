// ******************************************************************************************** //
//	LeniPather:	 Quest-00006 																	//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //


When
{
    $cond = $MyLevel >= 3 && $MyLevel <= 10 && QuestStatus("18") == "completed";
    Seq
    {
        $Name = "Bounty on Garrick Padfoot";
        $ID = 6;
        QuestPickup
        {
            $NPC = "Deputy Willem";
            $Location = [-8932.9,-136.332, 83.1518];
        }
        QuestGoal
        {
            Par
            {
                Until
                {
                    $cond = $ItemCount{"Garrick's Head"} >= 1;
                    Par
                    {
                        Pull
                        {
                            $Prio = 4;
                            $Names = ["Garrick Padfoot"];
                        }
                        Hotspots
                        {
                            $Prio = 5;
                            $Locations = [[ -9056, -459, 72.524]];
                        }
                    }
                }
            }
        }
        QuestHandin
        {
            $NPC = "Deputy Willem";
            $Location = [-8932.9,-136.332, 83.1518];
        }
    }
}