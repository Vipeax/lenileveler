package net.ppather.editor.editors.utils;

public class LanguageHandler {
	public static final int TASK = 0;
	public static final int FUNCTION = 1;
	public static final int DEFAULT_VARIABLE = 2;
	public static final int CUSTOM_VARIABLE = 3;
	public static final int OTHER = -1;
	
	public static final String [] PARENT_TOKENTYPE = new String[] {
		"Par", "Seq"
	};
	public static final String [] CONDITIONAL_TOKENTYPE = new String[] {
		"If", "Until","When"
	};
	public static final String [] BASIC_TOKENTYPE = new String[] {
		"Buy","Danger", "Defend", "Harvest", "Hotspots", "Loot", "Mail", "Pull", "Rest", "Vendor"
	};
	public static final String [] ADVENCED_TOKENTYPE = new String[] {
		"Assist", "AvoidPlayers", "BGQueue", "CastSpell", "GroupFollow", "Interact", "Load", 
		"Log", "LearnFP", "PlaceSpell", "QuestPickup", "QuestGoal", "QuestHandin", "Repeat", "SetHome",
		"SetState", "String", "Talent", "Taxi", "Train", "Unload", "UseItem", "Wait", "Walk"
	};
	public static final String [] BETA_TOKENTYPE = new String[] {
		"BGJoin", "BGLeave", "Follow", "PlaceItem", "ResetInstance"
	};
	public final static String[] FUNCTION_TOKENTYPE = new String[]{
		"BGQueued", "GetState", "HaveBuff", "HaveBuffSpellID", "NearTo",
	    "QuestExists", "QuestStatus", "Random",
	};
	
	public final static String[] TASKTAGS_VIEW = new String[]{
		"Par{}","Seq{}",
		
		// Conditional
		"If{}", "Until{}", "When{}",

		// Basic
		"Buy{}", "Danger{}", "Defend{}", "Harvest{}", "Hotspots{}", "Loot{}",
		"Mail{}", "Pull{}", "Rest{}", "Vendor{}",

		// Advanced 
		"Assist{}", "AvoidPlayers{}", "BGQueue{}", "CastSpell{}", "GroupFollow{}",
		"Interact{}", "Load{}", "Log{}", "LearnFP{}", "PlaceSpell{}", 
		"QuestPickup{}", "QuestGoal{}", "QuestHandin{}", "Repeat{}",
		"SetHome{}", "SetState{}", "String{}", "Talent{}", "Taxi{}", "Train{}",
		"Unload{}", "UseItem{}", "Wait{}", "Walk{}",

		// Beta
		 "(Beta)BGJoin{}", "(Beta)BGLeave{}", "(Beta)Follow{}", "(Beta)PlaceItem{}", "(Beta)ResetInstance{}",
	};
	public final static String[] TASKTAGS_MATCH = new String[]{
		// Parent
		"Par","Seq",
		
		// Conditional
		"If", "Until", "When",

		// Basic
		"Buy", "Danger", "Defend", "Harvest", "Hotspots", "Loot",
		"Mail", "Pull", "Rest", "Vendor",

		// Advanced
		"Assist", "AvoidPlayers", "BGQueue", "CastSpell", "GroupFollow",
		"Interact", "Load", "Log", "LearnFP", "PlaceSpell", 
		"QuestPickup", "QuestGoal", "QuestHandin", "Repeat",
		"SetHome", "SetState", "String", "Talent", "Taxi", "Train",
		"Unload", "UseItem", "Wait", "Walk",

		// Beta
		"BGJoin", "BGLeave", "Follow", "PlaceItem", "ResetInstance",
	};
	public final static String[] TASKTAGS_REPLACEMENT = new String[]{
		// Parent
		"Par{}","Seq{}",
		
		// Conditional
		"If{}", "Until{}", "When{}",

		// Basic
		"Buy{}", "Danger{}", "Defend{}", "Harvest{}", "Hotspots{}", "Loot{}",
		"Mail{}", "Pull{}", "Rest{}", "Vendor{}",

		// Advanced
		"Assist{}", "AvoidPlayers{}", "BGQueue{}", "CastSpell{}", "GroupFollow{}",
		"Interact{}", "Load{}", "Log{}", "LearnFP{}", "PlaceSpell{}", 
		"QuestPickup{}", "QuestGoal{}", "QuestHandin{}", "Repeat{}",
		"SetHome{}", "SetState{}", "String{}", "Talent{}", "Taxi{}", "Train{}",
		"Unload{}", "UseItem{}", "Wait{}", "Walk{}",

		// Beta
		"BGJoin{}", "BGLeave{}", "Follow{}", "PlaceItem{}", "ResetInstance{}",
	};
	public final static String[] TASKTAGS_HELP = new String[]{
		// Parent
		"Executes children based on set priority",
		"Executes children in order until the last one is finished",
		
		// Conditional
		"Execute single child as long as the condition is true", 
		"Execute single child until the condition is true", 
		"Execute single child when condition is true, and keep executing even if condition becomes false in the process",

		// Basic
		"Buy items from NPCs", "Attack any nearby hostile NPCs", "Defend yourself", 
		"Harvest herbs, ore or quest objectives", "Run along specified spots indefinitely", 
		"Loot nearby corpses", "Mail items to another toon", "Move towards nearby specified mobs and pull them", 
		"Restores Health and Mana according to set parameters", "Sell and repair at an NPC",

		// Advanced
		"Assist other players in combat", "Pretend to be AFK while other players are near", 
		"Queue for a BG", "Cast a specific spell", "Follow any nearby Group Players ",
		"Click an NPC", "Load another script dynamically", "Send a message to the pather log", 
		"Talk to a flight master to learn the flight path", "Take spells from the spellbook and place them on your action bar", 
		"Talk to an NPC to pick up a quest", "Has to contain instructions on how to complete a quest", "Talk to an NPC to hand in a quest", 
		"Allow single child to run more than once","Set your hearthstone home location at an innkeeper", 
		"Save a per-toon permanent variable in the toon state file", "Say something in-game", "Spend talent points", 
		"Use a flight master to fly to another location", "Train class or trade skills",
		"Unload a script that was previously loaded with LoadTask", "Use an item in your inventory ", 
		"Wait either indefinitely or until a BG starts", "Move along a series of specified locations once",

		// Beta
		"BETA: Join a BG when it's ready to join", "BETA: Leave a BG when it's over", "BETA: Follow another player", 
		"BETA: Take items from your inventory and place them on your action bar", "BETA: Right click your portrait to reset an instance",
	};
	
