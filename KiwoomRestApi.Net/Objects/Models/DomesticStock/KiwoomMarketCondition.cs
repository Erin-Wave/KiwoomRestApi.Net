using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.DomesticStock.MarketCondition;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.DomesticStock
{
	public record KiwoomMarketConditionGetOrderBook
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderBookTime;
		/// <summary>
		/// 매도10차선잔량대비
		/// </summary>
		[JsonProperty("sel_10th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange10;
		/// <summary>
		/// 매도10차선잔량
		/// </summary>
		[JsonProperty("sel_10th_pre_req")]
		public decimal? SellQuantity10;
		/// <summary>
		/// 매도10차선호가
		/// </summary>
		[JsonProperty("sel_10th_pre_bid")]
		public decimal? SellPrice10;
		/// <summary>
		/// 매도9차선잔량대비
		/// </summary>
		[JsonProperty("sel_9th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange9;
		/// <summary>
		/// 매도9차선잔량
		/// </summary>
		[JsonProperty("sel_9th_pre_req")]
		public decimal? SellQuantity9;
		/// <summary>
		/// 매도9차선호가
		/// </summary>
		[JsonProperty("sel_9th_pre_bid")]
		public decimal? SellPrice9;
		/// <summary>
		/// 매도8차선잔량대비
		/// </summary>
		[JsonProperty("sel_8th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange8;
		/// <summary>
		/// 매도8차선잔량
		/// </summary>
		[JsonProperty("sel_8th_pre_req")]
		public decimal? SellQuantity8;
		/// <summary>
		/// 매도8차선호가
		/// </summary>
		[JsonProperty("sel_8th_pre_bid")]
		public decimal? SellPrice8;
		/// <summary>
		/// 매도7차선잔량대비
		/// </summary>
		[JsonProperty("sel_7th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange7;
		/// <summary>
		/// 매도7차선잔량
		/// </summary>
		[JsonProperty("sel_7th_pre_req")]
		public decimal? SellQuantity7;
		/// <summary>
		/// 매도7차선호가
		/// </summary>
		[JsonProperty("sel_7th_pre_bid")]
		public decimal? SellPrice7;
		/// <summary>
		/// 매도6차선잔량대비
		/// </summary>
		[JsonProperty("sel_6th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange6;
		/// <summary>
		/// 매도6차선잔량
		/// </summary>
		[JsonProperty("sel_6th_pre_req")]
		public decimal? SellQuantity6;
		/// <summary>
		/// 매도6차선호가
		/// </summary>
		[JsonProperty("sel_6th_pre_bid")]
		public decimal? SellPrice6;
		/// <summary>
		/// 매도5차선잔량대비
		/// </summary>
		[JsonProperty("sel_5th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange5;
		/// <summary>
		/// 매도5차선잔량
		/// </summary>
		[JsonProperty("sel_5th_pre_req")]
		public decimal? SellQuantity5;
		/// <summary>
		/// 매도5차선호가
		/// </summary>
		[JsonProperty("sel_5th_pre_bid")]
		public decimal? SellPrice5;
		/// <summary>
		/// 매도4차선잔량대비
		/// </summary>
		[JsonProperty("sel_4th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange4;
		/// <summary>
		/// 매도4차선잔량
		/// </summary>
		[JsonProperty("sel_4th_pre_req")]
		public decimal? SellQuantity4;
		/// <summary>
		/// 매도4차선호가
		/// </summary>
		[JsonProperty("sel_4th_pre_bid")]
		public decimal? SellPrice4;
		/// <summary>
		/// 매도3차선잔량대비
		/// </summary>
		[JsonProperty("sel_3th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange3;
		/// <summary>
		/// 매도3차선잔량
		/// </summary>
		[JsonProperty("sel_3th_pre_req")]
		public decimal? SellQuantity3;
		/// <summary>
		/// 매도3차선호가
		/// </summary>
		[JsonProperty("sel_3th_pre_bid")]
		public decimal? SellPrice3;
		/// <summary>
		/// 매도2차선잔량대비
		/// </summary>
		[JsonProperty("sel_2th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange2;
		/// <summary>
		/// 매도2차선잔량
		/// </summary>
		[JsonProperty("sel_2th_pre_req")]
		public decimal? SellQuantity2;
		/// <summary>
		/// 매도2차선호가
		/// </summary>
		[JsonProperty("sel_2th_pre_bid")]
		public decimal? SellPrice2;
		/// <summary>
		/// 매도1차선잔량대비
		/// </summary>
		[JsonProperty("sel_1th_pre_req_pre")]
		public KiwoomDecimal? SellQuantityChange1;
		/// <summary>
		/// 매도최우선잔량
		/// </summary>
		[JsonProperty("sel_fpr_req")]
		public decimal? SellQuantity1;
		/// <summary>
		/// 매도최우선호가
		/// </summary>
		[JsonProperty("sel_fpr_bid")]
		public decimal? SellPrice1;
		/// <summary>
		/// 매수최우선호가
		/// </summary>
		[JsonProperty("buy_fpr_bid")]
		public decimal? BuyPrice1;
		/// <summary>
		/// 매수최우선잔량
		/// </summary>
		[JsonProperty("buy_fpr_req")]
		public decimal? BuyQuantity1;
		/// <summary>
		/// 매수1차선잔량대비
		/// </summary>
		[JsonProperty("buy_1th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange1;
		/// <summary>
		/// 매수2차선호가
		/// </summary>
		[JsonProperty("buy_2th_pre_bid")]
		public decimal? BuyPrice2;
		/// <summary>
		/// 매수2차선잔량
		/// </summary>
		[JsonProperty("buy_2th_pre_req")]
		public decimal? BuyQuantity2;
		/// <summary>
		/// 매수2차선잔량대비
		/// </summary>
		[JsonProperty("buy_2th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange2;
		/// <summary>
		/// 매수3차선호가
		/// </summary>
		[JsonProperty("buy_3th_pre_bid")]
		public decimal? BuyPrice3;
		/// <summary>
		/// 매수3차선잔량
		/// </summary>
		[JsonProperty("buy_3th_pre_req")]
		public decimal? BuyQuantity3;
		/// <summary>
		/// 매수3차선잔량대비
		/// </summary>
		[JsonProperty("buy_3th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange3;
		/// <summary>
		/// 매수4차선호가
		/// </summary>
		[JsonProperty("buy_4th_pre_bid")]
		public decimal? BuyPrice4;
		/// <summary>
		/// 매수4차선잔량
		/// </summary>
		[JsonProperty("buy_4th_pre_req")]
		public decimal? BuyQuantity4;
		/// <summary>
		/// 매수4차선잔량대비
		/// </summary>
		[JsonProperty("buy_4th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange4;
		/// <summary>
		/// 매수5차선호가
		/// </summary>
		[JsonProperty("buy_5th_pre_bid")]
		public decimal? BuyPrice5;
		/// <summary>
		/// 매수5차선잔량
		/// </summary>
		[JsonProperty("buy_5th_pre_req")]
		public decimal? BuyQuantity5;
		/// <summary>
		/// 매수5차선잔량대비
		/// </summary>
		[JsonProperty("buy_5th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange5;
		/// <summary>
		/// 매수6차선호가
		/// </summary>
		[JsonProperty("buy_6th_pre_bid")]
		public decimal? BuyPrice6;
		/// <summary>
		/// 매수6차선잔량
		/// </summary>
		[JsonProperty("buy_6th_pre_req")]
		public decimal? BuyQuantity6;
		/// <summary>
		/// 매수6차선잔량대비
		/// </summary>
		[JsonProperty("buy_6th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange6;
		/// <summary>
		/// 매수7차선호가
		/// </summary>
		[JsonProperty("buy_7th_pre_bid")]
		public decimal? BuyPrice7;
		/// <summary>
		/// 매수7차선잔량
		/// </summary>
		[JsonProperty("buy_7th_pre_req")]
		public decimal? BuyQuantity7;
		/// <summary>
		/// 매수7차선잔량대비
		/// </summary>
		[JsonProperty("buy_7th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange7;
		/// <summary>
		/// 매수8차선호가
		/// </summary>
		[JsonProperty("buy_8th_pre_bid")]
		public decimal? BuyPrice8;
		/// <summary>
		/// 매수8차선잔량
		/// </summary>
		[JsonProperty("buy_8th_pre_req")]
		public decimal? BuyQuantity8;
		/// <summary>
		/// 매수8차선잔량대비
		/// </summary>
		[JsonProperty("buy_8th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange8;
		/// <summary>
		/// 매수9차선호가
		/// </summary>
		[JsonProperty("buy_9th_pre_bid")]
		public decimal? BuyPrice9;
		/// <summary>
		/// 매수9차선잔량
		/// </summary>
		[JsonProperty("buy_9th_pre_req")]
		public decimal? BuyQuantity9;
		/// <summary>
		/// 매수9차선잔량대비
		/// </summary>
		[JsonProperty("buy_9th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange9;
		/// <summary>
		/// 매수10차선호가
		/// </summary>
		[JsonProperty("buy_10th_pre_bid")]
		public decimal? BuyPrice10;
		/// <summary>
		/// 매수10차선잔량
		/// </summary>
		[JsonProperty("buy_10th_pre_req")]
		public decimal? BuyQuantity10;
		/// <summary>
		/// 매수10차선잔량대비
		/// </summary>
		[JsonProperty("buy_10th_pre_req_pre")]
		public KiwoomDecimal? BuyQuantityChange10;
		/// <summary>
		/// 총매도잔량직전대비
		/// </summary>
		[JsonProperty("tot_sel_req_jub_pre")]
		public KiwoomDecimal? TotalSellQuantityChange;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 총매수잔량직전대비
		/// </summary>
		[JsonProperty("tot_buy_req_jub_pre")]
		public KiwoomDecimal? TotalBuyQuantityChange;
		/// <summary>
		/// 시간외매도잔량대비
		/// </summary>
		[JsonProperty("ovt_sel_req_pre")]
		public KiwoomDecimal? AfterMarketSellQuantityChange;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		[JsonProperty("ovt_sel_req")]
		public decimal? AfterMarketSellQuantity;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		[JsonProperty("ovt_buy_req")]
		public decimal? AfterMarketBuyQuantity;
		/// <summary>
		/// 시간외매수잔량대비
		/// </summary>
		[JsonProperty("ovt_buy_req_pre")]
		public KiwoomDecimal? AfterMarketBuyQuantityChange;
	}

	public record PriceVolumeDiff
	{
		/// <summary>
		/// 가격
		/// </summary>
		public KiwoomDecimal? Price;
		/// <summary>
		/// 수량
		/// </summary>
		public decimal? Quantity;
		/// <summary>
		/// 전일대비 차이
		/// </summary>
		public KiwoomDecimal? Change;

		public PriceVolumeDiff(decimal? price, decimal? quantity, decimal? change)
		{
			Price = price;
			Quantity = quantity;
			Change = change;
		}
	}

	public record KiwoomMarketConditionGetOrderBookList
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		public TimeSpan? OrderBookTime;
		/// <summary>
		/// 매도호가
		/// </summary>
		public PriceVolumeDiff[] SellQuotes;
		/// <summary>
		/// 매수호가
		/// </summary>
		public PriceVolumeDiff[] BuyQuotes;
		/// <summary>
		/// 총매도잔량직전대비
		/// </summary>
		public decimal? TotalSellRemainQuantityChange;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		public decimal? TotalSellRemainQuantity;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		public decimal? TotalBuyRemainQuantity;
		/// <summary>
		/// 총매수잔량직전대비
		/// </summary>
		public decimal? TotalBuyRemainQuantityChange;
		/// <summary>
		/// 시간외매도잔량대비
		/// </summary>
		public decimal? AfterMarketSellRemainQuantityChange;
		/// <summary>
		/// 시간외매도잔량
		/// </summary>
		public decimal? AfterMarketSellRemainQuantity;
		/// <summary>
		/// 시간외매수잔량
		/// </summary>
		public decimal? AfterMarketBuyRemainQuantity;
		/// <summary>
		/// 시간외매수잔량대비
		/// </summary>
		public decimal? AfterMarketBuyRemainQuantityChange;

		public KiwoomMarketConditionGetOrderBookList(KiwoomMarketConditionGetOrderBook raw)
		{
			OrderBookTime = raw.OrderBookTime;

			SellQuotes =
			[
				new(raw.SellPrice1, raw.SellQuantity1, raw.SellQuantityChange1),
				new(raw.SellPrice2, raw.SellQuantity2, raw.SellQuantityChange2),
				new(raw.SellPrice3, raw.SellQuantity3, raw.SellQuantityChange3),
				new(raw.SellPrice4, raw.SellQuantity4, raw.SellQuantityChange4),
				new(raw.SellPrice5, raw.SellQuantity5, raw.SellQuantityChange5),
				new(raw.SellPrice6, raw.SellQuantity6, raw.SellQuantityChange6),
				new(raw.SellPrice7, raw.SellQuantity7, raw.SellQuantityChange7),
				new(raw.SellPrice8, raw.SellQuantity8, raw.SellQuantityChange8),
				new(raw.SellPrice9, raw.SellQuantity9, raw.SellQuantityChange9),
				new(raw.SellPrice10, raw.SellQuantity10, raw.SellQuantityChange10)
			];
			BuyQuotes =
			[
				new(raw.BuyPrice1, raw.BuyQuantity1, raw.BuyQuantityChange1),
				new(raw.BuyPrice2, raw.BuyQuantity2, raw.BuyQuantityChange2),
				new(raw.BuyPrice3, raw.BuyQuantity3, raw.BuyQuantityChange3),
				new(raw.BuyPrice4, raw.BuyQuantity4, raw.BuyQuantityChange4),
				new(raw.BuyPrice5, raw.BuyQuantity5, raw.BuyQuantityChange5),
				new(raw.BuyPrice6, raw.BuyQuantity6, raw.BuyQuantityChange6),
				new(raw.BuyPrice7, raw.BuyQuantity7, raw.BuyQuantityChange7),
				new(raw.BuyPrice8, raw.BuyQuantity8, raw.BuyQuantityChange8),
				new(raw.BuyPrice9, raw.BuyQuantity9, raw.BuyQuantityChange9),
				new(raw.BuyPrice10, raw.BuyQuantity10, raw.BuyQuantityChange10)
			];

			TotalSellRemainQuantityChange = raw.TotalSellQuantityChange;
			TotalSellRemainQuantity = raw.TotalSellQuantity;
			TotalBuyRemainQuantity = raw.TotalBuyQuantity;
			TotalBuyRemainQuantityChange = raw.TotalBuyQuantityChange;
			AfterMarketSellRemainQuantityChange = raw.AfterMarketSellQuantityChange;
			AfterMarketSellRemainQuantity = raw.AfterMarketSellQuantity;
			AfterMarketBuyRemainQuantity = raw.AfterMarketBuyQuantity;
			AfterMarketBuyRemainQuantityChange = raw.AfterMarketBuyQuantityChange;
		}
	}

	public record KiwoomMarketConditionGetDailyWeeklyMonthly
	{
		/// <summary>
		/// 주식일주월시분
		/// </summary>
		[JsonProperty("stk_ddwkmm")]
		public IEnumerable<KiwoomMarketConditionGetDailyWeeklyMonthlyItem>? Items;
	}

	public record KiwoomMarketConditionGetDailyWeeklyMonthlyItem
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
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
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 외인보유
		/// </summary>
		[JsonProperty("for_poss")]
		public KiwoomDecimal? ForeignHolding;
		/// <summary>
		/// 외인비중
		/// </summary>
		[JsonProperty("for_wght")]
		public KiwoomDecimal? ForeignWeight;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[JsonProperty("for_netprps")]
		public decimal? ForeignNetBuy;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public decimal? InstitutionNetBuy;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public decimal? RetailNetBuy;
		/// <summary>
		/// 신용잔고율
		/// </summary>
		[JsonProperty("crd_remn_rt")]
		public decimal? CreditBalanceRate;
		/// <summary>
		/// 외국계
		/// </summary>
		[JsonProperty("frgn")]
		public decimal? ForeignInvestorRate;
		/// <summary>
		/// 프로그램
		/// </summary>
		[JsonProperty("prm")]
		public decimal? ProgramTradingRate;
	}

	public record KiwoomMarketConditionGetHourMinute
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
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
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 대비
		/// </summary>
		[JsonProperty("pre")]
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
	}

	public record KiwoomMarketConditionGetQuote
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public decimal? PreviousDayClose;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 상한가
		/// </summary>
		[JsonProperty("upl_pric")]
		public KiwoomDecimal? UpperPrice;
		/// <summary>
		/// 하한가
		/// </summary>
		[JsonProperty("lst_pric")]
		public KiwoomDecimal? LowerPrice;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		[JsonProperty("pred_trde_prica")]
		public decimal? PreviousDayTransactionAmount;
		/// <summary>
		/// 상장주식수
		/// </summary>
		[JsonProperty("flo_stkcnt")]
		public decimal? ListedQuantity;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 부호
		/// </summary>
		[JsonProperty("smbol")]
		public string? Sign;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public KiwoomDecimal? PreviousDayRate;
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
		/// 체결량
		/// </summary>
		[JsonProperty("cntr_qty")]
		public decimal? TradeQuantity;
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
		/// <summary>
		/// 예상체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public KiwoomDecimal? ExpectedTradePrice;
		/// <summary>
		/// 예상체결량
		/// </summary>
		[JsonProperty("exp_cntr_qty")]
		public decimal? ExpectedTradeQuantity;
		/// <summary>
		/// 예상매도우선호가
		/// </summary>
		[JsonProperty("exp_sel_pri_bid")]
		public decimal? ExpectedBestSellQuote;
		/// <summary>
		/// 예상매수우선호가
		/// </summary>
		[JsonProperty("exp_buy_pri_bid")]
		public decimal? ExpectedBestBuyQuote;
		/// <summary>
		/// 거래시작일
		/// </summary>
		[JsonProperty("trde_strt_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeStartDate;
		/// <summary>
		/// 행사가격
		/// </summary>
		[JsonProperty("exec_pric")]
		public decimal? ExercisePrice;
		/// <summary>
		/// 최고가
		/// </summary>
		[JsonProperty("hgst_pric")]
		public decimal? HighestPrice;
		/// <summary>
		/// 최저가
		/// </summary>
		[JsonProperty("lwst_pric")]
		public decimal? LowestPrice;
		/// <summary>
		/// 최고가일
		/// </summary>
		[JsonProperty("hgst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? HighestPriceDate;
		/// <summary>
		/// 최저가일
		/// </summary>
		[JsonProperty("lwst_pric_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LowestPriceDate;
		/// <summary>
		/// 매도1호가
		/// </summary>
		[JsonProperty("sel_1bid")]
		public decimal? SellPrice1;
		/// <summary>
		/// 매도2호가
		/// </summary>
		[JsonProperty("sel_2bid")]
		public decimal? SellPrice2;
		/// <summary>
		/// 매도3호가
		/// </summary>
		[JsonProperty("sel_3bid")]
		public decimal? SellPrice3;
		/// <summary>
		/// 매도4호가
		/// </summary>
		[JsonProperty("sel_4bid")]
		public decimal? SellPrice4;
		/// <summary>
		/// 매도5호가
		/// </summary>
		[JsonProperty("sel_5bid")]
		public decimal? SellPrice5;
		/// <summary>
		/// 매도6호가
		/// </summary>
		[JsonProperty("sel_6bid")]
		public decimal? SellPrice6;
		/// <summary>
		/// 매도7호가
		/// </summary>
		[JsonProperty("sel_7bid")]
		public decimal? SellPrice7;
		/// <summary>
		/// 매도8호가
		/// </summary>
		[JsonProperty("sel_8bid")]
		public decimal? SellPrice8;
		/// <summary>
		/// 매도9호가
		/// </summary>
		[JsonProperty("sel_9bid")]
		public decimal? SellPrice9;
		/// <summary>
		/// 매도10호가
		/// </summary>
		[JsonProperty("sel_10bid")]
		public decimal? SellPrice10;
		/// <summary>
		/// 매수1호가
		/// </summary>
		[JsonProperty("buy_1bid")]
		public decimal? BuyPrice1;
		/// <summary>
		/// 매수2호가
		/// </summary>
		[JsonProperty("buy_2bid")]
		public decimal? BuyPrice2;
		/// <summary>
		/// 매수3호가
		/// </summary>
		[JsonProperty("buy_3bid")]
		public decimal? BuyPrice3;
		/// <summary>
		/// 매수4호가
		/// </summary>
		[JsonProperty("buy_4bid")]
		public decimal? BuyPrice4;
		/// <summary>
		/// 매수5호가
		/// </summary>
		[JsonProperty("buy_5bid")]
		public decimal? BuyPrice5;
		/// <summary>
		/// 매수6호가
		/// </summary>
		[JsonProperty("buy_6bid")]
		public decimal? BuyPrice6;
		/// <summary>
		/// 매수7호가
		/// </summary>
		[JsonProperty("buy_7bid")]
		public decimal? BuyPrice7;
		/// <summary>
		/// 매수8호가
		/// </summary>
		[JsonProperty("buy_8bid")]
		public decimal? BuyPrice8;
		/// <summary>
		/// 매수9호가
		/// </summary>
		[JsonProperty("buy_9bid")]
		public decimal? BuyPrice9;
		/// <summary>
		/// 매수10호가
		/// </summary>
		[JsonProperty("buy_10bid")]
		public decimal? BuyPrice10;
		/// <summary>
		/// 매도1호가잔량
		/// </summary>
		[JsonProperty("sel_1bid_req")]
		public decimal? SellQuantity1;
		/// <summary>
		/// 매도2호가잔량
		/// </summary>
		[JsonProperty("sel_2bid_req")]
		public decimal? SellQuantity2;
		/// <summary>
		/// 매도3호가잔량
		/// </summary>
		[JsonProperty("sel_3bid_req")]
		public decimal? SellQuantity3;
		/// <summary>
		/// 매도4호가잔량
		/// </summary>
		[JsonProperty("sel_4bid_req")]
		public decimal? SellQuantity4;
		/// <summary>
		/// 매도5호가잔량
		/// </summary>
		[JsonProperty("sel_5bid_req")]
		public decimal? SellQuantity5;
		/// <summary>
		/// 매도6호가잔량
		/// </summary>
		[JsonProperty("sel_6bid_req")]
		public decimal? SellQuantity6;
		/// <summary>
		/// 매도7호가잔량
		/// </summary>
		[JsonProperty("sel_7bid_req")]
		public decimal? SellQuantity7;
		/// <summary>
		/// 매도8호가잔량
		/// </summary>
		[JsonProperty("sel_8bid_req")]
		public decimal? SellQuantity8;
		/// <summary>
		/// 매도9호가잔량
		/// </summary>
		[JsonProperty("sel_9bid_req")]
		public decimal? SellQuantity9;
		/// <summary>
		/// 매도10호가잔량
		/// </summary>
		[JsonProperty("sel_10bid_req")]
		public decimal? SellQuantity10;
		/// <summary>
		/// 매수1호가잔량
		/// </summary>
		[JsonProperty("buy_1bid_req")]
		public decimal? BuyQuantity1;
		/// <summary>
		/// 매수2호가잔량
		/// </summary>
		[JsonProperty("buy_2bid_req")]
		public decimal? BuyQuantity2;
		/// <summary>
		/// 매수3호가잔량
		/// </summary>
		[JsonProperty("buy_3bid_req")]
		public decimal? BuyQuantity3;
		/// <summary>
		/// 매수4호가잔량
		/// </summary>
		[JsonProperty("buy_4bid_req")]
		public decimal? BuyQuantity4;
		/// <summary>
		/// 매수5호가잔량
		/// </summary>
		[JsonProperty("buy_5bid_req")]
		public decimal? BuyQuantity5;
		/// <summary>
		/// 매수6호가잔량
		/// </summary>
		[JsonProperty("buy_6bid_req")]
		public decimal? BuyQuantity6;
		/// <summary>
		/// 매수7호가잔량
		/// </summary>
		[JsonProperty("buy_7bid_req")]
		public decimal? BuyQuantity7;
		/// <summary>
		/// 매수8호가잔량
		/// </summary>
		[JsonProperty("buy_8bid_req")]
		public decimal? BuyQuantity8;
		/// <summary>
		/// 매수9호가잔량
		/// </summary>
		[JsonProperty("buy_9bid_req")]
		public decimal? BuyQuantity9;
		/// <summary>
		/// 매수10호가잔량
		/// </summary>
		[JsonProperty("buy_10bid_req")]
		public decimal? BuyQuantity10;
		/// <summary>
		/// 매도1호가직전대비
		/// </summary>
		[JsonProperty("sel_1bid_jub_pre")]
		public KiwoomDecimal? SellChange1;
		/// <summary>
		/// 매도2호가직전대비
		/// </summary>
		[JsonProperty("sel_2bid_jub_pre")]
		public KiwoomDecimal? SellChange2;
		/// <summary>
		/// 매도3호가직전대비
		/// </summary>
		[JsonProperty("sel_3bid_jub_pre")]
		public KiwoomDecimal? SellChange3;
		/// <summary>
		/// 매도4호가직전대비
		/// </summary>
		[JsonProperty("sel_4bid_jub_pre")]
		public KiwoomDecimal? SellChange4;
		/// <summary>
		/// 매도5호가직전대비
		/// </summary>
		[JsonProperty("sel_5bid_jub_pre")]
		public KiwoomDecimal? SellChange5;
		/// <summary>
		/// 매도6호가직전대비
		/// </summary>
		[JsonProperty("sel_6bid_jub_pre")]
		public KiwoomDecimal? SellChange6;
		/// <summary>
		/// 매도7호가직전대비
		/// </summary>
		[JsonProperty("sel_7bid_jub_pre")]
		public KiwoomDecimal? SellChange7;
		/// <summary>
		/// 매도8호가직전대비
		/// </summary>
		[JsonProperty("sel_8bid_jub_pre")]
		public KiwoomDecimal? SellChange8;
		/// <summary>
		/// 매도9호가직전대비
		/// </summary>
		[JsonProperty("sel_9bid_jub_pre")]
		public KiwoomDecimal? SellChange9;
		/// <summary>
		/// 매도10호가직전대비
		/// </summary>
		[JsonProperty("sel_10bid_jub_pre")]
		public KiwoomDecimal? SellChange10;
		/// <summary>
		/// 매수1호가직전대비
		/// </summary>
		[JsonProperty("buy_1bid_jub_pre")]
		public KiwoomDecimal? BuyChange1;
		/// <summary>
		/// 매수2호가직전대비
		/// </summary>
		[JsonProperty("buy_2bid_jub_pre")]
		public KiwoomDecimal? BuyChange2;
		/// <summary>
		/// 매수3호가직전대비
		/// </summary>
		[JsonProperty("buy_3bid_jub_pre")]
		public KiwoomDecimal? BuyChange3;
		/// <summary>
		/// 매수4호가직전대비
		/// </summary>
		[JsonProperty("buy_4bid_jub_pre")]
		public KiwoomDecimal? BuyChange4;
		/// <summary>
		/// 매수5호가직전대비
		/// </summary>
		[JsonProperty("buy_5bid_jub_pre")]
		public KiwoomDecimal? BuyChange5;
		/// <summary>
		/// 매수6호가직전대비
		/// </summary>
		[JsonProperty("buy_6bid_jub_pre")]
		public KiwoomDecimal? BuyChange6;
		/// <summary>
		/// 매수7호가직전대비
		/// </summary>
		[JsonProperty("buy_7bid_jub_pre")]
		public KiwoomDecimal? BuyChange7;
		/// <summary>
		/// 매수8호가직전대비
		/// </summary>
		[JsonProperty("buy_8bid_jub_pre")]
		public KiwoomDecimal? BuyChange8;
		/// <summary>
		/// 매수9호가직전대비
		/// </summary>
		[JsonProperty("buy_9bid_jub_pre")]
		public KiwoomDecimal? BuyChange9;
		/// <summary>
		/// 매수10호가직전대비
		/// </summary>
		[JsonProperty("buy_10bid_jub_pre")]
		public KiwoomDecimal? BuyChange10;
		/// <summary>
		/// 매도1호가건수
		/// </summary>
		[JsonProperty("sel_1bid_cnt")]
		public int? SellCount1;
		/// <summary>
		/// 매도2호가건수
		/// </summary>
		[JsonProperty("sel_2bid_cnt")]
		public int? SellCount2;
		/// <summary>
		/// 매도3호가건수
		/// </summary>
		[JsonProperty("sel_3bid_cnt")]
		public int? SellCount3;
		/// <summary>
		/// 매도4호가건수
		/// </summary>
		[JsonProperty("sel_4bid_cnt")]
		public int? SellCount4;
		/// <summary>
		/// 매도5호가건수
		/// </summary>
		[JsonProperty("sel_5bid_cnt")]
		public int? SellCount5;
		/// <summary>
		/// 매수1호가건수
		/// </summary>
		[JsonProperty("buy_1bid_cnt")]
		public int? BuyCount1;
		/// <summary>
		/// 매수2호가건수
		/// </summary>
		[JsonProperty("buy_2bid_cnt")]
		public int? BuyCount2;
		/// <summary>
		/// 매수3호가건수
		/// </summary>
		[JsonProperty("buy_3bid_cnt")]
		public int? BuyCount3;
		/// <summary>
		/// 매수4호가건수
		/// </summary>
		[JsonProperty("buy_4bid_cnt")]
		public int? BuyCount4;
		/// <summary>
		/// 매수5호가건수
		/// </summary>
		[JsonProperty("buy_5bid_cnt")]
		public int? BuyCount5;
		/// <summary>
		/// LP매도1호가잔량
		/// </summary>
		[JsonProperty("lpsel_1bid_req")]
		public decimal? LpSellQuantity1;
		/// <summary>
		/// LP매도2호가잔량
		/// </summary>
		[JsonProperty("lpsel_2bid_req")]
		public decimal? LpSellQuantity2;
		/// <summary>
		/// LP매도3호가잔량
		/// </summary>
		[JsonProperty("lpsel_3bid_req")]
		public decimal? LpSellQuantity3;
		/// <summary>
		/// LP매도4호가잔량
		/// </summary>
		[JsonProperty("lpsel_4bid_req")]
		public decimal? LpSellQuantity4;
		/// <summary>
		/// LP매도5호가잔량
		/// </summary>
		[JsonProperty("lpsel_5bid_req")]
		public decimal? LpSellQuantity5;
		/// <summary>
		/// LP매도6호가잔량
		/// </summary>
		[JsonProperty("lpsel_6bid_req")]
		public decimal? LpSellQuantity6;
		/// <summary>
		/// LP매도7호가잔량
		/// </summary>
		[JsonProperty("lpsel_7bid_req")]
		public decimal? LpSellQuantity7;
		/// <summary>
		/// LP매도8호가잔량
		/// </summary>
		[JsonProperty("lpsel_8bid_req")]
		public decimal? LpSellQuantity8;
		/// <summary>
		/// LP매도9호가잔량
		/// </summary>
		[JsonProperty("lpsel_9bid_req")]
		public decimal? LpSellQuantity9;
		/// <summary>
		/// LP매도10호가잔량
		/// </summary>
		[JsonProperty("lpsel_10bid_req")]
		public decimal? LpSellQuantity10;
		/// <summary>
		/// LP매수1호가잔량
		/// </summary>
		[JsonProperty("lpbuy_1bid_req")]
		public decimal? LpBuyQuantity1;
		/// <summary>
		/// LP매수2호가잔량
		/// </summary>
		[JsonProperty("lpbuy_2bid_req")]
		public decimal? LpBuyQuantity2;
		/// <summary>
		/// LP매수3호가잔량
		/// </summary>
		[JsonProperty("lpbuy_3bid_req")]
		public decimal? LpBuyQuantity3;
		/// <summary>
		/// LP매수4호가잔량
		/// </summary>
		[JsonProperty("lpbuy_4bid_req")]
		public decimal? LpBuyQuantity4;
		/// <summary>
		/// LP매수5호가잔량
		/// </summary>
		[JsonProperty("lpbuy_5bid_req")]
		public decimal? LpBuyQuantity5;
		/// <summary>
		/// LP매수6호가잔량
		/// </summary>
		[JsonProperty("lpbuy_6bid_req")]
		public decimal? LpBuyQuantity6;
		/// <summary>
		/// LP매수7호가잔량
		/// </summary>
		[JsonProperty("lpbuy_7bid_req")]
		public decimal? LpBuyQuantity7;
		/// <summary>
		/// LP매수8호가잔량
		/// </summary>
		[JsonProperty("lpbuy_8bid_req")]
		public decimal? LpBuyQuantity8;
		/// <summary>
		/// LP매수9호가잔량
		/// </summary>
		[JsonProperty("lpbuy_9bid_req")]
		public decimal? LpBuyQuantity9;
		/// <summary>
		/// LP매수10호가잔량
		/// </summary>
		[JsonProperty("lpbuy_10bid_req")]
		public decimal? LpBuyQuantity10;
		/// <summary>
		/// 총매수잔량
		/// </summary>
		[JsonProperty("tot_buy_req")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		[JsonProperty("tot_sel_req")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 총매수건수
		/// </summary>
		[JsonProperty("tot_buy_cnt")]
		public int? TotalBuyCount;
		/// <summary>
		/// 총매도건수
		/// </summary>
		[JsonProperty("tot_sel_cnt")]
		public int? TotalSellCount;
	}

	public record KiwoomMarketConditionGetQuoteList
	{
		/// <summary>
		/// 종목명
		/// </summary>
		public string? StockName;
		/// <summary>
		/// 종목코드
		/// </summary>
		public string? StockCode;
		/// <summary>
		/// 날짜
		/// </summary>
		public DateTime? Date;
		/// <summary>
		/// 시간
		/// </summary>
		public TimeSpan? Time;
		/// <summary>
		/// 전일종가
		/// </summary>
		public decimal? PreviousDayClose;
		/// <summary>
		/// 전일거래량
		/// </summary>
		public decimal? PreviousDayVolume;
		/// <summary>
		/// 상한가
		/// </summary>
		public decimal? UpperPrice;
		/// <summary>
		/// 하한가
		/// </summary>
		public decimal? LowerPrice;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		public decimal? PreviousDayTransactionAmount;
		/// <summary>
		/// 상장주식수
		/// </summary>
		public decimal? ListedQuantity;
		/// <summary>
		/// 현재가
		/// </summary>
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 부호
		/// </summary>
		public string? Sign;
		/// <summary>
		/// 등락률
		/// </summary>
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 전일비
		/// </summary>
		public KiwoomDecimal? PreviousDayRate;
		/// <summary>
		/// 시가
		/// </summary>
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가
		/// </summary>
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가
		/// </summary>
		public KiwoomDecimal? Low;
		/// <summary>
		/// 체결량
		/// </summary>
		public decimal? TradeQuantity;
		/// <summary>
		/// 거래량
		/// </summary>
		public decimal? Volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		public decimal? TransactionAmount;
		/// <summary>
		/// 예상체결가
		/// </summary>
		public decimal? ExpectedTradePrice;
		/// <summary>
		/// 예상체결량
		/// </summary>
		public decimal? ExpectedTradeQuantity;
		/// <summary>
		/// 예상매도우선호가
		/// </summary>
		public decimal? ExpectedBestSellQuote;
		/// <summary>
		/// 예상매수우선호가
		/// </summary>
		public decimal? ExpectedBestBuyQuote;
		/// <summary>
		/// 거래시작일
		/// </summary>
		public DateTime? TradeStartDate;
		/// <summary>
		/// 행사가격
		/// </summary>
		public decimal? ExercisePrice;
		/// <summary>
		/// 최고가
		/// </summary>
		public decimal? HighestPrice;
		/// <summary>
		/// 최저가
		/// </summary>
		public decimal? LowestPrice;
		/// <summary>
		/// 최고가일
		/// </summary>
		public DateTime? HighestPriceDate;
		/// <summary>
		/// 최저가일
		/// </summary>
		public DateTime? LowestPriceDate;

		/// <summary>
		/// 매도호가
		/// </summary>
		public decimal?[] SellPrices;
		/// <summary>
		/// 매수호가
		/// </summary>
		public decimal?[] BuyPrices;
		/// <summary>
		/// 매도잔량
		/// </summary>
		public decimal?[] SellQuantities;
		/// <summary>
		/// 매수잔량
		/// </summary>
		public decimal?[] BuyQuantities;
		/// <summary>
		/// 매도호가직전대비
		/// </summary>
		public decimal?[] SellChanges;
		/// <summary>
		/// 매수호가직전대비
		/// </summary>
		public decimal?[] BuyChanges;
		/// <summary>
		/// 매도호가건수
		/// </summary>
		public int?[] SellCounts;
		/// <summary>
		/// 매수호가건수
		/// </summary>
		public int?[] BuyCounts;
		/// <summary>
		/// LP매도호가잔량
		/// </summary>
		public decimal?[] LpSellQuantities;
		/// <summary>
		/// LP매수호가잔량
		/// </summary>
		public decimal?[] LpBuyQuantities;

		/// <summary>
		/// 총매수잔량
		/// </summary>
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 총매도잔량
		/// </summary>
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 총매수건수
		/// </summary>
		public int? TotalBuyCount;
		/// <summary>
		/// 총매도건수
		/// </summary>
		public int? TotalSellCount;

		public KiwoomMarketConditionGetQuoteList(KiwoomMarketConditionGetQuote raw)
		{
			StockName = raw.StockName;
			StockCode = raw.StockCode;
			Date = raw.Date;
			Time = raw.Time;
			PreviousDayClose = raw.PreviousDayClose;
			PreviousDayVolume = raw.PreviousDayVolume;
			UpperPrice = raw.UpperPrice;
			LowerPrice = raw.LowerPrice;
			PreviousDayTransactionAmount = raw.PreviousDayTransactionAmount;
			ListedQuantity = raw.ListedQuantity;
			CurrentPrice = raw.CurrentPrice;
			Sign = raw.Sign;
			ChangeRate = raw.ChangeRate;
			PreviousDayRate = raw.PreviousDayRate;
			Open = raw.Open;
			High = raw.High;
			Low = raw.Low;
			TradeQuantity = raw.TradeQuantity;
			Volume = raw.Volume;
			TransactionAmount = raw.TransactionAmount;
			ExpectedTradePrice = raw.ExpectedTradePrice;
			ExpectedTradeQuantity = raw.ExpectedTradeQuantity;
			ExpectedBestSellQuote = raw.ExpectedBestSellQuote;
			ExpectedBestBuyQuote = raw.ExpectedBestBuyQuote;
			TradeStartDate = raw.TradeStartDate;
			ExercisePrice = raw.ExercisePrice;
			HighestPrice = raw.HighestPrice;
			LowestPrice = raw.LowestPrice;
			HighestPriceDate = raw.HighestPriceDate;
			LowestPriceDate = raw.LowestPriceDate;
			SellPrices =
			[
				raw.SellPrice1, raw.SellPrice2, raw.SellPrice3, raw.SellPrice4, raw.SellPrice5,
				raw.SellPrice6, raw.SellPrice7, raw.SellPrice8, raw.SellPrice9, raw.SellPrice10
			];
			BuyPrices =
			[
				raw.BuyPrice1, raw.BuyPrice2, raw.BuyPrice3, raw.BuyPrice4, raw.BuyPrice5,
				raw.BuyPrice6, raw.BuyPrice7, raw.BuyPrice8, raw.BuyPrice9, raw.BuyPrice10
			];
			SellQuantities =
			[
				raw.SellQuantity1, raw.SellQuantity2, raw.SellQuantity3, raw.SellQuantity4, raw.SellQuantity5,
				raw.SellQuantity6, raw.SellQuantity7, raw.SellQuantity8, raw.SellQuantity9, raw.SellQuantity10
			];
			BuyQuantities =
			[
				raw.BuyQuantity1, raw.BuyQuantity2, raw.BuyQuantity3, raw.BuyQuantity4, raw.BuyQuantity5,
				raw.BuyQuantity6, raw.BuyQuantity7, raw.BuyQuantity8, raw.BuyQuantity9, raw.BuyQuantity10
			];
			SellChanges =
			[
				raw.SellChange1, raw.SellChange2, raw.SellChange3, raw.SellChange4, raw.SellChange5,
				raw.SellChange6, raw.SellChange7, raw.SellChange8, raw.SellChange9, raw.SellChange10
			];
			BuyChanges =
			[
				raw.BuyChange1, raw.BuyChange2, raw.BuyChange3, raw.BuyChange4, raw.BuyChange5,
				raw.BuyChange6, raw.BuyChange7, raw.BuyChange8, raw.BuyChange9, raw.BuyChange10
			];
			SellCounts =
			[
				raw.SellCount1, raw.SellCount2, raw.SellCount3, raw.SellCount4, raw.SellCount5
			];
			BuyCounts =
			[
				raw.BuyCount1, raw.BuyCount2, raw.BuyCount3, raw.BuyCount4, raw.BuyCount5
			];
			LpSellQuantities =
			[
				raw.LpSellQuantity1, raw.LpSellQuantity2, raw.LpSellQuantity3, raw.LpSellQuantity4, raw.LpSellQuantity5,
				raw.LpSellQuantity6, raw.LpSellQuantity7, raw.LpSellQuantity8, raw.LpSellQuantity9, raw.LpSellQuantity10
			];
			LpBuyQuantities =
			[
				raw.LpBuyQuantity1, raw.LpBuyQuantity2, raw.LpBuyQuantity3, raw.LpBuyQuantity4, raw.LpBuyQuantity5,
				raw.LpBuyQuantity6, raw.LpBuyQuantity7, raw.LpBuyQuantity8, raw.LpBuyQuantity9, raw.LpBuyQuantity10
			];
			TotalBuyQuantity = raw.TotalBuyQuantity;
			TotalSellQuantity = raw.TotalSellQuantity;
			TotalBuyCount = raw.TotalBuyCount;
			TotalSellCount = raw.TotalSellCount;
		}
	}

	public record KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings
	{
		/// <summary>
		/// 신주인수권시세
		/// </summary>
		[JsonProperty("newstk_recvrht_mrpr")]
		public IEnumerable<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferingItem>? Items;
	}
	public record KiwoomMarketConditionGetAllMarketQuoteForRightsOfferingItem
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
		/// 최우선매도호가
		/// </summary>
		[JsonProperty("fpr_sel_bid")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// 최우선매수호가
		/// </summary>
		[JsonProperty("fpr_buy_bid")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
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
	}

	public record KiwoomMarketConditionGetDailyInstitutionTradingStocks
	{
		/// <summary>
		/// 일별기관매매종목
		/// </summary>
		[JsonProperty("daly_orgn_trde_stk")]
		public IEnumerable<KiwoomMarketConditionGetDailyInstitutionTradingStockItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyInstitutionTradingStockItem
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
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetBuyQuantity;
		/// <summary>
		/// 순매수금액
		/// </summary>
		[JsonProperty("netprps_amt")]
		public KiwoomDecimal? NetBuyAmount;
		/// <summary>
		/// 추정평균가
		/// </summary>
		[JsonProperty("prsm_avg_pric")]
		public decimal? EstimatedAveragePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 평균가대비
		/// </summary>
		[JsonProperty("avg_pric_pre")]
		public KiwoomDecimal? AveragePriceChange;
		/// <summary>
		/// 대비율
		/// </summary>
		[JsonProperty("pre_rt")]
		public KiwoomDecimal? ChangeRate;
	}

	public record KiwoomMarketConditionGetStockInstitutionTransactionTrends
	{
		/// <summary>
		/// 기관추정평균가
		/// </summary>
		[JsonProperty("orgn_prsm_avg_pric")]
		public decimal? InstitutionEstimatedAveragePrice;
		/// <summary>
		/// 외인추정평균가
		/// </summary>
		[JsonProperty("for_prsm_avg_pric")]
		public decimal? ForeignEstimatedAveragePrice;
		/// <summary>
		/// 종목별기관매매추이
		/// </summary>
		[JsonProperty("stk_orgn_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockInstitutionTransactionTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockInstitutionTransactionTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
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
		/// 기관기간누적
		/// </summary>
		[JsonProperty("orgn_dt_acc")]
		public KiwoomDecimal? InstitutionPeriodAccumulation;
		/// <summary>
		/// 기관일별순매매수량
		/// </summary>
		[JsonProperty("orgn_daly_nettrde_qty")]
		public KiwoomDecimal? InstitutionDailyNetVolume;
		/// <summary>
		/// 외인기간누적
		/// </summary>
		[JsonProperty("for_dt_acc")]
		public KiwoomDecimal? ForeignPeriodAccumulation;
		/// <summary>
		/// 외인일별순매매수량
		/// </summary>
		[JsonProperty("for_daly_nettrde_qty")]
		public KiwoomDecimal? ForeignDailyNetVolume;
		/// <summary>
		/// 한도소진율
		/// </summary>
		[JsonProperty("limit_exh_rt")]
		public KiwoomDecimal? LimitUsageRate;
	}

	public record KiwoomMarketConditionGetHourlyTradeMomentums
	{
		/// <summary>
		/// 체결강도시간별
		/// </summary>
		[JsonProperty("cntr_str_tm")]
		public IEnumerable<KiwoomMarketConditionGetHourlyTradeMomentumItem>? Items;
	}
	public record KiwoomMarketConditionGetHourlyTradeMomentumItem
	{
		/// <summary>
		/// 체결시간
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
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public KiwoomDecimal? Volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 체결강도5분
		/// </summary>
		[JsonProperty("cntr_str_5min")]
		public decimal? TradeMomentum5m;
		/// <summary>
		/// 체결강도20분
		/// </summary>
		[JsonProperty("cntr_str_20min")]
		public decimal? TradeMomentum20m;
		/// <summary>
		/// 체결강도60분
		/// </summary>
		[JsonProperty("cntr_str_60min")]
		public decimal? TradeMomentum60m;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomMarketConditionStockExchangeType? ExchangeType;
	}

	public record KiwoomMarketConditionGetDailyTradeMomentums
	{
		/// <summary>
		/// 체결강도일별
		/// </summary>
		[JsonProperty("cntr_str_daly")]
		public IEnumerable<KiwoomMarketConditionGetDailyTradeMomentumItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyTradeMomentumItem
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
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pred_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public KiwoomDecimal? Volume;
		/// <summary>
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 체결강도5일
		/// </summary>
		[JsonProperty("cntr_str_5min")]
		public decimal? TradeMomentum5d;
		/// <summary>
		/// 체결강도20일
		/// </summary>
		[JsonProperty("cntr_str_20min")]
		public decimal? TradeMomentum20d;
		/// <summary>
		/// 체결강도60일
		/// </summary>
		[JsonProperty("cntr_str_60min")]
		public decimal? TradeMomentum60d;
	}

	public record KiwoomMarketConditionGetIntradayInvestorTradings
	{
		/// <summary>
		/// 장중투자자별매매
		/// </summary>
		[JsonProperty("opmr_invsr_trde")]
		public IEnumerable<KiwoomMarketConditionGetIntradayInvestorTradingItem>? Items;
	}
	public record KiwoomMarketConditionGetIntradayInvestorTradingItem
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
		/// 순매수금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("netprps_amt")]
		public KiwoomDecimal? NetBuyAmount;
		/// <summary>
		/// 이전순매수금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("prev_netprps_amt")]
		public KiwoomDecimal? PreviousNetBuyAmount;
		/// <summary>
		/// 매수금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("buy_amt")]
		public KiwoomDecimal? BuyAmount;
		/// <summary>
		/// 순매수금액증감 (단위: 백만원)
		/// </summary>
		[JsonProperty("netprps_amt_irds")]
		public KiwoomDecimal? NetBuyAmountChange;
		/// <summary>
		/// 매수금액증감 (단위: 백만원)
		/// </summary>
		[JsonProperty("buy_amt_irds")]
		public KiwoomDecimal? BuyAmountChange;
		/// <summary>
		/// 매도금액 (단위: 백만원)
		/// </summary>
		[JsonProperty("sell_amt")]
		public KiwoomDecimal? SellAmount;
		/// <summary>
		/// 매도금액증감 (단위: 백만원)
		/// </summary>
		[JsonProperty("sell_amt_irds")]
		public KiwoomDecimal? SellAmountChange;
		/// <summary>
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetBuyQuantity;
		/// <summary>
		/// 이전시점순매수수량
		/// </summary>
		[JsonProperty("prev_pot_netprps_qty")]
		public KiwoomDecimal? PreviousNetBuyQuantity;
		/// <summary>
		/// 순매수증감
		/// </summary>
		[JsonProperty("netprps_irds")]
		public KiwoomDecimal? NetBuyChange;
		/// <summary>
		/// 매수수량
		/// </summary>
		[JsonProperty("buy_qty")]
		public KiwoomDecimal? BuyQuantity;
		/// <summary>
		/// 매수수량증감
		/// </summary>
		[JsonProperty("buy_qty_irds")]
		public KiwoomDecimal? BuyQuantityChange;
		/// <summary>
		/// 매도수량
		/// </summary>
		[JsonProperty("sell_qty")]
		public KiwoomDecimal? SellQuantity;
		/// <summary>
		/// 매도수량증감
		/// </summary>
		[JsonProperty("sell_qty_irds")]
		public KiwoomDecimal? SellQuantityChange;
	}

	public record KiwoomMarketConditionGetIntradayInvestorTradeCharts
	{
		/// <summary>
		/// 장중투자자별매매차트
		/// </summary>
		[JsonProperty("opaf_invsr_trde")]
		public IEnumerable<KiwoomMarketConditionGetIntradayInvestorTradeChartItem>? Items;
	}
	public record KiwoomMarketConditionGetIntradayInvestorTradeChartItem
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
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public decimal? RetailInvestor;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public decimal? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public decimal? Institution;
		/// <summary>
		/// 금융투자
		/// </summary>
		[JsonProperty("fnnc_invt")]
		public decimal? FinancialInvestment;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public decimal? Insurance;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public decimal? InvestmentTrust;
		/// <summary>
		/// 기타금융
		/// </summary>
		[JsonProperty("etc_fnnc")]
		public decimal? OtherFinancials;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public decimal? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public decimal? PensionEtc;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[JsonProperty("samo_fund")]
		public decimal? PrivateFund;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public decimal? Nation;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public decimal? OtherCorporations;
	}

	public record KiwoomMarketConditionGetSecurityFirmStockTradeTrends
	{
		/// <summary>
		/// 증권사별종목매매동향
		/// </summary>
		[JsonProperty("sec_stk_trde_trend")]
		public IEnumerable<KiwoomMarketConditionGetSecurityFirmStockTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetSecurityFirmStockTradeTrendItem
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
		/// 순매수수량
		/// </summary>
		[JsonProperty("netprps_qty")]
		public KiwoomDecimal? NetBuyQuantity;
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
	}

	public record KiwoomMarketConditionGetDailyStockPrices
	{
		/// <summary>
		/// 일별주가
		/// </summary>
		[JsonProperty("daly_stkpc")]
		public IEnumerable<KiwoomMarketConditionGetDailyStockPriceItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyStockPriceItem
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
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
		/// 종가
		/// </summary>
		[JsonProperty("close_pric")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public KiwoomDecimal? PreviousDayRate;
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
		/// 금액(백만)
		/// </summary>
		[JsonProperty("amt_mn")]
		public decimal? AmountInMillions;
		/// <summary>
		/// 신용비
		/// </summary>
		[JsonProperty("crd_rt")]
		public decimal? CreditRate;
		/// <summary>
		/// 개인
		/// </summary>
		[JsonProperty("ind")]
		public KiwoomDecimal? Retail;
		/// <summary>
		/// 기관
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institution;
		/// <summary>
		/// 외인수량
		/// </summary>
		[JsonProperty("for_qty")]
		public KiwoomDecimal? ForeignQuantity;
		/// <summary>
		/// 외국계
		/// </summary>
		[JsonProperty("frgn")]
		public KiwoomDecimal? Foreign;
		/// <summary>
		/// 프로그램
		/// </summary>
		[JsonProperty("prm")]
		public KiwoomDecimal? Program;
		/// <summary>
		/// 외인비
		/// </summary>
		[JsonProperty("for_rt")]
		public KiwoomDecimal? ForeignRate;
		/// <summary>
		/// 외인보유
		/// </summary>
		[JsonProperty("for_poss")]
		public KiwoomDecimal? ForeignHolding;
		/// <summary>
		/// 외인비중
		/// </summary>
		[JsonProperty("for_wght")]
		public KiwoomDecimal? ForeignWeight;
		/// <summary>
		/// 외인순매수
		/// </summary>
		[JsonProperty("for_netprps")]
		public KiwoomDecimal? ForeignNetBuy;
		/// <summary>
		/// 기관순매수
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public KiwoomDecimal? InstitutionNetBuy;
		/// <summary>
		/// 개인순매수
		/// </summary>
		[JsonProperty("ind_netprps")]
		public KiwoomDecimal? RetailNetBuy;
		/// <summary>
		/// 신용잔고율
		/// </summary>
		[JsonProperty("crd_remn_rt")]
		public decimal? CreditBalanceRate;
	}

	public record KiwoomMarketConditionGetAfterMarketSinglePriceOrderBook
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		[JsonProperty("bid_req_base_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderBookTime;
		/// <summary>
		/// 시간외단일가 매도호가직전대비5
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_5")]
		public decimal? AfterMarketSinglePriceSellChange5;
		/// <summary>
		/// 시간외단일가 매도호가직전대비4
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_4")]
		public decimal? AfterMarketSinglePriceSellChange4;
		/// <summary>
		/// 시간외단일가 매도호가직전대비3
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_3")]
		public decimal? AfterMarketSinglePriceSellChange3;
		/// <summary>
		/// 시간외단일가 매도호가직전대비2
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_2")]
		public decimal? AfterMarketSinglePriceSellChange2;
		/// <summary>
		/// 시간외단일가 매도호가직전대비1
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_jub_pre_1")]
		public decimal? AfterMarketSinglePriceSellChange1;
		/// <summary>
		/// 시간외단일가 매도호가수량5
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_5")]
		public decimal? AfterMarketSinglePriceSellQuantity5;
		/// <summary>
		/// 시간외단일가 매도호가수량4
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_4")]
		public decimal? AfterMarketSinglePriceSellQuantity4;
		/// <summary>
		/// 시간외단일가 매도호가수량3
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_3")]
		public decimal? AfterMarketSinglePriceSellQuantity3;
		/// <summary>
		/// 시간외단일가 매도호가수량2
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_2")]
		public decimal? AfterMarketSinglePriceSellQuantity2;
		/// <summary>
		/// 시간외단일가 매도호가수량1
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_qty_1")]
		public decimal? AfterMarketSinglePriceSellQuantity1;
		/// <summary>
		/// 시간외단일가 매도호가5
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_5")]
		public KiwoomDecimal? AfterMarketSinglePriceSellPrice5;
		/// <summary>
		/// 시간외단일가 매도호가4
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_4")]
		public KiwoomDecimal? AfterMarketSinglePriceSellPrice4;
		/// <summary>
		/// 시간외단일가 매도호가3
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_3")]
		public KiwoomDecimal? AfterMarketSinglePriceSellPrice3;
		/// <summary>
		/// 시간외단일가 매도호가2
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_2")]
		public KiwoomDecimal? AfterMarketSinglePriceSellPrice2;
		/// <summary>
		/// 시간외단일가 매도호가1
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_1")]
		public KiwoomDecimal? AfterMarketSinglePriceSellPrice1;
		/// <summary>
		/// 시간외단일가 매수호가1
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_1")]
		public KiwoomDecimal? AfterMarketSinglePriceBuyPrice1;
		/// <summary>
		/// 시간외단일가 매수호가2
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_2")]
		public KiwoomDecimal? AfterMarketSinglePriceBuyPrice2;
		/// <summary>
		/// 시간외단일가 매수호가3
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_3")]
		public KiwoomDecimal? AfterMarketSinglePriceBuyPrice3;
		/// <summary>
		/// 시간외단일가 매수호가4
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_4")]
		public KiwoomDecimal? AfterMarketSinglePriceBuyPrice4;
		/// <summary>
		/// 시간외단일가 매수호가5
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_5")]
		public KiwoomDecimal? AfterMarketSinglePriceBuyPrice5;
		/// <summary>
		/// 시간외단일가 매수호가수량1
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_1")]
		public decimal? AfterMarketSinglePriceBuyQuantity1;
		/// <summary>
		/// 시간외단일가 매수호가수량2
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_2")]
		public decimal? AfterMarketSinglePriceBuyQuantity2;
		/// <summary>
		/// 시간외단일가 매수호가수량3
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_3")]
		public decimal? AfterMarketSinglePriceBuyQuantity3;
		/// <summary>
		/// 시간외단일가 매수호가수량4
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_4")]
		public decimal? AfterMarketSinglePriceBuyQuantity4;
		/// <summary>
		/// 시간외단일가 매수호가수량5
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_qty_5")]
		public decimal? AfterMarketSinglePriceBuyQuantity5;
		/// <summary>
		/// 시간외단일가 매수호가직전대비1
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_1")]
		public decimal? AfterMarketSinglePriceBuyChange1;
		/// <summary>
		/// 시간외단일가 매수호가직전대비2
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_2")]
		public decimal? AfterMarketSinglePriceBuyChange2;
		/// <summary>
		/// 시간외단일가 매수호가직전대비3
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_3")]
		public decimal? AfterMarketSinglePriceBuyChange3;
		/// <summary>
		/// 시간외단일가 매수호가직전대비4
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_4")]
		public decimal? AfterMarketSinglePriceBuyChange4;
		/// <summary>
		/// 시간외단일가 매수호가직전대비5
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_jub_pre_5")]
		public decimal? AfterMarketSinglePriceBuyChange5;
		/// <summary>
		/// 시간외단일가 매도호가총잔량
		/// </summary>
		[JsonProperty("ovt_sigpric_sel_bid_tot_req")]
		public decimal? TotalAfterMarketSinglePriceSellQuantity;
		/// <summary>
		/// 시간외단일가 매수호가총잔량
		/// </summary>
		[JsonProperty("ovt_sigpric_buy_bid_tot_req")]
		public decimal? TotalAfterMarketSinglePriceBuyQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비
		/// </summary>
		[JsonProperty("sel_bid_tot_req_jub_pre")]
		public KiwoomDecimal? TotalSellQuantityChange;
		/// <summary>
		/// 매도호가총잔량
		/// </summary>
		[JsonProperty("sel_bid_tot_req")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 매수호가총잔량
		/// </summary>
		[JsonProperty("buy_bid_tot_req")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비
		/// </summary>
		[JsonProperty("buy_bid_tot_req_jub_pre")]
		public KiwoomDecimal? TotalBuyQuantityChange;
		/// <summary>
		/// 시간외매도호가총잔량직전대비
		/// </summary>
		[JsonProperty("ovt_sel_bid_tot_req_jub_pre")]
		public decimal? TotalAfterMarketSellQuantityChange;
		/// <summary>
		/// 시간외매도호가총잔량
		/// </summary>
		[JsonProperty("ovt_sel_bid_tot_req")]
		public decimal? TotalAfterMarketSellQuantity;
		/// <summary>
		/// 시간외매수호가총잔량
		/// </summary>
		[JsonProperty("ovt_buy_bid_tot_req")]
		public decimal? TotalAfterMarketBuyQuantity;
		/// <summary>
		/// 시간외매수호가총잔량직전대비
		/// </summary>
		[JsonProperty("ovt_buy_bid_tot_req_jub_pre")]
		public decimal? TotalAfterMarketBuyQuantityChange;
		/// <summary>
		/// 시간외단일가 현재가
		/// </summary>
		[JsonProperty("ovt_sigpric_cur_prc")]
		public decimal? AfterMarketSinglePriceCurrentPrice;
		/// <summary>
		/// 시간외단일가 전일대비기호
		/// </summary>
		[JsonProperty("ovt_sigpric_pred_pre_sig")]
		public string? AfterMarketSinglePriceChangeSign;
		/// <summary>
		/// 시간외단일가 전일대비
		/// </summary>
		[JsonProperty("ovt_sigpric_pred_pre")]
		public KiwoomDecimal? AfterMarketSinglePriceChange;
		/// <summary>
		/// 시간외단일가 등락률
		/// </summary>
		[JsonProperty("ovt_sigpric_flu_rt")]
		public KiwoomDecimal? AfterMarketSinglePriceChangeRate;
		/// <summary>
		/// 시간외단일가 누적거래량
		/// </summary>
		[JsonProperty("ovt_sigpric_acc_trde_qty")]
		public decimal? AfterMarketSinglePriceAccumulatedVolume;
	}

	public record KiwoomMarketConditionGetAfterMarketSinglePriceOrderBookList
	{
		/// <summary>
		/// 호가잔량기준시간
		/// </summary>
		public TimeSpan? OrderbookTime;
		/// <summary>
		/// 시간외단일가 매도호가직전대비
		/// </summary>
		public decimal?[] AfterMarketSinglePriceSellChanges;
		/// <summary>
		/// 시간외단일가 매도호가수량
		/// </summary>
		public decimal?[] AfterMarketSinglePriceSellQuantities;
		/// <summary>
		/// 시간외단일가 매도호가
		/// </summary>
		public KiwoomDecimal?[] AfterMarketSinglePriceSellPrices;
		/// <summary>
		/// 시간외단일가 매수호가
		/// </summary>
		public KiwoomDecimal?[] AfterMarketSinglePriceBuyPrices;
		/// <summary>
		/// 시간외단일가 매수호가수량
		/// </summary>
		public decimal?[] AfterMarketSinglePriceBuyQuantities;
		/// <summary>
		/// 시간외단일가 매수호가직전대비
		/// </summary>
		public decimal?[] AfterMarketSinglePriceBuyChanges;
		/// <summary>
		/// 시간외단일가 매도호가총잔량
		/// </summary>
		public decimal? TotalAfterMarketSinglePriceSellQuantity;
		/// <summary>
		/// 시간외단일가 매수호가총잔량
		/// </summary>
		public decimal? TotalAfterMarketSinglePriceBuyQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비
		/// </summary>
		public decimal? TotalSellQuantityChange;
		/// <summary>
		/// 매도호가총잔량
		/// </summary>
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 매수호가총잔량
		/// </summary>
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비
		/// </summary>
		public decimal? TotalBuyQuantityChange;
		/// <summary>
		/// 시간외매도호가총잔량직전대비
		/// </summary>
		public decimal? TotalAfterMarketSellQuantityChange;
		/// <summary>
		/// 시간외매도호가총잔량
		/// </summary>
		public decimal? TotalAfterMarketSellQuantity;
		/// <summary>
		/// 시간외매수호가총잔량
		/// </summary>
		public decimal? TotalAfterMarketBuyQuantity;
		/// <summary>
		/// 시간외매수호가총잔량직전대비
		/// </summary>
		public decimal? TotalAfterMarketBuyQuantityChange;
		/// <summary>
		/// 시간외단일가 현재가
		/// </summary>
		public decimal? AfterMarketSinglePriceCurrentPrice;
		/// <summary>
		/// 시간외단일가 전일대비기호
		/// </summary>
		public string? AfterMarketSinglePriceChangeSign;
		/// <summary>
		/// 시간외단일가 전일대비
		/// </summary>
		public KiwoomDecimal? AfterMarketSinglePriceChange;
		/// <summary>
		/// 시간외단일가 등락률
		/// </summary>
		public KiwoomDecimal? AfterMarketSinglePriceChangeRate;
		/// <summary>
		/// 시간외단일가 누적거래량
		/// </summary>
		public decimal? AfterMarketSinglePriceAccumulatedVolume;

		public KiwoomMarketConditionGetAfterMarketSinglePriceOrderBookList(KiwoomMarketConditionGetAfterMarketSinglePriceOrderBook raw)
		{
			OrderbookTime = raw.OrderBookTime;
			AfterMarketSinglePriceSellChanges =
			[
				raw.AfterMarketSinglePriceSellChange5, raw.AfterMarketSinglePriceSellChange4,
				raw.AfterMarketSinglePriceSellChange3, raw.AfterMarketSinglePriceSellChange2,
				raw.AfterMarketSinglePriceSellChange1
			];
			AfterMarketSinglePriceSellQuantities =
			[
				raw.AfterMarketSinglePriceSellQuantity5, raw.AfterMarketSinglePriceSellQuantity4,
				raw.AfterMarketSinglePriceSellQuantity3, raw.AfterMarketSinglePriceSellQuantity2,
				raw.AfterMarketSinglePriceSellQuantity1
			];
			AfterMarketSinglePriceSellPrices =
			[
				raw.AfterMarketSinglePriceSellPrice5, raw.AfterMarketSinglePriceSellPrice4,
				raw.AfterMarketSinglePriceSellPrice3, raw.AfterMarketSinglePriceSellPrice2,
				raw.AfterMarketSinglePriceSellPrice1
			];
			AfterMarketSinglePriceBuyPrices =
			[
				raw.AfterMarketSinglePriceBuyPrice1, raw.AfterMarketSinglePriceBuyPrice2,
				raw.AfterMarketSinglePriceBuyPrice3, raw.AfterMarketSinglePriceBuyPrice4,
				raw.AfterMarketSinglePriceBuyPrice5
			];
			AfterMarketSinglePriceBuyQuantities =
			[
				raw.AfterMarketSinglePriceBuyQuantity1, raw.AfterMarketSinglePriceBuyQuantity2,
				raw.AfterMarketSinglePriceBuyQuantity3, raw.AfterMarketSinglePriceBuyQuantity4,
				raw.AfterMarketSinglePriceBuyQuantity5
			];
			AfterMarketSinglePriceBuyChanges =
			[
				raw.AfterMarketSinglePriceBuyChange1, raw.AfterMarketSinglePriceBuyChange2,
				raw.AfterMarketSinglePriceBuyChange3, raw.AfterMarketSinglePriceBuyChange4,
				raw.AfterMarketSinglePriceBuyChange5
			];
			TotalAfterMarketSinglePriceSellQuantity = raw.TotalAfterMarketSinglePriceSellQuantity;
			TotalAfterMarketSinglePriceBuyQuantity = raw.TotalAfterMarketSinglePriceBuyQuantity;
			TotalSellQuantityChange = raw.TotalSellQuantityChange;
			TotalSellQuantity = raw.TotalSellQuantity;
			TotalBuyQuantity = raw.TotalBuyQuantity;
			TotalBuyQuantityChange = raw.TotalBuyQuantityChange;
			TotalAfterMarketSellQuantityChange = raw.TotalAfterMarketSellQuantityChange;
			TotalAfterMarketSellQuantity = raw.TotalAfterMarketSellQuantity;
			TotalAfterMarketBuyQuantity = raw.TotalAfterMarketBuyQuantity;
			TotalAfterMarketBuyQuantityChange = raw.TotalAfterMarketBuyQuantityChange;
			AfterMarketSinglePriceCurrentPrice = raw.AfterMarketSinglePriceCurrentPrice;
			AfterMarketSinglePriceChangeSign = raw.AfterMarketSinglePriceChangeSign;
			AfterMarketSinglePriceChange = raw.AfterMarketSinglePriceChange;
			AfterMarketSinglePriceChangeRate = raw.AfterMarketSinglePriceChangeRate;
			AfterMarketSinglePriceAccumulatedVolume = raw.AfterMarketSinglePriceAccumulatedVolume;
		}
	}

	public record KiwoomMarketConditionGetGoldTradeTrends
	{
		/// <summary>
		/// 금현물체결추이
		/// </summary>
		[JsonProperty("gold_cntr")]
		public IEnumerable<KiwoomMarketConditionGetGoldTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetGoldTradeTrendItem
	{
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public KiwoomDecimal? TradePrice;
		/// <summary>
		/// 전일 대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적 거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 거래량(체결량)
		/// </summary>
		[JsonProperty("cntr_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("pri_sel_bid_unit")]
		public KiwoomDecimal? SellPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("pri_buy_bid_unit")]
		public KiwoomDecimal? BuyPrice;
		/// <summary>
		/// 전일 거래량 대비 비율
		/// </summary>
		[JsonProperty("trde_pre")]
		public KiwoomDecimal? TransactionChange;
		/// <summary>
		/// 전일 거래량 대비 순간 거래량 비율
		/// </summary>
		[JsonProperty("trde_tern_rt")]
		public KiwoomDecimal? TradeTurnoverRate;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
	}

	public record KiwoomMarketConditionGetGoldDailyTrends
	{
		/// <summary>
		/// 금현물일별추이
		/// </summary>
		[JsonProperty("gold_daly_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetGoldDailyTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetGoldDailyTrendItem
	{
		/// <summary>
		/// 종가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? Close;
		/// <summary>
		/// 전일 대비
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적 거래대금(백만)
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount1M;
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
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 기관 순매수 수량
		/// </summary>
		[JsonProperty("orgn_netprps")]
		public KiwoomDecimal? InstitutionNetBuyQuantity;
		/// <summary>
		/// 외국인 순매수 수량
		/// </summary>
		[JsonProperty("for_netprps")]
		public KiwoomDecimal? ForeignNetBuyQuantity;
		/// <summary>
		/// 순매매량(개인)
		/// </summary>
		[JsonProperty("ind_netprps")]
		public KiwoomDecimal? RetailNetBuy;
	}

	public record KiwoomMarketConditionGetGoldExpectedTrades
	{
		/// <summary>
		/// 금현물예상체결
		/// </summary>
		[JsonProperty("gold_expt_exec")]
		public IEnumerable<KiwoomMarketConditionGetGoldExpectedTradeItem>? Items;
	}
	public record KiwoomMarketConditionGetGoldExpectedTradeItem
	{
		/// <summary>
		/// 예상 체결가
		/// </summary>
		[JsonProperty("exp_cntr_pric")]
		public KiwoomDecimal? ExpectedTradePrice;
		/// <summary>
		/// 예상 체결가 전일대비
		/// </summary>
		[JsonProperty("exp_pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 예상 체결가 등락율
		/// </summary>
		[JsonProperty("exp_flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 예상 체결 수량(누적)
		/// </summary>
		[JsonProperty("exp_acc_trde_qty")]
		public decimal? ExpectedAccumulatedVolume;
		/// <summary>
		/// 예상 체결 수량
		/// </summary>
		[JsonProperty("exp_cntr_trde_qty")]
		public KiwoomDecimal? ExpectedVolume;
		/// <summary>
		/// 예상 체결 시간
		/// </summary>
		[JsonProperty("exp_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpectedTradeTime;
		/// <summary>
		/// 예상 체결가 전일대비기호
		/// </summary>
		[JsonProperty("exp_pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 거래소 구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomMarketConditionStockExchangeType? ExchangeType;
	}

	public record KiwoomMarketConditionGetGoldInfo
	{
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
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
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
		/// 전일비
		/// </summary>
		[JsonProperty("pred_rt")]
		public KiwoomDecimal? PreviousDayRate;
		/// <summary>
		/// 상한가
		/// </summary>
		[JsonProperty("upl_pric")]
		public KiwoomDecimal? UpperPrice;
		/// <summary>
		/// 하한가
		/// </summary>
		[JsonProperty("lst_pric")]
		public KiwoomDecimal? LowerPrice;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("pred_close_pric")]
		public KiwoomDecimal? PreviousDayClose;
	}

	public record KiwoomMarketConditionGetGoldQuotes
	{
		/// <summary>
		/// 금현물호가
		/// </summary>
		[JsonProperty("gold_bid")]
		public IEnumerable<KiwoomMarketConditionGetGoldQuoteItem>? Items;
	}
	public record KiwoomMarketConditionGetGoldQuoteItem
	{
		/// <summary>
		/// 체결가
		/// </summary>
		[JsonProperty("cntr_pric")]
		public KiwoomDecimal? TradePrice;
		/// <summary>
		/// 전일 대비(원)
		/// </summary>
		[JsonProperty("pred_pre")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적 거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 거래량(체결량)
		/// </summary>
		[JsonProperty("cntr_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
		/// <summary>
		/// 전일대비기호
		/// </summary>
		[JsonProperty("pre_sig")]
		public string? ChangeSign;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("pri_sel_bid_unit")]
		public KiwoomDecimal? SellPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("pri_buy_bid_unit")]
		public KiwoomDecimal? BuyPrice;
		/// <summary>
		/// 전일 거래량 대비 비율
		/// </summary>
		[JsonProperty("trde_pre")]
		public KiwoomDecimal? TransactionChange;
		/// <summary>
		/// 전일 거래량 대비 순간 거래량 비율
		/// </summary>
		[JsonProperty("trde_tern_rt")]
		public KiwoomDecimal? TradeTurnoverRate;
		/// <summary>
		/// 체결강도
		/// </summary>
		[JsonProperty("cntr_str")]
		public decimal? TradeMomentum;
		/// <summary>
		/// K.O 접근도
		/// </summary>
		[JsonProperty("lpmmcm_nm_1")]
		public string? KnockOutProximity;
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomMarketConditionStockExchangeType? ExchangeType;
	}

	public record KiwoomMarketConditionGetHourlyProgramTradeTrends
	{
		/// <summary>
		/// 프로그램매매추이
		/// </summary>
		[JsonProperty("prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetHourlyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetHourlyProgramTradeTrendItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 차익거래매도
		/// </summary>
		[JsonProperty("dfrt_trde_sel")]
		public decimal? ArbitrageTransactionSell;
		/// <summary>
		/// 차익거래매수
		/// </summary>
		[JsonProperty("dfrt_trde_buy")]
		public decimal? ArbitrageTransactionBuy;
		/// <summary>
		/// 차익거래순매수
		/// </summary>
		[JsonProperty("dfrt_trde_netprps")]
		public KiwoomDecimal? ArbitrageTransactionNetBuy;
		/// <summary>
		/// 비차익거래매도
		/// </summary>
		[JsonProperty("ndiffpro_trde_sel")]
		public decimal? NonArbitrageTransactionSell;
		/// <summary>
		/// 비차익거래매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy")]
		public decimal? NonArbitrageTransactionBuy;
		/// <summary>
		/// 비차익거래순매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps")]
		public KiwoomDecimal? NonArbitrageTransactionNetBuy;
		/// <summary>
		/// 차익거래매도수량
		/// </summary>
		[JsonProperty("dfrt_trde_sell_qty")]
		public decimal? ArbitrageSellVolume;
		/// <summary>
		/// 차익거래매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_buy_qty")]
		public decimal? ArbitrageBuyVolume;
		/// <summary>
		/// 차익거래순매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_netprps_qty")]
		public KiwoomDecimal? ArbitrageNetBuyVolume;
		/// <summary>
		/// 비차익거래매도수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_sell_qty")]
		public decimal? NonArbitrageSellVolume;
		/// <summary>
		/// 비차익거래매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy_qty")]
		public decimal? NonArbitrageBuyVolume;
		/// <summary>
		/// 비차익거래순매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps_qty")]
		public KiwoomDecimal? NonArbitrageNetBuyVolume;
		/// <summary>
		/// 전체매도
		/// </summary>
		[JsonProperty("all_sel")]
		public decimal? TotalSell;
		/// <summary>
		/// 전체매수
		/// </summary>
		[JsonProperty("all_buy")]
		public decimal? TotalBuy;
		/// <summary>
		/// 전체순매수
		/// </summary>
		[JsonProperty("all_netprps")]
		public KiwoomDecimal? TotalNetBuy;
		/// <summary>
		/// KOSPI200
		/// </summary>
		[JsonProperty("kospi200")]
		public KiwoomDecimal? Kospi200;
		/// <summary>
		/// BASIS
		/// </summary>
		[JsonProperty("basis")]
		public KiwoomDecimal? Basis;
	}

	public record KiwoomMarketConditionGetProgramArbitrageBalanceTrends
	{
		/// <summary>
		/// 프로그램매매차익잔고추이
		/// </summary>
		[JsonProperty("prm_trde_dfrt_remn_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetProgramArbitrageBalanceTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetProgramArbitrageBalanceTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// 매수차익거래수량
		/// </summary>
		[JsonProperty("buy_dfrt_trde_qty")]
		public decimal? BuyArbitrageVolume;
		/// <summary>
		/// 매수차익거래금액
		/// </summary>
		[JsonProperty("buy_dfrt_trde_amt")]
		public KiwoomDecimal? BuyArbitrageTransactionAmount;
		/// <summary>
		/// 매수차익거래증감액
		/// </summary>
		[JsonProperty("buy_dfrt_trde_irds_amt")]
		public KiwoomDecimal? BuyArbitrageChangeAmount;
		/// <summary>
		/// 매도차익거래수량
		/// </summary>
		[JsonProperty("sel_dfrt_trde_qty")]
		public decimal? SellArbitrageVolume;
		/// <summary>
		/// 매도차익거래금액
		/// </summary>
		[JsonProperty("sel_dfrt_trde_amt")]
		public decimal? SellArbitrageTransactionAmount;
		/// <summary>
		/// 매도차익거래증감액
		/// </summary>
		[JsonProperty("sel_dfrt_trde_irds_amt")]
		public decimal? SellArbitrageChangeAmount;
	}

	public record KiwoomMarketConditionGetProgramTradeAccumulatedTrends
	{
		/// <summary>
		/// 프로그램매매누적추이
		/// </summary>
		[JsonProperty("prm_trde_acc_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetProgramTradeAccumulatedTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetProgramTradeAccumulatedTrendItem
	{
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? Date;
		/// <summary>
		/// KOSPI200
		/// </summary>
		[JsonProperty("kospi200")]
		public KiwoomDecimal? Kospi200;
		/// <summary>
		/// BASIS
		/// </summary>
		[JsonProperty("basis")]
		public KiwoomDecimal? Basis;
		/// <summary>
		/// 차익거래당일
		/// </summary>
		[JsonProperty("dfrt_trde_tdy")]
		public KiwoomDecimal? ArbitrageTransactionToday;
		/// <summary>
		/// 차익거래누적
		/// </summary>
		[JsonProperty("dfrt_trde_acc")]
		public KiwoomDecimal? ArbitrageTransactionAccumulated;
		/// <summary>
		/// 비차익거래당일
		/// </summary>
		[JsonProperty("ndiffpro_trde_tdy")]
		public KiwoomDecimal? NonArbitrageTransactionToday;
		/// <summary>
		/// 비차익거래누적
		/// </summary>
		[JsonProperty("ndiffpro_trde_acc")]
		public KiwoomDecimal? NonArbitrageTransactionAccumulated;
		/// <summary>
		/// 전체당일
		/// </summary>
		[JsonProperty("all_tdy")]
		public KiwoomDecimal? TotalToday;
		/// <summary>
		/// 전체누적
		/// </summary>
		[JsonProperty("all_acc")]
		public KiwoomDecimal? TotalAccumulated;
	}

	public record KiwoomMarketConditionGetStockTimeProgramTradeTrends
	{
		/// <summary>
		/// 종목시간별프로그램매매추이
		/// </summary>
		[JsonProperty("stk_tm_prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockTimeProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockTimeProgramTradeTrendItem
	{
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
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
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 프로그램매도금액
		/// </summary>
		[JsonProperty("prm_sell_amt")]
		public decimal? ProgramSellAmount;
		/// <summary>
		/// 프로그램매수금액
		/// </summary>
		[JsonProperty("prm_buy_amt")]
		public decimal? ProgramBuyAmount;
		/// <summary>
		/// 프로그램순매수금액
		/// </summary>
		[JsonProperty("prm_netprps_amt")]
		public KiwoomDecimal? ProgramNetBuyAmount;
		/// <summary>
		/// 프로그램순매수금액증감
		/// </summary>
		[JsonProperty("prm_netprps_amt_irds")]
		public KiwoomDecimal? ProgramNetBuyAmountChange;
		/// <summary>
		/// 프로그램매도수량
		/// </summary>
		[JsonProperty("prm_sell_qty")]
		public decimal? ProgramSellQuantity;
		/// <summary>
		/// 프로그램매수수량
		/// </summary>
		[JsonProperty("prm_buy_qty")]
		public decimal? ProgramBuyQuantity;
		/// <summary>
		/// 프로그램순매수수량
		/// </summary>
		[JsonProperty("prm_netprps_qty")]
		public KiwoomDecimal? ProgramNetBuyQuantity;
		/// <summary>
		/// 프로그램순매수수량증감
		/// </summary>
		[JsonProperty("prm_netprps_qty_irds")]
		public KiwoomDecimal? ProgramNetBuyQuantityChange;
		/// <summary>
		/// 기준가시간
		/// </summary>
		[JsonProperty("base_pric_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BasePriceTime;
		/// <summary>
		/// 대차거래상환주수합
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal? TotalSecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 잔고수주합
		/// </summary>
		[JsonProperty("remn_rcvord_sum")]
		public decimal? TotalBalanceQuantity;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomMarketConditionStockExchangeType? ExchangeType;
	}

	public record KiwoomMarketConditionGetDailyProgramTradeTrends
	{
		/// <summary>
		/// 프로그램매매추이
		/// </summary>
		[JsonProperty("prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetDailyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetDailyProgramTradeTrendItem
	{
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
		/// <summary>
		/// 차익거래매도
		/// </summary>
		[JsonProperty("dfrt_trde_sel")]
		public decimal? ArbitrageTransactionSell;
		/// <summary>
		/// 차익거래매수
		/// </summary>
		[JsonProperty("dfrt_trde_buy")]
		public decimal? ArbitrageTransactionBuy;
		/// <summary>
		/// 차익거래순매수
		/// </summary>
		[JsonProperty("dfrt_trde_netprps")]
		public KiwoomDecimal? ArbitrageTransactionNetBuy;
		/// <summary>
		/// 비차익거래매도
		/// </summary>
		[JsonProperty("ndiffpro_trde_sel")]
		public decimal? NonArbitrageTransactionSell;
		/// <summary>
		/// 비차익거래매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy")]
		public decimal? NonArbitrageTransactionBuy;
		/// <summary>
		/// 비차익거래순매수
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps")]
		public KiwoomDecimal? NonArbitrageTransactionNetBuy;
		/// <summary>
		/// 차익거래매도수량
		/// </summary>
		[JsonProperty("dfrt_trde_sell_qty")]
		public decimal? ArbitrageSellVolume;
		/// <summary>
		/// 차익거래매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_buy_qty")]
		public decimal? ArbitrageBuyVolume;
		/// <summary>
		/// 차익거래순매수수량
		/// </summary>
		[JsonProperty("dfrt_trde_netprps_qty")]
		public KiwoomDecimal? ArbitrageNetBuyVolume;
		/// <summary>
		/// 비차익거래매도수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_sell_qty")]
		public decimal? NonArbitrageSellVolume;
		/// <summary>
		/// 비차익거래매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_buy_qty")]
		public decimal? NonArbitrageBuyVolume;
		/// <summary>
		/// 비차익거래순매수수량
		/// </summary>
		[JsonProperty("ndiffpro_trde_netprps_qty")]
		public KiwoomDecimal? NonArbitrageNetBuyVolume;
		/// <summary>
		/// 전체매도
		/// </summary>
		[JsonProperty("all_sel")]
		public decimal? TotalSell;
		/// <summary>
		/// 전체매수
		/// </summary>
		[JsonProperty("all_buy")]
		public decimal? TotalBuy;
		/// <summary>
		/// 전체순매수
		/// </summary>
		[JsonProperty("all_netprps")]
		public KiwoomDecimal? TotalNetBuy;
		/// <summary>
		/// KOSPI200
		/// </summary>
		[JsonProperty("kospi200")]
		public KiwoomDecimal? Kospi200;
		/// <summary>
		/// BASIS
		/// </summary>
		[JsonProperty("basis")]
		public KiwoomDecimal? Basis;
	}

	public record KiwoomMarketConditionGetStockDailyProgramTradeTrends
	{
		/// <summary>
		/// 종목일별프로그램매매추이
		/// </summary>
		[JsonProperty("stk_daly_prm_trde_trnsn")]
		public IEnumerable<KiwoomMarketConditionGetStockDailyProgramTradeTrendItem>? Items;
	}
	public record KiwoomMarketConditionGetStockDailyProgramTradeTrendItem
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
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 프로그램매도금액
		/// </summary>
		[JsonProperty("prm_sell_amt")]
		public decimal? ProgramSellAmount;
		/// <summary>
		/// 프로그램매수금액
		/// </summary>
		[JsonProperty("prm_buy_amt")]
		public decimal? ProgramBuyAmount;
		/// <summary>
		/// 프로그램순매수금액
		/// </summary>
		[JsonProperty("prm_netprps_amt")]
		public KiwoomDecimal? ProgramNetBuyAmount;
		/// <summary>
		/// 프로그램순매수금액증감
		/// </summary>
		[JsonProperty("prm_netprps_amt_irds")]
		public KiwoomDecimal? ProgramNetBuyAmountChange;
		/// <summary>
		/// 프로그램매도수량
		/// </summary>
		[JsonProperty("prm_sell_qty")]
		public decimal? ProgramSellQuantity;
		/// <summary>
		/// 프로그램매수수량
		/// </summary>
		[JsonProperty("prm_buy_qty")]
		public decimal? ProgramBuyQuantity;
		/// <summary>
		/// 프로그램순매수수량
		/// </summary>
		[JsonProperty("prm_netprps_qty")]
		public KiwoomDecimal? ProgramNetBuyQuantity;
		/// <summary>
		/// 프로그램순매수수량증감
		/// </summary>
		[JsonProperty("prm_netprps_qty_irds")]
		public KiwoomDecimal? ProgramNetBuyQuantityChange;
		/// <summary>
		/// 기준가시간
		/// </summary>
		[JsonProperty("base_pric_tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? BasePriceTime;
		/// <summary>
		/// 대차거래상환주수합
		/// </summary>
		[JsonProperty("dbrt_trde_rpy_sum")]
		public decimal? TotalSecuritiesLendingRepaymentQuantity;
		/// <summary>
		/// 잔고수주합
		/// </summary>
		[JsonProperty("remn_rcvord_sum")]
		public decimal? TotalBalanceQuantity;
		/// <summary>
		/// 거래소구분 - KRX, NXT, 통합
		/// </summary>
		[JsonProperty("stex_tp")]
		public KiwoomMarketConditionStockExchangeType? ExchangeType;
	}
}
