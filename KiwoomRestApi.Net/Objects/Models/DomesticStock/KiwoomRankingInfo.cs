using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.DomesticStock
{
	public record KiwoomRankingInfoGetOrderBookTops
	{
		/// <summary>
		/// 호가잔량상위 목록
		/// </summary>
		[JsonProperty("bid_req_upper")]
		public IEnumerable<KiwoomRankingInfoGetOrderBookTopItem>? Items;
	}
	public record KiwoomRankingInfoGetOrderBookTopItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRemainQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRemainQuantity;
		/// <summary>
		/// 순매수잔량
		/// </summary>
		[JsonProperty("netprps_req")]
		public decimal? NetBuyRemainQuantity;
		/// <summary>
		/// 매수비율
		/// </summary>
		[JsonProperty("buy_rt")]
		public decimal? BuyRate;
	}

	public record KiwoomRankingInfoGetOrderBookSpikes
	{
		/// <summary>
		/// 호가잔량급증 목록
		/// </summary>
		[JsonProperty("bid_req_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetOrderBookSpikeItem>? Items;
	}
	public record KiwoomRankingInfoGetOrderBookSpikeItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 기준비율
		/// </summary>
		[JsonProperty("int")]
		public decimal? StandardRate;
		/// <summary>
		/// 현재값
		/// </summary>
		[JsonProperty("now")]
		public decimal? CurrentValue;
		/// <summary>
		/// 급증량
		/// </summary>
		[JsonProperty("sdnin_qty")]
		public decimal? SpikeQuantity;
		/// <summary>
		/// 급증비율
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public KiwoomDecimal? SpikeRate;
		/// <summary>
		/// 총매수량
		/// </summary>
		[JsonProperty("tot_buy_qty")]
		public decimal? TotalBuyQuantity;
	}

	public record KiwoomRankingInfoGetRemainQuantityRateSpikes
	{
		/// <summary>
		/// 잔량율급증 목록
		/// </summary>
		[JsonProperty("req_rt_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetRemainQuantityRateSpikeItem>? Items;
	}
	public record KiwoomRankingInfoGetRemainQuantityRateSpikeItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 기준비율
		/// </summary>
		[JsonProperty("int")]
		public KiwoomDecimal? StandardRate;
		/// <summary>
		/// 현재비율
		/// </summary>
		[JsonProperty("now_rt")]
		public KiwoomDecimal? CurrentRate;
		/// <summary>
		/// 급증비율
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public KiwoomDecimal? SpikeRate;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellRemainQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyRemainQuantity;
	}

	public record KiwoomRankingInfoGetVolumeSpikes
	{
		/// <summary>
		/// 거래량 급증 목록
		/// </summary>
		[JsonProperty("trde_qty_sdnin")]
		public IEnumerable<KiwoomRankingInfoGetVolumeSpikeItem>? Items;
	}
	public record KiwoomRankingInfoGetVolumeSpikeItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
		/// 전일거래량
		/// </summary>
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
		/// <summary>
		/// 급증량
		/// </summary>
		[JsonProperty("sdnin_qty")]
		public KiwoomDecimal? SpikeQuantity;
		/// <summary>
		/// 급증비율
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public KiwoomDecimal? SpikeRate;
	}

	public record KiwoomRankingInfoGetChangeRateTops
	{
		/// <summary>
		/// 전일대비 등락율 상위 목록
		/// </summary>
		[JsonProperty("pred_pre_flu_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetChangeRateTopItem>? Items;
	}

	public record KiwoomRankingInfoGetChangeRateTopItem
	{
		/// <summary>
		/// 종목분류
		/// </summary>
		[JsonProperty("stk_cls")]
		public string? StockClass;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainQuantity;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 건수
		/// </summary>
		[JsonProperty("cnt")]
		public int? Count;
	}

	public record KiwoomRankingInfoGetExpectedTradeChangeRateTops
	{
		/// <summary>
		/// 예상체결 등락율 상위 목록
		/// </summary>
		[JsonProperty("exp_cntr_flu_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetExpectedTradeChangeRateTopItem>? Items;
	}
	public record KiwoomRankingInfoGetExpectedTradeChangeRateTopItem
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
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public decimal? ExpectedTradePrice;
		/// <summary>
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
		/// 예상체결량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedTradeQuantity;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
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
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainQuantity;
	}


	public record KiwoomRankingInfoGetTodayVolumeTops
	{
		/// <summary>
		/// 당일거래량상위
		/// </summary>
		[JsonProperty("tdy_trde_qty_upper")]
		public IEnumerable<KiwoomRankingInfoGetTodayVolumeTopItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayVolumeTopItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public KiwoomDecimal? PreviousDayRate;
		/// <summary>
		/// 거래회전율
		/// </summary>
		[JsonProperty("trde_tern_rt")]
		public KiwoomDecimal? TradeTurnoverRate;
		/// <summary>
		/// 거래금액
		/// </summary>
		[JsonProperty("trde_amt")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 장중거래량
		/// </summary>
		[JsonProperty("opmr_trde_qty")]
		public decimal? IntradayVolume;
		/// <summary>
		/// 장중전일비
		/// </summary>
		[JsonProperty("opmr_pred_rt")]
		public decimal? IntradayPreviousDayRate;
		/// <summary>
		/// 장중거래회전율
		/// </summary>
		[JsonProperty("opmr_trde_rt")]
		public KiwoomDecimal? IntradayTradeTurnoverRate;
		/// <summary>
		/// 장중거래금액
		/// </summary>
		[JsonProperty("opmr_trde_amt")]
		public decimal? IntradayTransactionAmount;
		/// <summary>
		/// 장후거래량
		/// </summary>
		[JsonProperty("af_mkrt_trde_qty")]
		public decimal? AfterMarketVolume;
		/// <summary>
		/// 장후전일비
		/// </summary>
		[JsonProperty("af_mkrt_pred_rt")]
		public decimal? AfterMarketPreviousDayRate;
		/// <summary>
		/// 장후거래회전율
		/// </summary>
		[JsonProperty("af_mkrt_trde_rt")]
		public KiwoomDecimal? AfterMarketTradeTurnoverRate;
		/// <summary>
		/// 장후거래금액
		/// </summary>
		[JsonProperty("af_mkrt_trde_amt")]
		public decimal? AfterMarketTransactionAmount;
		/// <summary>
		/// 장전거래량
		/// </summary>
		[JsonProperty("bf_mkrt_trde_qty")]
		public decimal? BeforeMarketVolume;
		/// <summary>
		/// 장전전일비
		/// </summary>
		[JsonProperty("bf_mkrt_pred_rt")]
		public decimal? BeforeMarketPreviousDayRate;
		/// <summary>
		/// 장전거래회전율
		/// </summary>
		[JsonProperty("bf_mkrt_trde_rt")]
		public KiwoomDecimal? BeforeMarketTradeTurnoverRate;
		/// <summary>
		/// 장전거래금액
		/// </summary>
		[JsonProperty("bf_mkrt_trde_amt")]
		public decimal? BeforeMarketTransactionAmount;
	}

	public record KiwoomRankingInfoGetPreviousDayVolumeTops
	{
		/// <summary>
		/// 전일거래량상위
		/// </summary>
		[JsonProperty("pred_trde_qty_upper")]
		public IEnumerable<KiwoomRankingInfoGetPreviousDayVolumeTopItem>? Items;
	}
	public record KiwoomRankingInfoGetPreviousDayVolumeTopItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
	}

	public record KiwoomRankingInfoGetTransactionAmountTops
	{
		/// <summary>
		/// 거래대금상위
		/// </summary>
		[JsonProperty("trde_prica_upper")]
		public IEnumerable<KiwoomRankingInfoGetTransactionAmountTopItem>? Items;
	}
	public record KiwoomRankingInfoGetTransactionAmountTopItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 현재순위
		/// </summary>
		[JsonProperty("now_rank")]
		public int? CurrentRank;
		/// <summary>
		/// 전일순위
		/// </summary>
		[JsonProperty("pred_rank")]
		public int? PreviousRank;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
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
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
	}

	public record KiwoomRankingInfoGetCreditRateTops
	{
		/// <summary>
		/// 신용비율상위
		/// </summary>
		[JsonProperty("crd_rt_upper")]
		public IEnumerable<KiwoomRankingInfoGetCreditRateTopItem>? Items;
	}
	public record KiwoomRankingInfoGetCreditRateTopItem
	{
		/// <summary>
		/// 종목정보
		/// </summary>
		[JsonProperty("stk_infr")]
		public string? StockInfo;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 신용비율
		/// </summary>
		[JsonProperty("crd_rt")]
		public KiwoomDecimal? CreditRate;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[JsonProperty("buy_req")]
		public decimal? BuyRemainQuantity;
		/// <summary>
		/// 현재거래량
		/// </summary>
		[JsonProperty("now_trde_qty")]
		public decimal? CurrentVolume;
	}

	public record KiwoomRankingInfoGetForeignPeriodTransactionTops
	{
		/// <summary>
		/// 외인기간별매매상위
		/// </summary>
		[JsonProperty("for_dt_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignPeriodTransactionTopItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignPeriodTransactionTopItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
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
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 순매수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetBuyQuantity;
		/// <summary>
		/// 취득가능주식수
		/// </summary>
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? AcquirableQuantity;
	}

	public record KiwoomRankingInfoGetForeignContinuousNetTransactionTops
	{
		/// <summary>
		/// 외인연속순매매상위
		/// </summary>
		[JsonProperty("for_cont_nettrde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignContinuousNetTransactionTopItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignContinuousNetTransactionTopItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// D-1
		/// </summary>
		[JsonProperty("dm1")]
		public KiwoomDecimal? PreviousDay1;
		/// <summary>
		/// D-2
		/// </summary>
		[JsonProperty("dm2")]
		public KiwoomDecimal? PreviousDay2;
		/// <summary>
		/// D-3
		/// </summary>
		[JsonProperty("dm3")]
		public KiwoomDecimal? PreviousDay3;
		/// <summary>
		/// 합계
		/// </summary>
		[JsonProperty("tot")]
		public KiwoomDecimal? Total;
		/// <summary>
		/// 한도소진율
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public KiwoomDecimal? LimitUsageRate;
		/// <summary>
		/// 전일대비1
		/// </summary>
		[JsonProperty("pred_pre_1")]
		public KiwoomDecimal? Change1;
		/// <summary>
		/// 전일대비2
		/// </summary>
		[JsonProperty("pred_pre_2")]
		public KiwoomDecimal? Change2;
		/// <summary>
		/// 전일대비3
		/// </summary>
		[JsonProperty("pred_pre_3")]
		public KiwoomDecimal? Change3;
	}

	public record KiwoomRankingInfoGetForeignLimitUsageRateIncreaseTops
	{
		/// <summary>
		/// 외인한도소진율증가상위
		/// </summary>
		[JsonProperty("for_limit_exh_rt_incrs_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignLimitUsageRateIncreaseTopItem>? Items;
	}

	public record KiwoomRankingInfoGetForeignLimitUsageRateIncreaseTopItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
		/// 보유주식수
		/// </summary>
		[JsonProperty("poss_stkcnt")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 취득가능주식수
		/// </summary>
		[JsonProperty("gain_pos_stkcnt")]
		public decimal? AcquirableQuantity;
		/// <summary>
		/// 기준한도소진율
		/// </summary>
		[JsonProperty("base_limit_exh_rt")]
		public KiwoomDecimal? BaseLimitUsageRate;
		/// <summary>
		/// 한도소진율
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public KiwoomDecimal? LimitUsageRate;
		/// <summary>
		/// 소진율증가
		/// </summary>
		[JsonProperty("exh_rt_incrs")]
		public KiwoomDecimal? UsageRateIncrease;
	}

	public record KiwoomRankingInfoGetForeignWicketTransactionTops
	{
		/// <summary>
		/// 외국계창구매매상위
		/// </summary>
		[JsonProperty("frgn_wicket_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignWicketTransactionTopItem>? Items;
	}

	public record KiwoomRankingInfoGetForeignWicketTransactionTopItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
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
		/// 매도거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public KiwoomDecimal? SellVolume;
		/// <summary>
		/// 매수거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public KiwoomDecimal? BuyVolume;
		/// <summary>
		/// 순매수거래량
		/// </summary>
		[JsonProperty("netprps_trde_qty")]
		public KiwoomDecimal? NetBuyVolume;
		/// <summary>
		/// 순매수대금
		/// </summary>
		[JsonProperty("netprps_prica")]
		public KiwoomDecimal? NetBuyAmount;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
	}

	public record KiwoomRankingInfoGetStockSecuritiesRanks
	{
		/// <summary>
		/// 순위1
		/// </summary>
		[JsonProperty("rank_1")]
		public KiwoomDecimal? Rank1;
		/// <summary>
		/// 순위2
		/// </summary>
		[JsonProperty("rank_2")]
		public KiwoomDecimal? Rank2;
		/// <summary>
		/// 순위3
		/// </summary>
		[JsonProperty("rank_3")]
		public KiwoomDecimal? Rank3;
		/// <summary>
		/// 기간중거래량
		/// </summary>
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodVolume;
		/// <summary>
		/// 종목별증권사순위
		/// </summary>
		[JsonProperty("stk_sec_rank")]
		public IEnumerable<KiwoomRankingInfoGetStockSecuritiesRankItem>? Items;
	}

	public record KiwoomRankingInfoGetStockSecuritiesRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 회원사명
		/// </summary>
		[JsonProperty("mmcm_nm")]
		public string? MemberCompanyName;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public KiwoomDecimal? BuyQuantity;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public KiwoomDecimal? SellQuantity;
		/// <summary>
		/// 누적순매수수량
		/// </summary>
		[JsonProperty("acc_netprps_qty")]
		public KiwoomDecimal? AccumulatedNetBuyQuantity;
	}

	public record KiwoomRankingInfoGetSecuritiesTransactionTops
	{
		/// <summary>
		/// 증권사별매매상위
		/// </summary>
		[JsonProperty("sec_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetSecuritiesTransactionTopItem>? Items;
	}

	public record KiwoomRankingInfoGetSecuritiesTransactionTopItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 기간중주가등락
		/// </summary>
		[JsonProperty("prid_stkpc_flu")]
		public KiwoomDecimal? PeriodPriceChange;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 기간중거래량
		/// </summary>
		[JsonProperty("prid_trde_qty")]
		public decimal? PeriodVolume;
		/// <summary>
		/// 순매수
		/// </summary>
		[JsonProperty("netprps")]
		public KiwoomDecimal? NetBuy;
		/// <summary>
		/// 매수거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public KiwoomDecimal? BuyVolume;
		/// <summary>
		/// 매도거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public KiwoomDecimal? SellVolume;
		/// <summary>
		/// 순매수금액 (단위: 천원)
		/// </summary>
		[JsonProperty("netprps_amt")]
		public KiwoomDecimal? NetBuyAmount;
		/// <summary>
		/// 매수금액 (단위: 천원)
		/// </summary>
		[JsonProperty("buy_amt")]
		public KiwoomDecimal? BuyAmount;
		/// <summary>
		/// 매도금액 (단위: 천원)
		/// </summary>
		[JsonProperty("sell_amt")]
		public KiwoomDecimal? SellAmount;
	}

	public record KiwoomRankingInfoGetTodayMainBrokers
	{
		/// <summary>
		/// 매도거래원별증감1
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_1")]
		public KiwoomDecimal? SellBrokerChange1;
		/// <summary>
		/// 매도거래원수량1
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_1")]
		public KiwoomDecimal? SellBrokerQuantity1;
		/// <summary>
		/// 매도거래원1
		/// </summary>
		[JsonProperty("sel_trde_ori_1")]
		public string? SellBroker1;
		/// <summary>
		/// 매도거래원코드1
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_1")]
		public string? SellBrokerCode1;
		/// <summary>
		/// 매수거래원1
		/// </summary>
		[JsonProperty("buy_trde_ori_1")]
		public string? BuyBroker1;
		/// <summary>
		/// 매수거래원코드1
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_1")]
		public string? BuyBrokerCode1;
		/// <summary>
		/// 매수거래원수량1
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_1")]
		public KiwoomDecimal? BuyBrokerQuantity1;
		/// <summary>
		/// 매수거래원별증감1
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_1")]
		public KiwoomDecimal? BuyBrokerChange1;
		/// <summary>
		/// 매도거래원별증감2
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_2")]
		public KiwoomDecimal? SellBrokerChange2;
		/// <summary>
		/// 매도거래원수량2
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_2")]
		public KiwoomDecimal? SellBrokerQuantity2;
		/// <summary>
		/// 매도거래원2
		/// </summary>
		[JsonProperty("sel_trde_ori_2")]
		public string? SellBroker2;
		/// <summary>
		/// 매도거래원코드2
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_2")]
		public string? SellBrokerCode2;
		/// <summary>
		/// 매수거래원2
		/// </summary>
		[JsonProperty("buy_trde_ori_2")]
		public string? BuyBroker2;
		/// <summary>
		/// 매수거래원코드2
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_2")]
		public string? BuyBrokerCode2;
		/// <summary>
		/// 매수거래원수량2
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_2")]
		public KiwoomDecimal? BuyBrokerQuantity2;
		/// <summary>
		/// 매수거래원별증감2
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_2")]
		public KiwoomDecimal? BuyBrokerChange2;
		/// <summary>
		/// 매도거래원별증감3
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_3")]
		public KiwoomDecimal? SellBrokerChange3;
		/// <summary>
		/// 매도거래원수량3
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_3")]
		public KiwoomDecimal? SellBrokerQuantity3;
		/// <summary>
		/// 매도거래원3
		/// </summary>
		[JsonProperty("sel_trde_ori_3")]
		public string? SellBroker3;
		/// <summary>
		/// 매도거래원코드3
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_3")]
		public string? SellBrokerCode3;
		/// <summary>
		/// 매수거래원3
		/// </summary>
		[JsonProperty("buy_trde_ori_3")]
		public string? BuyBroker3;
		/// <summary>
		/// 매수거래원코드3
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_3")]
		public string? BuyBrokerCode3;
		/// <summary>
		/// 매수거래원수량3
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_3")]
		public KiwoomDecimal? BuyBrokerQuantity3;
		/// <summary>
		/// 매수거래원별증감3
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_3")]
		public KiwoomDecimal? BuyBrokerChange3;
		/// <summary>
		/// 매도거래원별증감4
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_4")]
		public KiwoomDecimal? SellBrokerChange4;
		/// <summary>
		/// 매도거래원수량4
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_4")]
		public KiwoomDecimal? SellBrokerQuantity4;
		/// <summary>
		/// 매도거래원4
		/// </summary>
		[JsonProperty("sel_trde_ori_4")]
		public string? SellBroker4;
		/// <summary>
		/// 매도거래원코드4
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_4")]
		public string? SellBrokerCode4;
		/// <summary>
		/// 매수거래원4
		/// </summary>
		[JsonProperty("buy_trde_ori_4")]
		public string? BuyBroker4;
		/// <summary>
		/// 매수거래원코드4
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_4")]
		public string? BuyBrokerCode4;
		/// <summary>
		/// 매수거래원수량4
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_4")]
		public KiwoomDecimal? BuyBrokerQuantity4;
		/// <summary>
		/// 매수거래원별증감4
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_4")]
		public KiwoomDecimal? BuyBrokerChange4;
		/// <summary>
		/// 매도거래원별증감5
		/// </summary>
		[JsonProperty("sel_trde_ori_irds_5")]
		public KiwoomDecimal? SellBrokerChange5;
		/// <summary>
		/// 매도거래원수량5
		/// </summary>
		[JsonProperty("sel_trde_ori_qty_5")]
		public KiwoomDecimal? SellBrokerQuantity5;
		/// <summary>
		/// 매도거래원5
		/// </summary>
		[JsonProperty("sel_trde_ori_5")]
		public string? SellBroker5;
		/// <summary>
		/// 매도거래원코드5
		/// </summary>
		[JsonProperty("sel_trde_ori_cd_5")]
		public string? SellBrokerCode5;
		/// <summary>
		/// 매수거래원5
		/// </summary>
		[JsonProperty("buy_trde_ori_5")]
		public string? BuyBroker5;
		/// <summary>
		/// 매수거래원코드5
		/// </summary>
		[JsonProperty("buy_trde_ori_cd_5")]
		public string? BuyBrokerCode5;
		/// <summary>
		/// 매수거래원수량5
		/// </summary>
		[JsonProperty("buy_trde_ori_qty_5")]
		public KiwoomDecimal? BuyBrokerQuantity5;
		/// <summary>
		/// 매수거래원별증감5
		/// </summary>
		[JsonProperty("buy_trde_ori_irds_5")]
		public KiwoomDecimal? BuyBrokerChange5;
		/// <summary>
		/// 외국계매도추정합변동
		/// </summary>
		[JsonProperty("frgn_sel_prsm_sum_chang")]
		public KiwoomDecimal? TotalForeignSellEstimateChange;
		/// <summary>
		/// 외국계매도추정합
		/// </summary>
		[JsonProperty("frgn_sel_prsm_sum")]
		public KiwoomDecimal? TotalForeignSellEstimate;
		/// <summary>
		/// 외국계매수추정합
		/// </summary>
		[JsonProperty("frgn_buy_prsm_sum")]
		public KiwoomDecimal? TotalForeignBuyEstimate;
		/// <summary>
		/// 외국계매수추정합변동
		/// </summary>
		[JsonProperty("frgn_buy_prsm_sum_chang")]
		public KiwoomDecimal? TotalForeignBuyEstimateChange;
		/// <summary>
		/// 당일주요거래원
		/// </summary>
		[JsonProperty("tdy_main_trde_ori")]
		public IEnumerable<KiwoomRankingInfoGetTodayMainBrokerItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayMainBrokerItem
	{
		/// <summary>
		/// 매도이탈시간
		/// </summary>
		[JsonProperty("sel_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? SellExitTime;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 매도상위이탈원
		/// </summary>
		[JsonProperty("sel_upper_scesn_ori")]
		public string? TopSellExitBroker;
		/// <summary>
		/// 매수이탈시간
		/// </summary>
		[JsonProperty("buy_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BuyExitTime;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매수상위이탈원
		/// </summary>
		[JsonProperty("buy_upper_scesn_ori")]
		public KiwoomString? TopBuyExitBroker;
		/// <summary>
		/// 조회일자
		/// </summary>
		[JsonProperty("qry_dt")]
		public string? QueryDate;
		/// <summary>
		/// 조회시간
		/// </summary>
		[JsonProperty("qry_tm")]
		public string? QueryTime;
	}

	public record KiwoomRankingInfoGetNetBuyBrokerRanks
	{
		/// <summary>
		/// 순매수거래원순위
		/// </summary>
		[JsonProperty("netprps_trde_ori_rank")]
		public IEnumerable<KiwoomRankingInfoGetNetBuyBrokerRankItem>? Items;
	}
	public record KiwoomRankingInfoGetNetBuyBrokerRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 회원사코드
		/// </summary>
		[JsonProperty("mmcm_cd")]
		public string? MemberCode;
		/// <summary>
		/// 회원사명
		/// </summary>
		[JsonProperty("mmcm_nm")]
		public string? MemberName;
	}

	public record KiwoomRankingInfoGetTodayTopExitBrokers
	{
		/// <summary>
		/// 당일상위이탈원
		/// </summary>
		[JsonProperty("tdy_upper_scesn_ori")]
		public IEnumerable<KiwoomRankingInfoGetTodayTopExitBrokerItem>? Items;
	}
	public record KiwoomRankingInfoGetTodayTopExitBrokerItem
	{
		/// <summary>
		/// 매도이탈시간
		/// </summary>
		[JsonProperty("sel_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? SellExitTime;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public decimal? SellQuantity;
		/// <summary>
		/// 매도상위이탈원
		/// </summary>
		[JsonProperty("sel_upper_scesn_ori")]
		public string? TopSellExitBroker;
		/// <summary>
		/// 매수이탈시간
		/// </summary>
		[JsonProperty("buy_scesn_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BuyExitTime;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매수상위이탈원
		/// </summary>
		[JsonProperty("buy_upper_scesn_ori")]
		public KiwoomString? TopBuyExitBroker;
		/// <summary>
		/// 조회일자
		/// </summary>
		[JsonProperty("qry_dt")]
		public string? QueryDate;
		/// <summary>
		/// 조회시간
		/// </summary>
		[JsonProperty("qry_tm")]
		public string? QueryTime;
	}

	public record KiwoomRankingInfoGetEqualNetTransactionRanks
	{
		/// <summary>
		/// 동일순매매순위
		/// </summary>
		[JsonProperty("eql_nettrde_rank")]
		public IEnumerable<KiwoomRankingInfoGetEqualNetTransactionRankItem>? Items;
	}
	public record KiwoomRankingInfoGetEqualNetTransactionRankItem
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 기관순매매수량
		/// </summary>
		[JsonProperty("orgn_nettrde_qty")]
		public KiwoomDecimal? InstitutionNetVolume;
		/// <summary>
		/// 기관순매매금액
		/// </summary>
		[JsonProperty("orgn_nettrde_amt")]
		public KiwoomDecimal? InstitutionNetTransactionAmount;
		/// <summary>
		/// 기관순매매평균가
		/// </summary>
		[JsonProperty("orgn_nettrde_avg_pric")]
		public decimal? InstitutionNetTransactionAveragePrice;
		/// <summary>
		/// 외인순매매수량
		/// </summary>
		[JsonProperty("for_nettrde_qty")]
		public KiwoomDecimal? ForeignerNetVolume;
		/// <summary>
		/// 외인순매매금액
		/// </summary>
		[JsonProperty("for_nettrde_amt")]
		public KiwoomDecimal? ForeignerNetTransactionAmount;
		/// <summary>
		/// 외인순매매평균가
		/// </summary>
		[JsonProperty("for_nettrde_avg_pric")]
		public decimal? ForeignerNetTransactionAveragePrice;
		/// <summary>
		/// 순매매수량
		/// </summary>
		[JsonProperty("nettrde_qty")]
		public KiwoomDecimal? NetVolume;
		/// <summary>
		/// 순매매금액
		/// </summary>
		[JsonProperty("nettrde_amt")]
		public KiwoomDecimal? NetTransactionAmount;
	}

	public record KiwoomRankingInfoGetOpenMarketInvestorTransactionTops
	{
		/// <summary>
		/// 장중투자자별매매상위
		/// </summary>
		[JsonProperty("opmr_invsr_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetOpenMarketInvestorTransactionTopItem>? Items;
	}
	public record KiwoomRankingInfoGetOpenMarketInvestorTransactionTopItem
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
		/// 매도량
		/// </summary>
		[JsonProperty("sel_qty")]
		public KiwoomDecimal? SellQuantity;
		/// <summary>
		/// 매수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public KiwoomDecimal? BuyQuantity;
		/// <summary>
		/// 순매도
		/// </summary>
		[JsonProperty("netslmt")]
		public KiwoomDecimal? NetSell;
	}

	public record KiwoomRankingInfoGetAfterMarketSinglePriceChangeRateRanks
	{
		/// <summary>
		/// 시간외단일가등락율순위
		/// </summary>
		[JsonProperty("ovt_sigpric_flu_rt_rank")]
		public IEnumerable<KiwoomRankingInfoGetAfterMarketSinglePriceChangeRateRankItem>? Items;
	}
	public record KiwoomRankingInfoGetAfterMarketSinglePriceChangeRateRankItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 매도총잔량
		/// </summary>
		[JsonProperty("sel_tot_req")]
		public decimal? TotalSellRemainQuantity;
		/// <summary>
		/// 매수총잔량
		/// </summary>
		[JsonProperty("buy_tot_req")]
		public decimal? TotalBuyRemainQuantity;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 당일종가
		/// </summary>
		[JsonProperty("tdy_close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 당일종가등락률
		/// </summary>
		[JsonProperty("tdy_close_pric_flu_rt")]
		public KiwoomDecimal? CloseChangeRate;
	}

	public record KiwoomRankingInfoGetForeignInstitutionTransactionTops
	{
		/// <summary>
		/// 외국인기관매매상위
		/// </summary>
		[JsonProperty("frgnr_orgn_trde_upper")]
		public IEnumerable<KiwoomRankingInfoGetForeignInstitutionTransactionTopItem>? Items;
	}
	public record KiwoomRankingInfoGetForeignInstitutionTransactionTopItem
	{
		/// <summary>
		/// 외인순매도종목코드
		/// </summary>
		[JsonProperty("for_netslmt_stk_cd")]
		public string? ForeignNetSellStockCode;
		/// <summary>
		/// 외인순매도종목명
		/// </summary>
		[JsonProperty("for_netslmt_stk_nm")]
		public string? ForeignNetSellStockName;
		/// <summary>
		/// 외인순매도금액
		/// </summary>
		[JsonProperty("for_netslmt_amt")]
		public KiwoomDecimal? ForeignNetSellAmount;
		/// <summary>
		/// 외인순매도수량
		/// </summary>
		[JsonProperty("for_netslmt_qty")]
		public KiwoomDecimal? ForeignNetSellQuantity;
		/// <summary>
		/// 외인순매수종목코드
		/// </summary>
		[JsonProperty("for_netprps_stk_cd")]
		public string? ForeignNetBuyStockCode;
		/// <summary>
		/// 외인순매수종목명
		/// </summary>
		[JsonProperty("for_netprps_stk_nm")]
		public string? ForeignNetBuyStockName;
		/// <summary>
		/// 외인순매수금액
		/// </summary>
		[JsonProperty("for_netprps_amt")]
		public KiwoomDecimal? ForeignNetBuyAmount;
		/// <summary>
		/// 외인순매수수량
		/// </summary>
		[JsonProperty("for_netprps_qty")]
		public KiwoomDecimal? ForeignNetBuyQuantity;
		/// <summary>
		/// 기관순매도종목코드
		/// </summary>
		[JsonProperty("orgn_netslmt_stk_cd")]
		public string? InstitutionNetSellStockCode;
		/// <summary>
		/// 기관순매도종목명
		/// </summary>
		[JsonProperty("orgn_netslmt_stk_nm")]
		public string? InstitutionNetSellStockName;
		/// <summary>
		/// 기관순매도금액
		/// </summary>
		[JsonProperty("orgn_netslmt_amt")]
		public KiwoomDecimal? InstitutionNetSellAmount;
		/// <summary>
		/// 기관순매도수량
		/// </summary>
		[JsonProperty("orgn_netslmt_qty")]
		public KiwoomDecimal? InstitutionNetSellQuantity;
		/// <summary>
		/// 기관순매수종목코드
		/// </summary>
		[JsonProperty("orgn_netprps_stk_cd")]
		public string? InstitutionNetBuyStockCode;
		/// <summary>
		/// 기관순매수종목명
		/// </summary>
		[JsonProperty("orgn_netprps_stk_nm")]
		public string? InstitutionNetBuyStockName;
		/// <summary>
		/// 기관순매수금액
		/// </summary>
		[JsonProperty("orgn_netprps_amt")]
		public KiwoomDecimal? InstitutionNetBuyAmount;
		/// <summary>
		/// 기관순매수수량
		/// </summary>
		[JsonProperty("orgn_netprps_qty")]
		public KiwoomDecimal? InstitutionNetBuyQuantity;
	}

	/// <summary>
	/// 사용자 지정 범위 조건 (요청용)
	/// </summary>
	public record KiwoomRankingInfoRangeCondition
	{
		/// <summary>
		/// 최소값 (null이면 하한 없음)
		/// </summary>
		public decimal? Min;
		/// <summary>
		/// 최대값 (null이면 상한 없음)
		/// </summary>
		public decimal? Max;
		/// <summary>
		/// 최소값 포함 여부 (true: 최소값 이상, false: 최소값 초과)
		/// </summary>
		public bool IsMinInclusive = true;
		/// <summary>
		/// 최대값 포함 여부 (true: 최대값 이하, false: 최대값 미만)
		/// </summary>
		public bool IsMaxInclusive = true;
	}

	public record KiwoomRankingInfoGetLargeTradeTops
	{
		/// <summary>
		/// 대량체결상위 목록
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomRankingInfoGetLargeTradeTopItem>? Items;
	}
	public record KiwoomRankingInfoGetLargeTradeTopItem
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
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 매수건수 - 건당 매수체결금액이 건별금액 조건을 초과하는 횟수
		/// </summary>
		[JsonProperty("buy_cnt")]
		public int? BuyCount;
		/// <summary>
		/// 매도건수 - 건당 매도체결금액이 건별금액 조건을 초과하는 횟수
		/// </summary>
		[JsonProperty("sel_cnt")]
		public int? SellCount;
		/// <summary>
		/// 대비 (매수건수 - 매도건수)
		/// </summary>
		[JsonProperty("pre")]
		public KiwoomInt? CountChange;
		/// <summary>
		/// 거래대금 (단위: 백만원)
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
	}

	public record KiwoomRankingInfoGetTradeAmountRangeTransactionRatios
	{
		/// <summary>
		/// 체결금액대별매매비중 목록
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomRankingInfoGetTradeAmountRangeTransactionRatioItem>? Items;
	}
	public record KiwoomRankingInfoGetTradeAmountRangeTransactionRatioItem
	{
		/// <summary>
		/// 매도총거래량
		/// </summary>
		[JsonProperty("sel_trde_qty")]
		public decimal? SellVolume;
		/// <summary>
		/// 매수총거래량
		/// </summary>
		[JsonProperty("buy_trde_qty")]
		public decimal? BuyVolume;
		/// <summary>
		/// 합계총거래량
		/// </summary>
		[JsonProperty("tot_trde_qty")]
		public decimal? TotalVolume;
		/// <summary>
		/// 매도건수
		/// </summary>
		[JsonProperty("sel_cnt")]
		public int? SellCount;
		/// <summary>
		/// 매수건수
		/// </summary>
		[JsonProperty("buy_cnt")]
		public int? BuyCount;
		/// <summary>
		/// 합계순건수 (매수건수 - 매도건수)
		/// </summary>
		[JsonProperty("tot_net_cnt")]
		public KiwoomInt? TotalNetCount;
		/// <summary>
		/// 매도비율
		/// </summary>
		[JsonProperty("sel_rt")]
		public KiwoomDecimal? SellRate;
		/// <summary>
		/// 매수비율
		/// </summary>
		[JsonProperty("buy_rt")]
		public KiwoomDecimal? BuyRate;
		/// <summary>
		/// 합계순비율 (매수비율 - 매도비율)
		/// </summary>
		[JsonProperty("tot_net_rt")]
		public KiwoomDecimal? TotalNetRate;
		/// <summary>
		/// 합계평균가격
		/// </summary>
		[JsonProperty("tot_avg_pric")]
		public decimal? TotalAveragePrice;
		/// <summary>
		/// 순간체결금액 구간 (3백이하, 5백이하, 1천이하, 3천이하, 5천이하, 1억이하, 5억이하, 5억초과)
		/// </summary>
		[JsonProperty("mont_cntr_amt")]
		public string? InstantTradeAmountRange;
		/// <summary>
		/// 매도평균가격
		/// </summary>
		[JsonProperty("sel_avg_pric")]
		public decimal? SellAveragePrice;
		/// <summary>
		/// 매수평균가격
		/// </summary>
		[JsonProperty("buy_avg_pric")]
		public decimal? BuyAveragePrice;
	}

	public record KiwoomRankingInfoGetTopProfitCustomerTransactionDetails
	{
		/// <summary>
		/// 수익률상위고객매매상세 목록
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomRankingInfoGetTopProfitCustomerTransactionDetailItem>? Items;
	}
	public record KiwoomRankingInfoGetTopProfitCustomerTransactionDetailItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		public string? Time;
		/// <summary>
		/// 순위 - 조회구분 설정에 따른 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
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
		[JsonProperty("cur_pric")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public KiwoomDecimal? BuyQuantity;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sel_qty")]
		public KiwoomDecimal? SellQuantity;
		/// <summary>
		/// 순매매수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetTransactionQuantity;
		/// <summary>
		/// 매수금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("buy_amt")]
		public KiwoomDecimal? BuyAmount;
		/// <summary>
		/// 매도금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("sell_amt")]
		public KiwoomDecimal? SellAmount;
		/// <summary>
		/// 순매매금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("netprps_amt")]
		public KiwoomDecimal? NetTransactionAmount;
		/// <summary>
		/// 계좌수 (보유 계좌수)
		/// </summary>
		[JsonProperty("acct_qty")]
		public int? AccountCount;
		/// <summary>
		/// 수량 (보유 수량)
		/// </summary>
		[JsonProperty("qty")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 평균매입가 (보유 평균 매입가)
		/// </summary>
		[JsonProperty("avg_pur_pric")]
		public decimal? AveragePurchasePrice;
		/// <summary>
		/// 수익률 (보유 수익률)
		/// </summary>
		[JsonProperty("prft_rt")]
		public KiwoomDecimal? ProfitRate;
	}
}
