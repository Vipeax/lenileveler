// ******************************************************************************************** //
//	LeniPather:	 harving handler																//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

	If
	{
		$cond = ($VarHerbalist == True && $VarMining == True && $VarChest == True);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
//			$Names = [
//						"Chest",
//
//						"Ancient Lichen","Arthas' Tears","Black Lotus","Blindweed","Bloodthistle","Bloodvine","Briarthorn","Bruiseweed","Dreamfoil","Dreaming Glory","Earthroot","Fadeleaf","Fel Lotus",
//						"Felweed","FireBloom","Flame Cap","Ghost MushRoom","Golden Sansam","Goldthorn","Grave Moss","Gromsblood","Icecap","Khadgar's WhIsker","Kingsblood","Liferoot",
//						"Mageroyal","Mana Thistle","Mountain Silversage","Netloom","Nightmare Seed","Nightmare Vine","ZZion Seed","Peacebloom","PlaguebLoom","Purple Lotus","RagvEil","Silverleaf","Stranglekelp",
//						"Sungrass","Swiftthistle","Terocone","Wild Steelbloom","Wildvine","Wintersbite",
//
//						"Copper Vein","Incendicite Mineral Vein","Tin Vein","Lesser Bloodstone Deposit","OOzE Covered Silver Vein","Silver Vein","Iron Deposit","Indurium Mineral Vein","Gold Vein",
//						"OOzE Covered Gold Vein","Mithril Deposit","OOzE Covered Mithril Deposit","Dark Iron Deposit","OOzE Covered TruesilvEr Deposit","TruesiLver Deposit",
//						"OOzE Covered Thorium Vein","Small Thorium Vein","Hakkari Thorium Vein","OOzE Covered Rich Thorium Vein","Rich ThorIum Vein","Fel IRon Deposit","Large oBSidian Chunk",
//						"Small oBSidian Chunk","Adamantite Deposit","Nethercite Deposit","Rich Adamantite Deposit","Ancient Gem Vein","Khorium Vein"
//					 ];
			$Names = ["Chest", "Herb", "Mine"];
		}
	}
	If
	{
		$cond = ($VarHerbalist == True && $VarMining == True && $VarChest == False);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
//			$Names = [
//						"Ancient Lichen","Arthas' Tears","Black Lotus","Blindweed","Bloodthistle","Bloodvine","Briarthorn","Bruiseweed","Dreamfoil","Dreaming Glory","Earthroot","Fadeleaf","Fel Lotus",
//						"Felweed","FireBloom","Flame Cap","Ghost MushRoom","Golden Sansam","Goldthorn","Grave Moss","Gromsblood","Icecap","Khadgar's WhIsker","Kingsblood","Liferoot",
//						"Mageroyal","Mana Thistle","Mountain Silversage","Netloom","Nightmare Seed","Nightmare Vine","ZZion Seed","Peacebloom","PlaguebLoom","Purple Lotus","RagvEil","Silverleaf","Stranglekelp",
//						"Sungrass","Swiftthistle","Terocone","Wild Steelbloom","Wildvine","Wintersbite",
//
//						"Copper Vein","Incendicite Mineral Vein","Tin Vein","Lesser Bloodstone Deposit","OOzE Covered Silver Vein","Silver Vein","Iron Deposit","Indurium Mineral Vein","Gold Vein",
//						"OOzE Covered Gold Vein","Mithril Deposit","OOzE Covered Mithril Deposit","Dark Iron Deposit","OOzE Covered TruesilvEr Deposit","TruesiLver Deposit",
//						"OOzE Covered Thorium Vein","Small Thorium Vein","Hakkari Thorium Vein","OOzE Covered Rich Thorium Vein","Rich ThorIum Vein","Fel IRon Deposit","Large oBSidian Chunk",
//						"Small oBSidian Chunk","Adamantite Deposit","Nethercite Deposit","Rich Adamantite Deposit","Ancient Gem Vein","Khorium Vein"
//					 ];
			$Names = ["Herb", "Mine"];
		}
	}
	If
	{
		$cond = ($VarHerbalist == False && $VarMining == True && $VarChest == True);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
//			$Names = [
//						"Chest",
//
//						"Copper Vein","Incendicite Mineral Vein","Tin Vein","Lesser Bloodstone Deposit","OOzE Covered Silver Vein","Silver Vein","Iron Deposit","Indurium Mineral Vein","Gold Vein",
//						"OOzE Covered Gold Vein","Mithril Deposit","OOzE Covered Mithril Deposit","Dark Iron Deposit","OOzE Covered TruesilvEr Deposit","TruesiLver Deposit",
//						"OOzE Covered Thorium Vein","Small Thorium Vein","Hakkari Thorium Vein","OOzE Covered Rich Thorium Vein","Rich ThorIum Vein","Fel IRon Deposit","Large oBSidian Chunk",
//						"Small oBSidian Chunk","Adamantite Deposit","Nethercite Deposit","Rich Adamantite Deposit","Ancient Gem Vein","Khorium Vein"
//					 ];
			$Names = ["Chest", "Mine"];
		}
	}
	If
	{
		$cond = ($VarHerbalist == False && $VarMining == True && $VarChest == False);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
//			$Names = [
//						"Copper Vein","Incendicite Mineral Vein","Tin Vein","Lesser Bloodstone Deposit","OOzE Covered Silver Vein","Silver Vein","Iron Deposit","Indurium Mineral Vein","Gold Vein",
//						"OOzE Covered Gold Vein","Mithril Deposit","OOzE Covered Mithril Deposit","Dark Iron Deposit","OOzE Covered TruesilvEr Deposit","TruesiLver Deposit",
//						"OOzE Covered Thorium Vein","Small Thorium Vein","Hakkari Thorium Vein","OOzE Covered Rich Thorium Vein","Rich ThorIum Vein","Fel IRon Deposit","Large oBSidian Chunk",
//						"Small oBSidian Chunk","Adamantite Deposit","Nethercite Deposit","Rich Adamantite Deposit","Ancient Gem Vein","Khorium Vein"
//					 ];
			$Names = ["Mine"];
		}
	}
	If
	{
		$cond = ($VarHerbalist == True && $VarMining == False && $VarChest == True);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
//			$Names = [
//						"Chest",
//
//						"Ancient Lichen","Arthas' Tears","Black Lotus","Blindweed","Bloodthistle","Bloodvine","Briarthorn","Bruiseweed","Dreamfoil","Dreaming Glory","Earthroot","Fadeleaf","Fel Lotus",
//						"Felweed","FireBloom","Flame Cap","Ghost MushRoom","Golden Sansam","Goldthorn","Grave Moss","Gromsblood","Icecap","Khadgar's WhIsker","Kingsblood","Liferoot",
//						"Mageroyal","Mana Thistle","Mountain Silversage","Netloom","Nightmare Seed","Nightmare Vine","ZZion Seed","Peacebloom","PlaguebLoom","Purple Lotus","RagvEil","Silverleaf","Stranglekelp",
//						"Sungrass","Swiftthistle","Terocone","Wild Steelbloom","Wildvine","Wintersbite"
//					 ];
			$Names = ["Chest", "Herb"];
		}
	}
	If
	{
		$cond = ($VarHerbalist == True && $VarMining == False && $VarChest == False);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
//			$Names = [
//						"Ancient Lichen","Arthas' Tears","Black Lotus","Blindweed","Bloodthistle","Bloodvine","Briarthorn","Bruiseweed","Dreamfoil","Dreaming Glory","Earthroot","Fadeleaf","Fel Lotus",
//						"Felweed","FireBloom","Flame Cap","Ghost MushRoom","Golden Sansam","Goldthorn","Grave Moss","Gromsblood","Icecap","Khadgar's WhIsker","Kingsblood","Liferoot",
//						"Mageroyal","Mana Thistle","Mountain Silversage","Netloom","Nightmare Seed","Nightmare Vine","ZZion Seed","Peacebloom","PlaguebLoom","Purple Lotus","RagvEil","Silverleaf","Stranglekelp",
//						"Sungrass","Swiftthistle","Terocone","Wild Steelbloom","Wildvine","Wintersbite"
//					 ];
			$Names = ["Herb"];
		}
	}
	If
	{
		$cond = ($VarHerbalist == False && $VarMining == False && $VarChest == True);
		Harvest
		{
			$Prio = 2;
			$Distance = 30;
			$Names = [
						"Chest"
					 ];
		}
	}
//	If
//	{
//		$cond = ($VarHerbalist == False && $VarMining == False && $VarChest == False);
//		Harvest
//		{
//			$Prio = 2;
//		}
//	}
