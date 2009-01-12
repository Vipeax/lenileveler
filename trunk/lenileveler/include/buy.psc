// ******************************************************************************************** //
//	LeniPather:	 Abstract buy handler															//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

Par
{
	$Prio = 3;
	$VarBuyRestItems = False;
	If
	{
		$cond = $VarBuyFood && $VarBuyWater;
		Par
		{
			$VarBuyRestItems = [[$VarBuyFoodItem, $VarBuyMinFood, $VarBuyQtyFood], [$VarBuyWaterItem, $VarBuyMinWater, $VarBuyQtyWater]];
		}
	}
	If
	{
		$cond = $VarBuyFood && !$VarBuyWater;
		Par
		{
			$VarBuyRestItems = [[$VarBuyFoodItem, $VarBuyMinFood, $VarBuyQtyFood]];
		}
	}
	If
	{
		$cond = !$VarBuyFood && $VarBuyWater;
		Par
		{
			$VarBuyRestItems = [[$VarBuyWaterItem, $VarBuyMinWater, $VarBuyQtyWater]];
		}
	}
	If
	{
		$cond = $VarBuyItems != False && $VarBuyRestNPC != "xxx";
		Buy
		{    
			$NPC = $VarBuyRestNPC; 
			$Location = $VarBuyRestNPC; 
	
			$Items = $VarBuyRestItems
			$UseMount = $VarBuyUseMount;
			$Proximity = $VarBuyProximity;
		}
	}
	If
	{
		$cond = $VarBuyAmmo && $VarBuyAmmoNPC != "xxx";
		Buy
		{
			$NPC = $VarBuyAmmoNPC;
			$Location = $VarBuyAmmoLocation; 
			
			$Items = [[$VarBuyAmmoItem, $VarBuyMinAmmo, $VarBuyQtyAmmo]];
			$UseMount = $VarBuyUseMount;
			$Proximity = $VarBuyProximity;
		}
	}
}

