using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.DomesticStock.StockInfo
{
	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 코스피
		/// </summary>
		Kospi = 1,
		/// <summary>
		/// 코스닥
		/// </summary>
		Kosdaq = 101,
		/// <summary>
		/// 코스피200
		/// </summary>
		Kospi200 = 201
	}

	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType2
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 코스피
		/// </summary>
		Kospi = 1,
		/// <summary>
		/// 코스닥
		/// </summary>
		Kosdaq = 2,
		/// <summary>
		/// 종목
		/// </summary>
		Stock = 3
	}

	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType3
	{
		/// <summary>
		/// 코스피
		/// </summary>
		Kospi = 0,
		/// <summary>
		/// 인프라투융자
		/// </summary>
		Infrastructure = 2,
		/// <summary>
		/// ELW
		/// </summary>
		Elw = 3,
		/// <summary>
		/// 뮤추얼펀드
		/// </summary>
		MutualFund = 4,
		/// <summary>
		/// 신주인수권
		/// </summary>
		Warrants = 5,
		/// <summary>
		/// 리츠
		/// </summary>
		Reit = 6,
		/// <summary>
		/// 신주인수권증서
		/// </summary>
		WarrantCertificates = 7,
		/// <summary>
		/// ETF
		/// </summary>
		Etf = 8,
		/// <summary>
		/// 하이일드
		/// </summary>
		HighYield = 9,
		/// <summary>
		/// 코스닥
		/// </summary>
		Kosdaq = 10,
		/// <summary>
		/// K-OTC
		/// </summary>
		Kotc = 30,
		/// <summary>
		/// 코넥스
		/// </summary>
		Konex = 50,
		/// <summary>
		/// ETN
		/// </summary>
		Etn = 60,
		/// <summary>
		/// 손실제한 ETN
		/// </summary>
		LossLimitedEtn = 70,
		/// <summary>
		/// 금현물
		/// </summary>
		GoldSpot = 80,
		/// <summary>
		/// 변동성 ETN
		/// </summary>
		VolatilityEtn = 90
	}

	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType4
	{
		/// <summary>
		/// 코스피(거래소)
		/// </summary>
		Kospi = 0,
		/// <summary>
		/// 코스닥
		/// </summary>
		Kosdaq = 1,
		/// <summary>
		/// KOSPI200
		/// </summary>
		Kospi200 = 2,
		/// <summary>
		/// KOSPI100
		/// </summary>
		Kospi100 = 4,
		/// <summary>
		/// KRX100(통합지수)
		/// </summary>
		Krx100 = 7
	}

	/// <summary>
	/// 시장구분
	/// </summary>
	public enum KiwoomStockInfoMarketType5
	{
		/// <summary>
		/// 코스피
		/// </summary>
		[EnumMember(Value = "P00101")]
		Kospi,
		/// <summary>
		/// 코스닥
		/// </summary>
		[EnumMember(Value = "P10102")]
		Kosdaq
	}
}
