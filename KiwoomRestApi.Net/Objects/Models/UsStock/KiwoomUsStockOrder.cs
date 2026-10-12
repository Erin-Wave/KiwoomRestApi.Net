using KiwoomRestApi.Net.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	public record KiwoomUsStockOrderBuyOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호 (취소 혹은 정정 주문 시 사용)
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 금일재매수사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_useda")]
		public decimal? TodayRebuyUsedAmount;
		/// <summary>
		/// 전일재매수사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_useda")]
		public decimal? PreviousDayRebuyUsedAmount;
		/// <summary>
		/// 사용증거금
		/// </summary>
		[JsonProperty("trst_prof_ch")]
		public decimal? UsedMargin;
	}

	public record KiwoomUsStockOrderSellOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호 (취소 혹은 정정 주문 시 사용)
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 보유수량
		/// </summary>
		[JsonProperty("poss_qty")]
		public decimal? PossessionQuantity;
		/// <summary>
		/// 금일재매도사용수량
		/// </summary>
		[JsonProperty("tdy_resel_usedq")]
		public decimal? TodayResellUsedQuantity;
		/// <summary>
		/// 전일재매도사용수량
		/// </summary>
		[JsonProperty("pred_resel_usedq")]
		public decimal? PreviousDayResellUsedQuantity;
	}

	public record KiwoomUsStockOrderModifyOrder
	{
		/// <summary>
		/// 종목명
		/// </summary>
		[JsonProperty("stk_nm")]
		public string? StockName;
		/// <summary>
		/// 주문번호 (취소 혹은 정정 주문 시 사용)
		/// </summary>
		[JsonProperty("ord_no")]
		public string? OrderId;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 금일재매수사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_useda")]
		public decimal? TodayRebuyUsedAmount;
		/// <summary>
		/// 전일재매수사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_useda")]
		public decimal? PreviousDayRebuyUsedAmount;
		/// <summary>
		/// 사용증거금
		/// </summary>
		[JsonProperty("trst_prof_ch")]
		public decimal? UsedMargin;
		/// <summary>
		/// 정정주문수량
		/// </summary>
		[JsonProperty("mdfy_ord_qty")]
		public decimal? ModifyOrderQuantity;
	}

	public record KiwoomUsStockOrderCancelOrder
	{
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
		/// 취소주문수량
		/// </summary>
		[JsonProperty("cncl_ord_qty")]
		public decimal? CancelOrderQuantity;
	}

	public record KiwoomUsStockOrderAvailableQuantity
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
		/// 원화주문신청여부 (Y, N)
		/// </summary>
		[JsonProperty("krw_ord_rqst_yn")]
		public string? KrwOrderRequestYn;
		/// <summary>
		/// 증거금50%종목 원화주문가능금액
		/// </summary>
		[JsonProperty("krw_ord_alowa_50")]
		public decimal? KrwOrderAvailableAmount50;
		/// <summary>
		/// 증거금50%종목 원화주문가능수량
		/// </summary>
		[JsonProperty("krw_ord_alowq_50")]
		public decimal? KrwOrderAvailableQuantity50;
		/// <summary>
		/// 증거금50%종목 주문가능금액
		/// </summary>
		[JsonProperty("ord_alowa_50")]
		public decimal? OrderAvailableAmount50;
		/// <summary>
		/// 증거금50%종목 주문가능수량
		/// </summary>
		[JsonProperty("ord_alowq_50")]
		public decimal? OrderAvailableQuantity50;
		/// <summary>
		/// 증거금50%종목 전일재사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_alowa_50")]
		public decimal? PreviousDayRebuyAvailableAmount50;
		/// <summary>
		/// 증거금50%종목 금일재사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_alowa_50")]
		public decimal? TodayRebuyAvailableAmount50;
		/// <summary>
		/// 증거금100%종목 원화주문가능금액
		/// </summary>
		[JsonProperty("krw_ord_alowa_100")]
		public decimal? KrwOrderAvailableAmount100;
		/// <summary>
		/// 증거금100%종목 원화주문가능수량
		/// </summary>
		[JsonProperty("krw_ord_alowq_100")]
		public decimal? KrwOrderAvailableQuantity100;
		/// <summary>
		/// 증거금100%종목 주문가능금액
		/// </summary>
		[JsonProperty("ord_alowa_100")]
		public decimal? OrderAvailableAmount100;
		/// <summary>
		/// 증거금100%종목 주문가능수량
		/// </summary>
		[JsonProperty("ord_alowq_100")]
		public decimal? OrderAvailableQuantity100;
		/// <summary>
		/// 증거금100%종목 전일재사용금액
		/// </summary>
		[JsonProperty("pred_rebuy_alowa_100")]
		public decimal? PreviousDayRebuyAvailableAmount100;
		/// <summary>
		/// 증거금100%종목 금일재사용금액
		/// </summary>
		[JsonProperty("tdy_rebuy_alowa_100")]
		public decimal? TodayRebuyAvailableAmount100;
		/// <summary>
		/// 미수불가 원화주문가능금액
		/// </summary>
		[JsonProperty("min_krw_ord_alowa")]
		public decimal? MinKrwOrderAvailableAmount;
		/// <summary>
		/// 미수불가 원화주문가능수량
		/// </summary>
		[JsonProperty("min_krw_ord_alowq")]
		public decimal? MinKrwOrderAvailableQuantity;
		/// <summary>
		/// 미수불가 주문가능금액
		/// </summary>
		[JsonProperty("min_ord_alowa")]
		public decimal? MinOrderAvailableAmount;
		/// <summary>
		/// 미수불가 주문가능수량
		/// </summary>
		[JsonProperty("min_ord_alowq")]
		public decimal? MinOrderAvailableQuantity;
		/// <summary>
		/// 미수불가 전일재사용금액
		/// </summary>
		[JsonProperty("min_pred_rebuy_alowa")]
		public decimal? MinPreviousDayRebuyAvailableAmount;
		/// <summary>
		/// 미수불가 금일재사용금액
		/// </summary>
		[JsonProperty("min_tdy_rebuy_alowa")]
		public decimal? MinTodayRebuyAvailableAmount;
		/// <summary>
		/// 원화예수금
		/// </summary>
		[JsonProperty("krw_entra")]
		public decimal? KrwDeposit;
		/// <summary>
		/// 외화예수금
		/// </summary>
		[JsonProperty("fc_entra")]
		public decimal? ForeignCurrencyDeposit;
		/// <summary>
		/// 외화미수금
		/// </summary>
		[JsonProperty("fc_uncl_amt")]
		public decimal? ForeignCurrencyUnclearedAmount;
		/// <summary>
		/// 주문가능현금
		/// </summary>
		[JsonProperty("ord_alowa")]
		public decimal? OrderAvailableCash;
		/// <summary>
		/// 해외원화주문설정금
		/// </summary>
		[JsonProperty("krw_ord_set_amt")]
		public decimal? OverseasKrwOrderSetAmount;
		/// <summary>
		/// 해외원화주문평가금
		/// </summary>
		[JsonProperty("krw_ord_evlt_amt")]
		public decimal? OverseasKrwOrderEvaluationAmount;
		/// <summary>
		/// 통화
		/// </summary>
		[JsonProperty("crnc_code")]
		public string? CurrencyCode;
	}

	public record KiwoomUsStockOrderReserveOrder
	{
		/// <summary>
		/// 예약주문번호 (예약주문 취소 시 사용)
		/// </summary>
		[JsonProperty("rsrv_ord_no")]
		public string? ReservationOrderId;
		/// <summary>
		/// 주문예정일
		/// </summary>
		[JsonProperty("frcs_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpectedOrderDate;
	}

	public record KiwoomUsStockOrderCancelReservedOrder
	{
		/// <summary>
		/// filler
		/// </summary>
		[JsonProperty("filler")]
		public string? Filler;
	}

	public record KiwoomUsStockOrderGetDailyReservedOrders
	{
		/// <summary>
		/// 일자별 예약내역 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockOrderDailyReservedOrderItem>? Items;
	}

	public record KiwoomUsStockOrderDailyReservedOrderItem
	{
		/// <summary>
		/// 예약일
		/// </summary>
		[JsonProperty("rsrv_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ReservationDate;
		/// <summary>
		/// 주문전송일
		/// </summary>
		[JsonProperty("ord_send_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? OrderSendDate;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 예약주문번호
		/// </summary>
		[JsonProperty("rsrv_ord_no")]
		public string? ReservationOrderId;
		/// <summary>
		/// 예약주문구분 (1:일반예약, 2:기간예약(잔량주문), 3:기간예약(지정수량주문))
		/// </summary>
		[JsonProperty("rsrv_ord_tp")]
		public string? ReservationType;
		/// <summary>
		/// 예약주문구분명
		/// </summary>
		[JsonProperty("rsrv_ord_nm")]
		public string? ReservationTypeName;
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
		/// 매도수구분
		/// </summary>
		[JsonProperty("slby_tp")]
		public string? SellBuyType;
		/// <summary>
		/// 매매구분 (00:지정가, 03:시장가, 34:Stop Limit, 35:Stop Market)
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TradeType;
		/// <summary>
		/// 매매구분명
		/// </summary>
		[JsonProperty("trde_nm")]
		public string? TradeTypeName;
		/// <summary>
		/// 오전오후구분
		/// </summary>
		[JsonProperty("am_pm_tp")]
		public string? AmPmType;
		/// <summary>
		/// 거래소이름
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 최초주문수량
		/// </summary>
		[JsonProperty("orig_ord_qty")]
		public decimal? OriginalOrderQuantity;
		/// <summary>
		/// 누적체결수량
		/// </summary>
		[JsonProperty("accm_cntr_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문단가 (단위: USD)
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderUnitPrice;
		/// <summary>
		/// 기간예약시작일자
		/// </summary>
		[JsonProperty("rsrv_strt_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ReservationStartDate;
		/// <summary>
		/// 기간예약종료일자
		/// </summary>
		[JsonProperty("rsrv_end_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ReservationEndDate;
		/// <summary>
		/// 처리내역
		/// </summary>
		[JsonProperty("err_cntn")]
		public string? ProcessMessage;

		// API 가이드 명세(stk_nm, trde_tp, trde_nm)와 응답 예시(frgn_stk_nm, frgn_trde_tp, frgn_trde_nm)의 필드명이 달라 두 이름을 모두 받습니다.
		[JsonProperty("frgn_stk_nm")]
		private string? ForeignStockName { set => StockName ??= value; }
		[JsonProperty("frgn_trde_tp")]
		private string? ForeignTradeType { set => TradeType ??= value; }
		[JsonProperty("frgn_trde_nm")]
		private string? ForeignTradeTypeName { set => TradeTypeName ??= value; }
	}

	public record KiwoomUsStockOrderGetReservedOrders
	{
		/// <summary>
		/// 예약주문 내역 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockOrderReservedOrderItem>? Items;
	}

	public record KiwoomUsStockOrderReservedOrderItem
	{
		/// <summary>
		/// 예약일
		/// </summary>
		[JsonProperty("rsrv_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ReservationDate;
		/// <summary>
		/// 예약주문번호
		/// </summary>
		[JsonProperty("rsrv_ord_no")]
		public string? ReservationOrderId;
		/// <summary>
		/// 기간예약시작일자
		/// </summary>
		[JsonProperty("rsrv_strt_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ReservationStartDate;
		/// <summary>
		/// 매도수구분
		/// </summary>
		[JsonProperty("slby_tp")]
		public string? SellBuyType;
		/// <summary>
		/// 주문수량
		/// </summary>
		[JsonProperty("ord_qty")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 최초주문수량
		/// </summary>
		[JsonProperty("orig_ord_qty")]
		public decimal? OriginalOrderQuantity;
		/// <summary>
		/// 예약취소여부
		/// </summary>
		[JsonProperty("rsrv_cncl_yn")]
		public string? ReservationCancelStatus;
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
		/// 거래소코드명
		/// </summary>
		[JsonProperty("stex_nm")]
		public string? ExchangeName;
		/// <summary>
		/// 예약주문구분 (1:일반예약, 2:기간예약(잔량주문), 3:기간예약(지정수량주문))
		/// </summary>
		[JsonProperty("rsrv_ord_tp")]
		public string? ReservationType;
		/// <summary>
		/// 예약주문구분명
		/// </summary>
		[JsonProperty("rsrv_ord_nm")]
		public string? ReservationTypeName;
		/// <summary>
		/// 기간예약종료일자
		/// </summary>
		[JsonProperty("rsrv_end_dt")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ReservationEndDate;
		/// <summary>
		/// 매매구분 (00:지정가, 03:시장가, 34:Stop Limit, 35:Stop Market)
		/// </summary>
		[JsonProperty("trde_tp")]
		public string? TradeType;
		/// <summary>
		/// 매매구분명
		/// </summary>
		[JsonProperty("trde_nm")]
		public string? TradeTypeName;
		/// <summary>
		/// 주문단가 (단위: USD)
		/// </summary>
		[JsonProperty("ord_uv")]
		public decimal? OrderUnitPrice;
		/// <summary>
		/// STOP가격
		/// </summary>
		[JsonProperty("stop_pric")]
		public decimal? StopPrice;
		/// <summary>
		/// 누적체결수량
		/// </summary>
		[JsonProperty("accm_cntr_qty")]
		public decimal? AccumulatedTradeQuantity;
		/// <summary>
		/// 오전오후구분
		/// </summary>
		[JsonProperty("am_pm_tp")]
		public string? AmPmType;
		/// <summary>
		/// 처리구분 (0:미처리, 1:정상처리, 9:처리중에러)
		/// </summary>
		[JsonProperty("proc_tp")]
		public string? ProcessType;
		/// <summary>
		/// 처리내역
		/// </summary>
		[JsonProperty("err_cntn")]
		public string? ProcessMessage;

		// API 가이드 명세(stk_nm, trde_tp, trde_nm)와 응답 예시(frgn_stk_nm, frgn_trde_tp, frgn_trde_nm)의 필드명이 달라 두 이름을 모두 받습니다.
		[JsonProperty("frgn_stk_nm")]
		private string? ForeignStockName { set => StockName ??= value; }
		[JsonProperty("frgn_trde_tp")]
		private string? ForeignTradeType { set => TradeType ??= value; }
		[JsonProperty("frgn_trde_nm")]
		private string? ForeignTradeTypeName { set => TradeTypeName ??= value; }
	}
}