	public final static String[] TASKTAGS_WIKI = new String[]{
		// Parent
		"http://wiki.ppather.net/index.php/ParTask","http://wiki.ppather.net/index.php/SeqTask",
		
		// Conditional
		"http://wiki.ppather.net/index.php/IfTask", "http://wiki.ppather.net/index.php/UntilTask", 
		"http://wiki.ppather.net/index.php/WhenTask",

		// Basic
		"http://wiki.ppather.net/index.php/BuyTask", "http://wiki.ppather.net/index.php/DangerTask", 
		"http://wiki.ppather.net/index.php/DefendTask", "http://wiki.ppather.net/index.php/HarvestTask", 
		"http://wiki.ppather.net/index.php/HotspotTask", "http://wiki.ppather.net/index.php/LootTask",
		"http://wiki.ppather.net/index.php/MailTask", "http://wiki.ppather.net/index.php/PullTask", 
		"http://wiki.ppather.net/index.php/RestTask", "http://wiki.ppather.net/index.php/VendorTask",

		// Advanced
		"http://wiki.ppather.net/index.php/AssistTask", "http://wiki.ppather.net/index.php/AvoidPlayersTask", 
		"http://wiki.ppather.net/index.php/BGQueueTask", "http://wiki.ppather.net/index.php/CastSpellTask", 
		"http://wiki.ppather.net/index.php/GroupFollowTask", "http://wiki.ppather.net/index.php/InteractTask", 
		"http://wiki.ppather.net/index.php/LoadTask", "http://wiki.ppather.net/index.php/LogTask", 
		"http://wiki.ppather.net/index.php/LearnFPTask", "http://wiki.ppather.net/index.php/PlaceSpellTask", 
		"http://wiki.ppather.net/index.php/QuestPickupTask", "http://wiki.ppather.net/index.php/QuestGoalTask", 
		"http://wiki.ppather.net/index.php/QuestHandinTask", "http://wiki.ppather.net/index.php/RepeatTask",
		"http://wiki.ppather.net/index.php/SetHomeTask", "http://wiki.ppather.net/index.php/SetStateTask", 
		"http://wiki.ppather.net/index.php/StringTask", "http://wiki.ppather.net/index.php/TalentTask", 
		"http://wiki.ppather.net/index.php/TaxiTask", "http://wiki.ppather.net/index.php/TrainTask",
		"http://wiki.ppather.net/index.php/UnloadTask", "http://wiki.ppather.net/index.php/UseItemTask", 
		"http://wiki.ppather.net/index.php/WaitTask", "http://wiki.ppather.net/index.php/WalkTask",

		// Beta
		"http://wiki.ppather.net/index.php/BGJoinTask", "http://wiki.ppather.net/index.php/BGLeaveTask", 
		"http://wiki.ppather.net/index.php/FollowTask", "http://wiki.ppather.net/index.php/PlaceItemTask", 
		"http://wiki.ppather.net/index.php/ResetInstanceTask",
	};
	
