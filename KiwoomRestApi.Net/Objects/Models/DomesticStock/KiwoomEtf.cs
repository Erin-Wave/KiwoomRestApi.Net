using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.DomesticStock.Etf;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.DomesticStock
{
	public record KiwoomEtfGetProfitRates
	{
		/// <summary>
		/// ETF수익율 리스트
		/// </summary>
		[JsonProperty("etfprft_rt_lst")]
		public IEnumerable<KiwoomEtfGetProfitRateItem>? Items;
	}
	public record KiwoomEtfGetProfitRateItem
	{
		/// <summary>
		/// ETF수익률
		/// </summary>
		[JsonProperty("etfprft_rt")]
		public KiwoomDecimal? EtfProfitRate;
		/// <summary>
		/// 체결수익률
		/// </summary>
		[JsonProperty("cntr_prft_rt")]
		public KiwoomDecimal? TradeProfitRate;
		/// <summary>
		/// 외인순매수수량
		/// </summary>
		[JsonProperty("for_netprps_qty")]
		public decimal? ForeignNetBuyQuantity;
		/// <summary>
		/// 기관순매수수량
		/// </summary>
		[JsonProperty("orgn_netprps_qty")]
		public decimal? InstitutionNetBuyQuantity;
	}

	public record KiwoomEtfGetStockInfo
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// ETF대상지수명
		/// </summary>
		[JsonProperty("etfobjt_idex_nm")]
		public string? EtfTargetIndexName;
		/// <summary>
		/// 원주가격
		/// </summary>
		[JsonProperty("wonju_pric")]
		public decimal? OriginalPrice;
		/// <summary>
		/// ETF과세유형
		/// </summary>
		[JsonProperty("etftxon_type")]
		public string? EtfTaxType;
		/// <summary>
		/// ETN과세유형
		/// </summary>
		[JsonProperty("etntxon_type")]
		public string? EtnTaxType;
	}

	public record KiwoomEtfGetDailyTransactions
	{
		/// <summary>
		/// ETF일별추이 리스트
		/// </summary>
		[JsonProperty("etfdaly_trnsn")]
		public IEnumerable<KiwoomEtfGetDailyTransactionItem>? Items;
	}
	public record KiwoomEtfGetDailyTransactionItem
	{
		/// <summary>
		/// 체결일자
		/// </summary>
		[JsonProperty("cntr_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeDate;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// NAV
		/// </summary>
		[JsonProperty("nav")]
		public KiwoomDecimal? Nav;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// NAV/지수괴리율
		/// </summary>
		[JsonProperty("navidex_dispty_rt")]
		public decimal? NavIndexDisparityRate;
		/// <summary>
		/// NAV/ETF괴리율
		/// </summary>
		[JsonProperty("navetfdispty_rt")]
		public decimal? NavEtfDisparityRate;
		/// <summary>
		/// 추적오차율
		/// </summary>
		[JsonProperty("trace_eor_rt")]
		public decimal? TrackingErrorRate;
		/// <summary>
		/// 추적현재가
		/// </summary>
		[JsonProperty("trace_cur_prc")]
		public decimal? TrackingCurrentPrice;
		/// <summary>
		/// 추적전일대비
		/// </summary>
		[JsonProperty("trace_pred_pre")]
		public decimal? TrackingChange;
		/// <summary>
		/// 추적대비기호
		/// </summary>
		[JsonProperty("trace_pre_sig")]
		public string? TrackingChangeSign;
	}

	public record KiwoomEtfGetAllMarketPrices
	{
		/// <summary>
		/// ETF전체시세 리스트
		/// </summary>
		[JsonProperty("etfall_mrpr")]
		public IEnumerable<KiwoomEtfGetAllMarketPriceItem>? Items;
	}
	public record KiwoomEtfGetAllMarketPriceItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 종목분류
		/// </summary>
		[JsonProperty("stk_cls")]
		public string? StockType;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// NAV
		/// </summary>
		[JsonProperty("nav")]
		public decimal? Nav;
		/// <summary>
		/// 추적오차율
		/// </summary>
		[JsonProperty("trace_eor_rt")]
		public decimal? TrackingErrorRate;
		/// <summary>
		/// 과표기준
		/// </summary>
		[JsonProperty("txbs")]
		public string? TaxBase;
		/// <summary>
		/// 배당전기준
		/// </summary>
		[JsonProperty("dvid_bf_base")]
		public string? DividendBeforeBase;
		/// <summary>
		/// 전일배당금
		/// </summary>
		[JsonProperty("pred_dvida")]
		public decimal? PreviousDayDividend;
		/// <summary>
		/// 추적지수명
		/// </summary>
		[JsonProperty("trace_idex_nm")]
		public string? TrackingIndexName;
		/// <summary>
		/// 배수
		/// </summary>
		[JsonProperty("drng")]
		public decimal? Multiple;
		/// <summary>
		/// 추적지수코드
		/// </summary>
		[JsonProperty("trace_idex_cd")]
		public string? TrackingIndexCode;
		/// <summary>
		/// 추적지수
		/// </summary>
		[JsonProperty("trace_idex")]
		public decimal? TrackingIndex;
		/// <summary>
		/// 추적등락율
		/// </summary>
		[JsonProperty("trace_flu_rt")]
		public decimal? TrackingChangeRate;
	}

	public record KiwoomEtfGetHourlyTransactions
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// ETF대상지수명
		/// </summary>
		[JsonProperty("etfobjt_idex_nm")]
		public string? EtfTargetIndexName;
		/// <summary>
		/// 원주가격
		/// </summary>
		[JsonProperty("wonju_pric")]
		public decimal? OriginalPrice;
		/// <summary>
		/// ETF과세유형
		/// </summary>
		[JsonProperty("etftxon_type")]
		public string? EtfTaxType;
		/// <summary>
		/// ETN과세유형
		/// </summary>
		[JsonProperty("etntxon_type")]
		public string? EtnTaxType;
		/// <summary>
		/// ETF시간대별추이
		/// </summary>
		[JsonProperty("etftisl_trnsn")]
		public IEnumerable<KiwoomEtfGetHourlyTransactionItem>? Items;
	}
	public record KiwoomEtfGetHourlyTransactionItem
	{
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// NAV
		/// </summary>
		[JsonProperty("nav")]
		public KiwoomDecimal? Nav;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// NAV지수
		/// </summary>
		[JsonProperty("navidex")]
		public KiwoomDecimal? NavIndex;
		/// <summary>
		/// NAVETF
		/// </summary>
		[JsonProperty("navetf")]
		public KiwoomDecimal? NavEtf;
		/// <summary>
		/// 추적
		/// </summary>
		[JsonProperty("trace")]
		public decimal? Tracking;
		/// <summary>
		/// 추적지수
		/// </summary>
		[JsonProperty("trace_idex")]
		public KiwoomDecimal? TrackingIndex;
		/// <summary>
		/// 추적지수전일대비
		/// </summary>
		[JsonProperty("trace_idex_pred_pre")]
		public KiwoomDecimal? TrackingIndexChange;
		/// <summary>
		/// 추적지수전일대비기호
		/// </summary>
		[JsonProperty("trace_idex_pred_pre_sig")]
		public string? TrackingIndexChangeSign;
	}

	public record KiwoomEtfGetHourlyTrades
	{
		/// <summary>
		/// 종목분류
		/// </summary>
		[JsonProperty("stk_cls")]
		public string? StockType;
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// ETF대상지수명
		/// </summary>
		[JsonProperty("etfobjt_idex_nm")]
		public string? EtfTargetIndexName;
		/// <summary>
		/// ETF대상지수코드
		/// </summary>
		[JsonProperty("etfobjt_idex_cd")]
		public string? EtfTargetIndexCode;
		/// <summary>
		/// 대상지수대비율
		/// </summary>
		[JsonProperty("objt_idex_pre_rt")]
		public decimal? TargetIndexChangeRate;
		/// <summary>
		/// 원주가격
		/// </summary>
		[JsonProperty("wonju_pric")]
		public KiwoomDecimal? OriginalPrice;
		/// <summary>
		/// ETF시간대별체결배열 리스트
		/// </summary>
		[JsonProperty("etftisl_cntr_array")]
		public IEnumerable<KiwoomEtfGetHourlyTradeItem>? Items;
	}
	public record KiwoomEtfGetHourlyTradeItem
	{
		/// <summary>
		/// 체결시간 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomEtfStockExchangeType? StockExchangeType;
	}

	public record KiwoomEtfGetDailyTrades
	{
		/// <summary>
		/// 거래시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// ETF순매수수량배열 리스트
		/// </summary>
		[JsonProperty("etfnetprps_qty_array")]
		public IEnumerable<KiwoomEtfGetDailyTradeItem>? Items;
	}
	public record KiwoomEtfGetDailyTradeItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc_n")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig_n")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre_n")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 외인순매수수량
		/// </summary>
		[JsonProperty("for_netprps_qty")]
		public KiwoomDecimal? ForeignNetBuyQuantity;
		/// <summary>
		/// 기관순매수수량
		/// </summary>
		[JsonProperty("orgn_netprps_qty")]
		public KiwoomDecimal? InstitutionNetBuyQuantity;
	}

	public record KiwoomEtfGetHourlyTrades2
	{
		/// <summary>
		/// ETFNAV배열 리스트
		/// </summary>
		[JsonProperty("etfnavarray")]
		public IEnumerable<KiwoomEtfGetHourlyTrades2Item>? Items;
	}
	public record KiwoomEtfGetHourlyTrades2Item
	{
		/// <summary>
		/// NAV
		/// </summary>
		[JsonProperty("nav")]
		public decimal? Nav;
		/// <summary>
		/// NAV전일대비
		/// </summary>
		[JsonProperty("navpred_pre")]
		public decimal? NavChange;
		/// <summary>
		/// NAV등락율
		/// </summary>
		[JsonProperty("navflu_rt")]
		public decimal? NavChangeRate;
		/// <summary>
		/// 추적오차율
		/// </summary>
		[JsonProperty("trace_eor_rt")]
		public decimal? TrackingErrorRate;
		/// <summary>
		/// 괴리율
		/// </summary>
		[JsonProperty("dispty_rt")]
		public decimal? DisparityRate;
		/// <summary>
		/// 주식수
		/// </summary>
		[JsonProperty("stkcnt")]
		public int? StockCount;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 외인보유수량
		/// </summary>
		[JsonProperty("for_rmnd_qty")]
		public decimal? ForeignHoldingQuantity;
		/// <summary>
		/// 대용가
		/// </summary>
		[JsonProperty("repl_pric")]
		public decimal? SubstitutePrice;
		/// <summary>
		/// 환산가격
		/// </summary>
		[JsonProperty("conv_pric")]
		public decimal? ConvertedPrice;
		/// <summary>
		/// DR/주
		/// </summary>
		[JsonProperty("drstk")]
		public decimal? DrPerStock;
		/// <summary>
		/// 원주가격
		/// </summary>
		[JsonProperty("wonju_pric")]
		public decimal? OriginalPrice;
	}

	public record KiwoomEtfGetHourlyTransactions2
	{
		/// <summary>
		/// ETF시간대별추이 리스트
		/// </summary>
		[JsonProperty("etftisl_trnsn")]
		public IEnumerable<KiwoomEtfGetHourlyTransactionItem2>? Items;
	}
	public record KiwoomEtfGetHourlyTransactionItem2
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[JsonProperty("for_netprps")]
		public KiwoomDecimal? ForeignNetBuy;
	}

}
