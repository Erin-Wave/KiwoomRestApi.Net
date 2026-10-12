using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.DomesticStock.Etf
{
	/// <summary>
	/// 운용사
	/// </summary>
	public enum KiwoomEtfManagementCompany
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "0000")]
		All = 0,
		/// <summary>
		/// KODEX (삼성)
		/// </summary>
		KodexSamsung = 3020,
		/// <summary>
		/// KOSEF (키움)
		/// </summary>
		KosefKiwoom = 3027,
		/// <summary>
		/// TIGER (미래에셋)
		/// </summary>
		TigerMiraeAsset = 3191,
		/// <summary>
		/// KINDEX (한국투자)
		/// </summary>
		KindexKoreaInvestment = 3228,
		/// <summary>
		/// KStar (KB)
		/// </summary>
		KstarKb = 3023,
		/// <summary>
		/// 아리랑 (한화)
		/// </summary>
		ArirangHanwha = 3022,
		/// <summary>
		/// SOL (신한자산운용)
		/// </summary>
		SolShinhan = 3048,
		/// <summary>
		/// HANARO (NH아문디)
		/// </summary>
		HanaroNhAmundi = 3257,
		/// <summary>
		/// 기타운용사
		/// </summary>
		Other = 9999
	}
}