	public final static String[] VARIABLETAGS_VIEW = new String[]{
	    // General/Skills 
		"$AlreadyTrained", "$MyClass", "$MyEnergy", "$MyFaction", "$MyLevel",
	    "$MyMana", "$MyRace", "$MyHealth",

	    // Inventory/Money/Gear
	    "$FreeBagSlots", "$MyGear", "$MyGearType", "$ItemCount", "$MyBagNames",
	    "$MyDurability", "$MyMoney",
	    
	    // Location
	    "$MySubZone", "$MyX", "$MyY", "$MyZ", "$MyZone",

	    // State/Combat
	    "$IsDead", "$IsInCombat", "$IsStealthed", "$MyTarget", 
	    
	    // Battleground
	    "$BGFinished", "$BGQueued", "$BGStarted",
	};
	
	public final static String[] VARIABLETAGS_MATCH = new String[]{
	    // General/Skills 
		"$AlreadyTrained", "$MyClass", "$MyEnergy", "$MyFaction", "$MyLevel",
	    "$MyMana", "$MyRace", "$MyHealth",

	    // Inventory/Money/Gear
	    "$FreeBagSlots", "$MyGear", "$MyGearType", "$ItemCount", "$MyBagNames",
	    "$MyDurability", "$MyMoney",
	    
	    // Location
	    "$MySubZone", "$MyX", "$MyY", "$MyZ", "$MyZone",

	    // State/Combat
	    "$IsDead", "$IsInCombat", "$IsStealthed", "$MyTarget", 
	    
	    // Battleground
	    "$BGFinished", "$BGQueued", "$BGStarted",
	};
	
	public final static String[] VARIABLETAGS_REPLACEMENT = new String[]{
	    // General/Skills 
		"$AlreadyTrained", "$MyClass", "$MyEnergy", "$MyFaction", "$MyLevel",
	    "$MyMana", "$MyRace", "$MyHealth",

	    // Inventory/Money/Gear
	    "$FreeBagSlots", "$MyGear", "$MyGearType", "$ItemCount{\"__CURSOR__\"}", "$MyBagNames",
	    "$MyDurability", "$MyMoney",
	    
	    // Location
	    "$MySubZone", "$MyX", "$MyY", "$MyZ", "$MyZone",

	    // State/Combat
	    "$IsDead", "$IsInCombat", "$IsStealthed", "$MyTarget{\"__CURSOR__\"}", 
	    
	    // Battleground
	    "$BGFinished", "$BGQueued", "$BGStarted",
	};
	
	public final static String[] VARIABLETAGS_HELP = new String[]{
	    // General/Skills 
		"Returns true if toon trained the latest batch of skills aready", "Returns class", 
		"Returns energy", "Returns faction", "Returns level",
	    "Returns mana", "Returns race", "Returns health",

	    // Inventory/Money/Gear
	    "Returns free bag slots", "Returns gear as array of GItem? wtf?", 
	    "Returns type of gear your toon can equip (cloth, leather, ...)", 
	    "Returns amount of specified item in inventory \r\n\r\nEXAMPLE: $ItemCount{\"item\"}", 
	    "Returns bags as dictionary (string, int)... wtf?",
	    "Returns durability of equipped item with lowest durability (not average)", 
	    "Returns money as copper",
	    
	    // Location
	    "Returns current subzone when it's working, but atm only returns \"subzone\"", 
	    "Returns current x coordinate", "Returns current y coordinate", "Returns current z coordinate", 
	    "Returns current zone",

	    // State/Combat
	    "Returns true if toon is dead", "Returns true if toon is in combat", 
	    "Returns true of toon is in stealth",
	    "Returns dictionary of target info. " +
	    	"\r\n\r\nPARAMETER: Health, HealthPoints, HealthMax, Mana, ManaPoints, " +
	    	    "\r\n           ManaMax, IsDead, IsPlayer, Reaction, Name, Level. " +
	    	"\r\n\r\nEXAMPLE: $Mytarget{\"IsPlayer\"}", 
	    
	    // Battleground
	    "Returns true if in a bg and it's over (checks if score frame is visible)", 
	    "Returns true if toon is queued for any bg", 
	    "Returns true if in a bg and it started already (checks preperation buff)",
	};
	
