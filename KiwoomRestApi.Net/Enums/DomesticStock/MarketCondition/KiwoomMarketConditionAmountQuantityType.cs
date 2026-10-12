namespace KiwoomRestApi.Net.Enums.DomesticStock.MarketCondition
{
	/// <summary>
	/// 금액수량구분
	/// </summary>
	public enum KiwoomMarketConditionAmountQuantityType
	{
		/// <summary>
		/// 금액
		/// </summary>
		Amount = 1,
		/// <summary>
		/// 수량
		/// </summary>
		Quantity = 2
	}

	/// <summary>
	/// 표시구분
	/// </summary>
	public enum KiwoomMarketConditionAmountQuantityType2
	{
		/// <summary>
		/// 수량
		/// </summary>
		Quantity = 0,
		/// <summary>
		/// 금액(백만원)
		/// </summary>
		Amount1M = 1
	}

	/// <summary>
	/// 금액수량구분
	/// </summary>
	public enum KiwoomMarketConditionAmountQuantityType3
	{
		/// <summary>
		/// 금액(백만원)
		/// </summary>
		Amount1M = 1,
		/// <summary>
		/// 수량(천주)
		/// </summary>
		Quantity1K = 2
	}
}
