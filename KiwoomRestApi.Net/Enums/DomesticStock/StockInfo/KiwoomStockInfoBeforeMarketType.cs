using System;

namespace KiwoomRestApi.Net.Enums.DomesticStock.StockInfo
{
	/// <summary>
	/// 장전구분
	/// </summary>
	public enum KiwoomStockInfoBeforeMarketType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 정규시장
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 값입니다. All(0:전체)만 사용할 수 있습니다.")]
		Regular = 1,
		/// <summary>
		/// 시간외단일가
		/// </summary>
		[Obsolete("KRX 시간외단일가 시장 폐지로 키움 API 명세에서 제거된 값입니다. All(0:전체)만 사용할 수 있습니다.")]
		AfterMarketSinglePrice = 2
	}
}
