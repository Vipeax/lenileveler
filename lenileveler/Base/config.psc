// ******************************************************************************************** //
//	LeniPather:	 General Configuration															//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //


	// ******************************************************************************************** //
	// 		Leveling Configuration   																//
	// ******************************************************************************************** //
		$VarLevelingFromRace = True;			// Use default template race leveling? True/False.
		$VarLevelingForcedRace = "Normal";		// Use this forced template leveling:
												// 		Alliance: 	Human/Dwarf/Gnome/NightElf/Dranei
												// 		Horde: 		Undead/Tauren/Orc/Troll/BloodElf
												// 		WARNING: Using this stuff can cause some bug with class trainer


	// ******************************************************************************************** //
	// 		Buy Configuration   																	//
	// ******************************************************************************************** //
		$VarBuyFood = False;					// Does Toon have to buy food? True/False
		$VarBuyWater = False;					// Does Toon have to buy water? True/False
		$VarBuyAmmo = False;					// Does Toon have to buy arrows/bullets? True/False	

		$VarBuyMinFood = 0; 					// Minimum quantities of food before purchasing new one.
		$VarBuyMinWater = 0; 					// Minimum quantities of mana regenerating food before purchasing new one.
		$VarBuyMinAmmo = 50; 					// Minimum quantities of arrows/bullets before repurchasing.

		$VarBuyQtyFood = 100; 					// Quantities of food to purchase.
		$VarBuyQtyWater = 100; 					// Quantities of water to purchase.
		$VarBuyQtyAmmo = 400; 					// Quantities of arrows/bullets to purchase.

		$VarBuyUseMount = True;					// Use mount to go buying? True/False



	// ******************************************************************************************** //
	// 		Repair and Vendoring Configuration   													//
	// ******************************************************************************************** //
		$VarVendorProtected = [];				// These items will NOT be sold. Seperated by a comma.
		$VarVendorForceSell = []; 				// These items will force to be sold. Seperated by a comma.
		$VarVendorMinDurability = 0.2; 			// How many percent of durability left before repairing. 0.2 means 20%
		$VarVendorMinFreeBagSlots = 1; 			// Minimum free bag slots left before selling.
		$VarVendorSellGray  = True; 			// Sell items with a Grey name? True/False
		$VarVendorSellWhite = True; 			// Sell items of Common quality? True/False
		$VarVendorSellGreen = False; 			// Sell items of Uncommon quality? True/False
		$VarVendorBlacklistTime	= 15 * 60;		// Blacklist vendor for 15 minutes.
		$VarVendorProximity = 60;				// When Toon is this near in yards, it will sell/repair.
		$VarVendorUseMount = True;				// Use mount to go selling/repairing? True/False


	// ******************************************************************************************** //
	// 		Mailing Configuration   																//
	// ******************************************************************************************** //
		$VarMail = False;						// Enable mail sending
		$VarMailTo = "YourToons";				// The name of the person who items will be mailed to.
		$VarMailItems = []; 					// Items to be mailed to the character above. Seperated by a comma.
		$VarMailProtected = []; 				// Items that will not be mailed. Seperated by a comma.
		$VarMailGreens = True; 					// Mail items of Uncommon quality (Green name) True/False
		$VarMailBlues = True; 					// Mail items of Rare quality (Blue name) True/False
		$VarMailEpic = True; 					// Mail items of Epic quality (Purple name) True/False
		$VarMailMinFreeBagSlots = 5; 			// Minimum free bag slots left before mailing.
		$VarMailProximity = 60;					// When Toon is this near in yards, it will send mail.



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
		$VarUseMount = True; 					// Use mount for long distance? True/False.
		$VarDangerDistance = 25;				// Danger distance
