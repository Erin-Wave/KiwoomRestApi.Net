namespace KiwoomRestApi.Net.Enums.DomesticStock.RankingInfo
{
	/// <summary>
	/// 시가총액구분
	/// </summary>
	public enum KiwoomRankingInfoMarketCapCondition
	{
		/// <summary>
		/// 전체조회
		/// </summary>
		All = 0,
		/// <summary>
		/// 1백억미만
		/// </summary>
		Under10B = 1,
		/// <summary>
		/// 1백억~3백억
		/// </summary>
		Range10BTo30B = 2,
		/// <summary>
		/// 3백억~5백억
		/// </summary>
		Range30BTo50B = 3,
		/// <summary>
		/// 5백억~1천억
		/// </summary>
		Range50BTo100B = 4,
		/// <summary>
		/// 1천억이상
		/// </summary>
		Over100B = 5,
		/// <summary>
		/// 1천억~3천억
		/// </summary>
		Range100BTo300B = 6,
		/// <summary>
		/// 3천억이상
		/// </summary>
		Over300B = 7,
		/// <summary>
		/// 5천억이상
		/// </summary>
		Over500B = 8,
		/// <summary>
		/// 1조이상
		/// </summary>
		Over1T = 9
	}
}
