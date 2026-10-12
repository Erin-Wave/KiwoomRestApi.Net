namespace KiwoomRestApi.Net.Enums.DomesticStock.RankingInfo
{
	/// <summary>
	/// 신용조건
	/// </summary>
	public enum KiwoomRankingInfoCreditCondition
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 신용융자A군
		/// </summary>
		CreditA = 1,
		/// <summary>
		/// 신용융자B군
		/// </summary>
		CreditB = 2,
		/// <summary>
		/// 신용융자C군
		/// </summary>
		CreditC = 3,
		/// <summary>
		/// 신용융자D군
		/// </summary>
		CreditD = 4,
		/// <summary>
		/// 신용한도초과제외
		/// </summary>
		ExcludeCreditLimitExceeded = 5,
		/// <summary>
		/// 신용융자E군
		/// </summary>
		CreditE = 7,
		/// <summary>
		/// 신용대주
		/// </summary>
		CreditShortSale = 8,
		/// <summary>
		/// 신용융자전체
		/// </summary>
		CreditAll = 9
	}

	/// <summary>
	/// 신용구분 (대량체결상위)
	/// </summary>
	public enum KiwoomRankingInfoCreditCondition2
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 신용융자A군
		/// </summary>
		CreditA = 1,
		/// <summary>
		/// 신용융자B군
		/// </summary>
		CreditB = 2,
		/// <summary>
		/// 신용융자C군
		/// </summary>
		CreditC = 3,
		/// <summary>
		/// 신용융자D군
		/// </summary>
		CreditD = 4,
		/// <summary>
		/// 신용대주
		/// </summary>
		CreditShortSale = 5,
		/// <summary>
		/// 신용융자E군
		/// </summary>
		CreditE = 7,
		/// <summary>
		/// 신용한도초과
		/// </summary>
		CreditLimitExceeded = 8,
		/// <summary>
		/// 신용융자전체
		/// </summary>
		CreditAll = 9
	}
}
