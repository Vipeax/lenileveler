// ******************************************************************************************** //
//	LeniPather:	 Elwynn Forest handler															//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

If 
{
	$cond = $MyLevel <= 6;
	Par 
	{
		#include </zones/esternkingdom/elwynnforest/northshire/vendor.psc>
		#include </zones/esternkingdom/elwynnforest/northshire/buy.psc>
		//#include </zones/esternkingdom/elwynnforest/northshire/mail.psc>
		#include </zones/esternkingdom/elwynnforest/northshire/quests.psc>
		When
		{
			$cond = $AlreadyTrained == 0 && $MyLevel % 2 == 0;
			#include </zones/esternkingdom/elwynnforest/northshire/train.psc>
		}
	}
}