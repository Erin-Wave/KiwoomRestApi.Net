using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockIndustryGetPeriodReturns
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockIndustryPeriodReturnItem>? Items;
	}

	public record KiwoomUsStockIndustryPeriodReturnItem
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public string? IndustryCode;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("inds_nm")]
		public string? IndustryName;
		/// <summary>
		/// 1일 수익률
		/// </summary>
		[JsonProperty("perf_1d")]
		public decimal? OneDayReturn;
		/// <summary>
		/// 5일 수익률
		/// </summary>
		[JsonProperty("perf_5d")]
		public decimal? FiveDayReturn;
		/// <summary>
		/// 1개월 수익률
		/// </summary>
		[JsonProperty("perf_1m")]
		public decimal? OneMonthReturn;
		/// <summary>
		/// 3개월 수익률
		/// </summary>
		[JsonProperty("perf_3m")]
		public decimal? ThreeMonthReturn;
		/// <summary>
		/// 6개월 수익률
		/// </summary>
		[JsonProperty("perf_6m")]
		public decimal? SixMonthReturn;
		/// <summary>
		/// 연초 대비 수익률
		/// </summary>
		[JsonProperty("perf_ytd")]
		public decimal? YearToDateReturn;
		/// <summary>
		/// 1년 수익률
		/// </summary>
		[JsonProperty("perf_1y")]
		public decimal? OneYearReturn;
	}

	public record KiwoomUsStockIndustryGetChangeRateRanks
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockIndustryChangeRateRankItem>? Items;
	}

	public record KiwoomUsStockIndustryChangeRateRankItem
	{
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
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
		/// 종목영문명
		/// </summary>
		[JsonProperty("stk_enm")]
		public string? StockEnglishName;
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
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBid;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBid;
		/// <summary>
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가
		/// </summary>
		[JsonProperty("high_pric")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		[JsonProperty("low_pric")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		public string? TradeTime;
	}
}
