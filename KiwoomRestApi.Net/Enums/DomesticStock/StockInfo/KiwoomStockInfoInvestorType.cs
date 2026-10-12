namespace KiwoomRestApi.Net.Enums.DomesticStock.StockInfo
{
	/// <summary>
	/// 투자자구분
	/// </summary>
	public enum KiwoomStockInfoInvestorType
	{
		/// <summary>
		/// 금융투자
		/// </summary>
		FinancialInvestment = 1000,
		/// <summary
		/// >보험
		/// </summary>
		Insurance = 2000,
		/// <summary>
		/// 투신
		/// </summary>
		InvestmentTrust = 3000,
		/// <summary>
		/// 사모펀드
		/// </summary>
		PrivateEquityFund = 3100,
		/// <summary>
		/// 은행
		/// </summary>
		Bank = 4000,
		/// <summary>
		/// 기타금융
		/// </summary>
		OtherFinancials = 5000,
		/// <summary>
		/// 연기금
		/// </summary>
		PensionFund = 6000,
		/// <summary>
		/// 국가
		/// </summary>
		Nation = 7000,
		/// <summary>
		/// 기타법인
		/// </summary>
		OtherCorporations = 7100,
		/// <summary>
		/// 개인
		/// </summary>
		Retail = 8000,
		/// <summary>
		/// 외국인
		/// </summary>
		Foreigner = 9000,
		/// <summary>
		/// 기관계
		/// </summary>
		Institution = 9999
	}
}
