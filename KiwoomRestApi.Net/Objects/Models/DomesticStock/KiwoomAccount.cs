using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.DomesticStock.Account;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.DomesticStock
{
	public record KiwoomAccountGetDailyBalanceProfitRates
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 총 매입가
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총 평가금액
		/// </summary>
		[JsonProperty("tot_evlt_amt")]
		public decimal? TotalEvaluationAmount;
		/// <summary>
		/// 총 평가손익
		/// </summary>
		[JsonProperty("tot_evltv_prft")]
		public KiwoomDecimal? TotalEvaluationProfitLoss;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("tot_prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("dbst_bal")]
		public decimal? Deposit;
		/// <summary>
		/// 추정자산
		/// </summary>
		[JsonProperty("day_stk_asst")]
		public decimal? EstimatedAsset;
		/// <summary>
		/// 현금비중
		/// </summary>
		[JsonProperty("buy_wght")]
		public decimal? CashWeight;
		/// <summary>
		/// 일별잔고수익률
		/// </summary>
		[JsonProperty("day_bal_rt")]
		public IEnumerable<KiwoomAccountGetDailyBalanceProfitRateItem>? DailyBalanceProfitRates;
	}
	public record KiwoomAccountGetDailyBalanceProfitRateItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 보유 수량
		/// </summary>
		[JsonProperty("rmnd_qty")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 매입 단가
		/// </summary>
		[JsonProperty("buy_uv")]
		public decimal? BuyPrice;
		/// <summary>
		/// 매수비중
		/// </summary>
		[JsonProperty("buy_wght")]
		public decimal? BuyWeight;
		/// <summary>
		/// 평가손익
		/// </summary>
		[JsonProperty("evltv_prft")]
		public KiwoomDecimal? EvaluationProfitLoss;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 평가비중
		/// </summary>
		[JsonProperty("evlt_wght")]
		public decimal? EvaluationWeight;
	}

	public record KiwoomAccountGetDailyStockRealizedProfitLosses
	{
		/// <summary>
		/// 일자별종목별실현손익
		/// </summary>
		[JsonProperty("dt_stk_div_rlzt_pl")]
		public IEnumerable<KiwoomAccountGetDailyStockRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetDailyStockRealizedProfitLossItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		/// <summary>
		/// 매입단가
		/// </summary>
		[JsonProperty("buy_uv")]
		public decimal? BuyPrice;
		/// <summary>
		/// 당일매도손익
		/// </summary>
		[JsonProperty("tdy_sel_pl")]
		public KiwoomDecimal? TodaySellProfitLoss;
		/// <summary>
		/// 손익율
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
		/// <summary>
		/// 인출가능금액
		/// </summary>
		[JsonProperty("wthd_alowa")]
		public decimal? WithdrawableAmount;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
		/// <summary>
		/// 종목코드1
		/// </summary>
		[JsonProperty("stk_cd_1")]
		public string? StockCode1;
		/// <summary>
		/// 당일매도손익1
		/// </summary>
		[JsonProperty("tdy_sel_pl_1")]
		public KiwoomDecimal? TodaySellProfitLoss1;
	}

	public record KiwoomAccountGetDailyStockRealizedProfitLossPeriods
	{
		/// <summary>
		/// 일자별종목별실현손익
		/// </summary>
		[JsonProperty("dt_stk_rlzt_pl")]
		public IEnumerable<KiwoomAccountGetDailyStockRealizedProfitLossPeriodItem>? Items;
	}
	public record KiwoomAccountGetDailyStockRealizedProfitLossPeriodItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 당일hts매도수수료
		/// </summary>
		[JsonProperty("tdy_htssel_cmsn")]
		public string? TodayHtsSellFee;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		/// <summary>
		/// 매입단가
		/// </summary>
		[JsonProperty("buy_uv")]
		public decimal? BuyPrice;
		/// <summary>
		/// 당일매도손익
		/// </summary>
		[JsonProperty("tdy_sel_pl")]
		public KiwoomDecimal? TodaySellProfitLoss;
		/// <summary>
		/// 손익율
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
		/// <summary>
		/// 인출가능금액
		/// </summary>
		[JsonProperty("wthd_alowa")]
		public decimal? WithdrawableAmount;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
	}

	public record KiwoomAccountGetDailyRealizedProfitLosses
	{
		/// <summary>
		/// 총매수금액
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총매도금액
		/// </summary>
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		/// <summary>
		/// 실현손익
		/// </summary>
		[JsonProperty("rlzt_pl")]
		public KiwoomDecimal? RealizedProfitLoss;
		/// <summary>
		/// 매매수수료
		/// </summary>
		[JsonProperty("trde_cmsn")]
		public decimal? TransactionFee;
		/// <summary>
		/// 매매세금
		/// </summary>
		[JsonProperty("trde_tax")]
		public decimal? TransactionTax;
		/// <summary>
		/// 일자별실현손익
		/// </summary>
		[JsonProperty("dt_rlzt_pl")]
		public IEnumerable<KiwoomAccountGetDailyRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetDailyRealizedProfitLossItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 당일매도손익
		/// </summary>
		[JsonProperty("tdy_sel_pl")]
		public KiwoomDecimal? TodaySellProfitLoss;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
	}

	public record KiwoomAccountGetUnfilledOrders
	{
		/// <summary>
		/// 미체결
		/// </summary>
		[JsonProperty("oso")]
		public IEnumerable<KiwoomAccountGetUnfilledOrderItem>? Items;
	}
	public record KiwoomAccountGetUnfilledOrderItem
	{
		/// <summary>
		/// 계좌번호
		/// </summary>
		[JsonProperty("acnt_no")]
		public string? AccountId;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 관리사번
		/// </summary>
		[JsonProperty("mang_empno")]
		public string? ManagerEmployeeId;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 업무구분
		/// </summary>
		[JsonProperty("tsk_tp")]
		public string? TaskType;
		/// <summary>
		/// 주문상태
		/// </summary>
		[JsonProperty("ord_stt")]
		public string? OrderStatus;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문가격
		/// </summary>
		[JsonProperty("ord_pric")]
		public decimal? OrderPrice;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[JsonProperty("oso_qty")]
		public decimal? UnfilledQuantity;
		/// <summary>
		/// 체결누계금액
		/// </summary>
		[JsonProperty("cntr_tot_amt")]
		public decimal? TradeTotalAmount;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 주문구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public KiwoomString? OrderTypeName;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TradeType;
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 체결번호
		/// </summary>
		[JsonProperty("cntr_no")]
		public string? TradeId;
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellQuote;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyQuote;
		/// <summary>
		/// 단위체결가
		/// </summary>
		[JsonProperty("unit_cntr_pric")]
		public decimal? UnitTradePrice;
		/// <summary>
		/// 단위체결량
		/// </summary>
		[JsonProperty("unit_cntr_qty")]
		public decimal? UnitTradeQuantity;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public string? RetailInvestor;
		/// <summary>
		/// 거래소구분 - 0 : 통합, 1 : KRX, 2 : NXT
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomAccountStockExchangeType? StockExchangeType;
		/// <summary>
		/// 거래소구분텍스트 - 통합,KRX,NXT
		/// </summary>
		[JsonProperty("stex_tp_txt")]
		public string? StockExchangeTypeText;
		/// <summary>
		/// SOR 여부값 - Y,N
		/// </summary>
		[JsonProperty("sor_yn")]
		[JsonConverter(typeof(KiwoomBoolConverter))]
		public bool? SorIndicator;
		/// <summary>
		/// 스톱가 - 스톱지정가주문 스톱가
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
	}

	public record KiwoomAccountGetFilledOrders
	{
		/// <summary>
		/// 체결
		/// </summary>
		[JsonProperty("cntr")]
		public IEnumerable<KiwoomAccountGetFilledOrderItem>? Items;
	}
	public record KiwoomAccountGetFilledOrderItem
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public KiwoomString? OrderTypeName;
		/// <summary>
		/// 주문가격
		/// </summary>
		[JsonProperty("ord_pric")]
		public decimal? OrderPrice;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[JsonProperty("oso_qty")]
		public decimal? UnfilledQuantity;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
		/// <summary>
		/// 주문상태
		/// </summary>
		[JsonProperty("ord_stt")]
		public string? OrderStatus;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TradeType;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 거래소구분 - 0 : 통합, 1 : KRX, 2 : NXT
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomAccountStockExchangeType? StockExchangeType;
		/// <summary>
		/// 거래소구분텍스트 - 통합,KRX,NXT
		/// </summary>
		[JsonProperty("stex_tp_txt")]
		public string? StockExchangeTypeText;
		/// <summary>
		/// SOR 여부값 - Y,N
		/// </summary>
		[JsonProperty("sor_yn")]
		[JsonConverter(typeof(KiwoomBoolConverter))]
		public bool? SorIndicator;
		/// <summary>
		/// 스톱가 - 스톱지정가주문 스톱가
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
	}

	public record KiwoomAccountGetTodayRealizedProfitLoss
	{
		/// <summary>
		/// 당일실현손익
		/// </summary>
		[JsonProperty("tdy_rlzt_pl")]
		public KiwoomDecimal? TodayRealizedProfitLoss;
		/// <summary>
		/// 당일실현손익상세
		/// </summary>
		[JsonProperty("tdy_rlzt_pl_dtl")]
		public IEnumerable<KiwoomAccountGetTodayRealizedProfitLossItem>? Items;
	}
	public record KiwoomAccountGetTodayRealizedProfitLossItem
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 매입단가
		/// </summary>
		[JsonProperty("buy_uv")]
		public decimal? BuyPrice;
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public decimal? TradePrice;
		/// <summary>
		/// 당일매도손익
		/// </summary>
		[JsonProperty("tdy_sel_pl")]
		public KiwoomDecimal? TodaySellProfitLoss;
		/// <summary>
		/// 손익율
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
	}

	public record KiwoomAccountGetProfitRates
	{
		/// <summary>
		/// 계좌수익률
		/// </summary>
		[JsonProperty("acnt_prft_rt")]
		public IEnumerable<KiwoomAccountGetProfitRateItem>? Items;
	}
	public record KiwoomAccountGetProfitRateItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 매입가
		/// </summary>
		[JsonProperty("pur_pric")]
		public decimal? BuyPrice;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("pur_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("rmnd_qty")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 당일매도손익
		/// </summary>
		[JsonProperty("tdy_sel_pl")]
		public KiwoomDecimal? TodaySellProfitLoss;
		/// <summary>
		/// 당일매매수수료
		/// </summary>
		[JsonProperty("tdy_trde_cmsn")]
		public decimal? TodayTransactionFee;
		/// <summary>
		/// 당일매매세금
		/// </summary>
		[JsonProperty("tdy_trde_tax")]
		public decimal? TodayTransactionTax;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 결제잔고
		/// </summary>
		[JsonProperty("setl_remn")]
		public decimal? SettlementBalance;
		/// <summary>
		/// 청산가능수량
		/// </summary>
		[JsonProperty("clrn_alow_qty")]
		public decimal? LiquidatableQuantity;
		/// <summary>
		/// 신용금액
		/// </summary>
		[JsonProperty("crd_amt")]
		public decimal? CreditAmount;
		/// <summary>
		/// 신용이자
		/// </summary>
		[JsonProperty("crd_int")]
		public decimal? CreditInterest;
		/// <summary>
		/// 만기일
		/// </summary>
		[JsonProperty("expr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpireDate;
	}

	public record KiwoomAccountGetUnfilledSplitOrders
	{
		/// <summary>
		/// 미체결분할주문리스트
		/// </summary>
		[JsonProperty("osop")]
		public IEnumerable<KiwoomAccountGetUnfilledSplitOrderItem>? Items;
	}
	public record KiwoomAccountGetUnfilledSplitOrderItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문가격
		/// </summary>
		[JsonProperty("ord_pric")]
		public decimal? OrderPrice;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[JsonProperty("osop_qty")]
		public decimal? UnfilledQuantity;
		/// <summary>
		/// 주문구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public KiwoomString? OrderTypeName;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TransactionType;
		/// <summary>
		/// 매도/수 구분
		/// </summary>
		[JsonProperty("sell_tp")]
		public string? OrderSide;
		/// <summary>
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 주문상태
		/// </summary>
		[JsonProperty("ord_stt")]
		public string? OrderStatus;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래소구분 - 0 : 통합, 1 : KRX, 2 : NXT
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomAccountStockExchangeType? StockExchangeType;
		/// <summary>
		/// 거래소구분텍스트 - 통합,KRX,NXT
		/// </summary>
		[JsonProperty("stex_tp_txt")]
		public string? StockExchangeTypeText;
	}

	public record KiwoomAccountGetTodayTransactionJournals
	{
		/// <summary>
		/// 총매도금액
		/// </summary>
		[JsonProperty("tot_sell_amt")]
		public decimal? TotalSellAmount;
		/// <summary>
		/// 총매수금액
		/// </summary>
		[JsonProperty("tot_buy_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총수수료_세금
		/// </summary>
		[JsonProperty("tot_cmsn_tax")]
		public decimal? TotalFeeTax;
		/// <summary>
		/// 총정산금액
		/// </summary>
		[JsonProperty("tot_exct_amt")]
		public KiwoomDecimal? TotalSettlementAmount;
		/// <summary>
		/// 총손익금액
		/// </summary>
		[JsonProperty("tot_pl_amt")]
		public KiwoomDecimal? TotalProfitLossAmount;
		/// <summary>
		/// 총수익률
		/// </summary>
		[JsonProperty("tot_prft_rt")]
		public KiwoomDecimal? TotalProfitRate;
		/// <summary>
		/// 당일매매일지
		/// </summary>
		[JsonProperty("tdy_trde_diary")]
		public IEnumerable<KiwoomAccountGetTodayTransactionJournalItem>? Items;
	}
	public record KiwoomAccountGetTodayTransactionJournalItem
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 매수평균가
		/// </summary>
		[JsonProperty("buy_avg_pric")]
		public decimal? BuyAveragePrice;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매도평균가
		/// </summary>
		[JsonProperty("sel_avg_pric")]
		public decimal? SellAveragePrice;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 수수료_제세금
		/// </summary>
		[JsonProperty("cmsn_alm_tax")]
		public decimal? FeeAndTax;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public KiwoomDecimal? ProfitLossAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
	}

	public record KiwoomAccountGetDeposits
	{
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? Deposit;
		/// <summary>
		/// 주식증거금현금
		/// </summary>
		[JsonProperty("profa_ch")]
		public decimal? StockMarginCash;
		/// <summary>
		/// 수익증권증거금현금
		/// </summary>
		[JsonProperty("bncr_profa_ch")]
		public decimal? FundMarginCash;
		/// <summary>
		/// 익일수익증권매도정산대금
		/// </summary>
		[JsonProperty("nxdy_bncr_sell_exct")]
		public decimal? NextDayFundSellSettlement;
		/// <summary>
		/// 해외주식원화대용설정금
		/// </summary>
		[JsonProperty("fc_stk_krw_repl_set_amt")]
		public decimal? ForeignStockKrwDeposit;
		/// <summary>
		/// 신용보증금현금
		/// </summary>
		[JsonProperty("crd_grnta_ch")]
		public decimal? CreditDepositCash;
		/// <summary>
		/// 신용담보금현금
		/// </summary>
		[JsonProperty("crd_grnt_ch")]
		public decimal? CreditCollateralCash;
		/// <summary>
		/// 추가담보금현금
		/// </summary>
		[JsonProperty("add_grnt_ch")]
		public decimal? AdditionalCollateralCash;
		/// <summary>
		/// 기타증거금
		/// </summary>
		[JsonProperty("etc_profa")]
		public decimal? OtherMargin;
		/// <summary>
		/// 미수확보금
		/// </summary>
		[JsonProperty("uncl_stk_amt")]
		public decimal? UnsettledSecured;
		/// <summary>
		/// 공매도대금
		/// </summary>
		[JsonProperty("shrts_prica")]
		public decimal? ShortSale;
		/// <summary>
		/// 신용설정평가금
		/// </summary>
		[JsonProperty("crd_set_grnta")]
		public decimal? CreditValuation;
		/// <summary>
		/// 수표입금액
		/// </summary>
		[JsonProperty("chck_ina_amt")]
		public decimal? CheckDeposit;
		/// <summary>
		/// 기타수표입금액
		/// </summary>
		[JsonProperty("etc_chck_ina_amt")]
		public decimal? OtherCheckDeposit;
		/// <summary>
		/// 신용담보재사용
		/// </summary>
		[JsonProperty("crd_grnt_ruse")]
		public decimal? CreditCollateralReuse;
		/// <summary>
		/// 코넥스기본예탁금
		/// </summary>
		[JsonProperty("knx_asset_evltv")]
		public decimal? KonexBaseDeposit;
		/// <summary>
		/// ELW예탁평가금
		/// </summary>
		[JsonProperty("elwdpst_evlta")]
		public decimal? ElwValuation;
		/// <summary>
		/// 신용대주권리예정금액
		/// </summary>
		[JsonProperty("crd_ls_rght_frcs_amt")]
		public decimal? CreditLoanExpectedRights;
		/// <summary>
		/// 생계형가입금액
		/// </summary>
		[JsonProperty("lvlh_join_amt")]
		public decimal? LivingTypeSubscription;
		/// <summary>
		/// 생계형입금가능금액
		/// </summary>
		[JsonProperty("lvlh_trns_alowa")]
		public decimal? LivingTypeAvailableDeposit;
		/// <summary>
		/// 대용금평가금액(합계)
		/// </summary>
		[JsonProperty("repl_amt")]
		public decimal? CollateralCashTotalValuation;
		/// <summary>
		/// 잔고대용평가금액
		/// </summary>
		[JsonProperty("remn_repl_evlta")]
		public decimal? BalanceCollateralValuation;
		/// <summary>
		/// 위탁대용잔고평가금액
		/// </summary>
		[JsonProperty("trst_remn_repl_evlta")]
		public decimal? ConsignedCollateralBalanceValuation;
		/// <summary>
		/// 수익증권대용평가금액
		/// </summary>
		[JsonProperty("bncr_remn_repl_evlta")]
		public decimal? FundCollateralValuation;
		/// <summary>
		/// 위탁증거금대용
		/// </summary>
		[JsonProperty("profa_repl")]
		public decimal? ConsignedMarginSubstitute;
		/// <summary>
		/// 신용보증금대용
		/// </summary>
		[JsonProperty("crd_grnta_repl")]
		public decimal? CreditDepositSubstitute;
		/// <summary>
		/// 신용담보금대용
		/// </summary>
		[JsonProperty("crd_grnt_repl")]
		public decimal? CreditCollateralSubstitute;
		/// <summary>
		/// 추가담보금대용
		/// </summary>
		[JsonProperty("add_grnt_repl")]
		public decimal? AdditionalCollateralSubstitute;
		/// <summary>
		/// 권리대용금
		/// </summary>
		[JsonProperty("rght_repl_amt")]
		public decimal? RightsSubstituteFund;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[JsonProperty("pymn_alow_amt")]
		public decimal? Withdrawable;
		/// <summary>
		/// 랩출금가능금액
		/// </summary>
		[JsonProperty("wrap_pymn_alow_amt")]
		public decimal? WrapWithdrawable;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[JsonProperty("ord_alow_amt")]
		public decimal? Orderable;
		/// <summary>
		/// 수익증권매수가능금액
		/// </summary>
		[JsonProperty("bncr_buy_alowa")]
		public decimal? FundBuyable;
		/// <summary>
		/// 20%종목주문가능금액
		/// </summary>
		[JsonProperty("20stk_ord_alow_amt")]
		public decimal? Orderable20Percent;
		/// <summary>
		/// 30%종목주문가능금액
		/// </summary>
		[JsonProperty("30stk_ord_alow_amt")]
		public decimal? Orderable30Percent;
		/// <summary>
		/// 40%종목주문가능금액
		/// </summary>
		[JsonProperty("40stk_ord_alow_amt")]
		public decimal? Orderable40Percent;
		/// <summary>
		/// 100%종목주문가능금액
		/// </summary>
		[JsonProperty("100stk_ord_alow_amt")]
		public decimal? Orderable100Percent;
		/// <summary>
		/// 현금미수금
		/// </summary>
		[JsonProperty("ch_uncla")]
		public decimal? CashUnsettled;
		/// <summary>
		/// 현금미수연체료
		/// </summary>
		[JsonProperty("ch_uncla_dlfe")]
		public decimal? CashReceivableLateFee;
		/// <summary>
		/// 현금미수금합계
		/// </summary>
		[JsonProperty("ch_uncla_tot")]
		public decimal? CashUnsettledTotal;
		/// <summary>
		/// 신용이자미납
		/// </summary>
		[JsonProperty("crd_int_npay")]
		public decimal? UnpaidCreditInterest;
		/// <summary>
		/// 신용이자미납연체료
		/// </summary>
		[JsonProperty("int_npay_amt_dlfe")]
		public decimal? UnpaidCreditInterestLateFee;
		/// <summary>
		/// 신용이자미납합계
		/// </summary>
		[JsonProperty("int_npay_amt_tot")]
		public decimal? TotalUnpaidCreditInterest;
		/// <summary>
		/// 기타대여금
		/// </summary>
		[JsonProperty("etc_loana")]
		public decimal? OtherLoan;
		/// <summary>
		/// 기타대여금연체료
		/// </summary>
		[JsonProperty("etc_loana_dlfe")]
		public decimal? OtherLoanLateFee;
		/// <summary>
		/// 기타대여금합계
		/// </summary>
		[JsonProperty("etc_loan_tot")]
		public decimal? TotalOtherLoan;
		/// <summary>
		/// 미상환융자금
		/// </summary>
		[JsonProperty("nrpy_loan")]
		public decimal? OutstandingCreditLoan;
		/// <summary>
		/// 융자금합계
		/// </summary>
		[JsonProperty("loan_sum")]
		public decimal? TotalCreditLoan;
		/// <summary>
		/// 대주금합계
		/// </summary>
		[JsonProperty("ls_sum")]
		public decimal? TotalShortSellingLoan;
		/// <summary>
		/// 신용담보비율
		/// </summary>
		[JsonProperty("crd_grnt_rt")]
		public decimal? CreditCollateralRate;
		/// <summary>
		/// 중도이용료
		/// </summary>
		[JsonProperty("mdstrm_usfe")]
		public decimal? EarlyTerminationFee;
		/// <summary>
		/// 최소주문가능금액
		/// </summary>
		[JsonProperty("min_ord_alow_yn")]
		public decimal? MinimumOrderable;
		/// <summary>
		/// 대출총평가금액
		/// </summary>
		[JsonProperty("loan_remn_evlt_amt")]
		public decimal? TotalLoanValuation;
		/// <summary>
		/// 예탁담보대출잔고
		/// </summary>
		[JsonProperty("dpst_grntl_remn")]
		public decimal? CollateralLoanBalance;
		/// <summary>
		/// 매도담보대출잔고
		/// </summary>
		[JsonProperty("sell_grntl_remn")]
		public decimal? ShortSellingLoanBalance;
		/// <summary>
		/// d+1추정예수금
		/// </summary>
		[JsonProperty("d1_entra")]
		public decimal? EstimatedDepositD1;
		/// <summary>
		/// d+1매도매수정산금
		/// </summary>
		[JsonProperty("d1_slby_exct_amt")]
		public KiwoomDecimal? SettlementAmountD1;
		/// <summary>
		/// d+1매수정산금
		/// </summary>
		[JsonProperty("d1_buy_exct_amt")]
		public decimal? BuySettlementD1;
		/// <summary>
		/// d+1미수변제소요금
		/// </summary>
		[JsonProperty("d1_out_rep_mor")]
		public decimal? RequiredRepaymentD1;
		/// <summary>
		/// d+1매도정산금
		/// </summary>
		[JsonProperty("d1_sel_exct_amt")]
		public decimal? SellSettlementD1;
		/// <summary>
		/// d+1출금가능금액
		/// </summary>
		[JsonProperty("d1_pymn_alow_amt")]
		public decimal? WithdrawableAmountD1;
		/// <summary>
		/// d+2추정예수금
		/// </summary>
		[JsonProperty("d2_entra")]
		public decimal? EstimatedDepositD2;
		/// <summary>
		/// d+2매도매수정산금
		/// </summary>
		[JsonProperty("d2_slby_exct_amt")]
		public KiwoomDecimal? SettlementAmountD2;
		/// <summary>
		/// d+2매수정산금
		/// </summary>
		[JsonProperty("d2_buy_exct_amt")]
		public decimal? BuySettlementD2;
		/// <summary>
		/// d+2미수변제소요금
		/// </summary>
		[JsonProperty("d2_out_rep_mor")]
		public decimal? RequiredRepaymentD2;
		/// <summary>
		/// d+2매도정산금
		/// </summary>
		[JsonProperty("d2_sel_exct_amt")]
		public decimal? SellSettlementD2;
		/// <summary>
		/// d+2출금가능금액
		/// </summary>
		[JsonProperty("d2_pymn_alow_amt")]
		public decimal? WithdrawableAmountD2;
		/// <summary>
		/// 50%종목주문가능금액
		/// </summary>
		[JsonProperty("50stk_ord_alow_amt")]
		public decimal? StockOrderAmount50Percent;
		/// <summary>
		/// 60%종목주문가능금액
		/// </summary>
		[JsonProperty("60stk_ord_alow_amt")]
		public decimal? StockOrderAmount60Percent;
		/// <summary>
		/// 종목별예수금
		/// </summary>
		[JsonProperty("stk_entr_prst")]
		public IEnumerable<KiwoomAccountGetDepositItem>? Items;
	}
	public record KiwoomAccountGetDepositItem
	{
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_cd")]
		public string? CurrencyCode;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fx_entr")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 원화대용평가금
		/// </summary>
		[JsonProperty("fc_krw_repl_evlta")]
		public decimal? KrwCollateralValuation;
		/// <summary>
		/// 해외주식증거금
		/// </summary>
		[JsonProperty("fc_trst_profa")]
		public decimal? ForeignStockMargin;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[JsonProperty("pymn_alow_amt")]
		public decimal? Withdrawable;
		/// <summary>
		/// 출금가능금액(예수금)
		/// </summary>
		[JsonProperty("pymn_alow_amt_entr")]
		public decimal? WithdrawableDeposit;
		/// <summary>
		/// 주문가능금액(예수금)
		/// </summary>
		[JsonProperty("ord_alow_amt_entr")]
		public decimal? OrderableDeposit;
		/// <summary>
		/// 외화미수(합계)
		/// </summary>
		[JsonProperty("fc_uncla")]
		public decimal? ForeignCurrencyOutstandingTotal;
		/// <summary>
		/// 외화현금미수금
		/// </summary>
		[JsonProperty("fc_ch_uncla")]
		public decimal? ForeignCashReceivable;
		/// <summary>
		/// 연체료
		/// </summary>
		[JsonProperty("dly_amt")]
		public decimal? OverdueFee;
		/// <summary>
		/// d+1외화예수금
		/// </summary>
		[JsonProperty("d1_fx_entr")]
		public decimal? ForeignCurrencyDepositD1;
		/// <summary>
		/// d+2외화예수금
		/// </summary>
		[JsonProperty("d2_fx_entr")]
		public decimal? ForeignCurrencyDepositD2;
		/// <summary>
		/// d+3외화예수금
		/// </summary>
		[JsonProperty("d3_fx_entr")]
		public decimal? ForeignCurrencyDepositD3;
		/// <summary>
		/// d+4외화예수금
		/// </summary>
		[JsonProperty("d4_fx_entr")]
		public decimal? ForeignCurrencyDepositD4;
	}

	public record KiwoomAccountGetDailyEstimatedDepositAssets
	{
		/// <summary>
		/// 일별추정예탁자산현황
		/// </summary>
		[JsonProperty("daly_prsm_dpst_aset_amt_prst")]
		public IEnumerable<KiwoomAccountGetDailyEstimatedDepositAssetItem>? Items;
	}
	public record KiwoomAccountGetDailyEstimatedDepositAssetItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? Deposit;
		/// <summary>
		/// 담보대출금
		/// </summary>
		[JsonProperty("grnt_use_amt")]
		public decimal? CollateralLoan;
		/// <summary>
		/// 신용융자금
		/// </summary>
		[JsonProperty("crd_loan")]
		public decimal? CreditLoan;
		/// <summary>
		/// 대주담보금
		/// </summary>
		[JsonProperty("ls_grnt")]
		public decimal? ShortSellingCollateral;
		/// <summary>
		/// 대용금
		/// </summary>
		[JsonProperty("repl_amt")]
		public decimal? Substitute;
		/// <summary>
		/// 추정예탁자산
		/// </summary>
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal? EstimatedDepositAsset;
		/// <summary>
		/// 추정예탁자산수익증권제외
		/// </summary>
		[JsonProperty("prsm_dpst_aset_amt_bncr_skip")]
		public decimal? EstimatedDepositAssetExcludeFund;
	}

	public record KiwoomAccountGetEstimatedDepositAsset
	{
		/// <summary>
		/// 추정예탁자산
		/// </summary>
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal? EstimatedDepositAsset;
	}

	public record KiwoomAccountGetEvaluations
	{
		/// <summary>
		/// 계좌명
		/// </summary>
		[JsonProperty("acnt_nm")]
		public string? AccountName;
		/// <summary>
		/// 지점명
		/// </summary>
		[JsonProperty("brch_nm")]
		public string? BranchName;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? DepositAmount;
		/// <summary>
		/// D+2추정예수금
		/// </summary>
		[JsonProperty("d2_entra")]
		public decimal? EstimatedDepositD2;
		/// <summary>
		/// 유가잔고평가액
		/// </summary>
		[JsonProperty("tot_est_amt")]
		public decimal? SecuritiesBalanceEvaluation;
		/// <summary>
		/// 예탁자산평가액
		/// </summary>
		[JsonProperty("aset_evlt_amt")]
		public decimal? DepositedAssetsEvaluation;
		/// <summary>
		/// 총매입금액
		/// </summary>
		[JsonProperty("tot_pur_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 추정예탁자산
		/// </summary>
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal? EstimatedDepositAsset;
		/// <summary>
		/// 매도담보대출금
		/// </summary>
		[JsonProperty("tot_grnt_sella")]
		public decimal? SellCollateralLoanAmount;
		/// <summary>
		/// 당일투자원금
		/// </summary>
		[JsonProperty("tdy_lspft_amt")]
		public decimal? TodayInvestmentPrincipal;
		/// <summary>
		/// 당월투자원금
		/// </summary>
		[JsonProperty("invt_bsamt")]
		public decimal? CurrentMonthInvestmentPrincipal;
		/// <summary>
		/// 누적투자원금
		/// </summary>
		[JsonProperty("lspft_amt")]
		public decimal? CumulativeInvestmentPrincipal;
		/// <summary>
		/// 당일투자손익
		/// </summary>
		[JsonProperty("tdy_lspft")]
		public KiwoomDecimal? TodayInvestmentProfitLoss;
		/// <summary>
		/// 당월투자손익
		/// </summary>
		[JsonProperty("lspft2")]
		public KiwoomDecimal? CurrentMonthInvestmentProfitLoss;
		/// <summary>
		/// 누적투자손익
		/// </summary>
		[JsonProperty("lspft")]
		public KiwoomDecimal? CumulativeInvestmentProfitLoss;
		/// <summary>
		/// 당일손익율
		/// </summary>
		[JsonProperty("tdy_lspft_rt")]
		public KiwoomDecimal? TodayProfitLossRate;
		/// <summary>
		/// 당월손익율
		/// </summary>
		[JsonProperty("lspft_ratio")]
		public KiwoomDecimal? CurrentMonthProfitLossRate;
		/// <summary>
		/// 누적손익율
		/// </summary>
		[JsonProperty("lspft_rt")]
		public KiwoomDecimal? CumulativeProfitLossRate;
		/// <summary>
		/// 종목별계좌평가현황
		/// </summary>
		[JsonProperty("stk_acnt_evlt_prst")]
		public IEnumerable<KiwoomAccountGetEvaluationItem>? Items;
	}
	public record KiwoomAccountGetEvaluationItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("rmnd_qty")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 평균단가
		/// </summary>
		[JsonProperty("avg_prc")]
		public decimal? AveragePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("pl_amt")]
		public KiwoomDecimal? ProfitLossAmount;
		/// <summary>
		/// 손익율
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("pur_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 결제잔고
		/// </summary>
		[JsonProperty("setl_remn")]
		public decimal? SettlementBalance;
		/// <summary>
		/// 전일매수수량
		/// </summary>
		[JsonProperty("pred_buyq")]
		public decimal? PreviousDayBuyQuantity;
		/// <summary>
		/// 전일매도수량
		/// </summary>
		[JsonProperty("pred_sellq")]
		public decimal? PreviousDaySellQuantity;
		/// <summary>
		/// 금일매수수량
		/// </summary>
		[JsonProperty("tdy_buyq")]
		public decimal? TodayBuyQuantity;
		/// <summary>
		/// 금일매도수량
		/// </summary>
		[JsonProperty("tdy_sellq")]
		public decimal? TodaySellQuantity;
	}

	public record KiwoomAccountGetTradeBalances
	{
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? DepositAmount;
		/// <summary>
		/// 예수금D+1
		/// </summary>
		[JsonProperty("entr_d1")]
		public decimal? DepositAmountD1;
		/// <summary>
		/// 예수금D+2
		/// </summary>
		[JsonProperty("entr_d2")]
		public decimal? DepositAmountD2;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[JsonProperty("pymn_alow_amt")]
		public decimal? WithdrawableAmount;
		/// <summary>
		/// 미수확보금
		/// </summary>
		[JsonProperty("uncl_stk_amt")]
		public decimal? SecuredReceivable;
		/// <summary>
		/// 대용금
		/// </summary>
		[JsonProperty("repl_amt")]
		public decimal? SubstituteAmount;
		/// <summary>
		/// 권리대용금
		/// </summary>
		[JsonProperty("rght_repl_amt")]
		public decimal? RightsSubstituteAmount;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[JsonProperty("ord_alowa")]
		public decimal? OrderableCash;
		/// <summary>
		/// 현금미수금
		/// </summary>
		[JsonProperty("ch_uncla")]
		public decimal? UnsettledCash;
		/// <summary>
		/// 신용이자미납금
		/// </summary>
		[JsonProperty("crd_int_npay_gold")]
		public decimal? UnpaidCreditInterest;
		/// <summary>
		/// 기타대여금
		/// </summary>
		[JsonProperty("etc_loana")]
		public decimal? OtherLoanAmount;
		/// <summary>
		/// 미상환융자금
		/// </summary>
		[JsonProperty("nrpy_loan")]
		public decimal? UnpaidCreditLoanAmount;
		/// <summary>
		/// 증거금현금
		/// </summary>
		[JsonProperty("profa_ch")]
		public decimal? MarginCash;
		/// <summary>
		/// 증거금대용
		/// </summary>
		[JsonProperty("repl_profa")]
		public decimal? MarginSubstitute;
		/// <summary>
		/// 주식매수총액
		/// </summary>
		[JsonProperty("stk_buy_tot_amt")]
		public decimal? TotalStockBuyAmount;
		/// <summary>
		/// 평가금액합계
		/// </summary>
		[JsonProperty("evlt_amt_tot")]
		public decimal? TotalEvaluationAmount;
		/// <summary>
		/// 총손익합계
		/// </summary>
		[JsonProperty("tot_pl_tot")]
		public KiwoomDecimal? TotalProfitLossAmount;
		/// <summary>
		/// 총손익률
		/// </summary>
		[JsonProperty("tot_pl_rt")]
		public KiwoomDecimal? TotalProfitLossRate;
		/// <summary>
		/// 총재매수가능금액
		/// </summary>
		[JsonProperty("tot_re_buy_alowa")]
		public decimal? TotalRebuyableAmount;
		/// <summary>
		/// 20%주문가능금액
		/// </summary>
		[JsonProperty("20ord_alow_amt")]
		public decimal? OrderableAmount20Percent;
		/// <summary>
		/// 30%주문가능금액
		/// </summary>
		[JsonProperty("30ord_alow_amt")]
		public decimal? OrderableAmount30Percent;
		/// <summary>
		/// 40%주문가능금액
		/// </summary>
		[JsonProperty("40ord_alow_amt")]
		public decimal? OrderableAmount40Percent;
		/// <summary>
		/// 50%주문가능금액
		/// </summary>
		[JsonProperty("50ord_alow_amt")]
		public decimal? OrderableAmount50Percent;
		/// <summary>
		/// 60%주문가능금액
		/// </summary>
		[JsonProperty("60ord_alow_amt")]
		public decimal? OrderableAmount60Percent;
		/// <summary>
		/// 100%주문가능금액
		/// </summary>
		[JsonProperty("100ord_alow_amt")]
		public decimal? OrderableAmount100Percent;
		/// <summary>
		/// 신용융자합계
		/// </summary>
		[JsonProperty("crd_loan_tot")]
		public decimal? TotalCreditLoan;
		/// <summary>
		/// 신용융자대주합계
		/// </summary>
		[JsonProperty("crd_loan_ls_tot")]
		public decimal? TotalCreditLoanAndBorrowed;
		/// <summary>
		/// 신용담보비율
		/// </summary>
		[JsonProperty("crd_grnt_rt")]
		public decimal? CreditCollateralRate;
		/// <summary>
		/// 예탁담보대출금액
		/// </summary>
		[JsonProperty("dpst_grnt_use_amt_amt")]
		public decimal? CollateralizedDepositLoanAmount;
		/// <summary>
		/// 매도담보대출금액
		/// </summary>
		[JsonProperty("grnt_loan_amt")]
		public decimal? SellCollateralLoanAmount;
		/// <summary>
		/// 종목별체결잔고
		/// </summary>
		[JsonProperty("stk_cntr_remn")]
		public IEnumerable<KiwoomAccountGetTradeBalanceItem>? Items;
	}
	public record KiwoomAccountGetTradeBalanceItem
	{
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 만기일
		/// </summary>
		[JsonProperty("expr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpireDate;
		/// <summary>
		/// 종목번호
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 결제잔고
		/// </summary>
		[JsonProperty("setl_remn")]
		public decimal? SettlementBalance;
		/// <summary>
		/// 현재잔고
		/// </summary>
		[JsonProperty("cur_qty")]
		public decimal? CurrentBalance;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 매입단가
		/// </summary>
		[JsonProperty("buy_uv")]
		public decimal? BuyPrice;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("pur_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 평가손익
		/// </summary>
		[JsonProperty("evltv_prft")]
		public KiwoomDecimal? EvaluationProfitLoss;
		/// <summary>
		/// 손익률
		/// </summary>
		[JsonProperty("pl_rt")]
		public KiwoomDecimal? ProfitLossRate;
	}

	public record KiwoomAccountGetOrderTradeDetails
	{
		/// <summary>
		/// 계좌별주문체결내역상세
		/// </summary>
		[JsonProperty("acnt_ord_cntr_prps_dtl")]
		public IEnumerable<KiwoomAccountGetOrderTradeDetailItem>? Items;
	}
	public record KiwoomAccountGetOrderTradeDetailItem
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 종목번호
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TransactionType;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderPrice;
		/// <summary>
		/// 확인수량
		/// </summary>
		[JsonProperty("cnfm_qty")]
		public decimal? ConfirmedQuantity;
		/// <summary>
		/// 접수구분
		/// </summary>
		[JsonProperty("acpt_tp")]
		public string? SubmissionType;
		/// <summary>
		/// 반대여부
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservationType;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderTime;
		/// <summary>
		/// 원주문
		/// </summary>
		[JsonProperty("ori_ord")]
		public string? OriginalOrder;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public string? OrderTypeName;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradePrice;
		/// <summary>
		/// 주문잔량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? OrderRemainQuantity;
		/// <summary>
		/// 통신구분
		/// </summary>
		[JsonProperty("comm_ord_tp")]
		public string? CommunicationOrderType;
		/// <summary>
		/// 정정취소
		/// </summary>
		[JsonProperty("mdfy_cncl")]
		public string? ModifyCancelType;
		/// <summary>
		/// 확인시간
		/// </summary>
		[JsonProperty("cnfm_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ConfirmTime;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public KiwoomAccountDomesticStockExchangeType? DomesticStockExchangeType;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("cond_uv")]
		public decimal? StopPrice;
	}

	public record KiwoomAccountGetNextDaySettlements
	{
		/// <summary>
		/// 매매일자
		/// </summary>
		[JsonProperty("trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TransactionDate;
		/// <summary>
		/// 결제일자
		/// </summary>
		[JsonProperty("setl_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? SettlementDate;
		/// <summary>
		/// 매도정산합
		/// </summary>
		[JsonProperty("sell_amt_sum")]
		public decimal? TotalSellSettlement;
		/// <summary>
		/// 매수정산합
		/// </summary>
		[JsonProperty("buy_amt_sum")]
		public decimal? TotalBuySettlement;
		/// <summary>
		/// 계좌별익일결제예정내역배열
		/// </summary>
		[JsonProperty("acnt_nxdy_setl_frcs_prps_array")]
		public IEnumerable<KiwoomAccountGetNextDaySettlementItem>? Items;
	}
	public record KiwoomAccountGetNextDaySettlementItem
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[JsonProperty("seq")]
		public string? SequenceId;
		/// <summary>
		/// 종목번호
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 수량
		/// </summary>
		[JsonProperty("qty")]
		public decimal? Quantity;
		/// <summary>
		/// 약정금액
		/// </summary>
		[JsonProperty("engg_amt")]
		public decimal? ContractedAmount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Fee;
		/// <summary>
		/// 소득세
		/// </summary>
		[JsonProperty("incm_tax")]
		public decimal? IncomeTax;
		/// <summary>
		/// 농특세
		/// </summary>
		[JsonProperty("rstx")]
		public decimal? SpecialRuralTax;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 매도수구분
		/// </summary>
		[JsonProperty("sell_tp")]
		public string? OrderSide;
		/// <summary>
		/// 단가
		/// </summary>
		[JsonProperty("unp")]
		public KiwoomDecimal? Price;
		/// <summary>
		/// 정산금액
		/// </summary>
		[JsonProperty("exct_amt")]
		public decimal? SettlementAmount;
		/// <summary>
		/// 거래세
		/// </summary>
		[JsonProperty("trde_tax")]
		public decimal? TransactionTax;
		/// <summary>
		/// 주민세
		/// </summary>
		[JsonProperty("resi_tax")]
		public decimal? ResidentTax;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
	}

	public record KiwoomAccountGetOrderTrades
	{
		/// <summary>
		/// 매도약정금액
		/// </summary>
		[JsonProperty("sell_grntl_engg_amt")]
		public decimal? SellContractedAmount;
		/// <summary>
		/// 매수약정금액
		/// </summary>
		[JsonProperty("buy_engg_amt")]
		public decimal? BuyContractedAmount;
		/// <summary>
		/// 약정금액
		/// </summary>
		[JsonProperty("engg_amt")]
		public decimal? ContractedAmount;
		/// <summary>
		/// 계좌별주문체결현황배열
		/// </summary>
		[JsonProperty("acnt_ord_cntr_prst_array")]
		public IEnumerable<KiwoomAccountGetOrderTradeItem>? Items;
	}
	public record KiwoomAccountGetOrderTradeItem
	{
		/// <summary>
		/// 주식채권구분
		/// </summary>
		[JsonProperty("stk_bond_tp")]
		public string? StockBondType;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 종목번호
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TransactionType;
		/// <summary>
		/// 주문유형구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public string? OrderTypeName;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderPrice;
		/// <summary>
		/// 확인수량
		/// </summary>
		[JsonProperty("cnfm_qty")]
		public decimal? ConfirmedQuantity;
		/// <summary>
		/// 예약/반대
		/// </summary>
		[JsonProperty("rsrv_oppo")]
		public string? ReservationOpposite;
		/// <summary>
		/// 체결번호
		/// </summary>
		[JsonProperty("cntr_no")]
		public string? ContractId;
		/// <summary>
		/// 접수구분
		/// </summary>
		[JsonProperty("acpt_tp")]
		public string? SubmissionType;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 결제구분
		/// </summary>
		[JsonProperty("setl_tp")]
		public string? SettlementType;
		/// <summary>
		/// 신용거래구분
		/// </summary>
		[JsonProperty("crd_deal_tp")]
		public string? CreditTransactionType;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradePrice;
		/// <summary>
		/// 통신구분
		/// </summary>
		[JsonProperty("comm_ord_tp")]
		public string? CommunicationOrderType;
		/// <summary>
		/// 정정/취소구분
		/// </summary>
		[JsonProperty("mdfy_cncl_tp")]
		public string? ModifyCancelType;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public KiwoomAccountDomesticStockExchangeType? DomesticStockExchangeType;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("cond_uv")]
		public decimal? StopPrice;
	}

	public record KiwoomAccountGetAvailableWithdrawalAmounts
	{
		/// <summary>
		/// 증거금20%주문가능금액
		/// </summary>
		[JsonProperty("profa_20ord_alow_amt")]
		public decimal? MarginOrderableAmount20Percent;
		/// <summary>
		/// 증거금20%주문가능수량
		/// </summary>
		[JsonProperty("profa_20ord_alowq")]
		public decimal? MarginOrderableQuantity20Percent;
		/// <summary>
		/// 증거금30%주문가능금액
		/// </summary>
		[JsonProperty("profa_30ord_alow_amt")]
		public decimal? MarginOrderableAmount30Percent;
		/// <summary>
		/// 증거금30%주문가능수량
		/// </summary>
		[JsonProperty("profa_30ord_alowq")]
		public decimal? MarginOrderableQuantity30Percent;
		/// <summary>
		/// 증거금40%주문가능금액
		/// </summary>
		[JsonProperty("profa_40ord_alow_amt")]
		public decimal? MarginOrderableAmount40Percent;
		/// <summary>
		/// 증거금40%주문가능수량
		/// </summary>
		[JsonProperty("profa_40ord_alowq")]
		public decimal? MarginOrderableQuantity40Percent;
		/// <summary>
		/// 증거금50%주문가능금액
		/// </summary>
		[JsonProperty("profa_50ord_alow_amt")]
		public decimal? MarginOrderableAmount50Percent;
		/// <summary>
		/// 증거금50%주문가능수량
		/// </summary>
		[JsonProperty("profa_50ord_alowq")]
		public decimal? MarginOrderableQuantity50Percent;
		/// <summary>
		/// 증거금60%주문가능금액
		/// </summary>
		[JsonProperty("profa_60ord_alow_amt")]
		public decimal? MarginOrderableAmount60Percent;
		/// <summary>
		/// 증거금60%주문가능수량
		/// </summary>
		[JsonProperty("profa_60ord_alowq")]
		public decimal? MarginOrderableQuantity60Percent;
		/// <summary>
		/// 증거금감면60%주문가능금액
		/// </summary>
		[JsonProperty("profa_rdex_60ord_alow_amt")]
		public decimal? MarginReduced60OrderableAmount;
		/// <summary>
		/// 증거금감면60%주문가능수량
		/// </summary>
		[JsonProperty("profa_rdex_60ord_alowq")]
		public decimal? MarginReduced60OrderableQuantity;
		/// <summary>
		/// 증거금100%주문가능금액
		/// </summary>
		[JsonProperty("profa_100ord_alow_amt")]
		public decimal? MarginOrderableAmount100Percent;
		/// <summary>
		/// 증거금100%주문가능수량
		/// </summary>
		[JsonProperty("profa_100ord_alowq")]
		public decimal? MarginOrderableQuantity100Percent;
		/// <summary>
		/// 전일재사용가능금액
		/// </summary>
		[JsonProperty("pred_reu_alowa")]
		public decimal? PreviousDayReusableAmount;
		/// <summary>
		/// 금일재사용가능금액
		/// </summary>
		[JsonProperty("tdy_reu_alowa")]
		public decimal? TodayReusableAmount;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? DepositAmount;
		/// <summary>
		/// 대용금
		/// </summary>
		[JsonProperty("repl_amt")]
		public decimal? SubstituteAmount;
		/// <summary>
		/// 미수금
		/// </summary>
		[JsonProperty("uncla")]
		public decimal? UnsettledAmount;
		/// <summary>
		/// 주문가능대용
		/// </summary>
		[JsonProperty("ord_pos_repl")]
		public decimal? OrderableSubstitute;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[JsonProperty("ord_alowa")]
		public decimal? OrderableCash;
		/// <summary>
		/// 인출가능금액
		/// </summary>
		[JsonProperty("wthd_alowa")]
		public decimal? WithdrawableAmount;
		/// <summary>
		/// 익일인출가능금액
		/// </summary>
		[JsonProperty("nxdy_wthd_alowa")]
		public decimal? WithdrawableAmountD1;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("pur_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Fee;
		/// <summary>
		/// 매입정산금액
		/// </summary>
		[JsonProperty("pur_exct_amt")]
		public decimal? BuySettlementAmount;
		/// <summary>
		/// D+2추정예수금
		/// </summary>
		[JsonProperty("d2entra")]
		public decimal? EstimatedDepositD2;
		/// <summary>
		/// 증거금감면적용구분 - 0:일반, 1:60%감면
		/// </summary>
		[JsonProperty("profa_rdex_aplc_tp")]
		public KiwoomAccountMarginReductionApplyType? MarginReductionApplyType;
	}

	public record KiwoomAccountGetMarginOrders
	{
		/// <summary>
		/// 종목증거금율
		/// </summary>
		[JsonProperty("stk_profa_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal? StockMarginRate;
		/// <summary>
		/// 계좌증거금율
		/// </summary>
		[JsonProperty("profa_rt")]
		public string? AccountMarginRate;
		/// <summary>
		/// 적용증거금율
		/// </summary>
		[JsonProperty("aplc_rt")]
		[JsonConverter(typeof(KiwoomPercentConverter))]
		public decimal? AppliedMarginRate;
		/// <summary>
		/// 증거금20%주문가능금액
		/// </summary>
		[JsonProperty("profa_20ord_alow_amt")]
		public decimal? MarginOrderableAmount20Percent;
		/// <summary>
		/// 증거금20%주문가능수량
		/// </summary>
		[JsonProperty("profa_20ord_alowq")]
		public decimal? MarginOrderableQuantity20Percent;
		/// <summary>
		/// 증거금20%전일재사용금액
		/// </summary>
		[JsonProperty("profa_20pred_reu_amt")]
		public decimal? MarginPreviousDayReuseAmount20Percent;
		/// <summary>
		/// 증거금20%금일재사용금액
		/// </summary>
		[JsonProperty("profa_20tdy_reu_amt")]
		public decimal? MarginTodayReuseAmount20Percent;
		/// <summary>
		/// 증거금30%주문가능금액
		/// </summary>
		[JsonProperty("profa_30ord_alow_amt")]
		public decimal? MarginOrderableAmount30Percent;
		/// <summary>
		/// 증거금30%주문가능수량
		/// </summary>
		[JsonProperty("profa_30ord_alowq")]
		public decimal? MarginOrderableQuantity30Percent;
		/// <summary>
		/// 증거금30%전일재사용금액
		/// </summary>
		[JsonProperty("profa_30pred_reu_amt")]
		public decimal? MarginPreviousDayReuseAmount30Percent;
		/// <summary>
		/// 증거금30%금일재사용금액
		/// </summary>
		[JsonProperty("profa_30tdy_reu_amt")]
		public decimal? MarginTodayReuseAmount30Percent;
		/// <summary>
		/// 증거금40%주문가능금액
		/// </summary>
		[JsonProperty("profa_40ord_alow_amt")]
		public decimal? MarginOrderableAmount40Percent;
		/// <summary>
		/// 증거금40%주문가능수량
		/// </summary>
		[JsonProperty("profa_40ord_alowq")]
		public decimal? MarginOrderableQuantity40Percent;
		/// <summary>
		/// 증거금40%전일재사용금액
		/// </summary>
		[JsonProperty("profa_40pred_reu_amt")]
		public decimal? MarginPreviousDayReuseAmount40Percent;
		/// <summary>
		/// 증거금40%금일재사용금액
		/// </summary>
		[JsonProperty("profa_40tdy_reu_amt")]
		public decimal? MarginTodayReuseAmount40Percent;
		/// <summary>
		/// 증거금50%주문가능금액
		/// </summary>
		[JsonProperty("profa_50ord_alow_amt")]
		public decimal? MarginOrderableAmount50Percent;
		/// <summary>
		/// 증거금50%주문가능수량
		/// </summary>
		[JsonProperty("profa_50ord_alowq")]
		public decimal? MarginOrderableQuantity50Percent;
		/// <summary>
		/// 증거금50%전일재사용금액
		/// </summary>
		[JsonProperty("profa_50pred_reu_amt")]
		public decimal? MarginPreviousDayReuseAmount50Percent;
		/// <summary>
		/// 증거금50%금일재사용금액
		/// </summary>
		[JsonProperty("profa_50tdy_reu_amt")]
		public decimal? MarginTodayReuseAmount50Percent;
		/// <summary>
		/// 증거금60%주문가능금액
		/// </summary>
		[JsonProperty("profa_60ord_alow_amt")]
		public decimal? MarginOrderableAmount60Percent;
		/// <summary>
		/// 증거금60%주문가능수량
		/// </summary>
		[JsonProperty("profa_60ord_alowq")]
		public decimal? MarginOrderableQuantity60Percent;
		/// <summary>
		/// 증거금60%전일재사용금액
		/// </summary>
		[JsonProperty("profa_60pred_reu_amt")]
		public decimal? MarginPreviousDayReuseAmount60Percent;
		/// <summary>
		/// 증거금60%금일재사용금액
		/// </summary>
		[JsonProperty("profa_60tdy_reu_amt")]
		public decimal? MarginTodayReuseAmount60Percent;
		/// <summary>
		/// 증거금100%주문가능금액
		/// </summary>
		[JsonProperty("profa_100ord_alow_amt")]
		public decimal? MarginOrderableAmount100Percent;
		/// <summary>
		/// 증거금100%주문가능수량
		/// </summary>
		[JsonProperty("profa_100ord_alowq")]
		public decimal? MarginOrderableQuantity100Percent;
		/// <summary>
		/// 증거금100%전일재사용금액
		/// </summary>
		[JsonProperty("profa_100pred_reu_amt")]
		public decimal? MarginPreviousDayReuseAmount100Percent;
		/// <summary>
		/// 증거금100%금일재사용금액
		/// </summary>
		[JsonProperty("profa_100tdy_reu_amt")]
		public decimal? MarginTodayReuseAmount100Percent;
		/// <summary>
		/// 미수불가주문가능금액
		/// </summary>
		[JsonProperty("min_ord_alow_amt")]
		public decimal? UnavailableOrderAmount;
		/// <summary>
		/// 미수불가주문가능수량
		/// </summary>
		[JsonProperty("min_ord_alowq")]
		public decimal? UnavailableOrderQuantity;
		/// <summary>
		/// 미수불가전일재사용금액
		/// </summary>
		[JsonProperty("min_pred_reu_amt")]
		public decimal? PreviousDayUnavailableAmount;
		/// <summary>
		/// 미수불가금일재사용금액
		/// </summary>
		[JsonProperty("min_tdy_reu_amt")]
		public decimal? TodayUnavailableAmount;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? DepositAmount;
		/// <summary>
		/// 대용금
		/// </summary>
		[JsonProperty("repl_amt")]
		public decimal? SubstituteAmount;
		/// <summary>
		/// 미수금
		/// </summary>
		[JsonProperty("uncla")]
		public decimal? UnsettledAmount;
		/// <summary>
		/// 주문가능대용
		/// </summary>
		[JsonProperty("ord_pos_repl")]
		public decimal? OrderableSubstitute;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[JsonProperty("ord_alowa")]
		public decimal? OrderableCash;
	}

	public record KiwoomAccountGetCreditDepositOrders
	{
		/// <summary>
		/// 종목보증금율
		/// </summary>
		[JsonProperty("stk_assr_rt")]
		public string? StockDepositRate;
		/// <summary>
		/// 종목보증금율명
		/// </summary>
		[JsonProperty("stk_assr_rt_nm")]
		public string? StockDepositRateName;
		/// <summary>
		/// 보증금30%주문가능금액
		/// </summary>
		[JsonProperty("assr_30ord_alow_amt")]
		public decimal? DepositOrderableAmount30Percent;
		/// <summary>
		/// 보증금30%주문가능수량
		/// </summary>
		[JsonProperty("assr_30ord_alowq")]
		public decimal? DepositOrderableQuantity30Percent;
		/// <summary>
		/// 보증금30%전일재사용금액
		/// </summary>
		[JsonProperty("assr_30pred_reu_amt")]
		public decimal? DepositPreviousDayReuseAmount30Percent;
		/// <summary>
		/// 보증금30%금일재사용금액
		/// </summary>
		[JsonProperty("assr_30tdy_reu_amt")]
		public decimal? DepositTodayReuseAmount30Percent;
		/// <summary>
		/// 보증금40%주문가능금액
		/// </summary>
		[JsonProperty("assr_40ord_alow_amt")]
		public decimal? DepositOrderableAmount40Percent;
		/// <summary>
		/// 보증금40%주문가능수량
		/// </summary>
		[JsonProperty("assr_40ord_alowq")]
		public decimal? DepositOrderableQuantity40Percent;
		/// <summary>
		/// 보증금40%전일재사용금액
		/// </summary>
		[JsonProperty("assr_40pred_reu_amt")]
		public decimal? DepositPreviousDayReuseAmount40Percent;
		/// <summary>
		/// 보증금40%금일재사용금액
		/// </summary>
		[JsonProperty("assr_40tdy_reu_amt")]
		public decimal? DepositTodayReuseAmount40Percent;
		/// <summary>
		/// 보증금50%주문가능금액
		/// </summary>
		[JsonProperty("assr_50ord_alow_amt")]
		public decimal? DepositOrderableAmount50Percent;
		/// <summary>
		/// 보증금50%주문가능수량
		/// </summary>
		[JsonProperty("assr_50ord_alowq")]
		public decimal? DepositOrderableQuantity50Percent;
		/// <summary>
		/// 보증금50%전일재사용금액
		/// </summary>
		[JsonProperty("assr_50pred_reu_amt")]
		public decimal? DepositPreviousDayReuseAmount50Percent;
		/// <summary>
		/// 보증금50%금일재사용금액
		/// </summary>
		[JsonProperty("assr_50tdy_reu_amt")]
		public decimal? DepositTodayReuseAmount50Percent;
		/// <summary>
		/// 보증금60%주문가능금액
		/// </summary>
		[JsonProperty("assr_60ord_alow_amt")]
		public decimal? DepositOrderableAmount60Percent;
		/// <summary>
		/// 보증금60%주문가능수량
		/// </summary>
		[JsonProperty("assr_60ord_alowq")]
		public decimal? DepositOrderableQuantity60Percent;
		/// <summary>
		/// 보증금60%전일재사용금액
		/// </summary>
		[JsonProperty("assr_60pred_reu_amt")]
		public decimal? DepositPreviousDayReuseAmount60Percent;
		/// <summary>
		/// 보증금60%금일재사용금액
		/// </summary>
		[JsonProperty("assr_60tdy_reu_amt")]
		public decimal? DepositTodayReuseAmount60Percent;
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entr")]
		public decimal? DepositAmount;
		/// <summary>
		/// 대용금
		/// </summary>
		[JsonProperty("repl_amt")]
		public decimal? SubstituteAmount;
		/// <summary>
		/// 미수금
		/// </summary>
		[JsonProperty("uncla")]
		public decimal? UnsettledAmount;
		/// <summary>
		/// 주문가능대용
		/// </summary>
		[JsonProperty("ord_pos_repl")]
		public decimal? OrderableSubstitute;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[JsonProperty("ord_alowa")]
		public decimal? OrderableCash;
		/// <summary>
		/// 미수가능금액
		/// </summary>
		[JsonProperty("out_alowa")]
		public decimal? UnsettledAvailableAmount;
		/// <summary>
		/// 미수가능수량
		/// </summary>
		[JsonProperty("out_pos_qty")]
		public decimal? UnsettledAvailableQuantity;
		/// <summary>
		/// 미수불가금액
		/// </summary>
		[JsonProperty("min_amt")]
		public decimal? UnsettledIneligibleAmount;
		/// <summary>
		/// 미수불가수량
		/// </summary>
		[JsonProperty("min_qty")]
		public decimal? UnsettledIneligibleQuantity;
	}

	public record KiwoomAccountGetMarginDetails
	{
		/// <summary>
		/// 금일재사용대상금액
		/// </summary>
		[JsonProperty("tdy_reu_objt_amt")]
		public decimal? TodayReuseTargetAmount;
		/// <summary>
		/// 금일재사용사용금액
		/// </summary>
		[JsonProperty("tdy_reu_use_amt")]
		public decimal? TodayReuseUsedAmount;
		/// <summary>
		/// 금일재사용가능금액
		/// </summary>
		[JsonProperty("tdy_reu_alowa")]
		public decimal? TodayReusableAmount;
		/// <summary>
		/// 금일재사용제한금액
		/// </summary>
		[JsonProperty("tdy_reu_lmtt_amt")]
		public decimal? TodayReuseLimitAmount;
		/// <summary>
		/// 금일재사용가능금액최종
		/// </summary>
		[JsonProperty("tdy_reu_alowa_fin")]
		public decimal? TodayReusableFinalAmount;
		/// <summary>
		/// 전일재사용대상금액
		/// </summary>
		[JsonProperty("pred_reu_objt_amt")]
		public decimal? PreviousDayReuseTargetAmount;
		/// <summary>
		/// 전일재사용사용금액
		/// </summary>
		[JsonProperty("pred_reu_use_amt")]
		public decimal? PreviousDayReuseUsedAmount;
		/// <summary>
		/// 전일재사용가능금액
		/// </summary>
		[JsonProperty("pred_reu_alowa")]
		public decimal? PreviousDayReusableAmount;
		/// <summary>
		/// 전일재사용제한금액
		/// </summary>
		[JsonProperty("pred_reu_lmtt_amt")]
		public decimal? PreviousDayReuseLimitAmount;
		/// <summary>
		/// 전일재사용가능금액최종
		/// </summary>
		[JsonProperty("pred_reu_alowa_fin")]
		public decimal? PreviousDayReusableFinalAmount;
		/// <summary>
		/// 현금금액
		/// </summary>
		[JsonProperty("ch_amt")]
		public decimal? CashAmount;
		/// <summary>
		/// 현금증거금
		/// </summary>
		[JsonProperty("ch_profa")]
		public decimal? CashMargin;
		/// <summary>
		/// 사용가능현금
		/// </summary>
		[JsonProperty("use_pos_ch")]
		public decimal? AvailableCash;
		/// <summary>
		/// 현금사용제한금액
		/// </summary>
		[JsonProperty("ch_use_lmtt_amt")]
		public decimal? CashUseLimitAmount;
		/// <summary>
		/// 사용가능현금최종
		/// </summary>
		[JsonProperty("use_pos_ch_fin")]
		public decimal? AvailableCashFinal;
		/// <summary>
		/// 대용금액
		/// </summary>
		[JsonProperty("repl_amt_amt")]
		public decimal? SubstituteAmount;
		/// <summary>
		/// 대용증거금
		/// </summary>
		[JsonProperty("repl_profa")]
		public decimal? SubstituteMargin;
		/// <summary>
		/// 사용가능대용
		/// </summary>
		[JsonProperty("use_pos_repl")]
		public decimal? AvailableSubstitute;
		/// <summary>
		/// 대용사용제한금액
		/// </summary>
		[JsonProperty("repl_use_lmtt_amt")]
		public decimal? SubstituteUseLimitAmount;
		/// <summary>
		/// 사용가능대용최종
		/// </summary>
		[JsonProperty("use_pos_repl_fin")]
		public decimal? AvailableSubstituteFinal;
		/// <summary>
		/// 신용보증금현금
		/// </summary>
		[JsonProperty("crd_grnta_ch")]
		public decimal? CreditGuaranteeCash;
		/// <summary>
		/// 신용보증금대용
		/// </summary>
		[JsonProperty("crd_grnta_repl")]
		public decimal? CreditDepositSubstitute;
		/// <summary>
		/// 신용담보금현금
		/// </summary>
		[JsonProperty("crd_grnt_ch")]
		public decimal? CreditCollateralCash;
		/// <summary>
		/// 신용담보금대용
		/// </summary>
		[JsonProperty("crd_grnt_repl")]
		public decimal? CreditCollateralSubstitute;
		/// <summary>
		/// 미수금
		/// </summary>
		[JsonProperty("uncla")]
		public decimal? UnsettledAmount;
		/// <summary>
		/// 대주담보금재사용금액
		/// </summary>
		[JsonProperty("ls_grnt_reu_gold")]
		public decimal? ShortSellCollateralReuseAmount;
		/// <summary>
		/// 20%주문가능금액
		/// </summary>
		[JsonProperty("20ord_alow_amt")]
		public decimal? OrderableAmount20Percent;
		/// <summary>
		/// 30%주문가능금액
		/// </summary>
		[JsonProperty("30ord_alow_amt")]
		public decimal? OrderableAmount30Percent;
		/// <summary>
		/// 40%주문가능금액
		/// </summary>
		[JsonProperty("40ord_alow_amt")]
		public decimal? OrderableAmount40Percent;
		/// <summary>
		/// 50%주문가능금액
		/// </summary>
		[JsonProperty("50ord_alow_amt")]
		public decimal? OrderableAmount50Percent;
		/// <summary>
		/// 60%주문가능금액
		/// </summary>
		[JsonProperty("60ord_alow_amt")]
		public decimal? OrderableAmount60Percent;
		/// <summary>
		/// 100%주문가능금액
		/// </summary>
		[JsonProperty("100ord_alow_amt")]
		public decimal? OrderableAmount100Percent;
		/// <summary>
		/// 금일신용상환손실금액
		/// </summary>
		[JsonProperty("tdy_crd_rpya_loss_amt")]
		public decimal? TodayCreditRepaymentLossAmount;
		/// <summary>
		/// 전일신용상환손실금액
		/// </summary>
		[JsonProperty("pred_crd_rpya_loss_amt")]
		public decimal? PreviousDayCreditRepaymentLossAmount;
		/// <summary>
		/// 금일대주상환손실대용증거금
		/// </summary>
		[JsonProperty("tdy_ls_rpya_loss_repl_profa")]
		public decimal? TodayShortSellRepaymentLossSubstituteMargin;
		/// <summary>
		/// 전일대주상환손실대용증거금
		/// </summary>
		[JsonProperty("pred_ls_rpya_loss_repl_profa")]
		public decimal? PreviousDayShortSellRepaymentLossSubstituteMargin;
		/// <summary>
		/// 평가대용금(현물사용제외)
		/// </summary>
		[JsonProperty("evlt_repl_amt_spg_use_skip")]
		public decimal? EvaluationSubstituteAmount;
		/// <summary>
		/// 평가대용비율
		/// </summary>
		[JsonProperty("evlt_repl_rt")]
		public decimal? EvaluationSubstituteRate;
		/// <summary>
		/// 신용대용증거금
		/// </summary>
		[JsonProperty("crd_repl_profa")]
		public decimal? CreditSubstituteMargin;
		/// <summary>
		/// 현금주문대용증거금
		/// </summary>
		[JsonProperty("ch_ord_repl_profa")]
		public decimal? CashOrderSubstituteMargin;
		/// <summary>
		/// 신용주문대용증거금
		/// </summary>
		[JsonProperty("crd_ord_repl_profa")]
		public decimal? CreditOrderSubstituteMargin;
		/// <summary>
		/// 신용대용환산금액
		/// </summary>
		[JsonProperty("crd_repl_conv_gold")]
		public decimal? CreditSubstituteAmount;
		/// <summary>
		/// 대용가능금액(현금제한)
		/// </summary>
		[JsonProperty("repl_alowa")]
		public decimal? SubstituteAvailableAmountCashLimit;
		/// <summary>
		/// 대용가능금액(신용제한)
		/// </summary>
		[JsonProperty("repl_alowa_2")]
		public decimal? SubstituteAvailableAmountCreditLimit;
		/// <summary>
		/// 현금대용부족금액
		/// </summary>
		[JsonProperty("ch_repl_lck_gold")]
		public decimal? CashSubstituteDeficitAmount;
		/// <summary>
		/// 신용대용부족금액
		/// </summary>
		[JsonProperty("crd_repl_lck_gold")]
		public decimal? CreditSubstituteDeficitAmount;
		/// <summary>
		/// 현금주문가능대용금액
		/// </summary>
		[JsonProperty("ch_ord_alow_repla")]
		public decimal? CashOrderableSubstituteAmount;
		/// <summary>
		/// 신용주문가능대용금액
		/// </summary>
		[JsonProperty("crd_ord_alow_repla")]
		public decimal? CreditOrderableSubstituteAmount;
		/// <summary>
		/// D+2가정산예수금
		/// </summary>
		[JsonProperty("d2vexct_entr")]
		public decimal? EstimatedSettlementDepositD2;
		/// <summary>
		/// D+2현금주문가능금액
		/// </summary>
		[JsonProperty("d2ch_ord_alow_amt")]
		public decimal? CashOrderableAmountD2;
	}

	public record KiwoomAccountGetConsignedTransactions
	{
		/// <summary>
		/// 위탁종합거래내역배열
		/// </summary>
		[JsonProperty("trst_ovrl_trde_prps_array")]
		public IEnumerable<KiwoomAccountGetConsignedTransactionItem>? Items;
	}
	public record KiwoomAccountGetConsignedTransactionItem
	{
		/// <summary>
		/// 거래일자
		/// </summary>
		[JsonProperty("trde_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TransactionDate;
		/// <summary>
		/// 거래번호
		/// </summary>
		[JsonProperty("trde_no")]
		public string? TransactionId;
		/// <summary>
		/// 적요명
		/// </summary>
		[JsonProperty("rmrk_nm")]
		public string? Remark;
		/// <summary>
		/// 신용거래구분명
		/// </summary>
		[JsonProperty("crd_deal_tp_nm")]
		public string? CreditTransactionTypeName;
		/// <summary>
		/// 정산금액
		/// </summary>
		[JsonProperty("exct_amt")]
		public decimal? SettlementAmount;
		/// <summary>
		/// 대출금상환
		/// </summary>
		[JsonProperty("loan_amt_rpya")]
		public decimal? LoanRepaymentAmount;
		/// <summary>
		/// 거래금액(외화)
		/// </summary>
		[JsonProperty("fc_trde_amt")]
		public decimal? ForeignTransactionAmount;
		/// <summary>
		/// 정산금액(외화)
		/// </summary>
		[JsonProperty("fc_exct_amt")]
		public decimal? ForeignSettlementAmount;
		/// <summary>
		/// 예수금잔고
		/// </summary>
		[JsonProperty("entra_remn")]
		public decimal? DepositBalance;
		/// <summary>
		/// 통화코드
		/// </summary>
		[JsonProperty("crnc_cd")]
		public string? CurrencyCode;
		/// <summary>
		/// 거래종류구분 - 1:입출금, 2:펀드, 3:ELS, 4:채권, 5:해외채권, 6:외화RP, 7:외화발행어음
		/// </summary>
		[JsonProperty("trde_ocr_tp")]
		public KiwoomAccountTransactionType4? TransactionType;
		/// <summary>
		/// 거래종류명
		/// </summary>
		[JsonProperty("trde_kind_nm")]
		public string? TransactionTypeName;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 거래금액
		/// </summary>
		[JsonProperty("trde_amt")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 거래및농특세
		/// </summary>
		[JsonProperty("trde_agri_tax")]
		public decimal? TransactionAndSpecialRuralTax;
		/// <summary>
		/// 상환차금
		/// </summary>
		[JsonProperty("rpy_diffa")]
		public decimal? RepaymentDeficitAmount;
		/// <summary>
		/// 거래세(외화)
		/// </summary>
		[JsonProperty("fc_trde_tax")]
		public decimal? ForeignTransactionTax;
		/// <summary>
		/// 연체합
		/// </summary>
		[JsonProperty("dly_sum")]
		public decimal? TotalOverdueAmount;
		/// <summary>
		/// 외화예수금잔고
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignDepositBalance;
		/// <summary>
		/// 매체구분명
		/// </summary>
		[JsonProperty("mdia_tp_nm")]
		public string? MediaTypeName;
		/// <summary>
		/// 입출구분
		/// </summary>
		[JsonProperty("io_tp")]
		public string? InOutTypeCode;
		/// <summary>
		/// 입출구분명
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public string? InOutTypeName;
		/// <summary>
		/// 원거래번호
		/// </summary>
		[JsonProperty("orig_deal_no")]
		public string? OriginalTransactionId;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 거래수량/좌수
		/// </summary>
		[JsonProperty("trde_qty_jwa_cnt")]
		public int? TransactionCount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Fee;
		/// <summary>
		/// 이자/대주이용
		/// </summary>
		[JsonProperty("int_ls_usfe")]
		public decimal? InterestShortSellUsageFee;
		/// <summary>
		/// 수수료(외화)
		/// </summary>
		[JsonProperty("fc_cmsn")]
		public decimal? ForeignFee;
		/// <summary>
		/// 연체합(외화)
		/// </summary>
		[JsonProperty("fc_dly_sum")]
		public decimal? TotalForeignOverdueAmount;
		/// <summary>
		/// 유가금잔
		/// </summary>
		[JsonProperty("vlbl_nowrm")]
		public decimal? SecuritiesCashBalance;
		/// <summary>
		/// 처리시간
		/// </summary>
		[JsonProperty("proc_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ProcessingTime;
		/// <summary>
		/// ISIN코드
		/// </summary>
		[JsonProperty("isin_cd")]
		public string? IsinCode;
		/// <summary>
		/// 거래소코드
		/// </summary>
		[JsonProperty("stex_cd")]
		public string? StockExchangeCode;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? StockExchangeName;
		/// <summary>
		/// 거래단가/환율
		/// </summary>
		[JsonProperty("trde_unit")]
		public decimal? TransactionPriceExchangeRate;
		/// <summary>
		/// 소득/주민세
		/// </summary>
		[JsonProperty("incm_resi_tax")]
		public decimal? IncomeResidentTax;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 미수(원/주)
		/// </summary>
		[JsonProperty("uncl_ocr")]
		public decimal? UnsettledAmountOriginal;
		/// <summary>
		/// 변제합
		/// </summary>
		[JsonProperty("rpym_sum")]
		public decimal? TotalRepayment;
		/// <summary>
		/// 체결일
		/// </summary>
		[JsonProperty("cntr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeDate;
		/// <summary>
		/// 출납번호
		/// </summary>
		[JsonProperty("rcpy_no")]
		public string? PaymentId;
		/// <summary>
		/// 처리자
		/// </summary>
		[JsonProperty("prcsr")]
		public string? Processor;
		/// <summary>
		/// 처리점
		/// </summary>
		[JsonProperty("proc_brch")]
		public string? ProcessingBranch;
		/// <summary>
		/// 매매형태
		/// </summary>
		[JsonProperty("trde_stle")]
		public string? TransactionStyle;
		/// <summary>
		/// 과세기준가
		/// </summary>
		[JsonProperty("txon_base_pric")]
		public decimal? TaxBasePrice;
		/// <summary>
		/// 세금수수료합
		/// </summary>
		[JsonProperty("tax_sum_cmsn")]
		public decimal? TotalTaxFee;
		/// <summary>
		/// 외국납부세액(외화)
		/// </summary>
		[JsonProperty("frgn_pay_txam")]
		public decimal? ForeignPaymentTaxAmount;
		/// <summary>
		/// 미수(외화)
		/// </summary>
		[JsonProperty("fc_uncl_ocr")]
		public decimal? ForeignUnsettledAmount;
		/// <summary>
		/// 변제합(외화)
		/// </summary>
		[JsonProperty("rpym_sum_fr")]
		public decimal? TotalForeignRepayment;
		/// <summary>
		/// 입금자
		/// </summary>
		[JsonProperty("rcpmnyer")]
		public string? Depositor;
		/// <summary>
		/// 거래내역구분
		/// </summary>
		[JsonProperty("trde_prtc_tp")]
		public string? TransactionDetailType;
	}

	public record KiwoomAccountGetDailyProfitRateDetails
	{
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[JsonProperty("mang_empno")]
		public string? ManagerEmployeeId;
		/// <summary>
		/// 관리자명
		/// </summary>
		[JsonProperty("mngr_nm")]
		public string? ManagerName;
		/// <summary>
		/// 관리자지점
		/// </summary>
		[JsonProperty("dept_nm")]
		public string? ManagerBranch;
		/// <summary>
		/// 예수금_초
		/// </summary>
		[JsonProperty("entr_fr")]
		public decimal? DepositAmountStart;
		/// <summary>
		/// 예수금_말
		/// </summary>
		[JsonProperty("entr_to")]
		public decimal? DepositAmountEnd;
		/// <summary>
		/// 유가증권평가금액_초
		/// </summary>
		[JsonProperty("scrt_evlt_amt_fr")]
		public decimal? SecuritiesEvaluationAmountStart;
		/// <summary>
		/// 유가증권평가금액_말
		/// </summary>
		[JsonProperty("scrt_evlt_amt_to")]
		public decimal? SecuritiesEvaluationAmountEnd;
		/// <summary>
		/// 대주담보금_초
		/// </summary>
		[JsonProperty("ls_grnt_fr")]
		public decimal? ShortSellCollateralStart;
		/// <summary>
		/// 대주담보금_말
		/// </summary>
		[JsonProperty("ls_grnt_to")]
		public decimal? ShortSellCollateralEnd;
		/// <summary>
		/// 신용융자금_초
		/// </summary>
		[JsonProperty("crd_loan_fr")]
		public decimal? CreditLoanAmountStart;
		/// <summary>
		/// 신용융자금_말
		/// </summary>
		[JsonProperty("crd_loan_to")]
		public decimal? CreditLoanAmountEnd;
		/// <summary>
		/// 현금미수금_초
		/// </summary>
		[JsonProperty("ch_uncla_fr")]
		public decimal? CashUnsettledAmountStart;
		/// <summary>
		/// 현금미수금_말
		/// </summary>
		[JsonProperty("ch_uncla_to")]
		public decimal? CashUnsettledAmountEnd;
		/// <summary>
		/// 원화대용금_초
		/// </summary>
		[JsonProperty("krw_asgna_fr")]
		public decimal? KrwSubstituteAmountStart;
		/// <summary>
		/// 원화대용금_말
		/// </summary>
		[JsonProperty("krw_asgna_to")]
		public decimal? KrwSubstituteAmountEnd;
		/// <summary>
		/// 대주평가금_초
		/// </summary>
		[JsonProperty("ls_evlta_fr")]
		public decimal? ShortSellEvaluationAmountStart;
		/// <summary>
		/// 대주평가금_말
		/// </summary>
		[JsonProperty("ls_evlta_to")]
		public decimal? ShortSellEvaluationAmountEnd;
		/// <summary>
		/// 권리평가금_초
		/// </summary>
		[JsonProperty("rght_evlta_fr")]
		public decimal? RightsEvaluationAmountStart;
		/// <summary>
		/// 권리평가금_말
		/// </summary>
		[JsonProperty("rght_evlta_to")]
		public decimal? RightsEvaluationAmountEnd;
		/// <summary>
		/// 대출금_초
		/// </summary>
		[JsonProperty("loan_amt_fr")]
		public decimal? LoanAmountStart;
		/// <summary>
		/// 대출금_말
		/// </summary>
		[JsonProperty("loan_amt_to")]
		public decimal? LoanAmountEnd;
		/// <summary>
		/// 기타대여금_초
		/// </summary>
		[JsonProperty("etc_loana_fr")]
		public decimal? OtherLoanAmountStart;
		/// <summary>
		/// 기타대여금_말
		/// </summary>
		[JsonProperty("etc_loana_to")]
		public decimal? OtherLoanAmountEnd;
		/// <summary>
		/// 신용이자미납금_초
		/// </summary>
		[JsonProperty("crd_int_npay_gold_fr")]
		public decimal? CreditInterestUnpaidAmountStart;
		/// <summary>
		/// 신용이자미납금_말
		/// </summary>
		[JsonProperty("crd_int_npay_gold_to")]
		public decimal? CreditInterestUnpaidAmountEnd;
		/// <summary>
		/// 신용이자_초
		/// </summary>
		[JsonProperty("crd_int_fr")]
		public decimal? CreditInterestStart;
		/// <summary>
		/// 신용이자_말
		/// </summary>
		[JsonProperty("crd_int_to")]
		public decimal? CreditInterestEnd;
		/// <summary>
		/// 순자산액계_초
		/// </summary>
		[JsonProperty("tot_amt_fr")]
		public decimal? TotalNetAssetAmountStart;
		/// <summary>
		/// 순자산액계_말
		/// </summary>
		[JsonProperty("tot_amt_to")]
		public decimal? TotalNetAssetAmountEnd;
		/// <summary>
		/// 투자원금평잔
		/// </summary>
		[JsonProperty("invt_bsamt")]
		public decimal? InvestmentPrincipalAverageAmount;
		/// <summary>
		/// 평가손익
		/// </summary>
		[JsonProperty("evltv_prft")]
		public KiwoomDecimal? EvaluationProfitLoss;
		/// <summary>
		/// 수익률
		/// </summary>
		[JsonProperty("prft_rt")]
		public decimal? ProfitRate;
		/// <summary>
		/// 회전율
		/// </summary>
		[JsonProperty("tern_rt")]
		public decimal? TurnoverRate;
		/// <summary>
		/// 기간내총입금
		/// </summary>
		[JsonProperty("termin_tot_trns")]
		public decimal? TotalDepositDuringPeriod;
		/// <summary>
		/// 기간내총출금
		/// </summary>
		[JsonProperty("termin_tot_pymn")]
		public decimal? TotalWithdrawalDuringPeriod;
		/// <summary>
		/// 기간내총입고
		/// </summary>
		[JsonProperty("termin_tot_inq")]
		public decimal? TotalIncomingDuringPeriod;
		/// <summary>
		/// 기간내총출고
		/// </summary>
		[JsonProperty("termin_tot_outq")]
		public decimal? TotalOutgoingDuringPeriod;
		/// <summary>
		/// 선물대용매도금액
		/// </summary>
		[JsonProperty("futr_repl_sella")]
		public decimal? FuturesSubstituteSellAmount;
		/// <summary>
		/// 위탁대용매도금액
		/// </summary>
		[JsonProperty("trst_repl_sella")]
		public decimal? ConsignmentSubstituteSellAmount;
	}

	public record KiwoomAccountGetDailyStatus
	{
		/// <summary>
		/// D+2추정예수금
		/// </summary>
		[JsonProperty("d2_entra")]
		public decimal? EstimatedDepositD2;
		/// <summary>
		/// 신용이자미납금
		/// </summary>
		[JsonProperty("crd_int_npay_gold")]
		public decimal? CreditInterestUnpaidAmount;
		/// <summary>
		/// 기타대여금
		/// </summary>
		[JsonProperty("etc_loana")]
		public decimal? OtherLoanAmount;
		/// <summary>
		/// 일반주식평가금액D+2
		/// </summary>
		[JsonProperty("gnrl_stk_evlt_amt_d2")]
		public decimal? GeneralStockEvaluationAmountD2;
		/// <summary>
		/// 예탁담보대출금D+2
		/// </summary>
		[JsonProperty("dpst_grnt_use_amt_d2")]
		public decimal? DepositedCollateralLoanAmountD2;
		/// <summary>
		/// 예탁담보주식평가금액D+2
		/// </summary>
		[JsonProperty("crd_stk_evlt_amt_d2")]
		public decimal? DepositedCollateralStockEvaluationAmountD2;
		/// <summary>
		/// 신용융자금D+2
		/// </summary>
		[JsonProperty("crd_loan_d2")]
		public decimal? CreditLoanAmountD2;
		/// <summary>
		/// 신용융자평가금D+2
		/// </summary>
		[JsonProperty("crd_loan_evlta_d2")]
		public decimal? CreditLoanEvaluationAmountD2;
		/// <summary>
		/// 신용대주담보금D+2
		/// </summary>
		[JsonProperty("crd_ls_grnt_d2")]
		public decimal? CreditShortSellCollateralAmountD2;
		/// <summary>
		/// 신용대주평가금D+2
		/// </summary>
		[JsonProperty("crd_ls_evlta_d2")]
		public decimal? CreditShortSellEvaluationAmountD2;
		/// <summary>
		/// 입금금액
		/// </summary>
		[JsonProperty("ina_amt")]
		public decimal? DepositAmount;
		/// <summary>
		/// 출금금액
		/// </summary>
		[JsonProperty("outa")]
		public decimal? WithdrawalAmount;
		/// <summary>
		/// 입고금액
		/// </summary>
		[JsonProperty("inq_amt")]
		public decimal? IncomingAmount;
		/// <summary>
		/// 출고금액
		/// </summary>
		[JsonProperty("outq_amt")]
		public decimal? OutgoingAmount;
		/// <summary>
		/// 매도금액
		/// </summary>
		[JsonProperty("sell_amt")]
		public decimal? SellAmount;
		/// <summary>
		/// 매수금액
		/// </summary>
		[JsonProperty("buy_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Fee;
		/// <summary>
		/// 세금
		/// </summary>
		[JsonProperty("tax")]
		public decimal? Tax;
		/// <summary>
		/// 주식매입자금대출금
		/// </summary>
		[JsonProperty("stk_pur_cptal_loan_amt")]
		public decimal? StockBuyCapitalLoanAmount;
		/// <summary>
		/// RP평가금액
		/// </summary>
		[JsonProperty("rp_evlt_amt")]
		public decimal? RpEvaluationAmount;
		/// <summary>
		/// 채권평가금액
		/// </summary>
		[JsonProperty("bd_evlt_amt")]
		public decimal? BondEvaluationAmount;
		/// <summary>
		/// ELS평가금액
		/// </summary>
		[JsonProperty("elsevlt_amt")]
		public decimal? ElsEvaluationAmount;
		/// <summary>
		/// 신용이자금액
		/// </summary>
		[JsonProperty("crd_int_amt")]
		public decimal? CreditInterestAmount;
		/// <summary>
		/// 매도대금담보대출이자금액
		/// </summary>
		[JsonProperty("sel_prica_grnt_loan_int_amt_amt")]
		public decimal? SellAmountCollateralLoanInterestAmount;
		/// <summary>
		/// 배당금액
		/// </summary>
		[JsonProperty("dvida_amt")]
		public decimal? DividendAmount;
	}

	public record KiwoomAccountGetEvaluationBalances
	{
		/// <summary>
		/// 총매입금액
		/// </summary>
		[JsonProperty("tot_pur_amt")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 총평가금액
		/// </summary>
		[JsonProperty("tot_evlt_amt")]
		public decimal? TotalEvaluationAmount;
		/// <summary>
		/// 총평가손익금액
		/// </summary>
		[JsonProperty("tot_evlt_pl")]
		public KiwoomDecimal? TotalEvaluationProfitLossAmount;
		/// <summary>
		/// 총수익률(%)
		/// </summary>
		[JsonProperty("tot_prft_rt")]
		public KiwoomDecimal? TotalProfitRate;
		/// <summary>
		/// 추정예탁자산
		/// </summary>
		[JsonProperty("prsm_dpst_aset_amt")]
		public decimal? EstimatedDepositAssetAmount;
		/// <summary>
		/// 총대출금
		/// </summary>
		[JsonProperty("tot_loan_amt")]
		public decimal? TotalLoanAmount;
		/// <summary>
		/// 총융자금액
		/// </summary>
		[JsonProperty("tot_crd_loan_amt")]
		public decimal? TotalCreditLoanAmount;
		/// <summary>
		/// 총대주금액
		/// </summary>
		[JsonProperty("tot_crd_ls_amt")]
		public decimal? TotalShortSellAmount;
		/// <summary>
		/// 계좌평가잔고개별합산
		/// </summary>
		[JsonProperty("acnt_evlt_remn_indv_tot")]
		public IEnumerable<KiwoomAccountGetEvaluationBalanceItem>? Items;
	}
	public record KiwoomAccountGetEvaluationBalanceItem
	{
		/// <summary>
		/// 종목번호
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 평가손익
		/// </summary>
		[JsonProperty("evltv_prft")]
		public KiwoomDecimal? EvaluationProfitLoss;
		/// <summary>
		/// 수익률(%)
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 매입가
		/// </summary>
		[JsonProperty("pur_pric")]
		public decimal? BuyPrice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("rmnd_qty")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 매매가능수량
		/// </summary>
		[JsonProperty("trde_able_qty")]
		public decimal? TransactableQuantity;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일매수수량
		/// </summary>
		[JsonProperty("pred_buyq")]
		public decimal? PreviousDayBuyQuantity;
		/// <summary>
		/// 전일매도수량
		/// </summary>
		[JsonProperty("pred_sellq")]
		public decimal? PreviousDaySellQuantity;
		/// <summary>
		/// 금일매수수량
		/// </summary>
		[JsonProperty("tdy_buyq")]
		public decimal? TodayBuyQuantity;
		/// <summary>
		/// 금일매도수량
		/// </summary>
		[JsonProperty("tdy_sellq")]
		public decimal? TodaySellQuantity;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("pur_amt")]
		public decimal? BuyAmount;
		/// <summary>
		/// 매입수수료
		/// </summary>
		[JsonProperty("pur_cmsn")]
		public decimal? BuyFee;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("evlt_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 평가수수료
		/// </summary>
		[JsonProperty("sell_cmsn")]
		public decimal? EvaluationFee;
		/// <summary>
		/// 세금
		/// </summary>
		[JsonProperty("tax")]
		public decimal? Tax;
		/// <summary>
		/// 수수료합 (매입수수료 + 평가수수료)
		/// </summary>
		[JsonProperty("sum_cmsn")]
		public decimal? TotalFee;
		/// <summary>
		/// 보유비중(%)
		/// </summary>
		[JsonProperty("poss_rt")]
		public decimal? HoldingRate;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
		/// <summary>
		/// 신용구분명
		/// </summary>
		[JsonProperty("crd_tp_nm")]
		public string? CreditTypeName;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("crd_loan_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
	}

	public record KiwoomAccountGetAccountId
	{
		/// <summary>
		/// 계좌번호
		/// </summary>
		[JsonProperty("acctNo")]
		public string? AccountId;
	}

	public record KiwoomAccountGetGoldEvaluationBalances
	{
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("tot_entr")]
		public decimal? Deposit;
		/// <summary>
		/// 추정예수금
		/// </summary>
		[JsonProperty("net_entr")]
		public decimal? EstimatedDeposit;
		/// <summary>
		/// 잔고평가액
		/// </summary>
		[JsonProperty("tot_est_amt")]
		public decimal? BalanceEvaluation;
		/// <summary>
		/// 예탁자산평가액
		/// </summary>
		[JsonProperty("net_amt")]
		public decimal? DepositedAssetsEvaluation;
		/// <summary>
		/// 총매입금액
		/// </summary>
		[JsonProperty("tot_book_amt2")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 추정예탁자산
		/// </summary>
		[JsonProperty("tot_dep_amt")]
		public decimal? EstimatedDepositAsset;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[JsonProperty("paym_alowa")]
		public decimal? Withdrawable;
		/// <summary>
		/// 실현손익
		/// </summary>
		[JsonProperty("pl_amt")]
		public KiwoomDecimal? RealizedProfitLoss;
		/// <summary>
		/// 금현물계좌평가 리스트
		/// </summary>
		[JsonProperty("gold_acnt_evlt_prst")]
		public IEnumerable<KiwoomAccountGetGoldEvaluationBalanceItem>? Items;
	}
	public record KiwoomAccountGetGoldEvaluationBalanceItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("real_qty")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 평균단가
		/// </summary>
		[JsonProperty("avg_prc")]
		public decimal? AveragePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 평가금액
		/// </summary>
		[JsonProperty("est_amt")]
		public decimal? EvaluationAmount;
		/// <summary>
		/// 손익금액
		/// </summary>
		[JsonProperty("est_lspft")]
		public KiwoomDecimal? ProfitLossAmount;
		/// <summary>
		/// 손익율(%)
		/// </summary>
		[JsonProperty("est_ratio")]
		public KiwoomDecimal? ProfitRate;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Fee;
		/// <summary>
		/// 부가가치세
		/// </summary>
		[JsonProperty("vlad_tax")]
		public decimal? ValueAddedTax;
		/// <summary>
		/// 매입금액
		/// </summary>
		[JsonProperty("book_amt2")]
		public decimal? BuyAmount;
		/// <summary>
		/// 손익분기매입가
		/// </summary>
		[JsonProperty("pl_prch_prc")]
		public decimal? BreakEvenPrice;
		/// <summary>
		/// 결제잔고
		/// </summary>
		[JsonProperty("qty")]
		public decimal? SettlementBalance;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 가능수량
		/// </summary>
		[JsonProperty("able_qty")]
		public decimal? AvailableQuantity;
	}

	public record KiwoomAccountGetGoldDeposit
	{
		/// <summary>
		/// 예수금
		/// </summary>
		[JsonProperty("entra")]
		public decimal? Deposit;
		/// <summary>
		/// 증거금현금
		/// </summary>
		[JsonProperty("profa_ch")]
		public decimal? MarginCash;
		/// <summary>
		/// 수표입금액
		/// </summary>
		[JsonProperty("chck_ina_amt")]
		public decimal? CheckDeposit;
		/// <summary>
		/// 기타대여금
		/// </summary>
		[JsonProperty("etc_loan")]
		public decimal? OtherLoan;
		/// <summary>
		/// 기타대여금연체료
		/// </summary>
		[JsonProperty("etc_loan_dlfe")]
		public decimal? OtherLoanLateFee;
		/// <summary>
		/// 기타대여금합계
		/// </summary>
		[JsonProperty("etc_loan_tot")]
		public decimal? TotalOtherLoan;
		/// <summary>
		/// 추정예수금
		/// </summary>
		[JsonProperty("prsm_entra")]
		public decimal? EstimatedDeposit;
		/// <summary>
		/// 매수정산금
		/// </summary>
		[JsonProperty("buy_exct_amt")]
		public decimal? BuySettlement;
		/// <summary>
		/// 매도정산금
		/// </summary>
		[JsonProperty("sell_exct_amt")]
		public decimal? SellSettlement;
		/// <summary>
		/// 매도매수정산금
		/// </summary>
		[JsonProperty("sell_buy_exct_amt")]
		public decimal? NetSettlement;
		/// <summary>
		/// 미수변제소요금
		/// </summary>
		[JsonProperty("dly_amt")]
		public decimal? RequiredRepayment;
		/// <summary>
		/// 추정출금가능금액
		/// </summary>
		[JsonProperty("prsm_pymn_alow_amt")]
		public decimal? EstimatedWithdrawable;
		/// <summary>
		/// 출금가능금액
		/// </summary>
		[JsonProperty("pymn_alow_amt")]
		public decimal? Withdrawable;
		/// <summary>
		/// 주문가능금액
		/// </summary>
		[JsonProperty("ord_alow_amt")]
		public decimal? Orderable;
	}

	public record KiwoomAccountGetGoldAllTrades
	{
		/// <summary>
		/// 계좌별주문체결현황
		/// </summary>
		[JsonProperty("acnt_ord_cntr_prst")]
		public IEnumerable<KiwoomAccountGetGoldAllTradeItem>? Items;
	}
	public record KiwoomAccountGetGoldAllTradeItem
	{
		/// <summary>
		/// 주식채권구분
		/// </summary>
		[JsonProperty("stk_bond_tp")]
		public string? StockBondType;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 상품코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TransactionType;
		/// <summary>
		/// 주문유형구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public string? OrderType;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderPrice;
		/// <summary>
		/// 확인수량
		/// </summary>
		[JsonProperty("cnfm_qty")]
		public decimal? ConfirmQuantity;
		/// <summary>
		/// 접수구분
		/// </summary>
		[JsonProperty("data_send_end_tp")]
		public string? ReceiptType;
		/// <summary>
		/// 시장구분
		/// </summary>
		[JsonProperty("mrkt_deal_tp")]
		public string? MarketType;
		/// <summary>
		/// 예약/반대여부
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservedType;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 결제구분
		/// </summary>
		[JsonProperty("dcd_tp_nm")]
		public string? SettlementType;
		/// <summary>
		/// 신용거래구분
		/// </summary>
		[JsonProperty("crd_deal_tp")]
		public string? CreditTransactionType;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradePrice;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? UnfilledQuantity;
		/// <summary>
		/// 통신구분
		/// </summary>
		[JsonProperty("comm_ord_tp")]
		public string? CommunicationType;
		/// <summary>
		/// 정정취소구분
		/// </summary>
		[JsonProperty("mdfy_cncl_tp")]
		public string? ModifyCancelType;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticStockExchangeType;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("cond_uv")]
		public decimal? StopPrice;
	}

	public record KiwoomAccountGetGoldTrades
	{
		/// <summary>
		/// 계좌별주문체결내역상세
		/// </summary>
		[JsonProperty("acnt_ord_cntr_prps_dtl")]
		public IEnumerable<KiwoomAccountGetGoldTradeItem>? Items;
	}
	public record KiwoomAccountGetGoldTradeItem
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 종목번호
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TransactionType;
		/// <summary>
		/// 신용구분
		/// </summary>
		[JsonProperty("crd_tp")]
		public string? CreditType;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderPrice;
		/// <summary>
		/// 확인수량
		/// </summary>
		[JsonProperty("cnfm_qty")]
		public decimal? ConfirmQuantity;
		/// <summary>
		/// 접수구분
		/// </summary>
		[JsonProperty("acpt_tp")]
		public string? ReceiptType;
		/// <summary>
		/// 반대여부
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReversedType;
		/// <summary>
		/// 주문시간
		/// </summary>
		[JsonProperty("ord_tm")]
		public string? OrderTime;
		/// <summary>
		/// 원주문
		/// </summary>
		[JsonProperty("ori_ord")]
		public string? OriginalId;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public string? OrderType;
		/// <summary>
		/// 대출일
		/// </summary>
		[JsonProperty("loan_dt")]
		public string? LoanDate;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradePrice;
		/// <summary>
		/// 주문잔량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? OrderRemainQuantity;
		/// <summary>
		/// 통신구분
		/// </summary>
		[JsonProperty("comm_ord_tp")]
		public string? CommunicationType;
		/// <summary>
		/// 정정취소
		/// </summary>
		[JsonProperty("mdfy_cncl")]
		public string? ModifyCancelType;
		/// <summary>
		/// 확인시간
		/// </summary>
		[JsonProperty("cnfm_tm")]
		public string? ConfirmTime;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticStockExchangeType;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("cond_uv")]
		public decimal? StopPrice;
	}

	public record KiwoomAccountGetGoldTradeHistories
	{
		/// <summary>
		/// 계좌번호
		/// </summary>
		[JsonProperty("acnt_print")]
		public string? AccountId;
		/// <summary>
		/// 금현물거래내역 리스트
		/// </summary>
		[JsonProperty("gold_trde_hist")]
		public IEnumerable<KiwoomAccountGetGoldTradeHistoryItem>? Items;
	}
	public record KiwoomAccountGetGoldTradeHistoryItem
	{
		/// <summary>
		/// 거래일자
		/// </summary>
		[JsonProperty("deal_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TransactionDate;
		/// <summary>
		/// 거래번호
		/// </summary>
		[JsonProperty("deal_no")]
		public string? TradeId;
		/// <summary>
		/// 적요명
		/// </summary>
		[JsonProperty("rmrk_nm")]
		public string? Remarks;
		/// <summary>
		/// 거래수량
		/// </summary>
		[JsonProperty("deal_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 금현물부가가치세
		/// </summary>
		[JsonProperty("gold_spot_vat")]
		public decimal? GoldSpotValueAddedTax;
		/// <summary>
		/// 정산금액
		/// </summary>
		[JsonProperty("exct_amt")]
		public decimal? Settlement;
		/// <summary>
		/// 연체합
		/// </summary>
		[JsonProperty("dly_sum")]
		public decimal? TotalOverdueAmount;
		/// <summary>
		/// 예수금잔고
		/// </summary>
		[JsonProperty("entra_remn")]
		public decimal? DepositBalance;
		/// <summary>
		/// 메체구분명
		/// </summary>
		[JsonProperty("mdia_nm")]
		public string? MediaTypeName;
		/// <summary>
		/// 원거래번호
		/// </summary>
		[JsonProperty("orig_deal_no")]
		public string? OriginalTradeId;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 거래단가
		/// </summary>
		[JsonProperty("uv_exrt")]
		public decimal? TradePrice;
		/// <summary>
		/// 수수료
		/// </summary>
		[JsonProperty("cmsn")]
		public decimal? Fee;
		/// <summary>
		/// 미수(원/g)
		/// </summary>
		[JsonProperty("uncl_ocr")]
		public decimal? UnsettledAmount;
		/// <summary>
		/// 변제합
		/// </summary>
		[JsonProperty("rpym_sum")]
		public decimal? TotalRepayment;
		/// <summary>
		/// 현물잔고
		/// </summary>
		[JsonProperty("spot_remn")]
		public decimal? SpotBalance;
		/// <summary>
		/// 처리시간
		/// </summary>
		[JsonProperty("proc_time")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ProcessingTime;
		/// <summary>
		/// 출납번호
		/// </summary>
		[JsonProperty("rcpy_no")]
		public string? PaymentId;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 거래금액
		/// </summary>
		[JsonProperty("deal_amt")]
		public decimal? TradeAmount;
		/// <summary>
		/// 소득/주민세
		/// </summary>
		[JsonProperty("tax_tot_amt")]
		public decimal? IncomeResidentTax;
		/// <summary>
		/// 체결일
		/// </summary>
		[JsonProperty("cntr_dt")]
		public string? TradeDate;
		/// <summary>
		/// 처리점
		/// </summary>
		[JsonProperty("proc_brch_nm")]
		public string? ProcessingBranch;
		/// <summary>
		/// 처리자
		/// </summary>
		[JsonProperty("prcsr")]
		public string? Processor;
	}

	public record KiwoomAccountGetGoldUnfilledOrders
	{
		/// <summary>
		/// 계좌별주문미체결현황
		/// </summary>
		[JsonProperty("acnt_ord_oso_prst")]
		public IEnumerable<KiwoomAccountGetGoldUnfilledOrderItem>? Items;
	}
	public record KiwoomAccountGetGoldUnfilledOrderItem
	{
		/// <summary>
		/// 주식채권구분
		/// </summary>
		[JsonProperty("stk_bond_tp")]
		public string? StockBondType;
		/// <summary>
		/// 주문번호
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 상품코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 매매구분
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TransactionType;
		/// <summary>
		/// 주문유형구분
		/// </summary>
		[JsonProperty("io_tp_nm")]
		public string? OrderTypeName;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderPrice;
		/// <summary>
		/// 확인수량
		/// </summary>
		[JsonProperty("cnfm_qty")]
		public decimal? ConfirmQuantity;
		/// <summary>
		/// 접수구분
		/// </summary>
		[JsonProperty("data_send_end_tp")]
		public string? ReceiptType;
		/// <summary>
		/// 시장구분
		/// </summary>
		[JsonProperty("mrkt_deal_tp")]
		public string? MarketType;
		/// <summary>
		/// 예약/반대여부
		/// </summary>
		[JsonProperty("rsrv_tp")]
		public string? ReservedType;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[JsonProperty("orig_ord_no")]
		public string? OriginalOrderId;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 결제구분
		/// </summary>
		[JsonProperty("dcd_tp_nm")]
		public string? SettlementType;
		/// <summary>
		/// 신용거래구분
		/// </summary>
		[JsonProperty("crd_deal_tp")]
		public string? CreditTransactionType;
		/// <summary>
		/// 체결수량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 체결단가
		/// </summary>
		[JsonProperty("cntr_uv")]
		public decimal? TradePrice;
		/// <summary>
		/// 미체결수량
		/// </summary>
		[JsonProperty("ord_remnq")]
		public decimal? UnfilledQuantity;
		/// <summary>
		/// 통신구분
		/// </summary>
		[JsonProperty("comm_ord_tp")]
		public string? CommunicationType;
		/// <summary>
		/// 정정취소구분
		/// </summary>
		[JsonProperty("mdfy_cncl_tp")]
		public string? ModifyCancelType;
		/// <summary>
		/// 국내거래소구분
		/// </summary>
		[JsonProperty("dmst_stex_tp")]
		public string? DomesticStockExchangeType;
		/// <summary>
		/// 스톱가
		/// </summary>
		[JsonProperty("cond_uv")]
		public decimal? StopPrice;
	}
}