	public final static String[] VARIABLETAGS_WIKI = new String[]{
	    // General/Skills 
		"http://wiki.ppather.net/index.php/$AlreadyTrained", "http://wiki.ppather.net/index.php/$MyClass", 
		"http://wiki.ppather.net/index.php/$MyEnergy", "http://wiki.ppather.net/index.php/$MyFaction", 
		"http://wiki.ppather.net/index.php/$MyLevel", "http://wiki.ppather.net/index.php/$MyMana", 
		"http://wiki.ppather.net/index.php/$MyRace", "http://wiki.ppather.net/index.php/$MyHealth",

	    // Inventory/Money/Gear
	    "http://wiki.ppather.net/index.php/$FreeBagSlots", "http://wiki.ppather.net/index.php/$MyGear", 
	    "http://wiki.ppather.net/index.php/$MyGearType", "http://wiki.ppather.net/index.php/$ItemCount", 
	    "http://wiki.ppather.net/index.php/$MyBagNames", "http://wiki.ppather.net/index.php/$MyDurability", 
	    "http://wiki.ppather.net/index.php/$MyMoney",
	    
	    // Location
	    "http://wiki.ppather.net/index.php/$MySubZone", "http://wiki.ppather.net/index.php/$MyX", 
	    "http://wiki.ppather.net/index.php/$MyY", "http://wiki.ppather.net/index.php/$MyZ", 
	    "http://wiki.ppather.net/index.php/$MyZone",

	    // State/Combat
	    "http://wiki.ppather.net/index.php/$IsDead", "http://wiki.ppather.net/index.php/$IsInCombat", 
	    "http://wiki.ppather.net/index.php/$IsStealthed", "http://wiki.ppather.net/index.php/$MyTarget", 
	    
	    // Battleground
	    "http://wiki.ppather.net/index.php/$BGFinished", "http://wiki.ppather.net/index.php/$BGQueued", 
	    "http://wiki.ppather.net/index.php/$BGStarted",
	};
	
	public final static String[] FUNCTIONTAGS_VIEW = new String[]{
	    // General
		"BGQueued(BG)", "GetState(variable)", "HaveBuff(BuffName)", "HaveBuffSpellID(Spell ID)", "NearTo([X, Y, Z])",
	    "QuestExists(QuestID)", "QuestStatus(QuestID)", "Random(min, max)",
	};
	
	public final static String[] FUNCTIONTAGS_MATCH = new String[]{
	    // General
		"BGQueued", "GetState", "HaveBuff", "HaveBuffSpellID", "NearTo",
	    "QuestExists", "QuestStatus", "Random",
	};
	
	public final static String[] FUNCTIONTAGS_REPLACEMENT = new String[]{
	    // General
		"BGQueued(__CURSOR__)", "GetState(__CURSOR__)", "HaveBuff(__CURSOR__)", "HaveBuffSpellID(__CURSOR__)", "NearTo([__CURSOR__, , ]",
	    "QuestExists(__CURSOR__)", "QuestStatus(__CURSOR__)", "Random(__CURSOR__, )",
	};
	
	public final static String[] FUNCTIONTAGS_HELP = new String[]{
	    // General
		"Returns true if queued for specified battleground", "Returns value of specified variable in toonstate file", 
		"Returns true if character has specified buff, should also work for debuffs by spell name", 
		"Returns true if character has specified buff, should also work for debuffs by spell ID", 
		"Returns true if within radius of coordinates", "Returns 1 (true) if toondata contains quest id (doesn't care about quest state)", 
		"Returns state of specified quest id \r\nRETURNS: accepted, failed, goaldone, completed, completedr", 
		"Returns a random number between min and max (including max) ",
	};
	
	public final static String[] FUNCTIONTAGS_WIKI = new String[]{
	    // General
		"http://wiki.ppather.net/index.php/BGQueued", "http://wiki.ppather.net/index.php/GetState", 
		"http://wiki.ppather.net/index.php/HaveBuff", "http://wiki.ppather.net/index.php/HaveBuffSpellID", 
		"http://wiki.ppather.net/index.php/NearTo", "http://wiki.ppather.net/index.php/QuestExists", 
		"http://wiki.ppather.net/index.php/QuestStatus", "http://wiki.ppather.net/index.php/Random",
	};
}
