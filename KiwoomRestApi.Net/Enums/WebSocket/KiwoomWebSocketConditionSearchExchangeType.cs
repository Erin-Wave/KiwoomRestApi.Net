using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.WebSocket
{
	/// <summary>
	/// 조건검색 거래소구분 (시세 기준)
	/// </summary>
	public enum KiwoomWebSocketConditionSearchExchangeType
	{
		/// <summary>
		/// KRX 시세
		/// </summary>
		[EnumMember(Value = "K")]
		Krx,
		/// <summary>
		/// 통합시세
		/// </summary>
		[EnumMember(Value = "A")]
		Unified
	}
}
