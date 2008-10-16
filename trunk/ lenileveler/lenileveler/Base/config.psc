// ******************************************************************************************** //
//	LeniPather:	 General Configuration															//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //


	// ******************************************************************************************** //
	// 		Misc Configuration   																	//
	// ******************************************************************************************** //
		$VarLevelingFromRace = True;			// Use default template race leveling? True/False.
		$VarLevelingForcedRace = "";			// Use this forced template leveling:
												// 		Alliance: 	Human/Dwarf/Gnome/NightElf/Dranei
												// 		Horde: 		Undead/Tauren/Orc/Troll/BloodElf
												// 		WARNING: Using this stuff can cause some bug with class trainer


	// ******************************************************************************************** //
	// 		Ranged Configuration   																	//
	// ******************************************************************************************** //
		$VarRanged = "Rough Arrow";  			// The name of the Ammo you wish to be purchased.
		$VarMinRanged = 0; 						// Minimum quantities of arrows before repurchasing.
		$VarBuyRanged = 10; 					// How many Ranged ammo to purchase?



	// ******************************************************************************************** //
	// 		Food/Drink Configuration   																//
	// ******************************************************************************************** //
		$VarMinFood = 0; 						// Minimum quantities of food before purchasing new one.
		$VarMinWater = 0; 						// Minimum quantities of mana regenerating food before purchasing new one.
		$VarBuyFood = 10; 						// Quantities of food to purchase.
		$VarBuyWater = 10; 						// Quantities of water to purchase.
		$VarFood = "tough Hunk of Bread"; 		// The name of the food to purchase.s
		$VarWater = "Moonberry Juice"; 			// The name of the water to purchase.



	// ******************************************************************************************** //
	// 		Repair and Vendoring Configuration   													//
	// ******************************************************************************************** //
		$VarVendProtected = [];					// These items will NOT be sold. Seperated by a comma.
		$VarVendForced = []; 					// These items will force to be sold. Seperated by a comma.
		$VarMinDurability = 0.2; 				// How many percent of durability left before repairing. 0.2 means 20%
		$VarMinFreeBagSlots = 1; 				// Minimum free bag slots left before selling.
		$VarSellGray  = True; 					// Sell items with a Grey name? True/False
		$VarSellWhite = True; 					// Sell items of Common quality? True/False
		$VarSellGreen = False; 					// Sell items of Uncommon quality? True/False


	// ******************************************************************************************** //
	// 		Mailing Configuration   																//
	// ******************************************************************************************** //
		$VarTo = "Test"; 						// Replace 'Test' with the name of the character which will receive the items.
		$VarItems = []; 						// Items to be mailed to the character above.
		$VarMailProtected = []; 				// Items that will not be mailed
		$VarMailGreens = True; 					// Mail items of Uncommon quality (Green name) True/False
		$VarMailBlues = True; 					// Mail items of Rare quality (Blue name) True/False
		$VarMailEpic = True; 					// Mail items of Epic quality (Purple name) True/False


	// ******************************************************************************************** //
	// 		Profession/Harving Configuration   														//
	// ******************************************************************************************** //
		$VarChest = True; 						// Do you want to loot chest? True/False
		$VarSkin = False; 						// Do you want to be a Skinner? True/False
		$VarHerbalist = False; 					// Do you want to be a Herbalist? True/False
		$VarMining = False; 					// Do you want to be a Miner? True/False
		$VarAlchi = False; 						// Do you want to be an Alchemist? True/False
		$VarGorge = False; 						// Do you want to be a Blacksmith? True/False
		$VarCuisto = False; 					// Do you want to learn the Cooking skill? True/False
		$VarInge = False; 						// Do you want to be an Engineer? True/False
		$VarEnchante = False; 					// Do you want to be an Enchanter? True/False
		$VarAid = False; 						// Do you want to have First Aid? True/False
		$VarFish = False; 						// Do you want to learn the Fishing skill? True/False
		$VarTCuir = False; 						// Do you want to be a Leatherworker? True/False
		$VarTailor = False; 					// Do you want to be a Tailor? True/False


	// ******************************************************************************************** //
	// 		Security Configuration   																//
	// ******************************************************************************************** //
		//$VarAvoidPlayers = False; 			// Do you want to stop (pause) Glider when a player is near? True/False
		//$VarAvoidRange = 60; 					// How close have the players to be to trigger the detecetion in yards?
		//$VarWaitUntilClear = False; 			// Wait until the player is gone, and safe to Glide again? True/False
		//$VarTimeUntilExit = 800; 				// Minutes before auto quit the game if someone follows you.
		//$VarStealthWhileHiding = True; 		// Rogue or druid==> Using stealth to hide. True/False
		//$VarStealthKey = "Pogue.Stealth"; 	// The key of your stealth spell. Assuming you are using Pogue.
		//$VarCatFormKey = "Druid.CatForm"; 	// The key of your stealth spell.
		//$VarPlaySound = False; 				// Play a warning sound if a player is near? True/False


	// ******************************************************************************************** //
	// 		Misc Configuration   																	//
	// ******************************************************************************************** //
		$VarUseMount = False; 					// Use mount for long distance? True/False.
		$VarDangerDistance = 25;				// Danger distance
