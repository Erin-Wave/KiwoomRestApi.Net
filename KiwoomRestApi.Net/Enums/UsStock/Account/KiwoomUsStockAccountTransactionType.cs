using System;
using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Account
{
	/// <summary>
	/// 구분
	/// </summary>
	public enum KiwoomUsStockAccountTransactionType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "0")]
		All,
		/// <summary>
		/// 입출금
		/// </summary>
		[EnumMember(Value = "1")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		DepositWithdrawal,
		/// <summary>
		/// 입출고
		/// </summary>
		[EnumMember(Value = "2")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		IncomingOutgoing,
		/// <summary>
		/// 매매
		/// </summary>
		[EnumMember(Value = "3")]
		Transaction,
		/// <summary>
		/// 매수
		/// </summary>
		[EnumMember(Value = "4")]
		Buy,
		/// <summary>
		/// 매도
		/// </summary>
		[EnumMember(Value = "5")]
		Sell,
		/// <summary>
		/// 입금
		/// </summary>
		[EnumMember(Value = "6")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		Deposit,
		/// <summary>
		/// 출금
		/// </summary>
		[EnumMember(Value = "7")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		Withdrawal,
		/// <summary>
		/// 배당금입금
		/// </summary>
		[EnumMember(Value = "8")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		DividendDeposit,
		/// <summary>
		/// 환전
		/// </summary>
		[EnumMember(Value = "F")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		ForexExchange,
		/// <summary>
		/// 입출금+환전(매체전용)
		/// </summary>
		[EnumMember(Value = "M")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		InOutAndForex,
		/// <summary>
		/// 환전매수
		/// </summary>
		[EnumMember(Value = "G")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		ForexBuy,
		/// <summary>
		/// 환전매도
		/// </summary>
		[EnumMember(Value = "H")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		ForexSell,
		/// <summary>
		/// 환전정산입금
		/// </summary>
		[EnumMember(Value = "I")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		ForexSettlementIn,
		/// <summary>
		/// 환전정산출금
		/// </summary>
		[EnumMember(Value = "J")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		ForexSettlementOut,
		/// <summary>
		/// 환전+환전정산입출금
		/// </summary>
		[EnumMember(Value = "K")]
		[Obsolete("키움 API 명세에서 제거된 구분값입니다. All(0), Transaction(3), Buy(4), Sell(5)만 사용할 수 있습니다.")]
		ForexAndForexSettlement
	}
}
