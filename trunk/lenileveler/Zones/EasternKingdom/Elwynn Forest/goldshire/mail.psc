// ******************************************************************************************** //
//	LeniPather:	 Elwynn Forest - Goldshire mail handler											//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

If
{
	$cond = $VarMail && $VarMailTo != ''
	Mail
	{
		$Prio = 3;
		//$Location = [-2350.14, -1945.08, 95.8];
    	$To = $VarMailTo;
    	$Items = $VarMailItems;
    	$Protected = $VarMailProtected;   
    	$MailGreens = $VarMailGreens;
    	$MailBlues = $VarMailBlues;
    	$MailEpics = $VarMailEpic; 
    	$MinFreeBagSlots = $VarMailMinFreeBagSlots;
		$Proximity = $VarMailProximity;
	}
}