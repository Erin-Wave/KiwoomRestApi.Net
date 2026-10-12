using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.DomesticStock
{
	public record KiwoomThemeGetGroups
	{
		/// <summary>
		/// 테마그룹별
		/// </summary>
		[JsonProperty("thema_grp")]
		public IEnumerable<KiwoomThemeGetGroupItem>? Items;
	}
	public record KiwoomThemeGetGroupItem
	{
		/// <summary>
		/// 테마그룹코드
		/// </summary>
		[JsonProperty("thema_grp_cd")]
		public string? ThemeGroupCode;
		/// <summary>
		/// 테마명
		/// </summary>
		[JsonProperty("thema_nm")]
		public string? ThemeName;
		/// <summary>
		/// 종목수
		/// </summary>
		[JsonProperty("stk_num")]
		public int? StockCount;
		/// <summary>
		/// 등락기호
		/// </summary>
		[JsonProperty("flu_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 상승종목수
		/// </summary>
		[JsonProperty("rising_stk_num")]
		public int? UpStockCount;
		/// <summary>
		/// 하락종목수
		/// </summary>
		[JsonProperty("fall_stk_num")]
		public int? DownStockCount;
		/// <summary>
		/// 기간수익률
		/// </summary>
		[JsonProperty("dt_prft_rt")]
		public KiwoomDecimal? PeriodProfitRate;
		/// <summary>
		/// 주요종목
		/// </summary>
		[JsonProperty("main_stk")]
		public string? MainStock;
	}

	public record KiwoomThemeGetComponentStocks
	{
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 기간수익률
		/// </summary>
		[JsonProperty("dt_prft_rt")]
		public KiwoomDecimal? PeriodProfitRate;
		/// <summary>
		/// 테마구성종목
		/// </summary>
		[JsonProperty("thema_comp_stk")]
		public IEnumerable<KiwoomThemeGetComponentStockItem>? Items;
	}
	public record KiwoomThemeGetComponentStockItem
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
		/// 등락기호
		/// </summary>
		[JsonProperty("flu_sig")]
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
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellQuote;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[JsonProperty("sel_req")]
		public decimal? SellRemainQuantity;
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
		/// <summary>
		/// 기간수익률
		/// </summary>
		[JsonProperty("dt_prft_rt_n")]
		public decimal? PeriodProfitRate;
	}
}
