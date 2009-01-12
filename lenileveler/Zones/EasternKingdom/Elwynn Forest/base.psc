// ******************************************************************************************** //
//	LeniPather:	 Elwynn Forest handler															//
//																								//
// 	Version: 	0.1																				//
// 	Authors: 	Leniver																			//
// ******************************************************************************************** //

If 
{
	$cond = $MyLevel <= 6
	Par 
	{
		#include </zones/estern kingdom/elwynn forest/northshire/vendor.psc>
		#include </zones/estern kingdom/elwynn forest/northshire/buy.psc>
		//#include </zones/estern kingdom/elwynn forest/northshire/mail.psc>
		When
		{
			$cond = $AlreadyTrained == 0 && $MyLevel % 2 == 0;
			#include </zones/estern kingdom/elwynn forest/northshire/train.psc>
		}
	}
}