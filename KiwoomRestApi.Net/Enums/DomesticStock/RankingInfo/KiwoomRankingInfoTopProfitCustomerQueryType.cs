namespace KiwoomRestApi.Net.Enums.DomesticStock.RankingInfo
{
	/// <summary>
	/// 조회구분 (수익률상위고객매매상세)
	/// </summary>
	public enum KiwoomRankingInfoTopProfitCustomerQueryType
	{
		/// <summary>
		/// 수익률
		/// </summary>
		ProfitRate = 0,
		/// <summary>
		/// 매수
		/// </summary>
		Buy = 1,
		/// <summary>
		/// 매도
		/// </summary>
		Sell = 2,
		/// <summary>
		/// 순매매
		/// </summary>
		NetTransaction = 3,
		/// <summary>
		/// 계좌수
		/// </summary>
		AccountCount = 4,
		/// <summary>
		/// 수량
		/// </summary>
		Quantity = 5,
		/// <summary>
		/// 평균매입가
		/// </summary>
		AveragePurchasePrice = 6
	}
}
