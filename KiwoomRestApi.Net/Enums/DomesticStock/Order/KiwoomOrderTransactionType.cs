using System;

namespace KiwoomRestApi.Net.Enums.DomesticStock.Order
{
	/// <summary>
	/// 매매구분
	/// </summary>
	public enum KiwoomOrderTransactionType
	{
		/// <summary>
		/// 보통
		/// </summary>
		Normal = 0,
		/// <summary>
		/// 시장가
		/// </summary>
		Market = 3,
		/// <summary>
		/// 조건부지정가
		/// </summary>
		ConditionalLimit = 5,
		/// <summary>
		/// 최유리지정가 
		/// </summary>
		BestLimit = 6,
		/// <summary>
		/// 최우선지정가 
		/// </summary>
		HighestPriority = 7,
		/// <summary>
		/// 보통(IOC)
		/// </summary>
		NormalIoc = 10,
		/// <summary>
		/// 시장가(IOC)
		/// </summary>
		MarketIoc = 13,
		/// <summary>
		/// 최유리(IOC)
		/// </summary>
		BestIoc = 16,
		/// <summary>
		/// 보통(FOK)
		/// </summary>
		NormalFok = 20,
		/// <summary>
		/// 시장가(FOK)
		/// </summary>
		MarketFok = 23,
		/// <summary>
		/// 최유리(FOK)
		/// </summary>
		BestFok = 26,
		/// <summary>
		/// 스톱지정가
		/// </summary>
		StopLimit = 28,
		/// <summary>
		/// 중간가
		/// </summary>
		MedianPrice = 29,
		/// <summary>
		/// 중간가(IOC)
		/// </summary>
		MedianPriceIoc = 30,
		/// <summary>
		/// 중간가(FOK)
		/// </summary>
		MedianPriceFok = 31,
		/// <summary>
		/// 보통(GTP) - NXT 프리마켓 한정
		/// </summary>
		NormalGtp = 40,
		/// <summary>
		/// 최유리(GTP) - NXT 프리마켓 한정
		/// </summary>
		BestGtp = 46,
		/// <summary>
		/// 최우선(GTP) - NXT 프리마켓 한정
		/// </summary>
		HighestPriorityGtp = 47,
		/// <summary>
		/// 장시작전시간외
		/// </summary>
		BeforeMarketOpen = 61,
		/// <summary>
		/// 시간외단일가
		/// </summary>
		[Obsolete("KRX 시간외단일가 시장 폐지로 2026-09-12부터 사용할 수 없는 주문유형입니다.")]
		AfterMarketSinglePrice = 62,
		/// <summary>
		/// 장마감후시간외 
		/// </summary>
		AfterMarketClose = 81
	}
}
