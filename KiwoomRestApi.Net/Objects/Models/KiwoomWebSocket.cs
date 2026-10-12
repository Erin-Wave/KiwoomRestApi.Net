using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.WebSocket;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models
{
	public record KiwoomWebSocketSendMessage
	{
		/// <summary>
		/// 서비스명 - REG : 등록, REMOVE : 해지
		/// </summary>
		[JsonProperty("trnm")]
		public string? ServiceName;
		/// <summary>
		/// 그룹번호
		/// </summary>
		[JsonProperty("grp_no")]
		public string? GroupId;
		/// <summary>
		/// 기존등록유지여부 - 등록(REG)시 0:기존유지안함 1:기존유지(Default), 0일경우 기존등록한 item/type은 해지, 1일경우 기존등록한 item/type 유지, 해지(REMOVE)시 값 불필요
		/// </summary>
		[JsonProperty("refresh")]
		public string? Refresh;
		/// <summary>
		/// 실시간 등록 리스트
		/// </summary>
		[JsonProperty("data")]
		public IEnumerable<KiwoomWebSocketSendMessageItem> Data = [];
	}

	public record KiwoomWebSocketSendMessageItem
	{
		/// <summary>
		/// 실시간 등록 요소
		/// </summary>
		[JsonProperty("item")]
		public IEnumerable<string>? Item;
		/// <summary>
		/// 실시간 항목 - TR 명(0A,0B....)
		/// </summary>
		[JsonProperty("type")]
		public IEnumerable<string> Type = [];
	}

	public record KiwoomWebSocketReceiveMessage<T>
	{
		/// <summary>
		/// 결과코드 - 통신결과에대한 코드(등록, 해지요청시에만 값 전송 0:정상,1:오류, 데이터 실시간 수신시 미전송)
		/// </summary>
		[JsonProperty("return_code")]
		public int? ReturnCode;
		/// <summary>
		/// 결과메시지 - 통신결과에 대한 메시지
		/// </summary>
		[JsonProperty("return_msg")]
		public string? ReturnMessage;
		/// <summary>
		/// 서비스명 - 등록,해지요청시 요청값 반환, 실시간수신시 REAL 반환
		/// </summary>
		[JsonProperty("trnm")]
		public string? ServiceName;
		/// <summary>
		/// 실시간 등록리스트
		/// </summary>
		[JsonProperty("data")]
		public IEnumerable<KiwoomWebSocketRealtimeSubscription<T>>? Data;
	}

	public record KiwoomWebSocketReceiveMessage2<T>
	{
		/// <summary>
		/// 결과코드 - 정상:0 나머지:에러
		/// </summary>
		[JsonProperty("return_code")]
		public int? ReturnCode;
		/// <summary>
		/// 결과메시지 - 정상인 경우는 메시지 없음
		/// </summary>
		[JsonProperty("return_msg")]
		public string? ReturnMessage;
		/// <summary>
		/// 서비스명
		/// </summary>
		[JsonProperty("trnm")]
		public string? ServiceName;
		/// <summary>
		/// 조건검색식 일련번호
		/// </summary>
		[JsonProperty("seq")]
		public decimal? Id;
		/// <summary>
		/// 연속조회여부 - 연속 데이터가 존재하는경우 Y, 없으면 N
		/// </summary>
		[JsonProperty("cont-yn")]
		public string? ContinueYn;
		/// <summary>
		/// 연속조회키 - 연속조회여부가Y일경우 다음 조회시 필요한 조회값
		/// </summary>
		[JsonProperty("next-key")]
		public string? NextKey;
		/// <summary>
		/// 데이터
		/// </summary>
		[JsonProperty("data")]
		public IEnumerable<T>? Data;
	}

	public record KiwoomWebSocketRealtimeSubscription<T>
	{
		/// <summary>
		/// 실시간항목 - TR 명(0A,0B....)
		/// </summary>
		[JsonProperty("type")]
		public string? Type;
		/// <summary>
		/// 실시간 항목명
		/// </summary>
		[JsonProperty("name")]
		public string? Name;
		/// <summary>
		/// 실시간 등록 요소 - 거래소별 종목코드 (KRX:039490,NXT:039490_NX,SOR:039490_AL)
		/// </summary>
		[JsonProperty("item")]
		public string? Item;
		/// <summary>
		/// 실시간 값 리스트
		/// </summary>
		[JsonProperty("values")]
		public T? Values;
	}
	public record KiwoomWebSocketRealtimeOrderTrade
	{
		/// <summary>
		/// 계좌번호 (9201)
		/// </summary>
		[JsonProperty("9201")]
		public string? AccountId;
		/// <summary>
		/// 주문번호 (9203)
		/// </summary>
		[JsonProperty("9203")]
		public string? OrderId;
		/// <summary>
		/// 관리자사번 (9205)
		/// </summary>
		[JsonProperty("9205")]
		public string? ManagerId;
		/// <summary>
		/// 종목코드 또는 업종코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 주문업무분류 (912)
		/// </summary>
		[JsonProperty("912")]
		public string? OrderBusinessType;
		/// <summary>
		/// 주문상태 (913)
		/// </summary>
		[JsonProperty("913")]
		public string? OrderStatus;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 주문수량 (900)
		/// </summary>
		[JsonProperty("900")]
		public decimal? OrderQuantity;
		/// <summary>
		/// 주문가격 (901)
		/// </summary>
		[JsonProperty("901")]
		public decimal? OrderPrice;
		/// <summary>
		/// 미체결수량 (902)
		/// </summary>
		[JsonProperty("902")]
		public decimal? UnsettledQuantity;
		/// <summary>
		/// 체결누계금액 (903)
		/// </summary>
		[JsonProperty("903")]
		public decimal? TotalTradeAmount;
		/// <summary>
		/// 원주문번호 (904)
		/// </summary>
		[JsonProperty("904")]
		public decimal? OriginalOrderId;
		/// <summary>
		/// 주문구분 (905)
		/// </summary>
		[JsonProperty("905")]
		public KiwoomString? OrderType;
		/// <summary>
		/// 매매구분 (906)
		/// </summary>
		[JsonProperty("906")]
		public string? TradeType;
		/// <summary>
		/// 매도수구분 (907)
		/// </summary>
		[JsonProperty("907")]
		public string? OrderSide;
		/// <summary>
		/// 주문/체결시간 (908)
		/// </summary>
		[JsonProperty("908")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OrderTradeTime;
		/// <summary>
		/// 체결번호 (909)
		/// </summary>
		[JsonProperty("909")]
		public decimal? TradeId;
		/// <summary>
		/// 체결가 (910)
		/// </summary>
		[JsonProperty("910")]
		public decimal? TradePrice;
		/// <summary>
		/// 체결량 (911)
		/// </summary>
		[JsonProperty("911")]
		public decimal? TradeQuantity;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// (최우선)매도호가 (27)
		/// </summary>
		[JsonProperty("27")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// (최우선)매수호가 (28)
		/// </summary>
		[JsonProperty("28")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 단위체결가 (914)
		/// </summary>
		[JsonProperty("914")]
		public decimal? UnitTradePrice;
		/// <summary>
		/// 단위체결량 (915)
		/// </summary>
		[JsonProperty("915")]
		public decimal? UnitTradeQuantity;
		/// <summary>
		/// 당일매매수수료 (938)
		/// </summary>
		[JsonProperty("938")]
		public decimal? TodayFee;
		/// <summary>
		/// 당일매매세금 (939)
		/// </summary>
		[JsonProperty("939")]
		public decimal? TodayTax;
		/// <summary>
		/// 거부사유 (919)
		/// </summary>
		[JsonProperty("919")]
		public string? RejectReason;
		/// <summary>
		/// 화면번호 (920)
		/// </summary>
		[JsonProperty("920")]
		public decimal? ScreenId;
		/// <summary>
		/// 터미널번호 (921)
		/// </summary>
		[JsonProperty("921")]
		public decimal? TerminalId;
		/// <summary>
		/// 신용구분 (922) - 실시간 체결용
		/// </summary>
		[JsonProperty("922")]
		public string? CreditType;
		/// <summary>
		/// 대출일 (923) - 실시간 체결용
		/// </summary>
		[JsonProperty("923")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 시간외단일가 현재가 (10010)
		/// </summary>
		[Obsolete("KRX 시간외단일가 시장 폐지로 2026-09-12부터 제공되지 않는 항목입니다.")]
		[JsonProperty("10010")]
		public decimal? AfterMarketSinglePrice;
		/// <summary>
		/// 거래소구분 (2134) - 0: 통합, 1: KRX, 2: NXT
		/// </summary>
		[JsonProperty("2134")]
		public KiwoomWebSocketStockExchangeType? ExchangeType;
		/// <summary>
		/// 거래소구분명 (2135) - 통합, KRX, NXT
		/// </summary>
		[JsonProperty("2135")]
		public string? ExchangeTypeName;
		/// <summary>
		/// SOR 여부 (2136) - Y/N
		/// </summary>
		[JsonProperty("2136")]
		public string? Sor;
	}

	public record KiwoomWebSocketRealtimeBalance
	{
		/// <summary>
		/// 계좌번호 (9201)
		/// </summary>
		[JsonProperty("9201")]
		public string? AccountId;
		/// <summary>
		/// 종목코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 신용구분 (917)
		/// </summary>
		[JsonProperty("917")]
		public string? CreditType;
		/// <summary>
		/// 대출일 (916)
		/// </summary>
		[JsonProperty("916")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? LoanDate;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 보유수량 (930)
		/// </summary>
		[JsonProperty("930")]
		public decimal? HoldingQuantity;
		/// <summary>
		/// 매입단가 (931)
		/// </summary>
		[JsonProperty("931")]
		public decimal? BuyPrice;
		/// <summary>
		/// 총매입금액 (932)
		/// </summary>
		[JsonProperty("932")]
		public decimal? TotalBuyAmount;
		/// <summary>
		/// 주문가능수량 (933)
		/// </summary>
		[JsonProperty("933")]
		public decimal? OrderableQuantity;
		/// <summary>
		/// 당일순매수량 (945)
		/// </summary>
		[JsonProperty("945")]
		public KiwoomDecimal? TodayNetBuyVolume;
		/// <summary>
		/// 매도매수구분 (946)
		/// </summary>
		[JsonProperty("946")]
		public string? OrderSide;
		/// <summary>
		/// 당일총매도손익 (950)
		/// </summary>
		[JsonProperty("950")]
		public KiwoomDecimal? TotalTodaySellProfitLoss;
		/// <summary>
		/// 추가항목1 (951)
		/// </summary>
		[JsonProperty("951")]
		public string? ExtraItem1;
		/// <summary>
		/// 최우선매도호가 (27)
		/// </summary>
		[JsonProperty("27")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// 최우선매수호가 (28)
		/// </summary>
		[JsonProperty("28")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 기준가 (307)
		/// </summary>
		[JsonProperty("307")]
		public decimal? BasePrice;
		/// <summary>
		/// 손익률 (8019)
		/// </summary>
		[JsonProperty("8019")]
		public KiwoomDecimal? ProfitLossRate;
		/// <summary>
		/// 신용금액 (957)
		/// </summary>
		[JsonProperty("957")]
		public decimal? CreditAmount;
		/// <summary>
		/// 신용이자 (958)
		/// </summary>
		[JsonProperty("958")]
		public decimal? CreditInterest;
		/// <summary>
		/// 만료일 (918)
		/// </summary>
		[JsonProperty("918")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? ExpirationDate;
		/// <summary>
		/// 당일실현손익(주식) (990)
		/// </summary>
		[JsonProperty("990")]
		public KiwoomDecimal? TodayRealizedProfitLossStock;
		/// <summary>
		/// 당일실현손익률(주식) (991)
		/// </summary>
		[JsonProperty("991")]
		public KiwoomDecimal? TodayRealizedProfitLossRateStock;
		/// <summary>
		/// 당일실현손익(신용) (992)
		/// </summary>
		[JsonProperty("992")]
		public KiwoomDecimal? TodayRealizedProfitLossCredit;
		/// <summary>
		/// 당일실현손익률(신용) (993)
		/// </summary>
		[JsonProperty("993")]
		public KiwoomDecimal? TodayRealizedProfitLossRateCredit;
		/// <summary>
		/// 대주대출수량 (959)
		/// </summary>
		[JsonProperty("959")]
		public decimal? ShortSellLoanQuantity;
		/// <summary>
		/// 추가항목2 (924)
		/// </summary>
		[JsonProperty("924")]
		public string? ExtraItem2;
	}

	public record KiwoomWebSocketRealtimeStockTrend
	{
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락률 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 최우선매도호가 (27)
		/// </summary>
		[JsonProperty("27")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// 최우선매수호가 (28)
		/// </summary>
		[JsonProperty("28")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금 (14)
		/// </summary>
		[JsonProperty("14")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 시가 (16)
		/// </summary>
		[JsonProperty("16")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가 (17)
		/// </summary>
		[JsonProperty("17")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가 (18)
		/// </summary>
		[JsonProperty("18")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 전일대비부호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비거래량 (26)
		/// </summary>
		[JsonProperty("26")]
		public KiwoomDecimal? PreviousDayVolumeChange;
		/// <summary>
		/// 거래대금전일대비 (29)
		/// </summary>
		[JsonProperty("29")]
		public KiwoomDecimal? AmountChange;
		/// <summary>
		/// 거래량비율(전일대비) (30)
		/// </summary>
		[JsonProperty("30")]
		public KiwoomDecimal? PreviousDayVolumeChangeRate;
		/// <summary>
		/// 회전율 (31)
		/// </summary>
		[JsonProperty("31")]
		public decimal? TurnoverRate;
		/// <summary>
		/// 거래대금 (32)
		/// </summary>
		[JsonProperty("32")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 시가총액 (311)
		/// </summary>
		[JsonProperty("311")]
		public decimal? MarketCapitalization;
		/// <summary>
		/// 상한가도달시간 (567)
		/// </summary>
		[JsonProperty("567")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? UpperPriceTime;
		/// <summary>
		/// 하한가도달시간 (568)
		/// </summary>
		[JsonProperty("568")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? LowerPriceTime;
	}

	public record KiwoomWebSocketRealtimeStockTrade
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// (최우선)매도호가 (27)
		/// </summary>
		[JsonProperty("27")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// (최우선)매수호가 (28)
		/// </summary>
		[JsonProperty("28")]
		public KiwoomDecimal? BestBuyQuote;
		/// <summary>
		/// 거래량 (+매수,-매도체결) (15)
		/// </summary>
		[JsonProperty("15")]
		public KiwoomDecimal? Volume;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금 (14)
		/// </summary>
		[JsonProperty("14")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 시가 (16)
		/// </summary>
		[JsonProperty("16")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가 (17)
		/// </summary>
		[JsonProperty("17")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가 (18)
		/// </summary>
		[JsonProperty("18")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// 전일거래량대비(계약,주) (26)
		/// </summary>
		[JsonProperty("26")]
		public KiwoomDecimal? VolumeChange;
		/// <summary>
		/// 거래대금증감 (29)
		/// </summary>
		[JsonProperty("29")]
		public KiwoomDecimal? TransactionAmountChange;
		/// <summary>
		/// 전일거래량대비(비율) (30)
		/// </summary>
		[JsonProperty("30")]
		public KiwoomDecimal? VolumeChangeRate;
		/// <summary>
		/// 거래회전율 (31)
		/// </summary>
		[JsonProperty("31")]
		public decimal? TurnoverRate;
		/// <summary>
		/// 거래비용 (32)
		/// </summary>
		[JsonProperty("32")]
		public decimal? TransactionAmount;
		/// <summary>
		/// 체결강도 (228)
		/// </summary>
		[JsonProperty("228")]
		public decimal? TradeMomentum;
		/// <summary>
		/// 시가총액(억) (311)
		/// </summary>
		[JsonProperty("311")]
		public decimal? MarketCapitalization;
		/// <summary>
		/// 장구분 (290)
		/// </summary>
		[JsonProperty("290")]
		public decimal? MarketType;
		/// <summary>
		/// K.O 접근도 (691)
		/// </summary>
		[JsonProperty("691")]
		public decimal? KnockOutProximity;
		/// <summary>
		/// 상한가발생시간 (567)
		/// </summary>
		[JsonProperty("567")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? UpperPriceTime;
		/// <summary>
		/// 하한가발생시간 (568)
		/// </summary>
		[JsonProperty("568")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? LowerPriceTime;
		/// <summary>
		/// 전일 동시간 거래량 비율 (851)
		/// </summary>
		[JsonProperty("851")]
		public decimal? SameTimeVolumeRate;
		/// <summary>
		/// 시가시간 (1890)
		/// </summary>
		[JsonProperty("1890")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? OpenTime;
		/// <summary>
		/// 고가시간 (1891)
		/// </summary>
		[JsonProperty("1891")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? HighTime;
		/// <summary>
		/// 저가시간 (1892)
		/// </summary>
		[JsonProperty("1892")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? LowTime;
		/// <summary>
		/// 매도체결량 (1030)
		/// </summary>
		[JsonProperty("1030")]
		public decimal? SellTradeVolume;
		/// <summary>
		/// 매수체결량 (1031)
		/// </summary>
		[JsonProperty("1031")]
		public decimal? BuyTradeVolume;
		/// <summary>
		/// 매수비율 (1032)
		/// </summary>
		[JsonProperty("1032")]
		public decimal? BuyRate;
		/// <summary>
		/// 매도체결건수 (1071)
		/// </summary>
		[JsonProperty("1071")]
		public int? SellTradeCount;
		/// <summary>
		/// 매수체결건수 (1072)
		/// </summary>
		[JsonProperty("1072")]
		public int? BuyTradenCount;
		/// <summary>
		/// 순간거래대금 (1313)
		/// </summary>
		[JsonProperty("1313")]
		public decimal? InstantTransactionAmount;
		/// <summary>
		/// 매도체결량_단건 (1315)
		/// </summary>
		[JsonProperty("1315")]
		public decimal? SingleSellTradeQuantity;
		/// <summary>
		/// 매수체결량_단건 (1316)
		/// </summary>
		[JsonProperty("1316")]
		public decimal? SingleBuyTradeQuantity;
		/// <summary>
		/// 순매수체결량 (1314)
		/// </summary>
		[JsonProperty("1314")]
		public decimal? NetBuyTradeQuantity;
		/// <summary>
		/// CFD증거금 (1497)
		/// </summary>
		[JsonProperty("1497")]
		public decimal? CfdMargin;
		/// <summary>
		/// 유지증거금 (1498)
		/// </summary>
		[JsonProperty("1498")]
		public decimal? CfdMaintenanceMargin;
		/// <summary>
		/// 당일거래평균가 (620)
		/// </summary>
		[JsonProperty("620")]
		public decimal? TodayAveragePrice;
		/// <summary>
		/// CFD거래비용 (732)
		/// </summary>
		[JsonProperty("732")]
		public decimal? CfdTransactionAmount;
		/// <summary>
		/// 대주거래비용 (852)
		/// </summary>
		[JsonProperty("852")]
		public decimal? ShortSellingAmount;
		/// <summary>
		/// 거래소구분 (9081)
		/// </summary>
		[JsonProperty("9081")]
		public KiwoomWebSocketStockExchangeType? ExchangeType;
	}

	public record KiwoomWebSocketRealtimeBestQuote
	{
		/// <summary>
		/// (최우선)매도호가 (27)
		/// </summary>
		[JsonProperty("27")]
		public KiwoomDecimal? BestSellQuote;
		/// <summary>
		/// (최우선)매수호가 (28)
		/// </summary>
		[JsonProperty("28")]
		public KiwoomDecimal? BestBuyQuote;
	}

	public record KiwoomWebSocketRealtimeOrderBook
	{
		/// <summary>
		/// 호가시간 (21)
		/// </summary>
		[JsonProperty("21")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? QuoteTime;
		/// <summary>
		/// 매도호가1 (41)
		/// </summary>
		[JsonProperty("41")]
		public KiwoomDecimal? SellPrice1;
		/// <summary>
		/// 매도호가수량1 (61)
		/// </summary>
		[JsonProperty("61")]
		public decimal? SellQuantity1;
		/// <summary>
		/// 매도호가직전대비1 (81)
		/// </summary>
		[JsonProperty("81")]
		public decimal? SellPriceChange1;
		/// <summary>
		/// 매수호가1 (51)
		/// </summary>
		[JsonProperty("51")]
		public KiwoomDecimal? BuyPrice1;
		/// <summary>
		/// 매수호가수량1 (71)
		/// </summary>
		[JsonProperty("71")]
		public decimal? BuyQuantity1;
		/// <summary>
		/// 매수호가직전대비1 (91)
		/// </summary>
		[JsonProperty("91")]
		public decimal? BuyPriceChange1;
		/// <summary>
		/// 매도호가2 (42)
		/// </summary>
		[JsonProperty("42")]
		public KiwoomDecimal? SellPrice2;
		/// <summary>
		/// 매도호가수량2 (62)
		/// </summary>
		[JsonProperty("62")]
		public decimal? SellQuantity2;
		/// <summary>
		/// 매도호가직전대비2 (82)
		/// </summary>
		[JsonProperty("82")]
		public decimal? SellPriceChange2;
		/// <summary>
		/// 매수호가2 (52)
		/// </summary>
		[JsonProperty("52")]
		public KiwoomDecimal? BuyPrice2;
		/// <summary>
		/// 매수호가수량2 (72)
		/// </summary>
		[JsonProperty("72")]
		public decimal? BuyQuantity2;
		/// <summary>
		/// 매수호가직전대비2 (92)
		/// </summary>
		[JsonProperty("92")]
		public decimal? BuyPriceChange2;
		/// <summary>
		/// 매도호가3 (43)
		/// </summary>
		[JsonProperty("43")]
		public KiwoomDecimal? SellPrice3;
		/// <summary>
		/// 매도호가수량3 (63)
		/// </summary>
		[JsonProperty("63")]
		public decimal? SellQuantity3;
		/// <summary>
		/// 매도호가직전대비3 (83)
		/// </summary>
		[JsonProperty("83")]
		public decimal? SellPriceChange3;
		/// <summary>
		/// 매수호가3 (53)
		/// </summary>
		[JsonProperty("53")]
		public KiwoomDecimal? BuyPrice3;
		/// <summary>
		/// 매수호가수량3 (73)
		/// </summary>
		[JsonProperty("73")]
		public decimal? BuyQuantity3;
		/// <summary>
		/// 매수호가직전대비3 (93)
		/// </summary>
		[JsonProperty("93")]
		public decimal? BuyPriceChange3;
		/// <summary>
		/// 매도호가4 (44)
		/// </summary>
		[JsonProperty("44")]
		public KiwoomDecimal? SellPrice4;
		/// <summary>
		/// 매도호가수량4 (64)
		/// </summary>
		[JsonProperty("64")]
		public decimal? SellQuantity4;
		/// <summary>
		/// 매도호가직전대비4 (84)
		/// </summary>
		[JsonProperty("84")]
		public decimal? SellPriceChange4;
		/// <summary>
		/// 매수호가4 (54)
		/// </summary>
		[JsonProperty("54")]
		public KiwoomDecimal? BuyPrice4;
		/// <summary>
		/// 매수호가수량4 (74)
		/// </summary>
		[JsonProperty("74")]
		public decimal? BuyQuantity4;
		/// <summary>
		/// 매수호가직전대비4 (94)
		/// </summary>
		[JsonProperty("94")]
		public decimal? BuyPriceChange4;
		/// <summary>
		/// 매도호가5 (45)
		/// </summary>
		[JsonProperty("45")]
		public KiwoomDecimal? SellPrice5;
		/// <summary>
		/// 매도호가수량5 (65)
		/// </summary>
		[JsonProperty("65")]
		public decimal? SellQuantity5;
		/// <summary>
		/// 매도호가직전대비5 (85)
		/// </summary>
		[JsonProperty("85")]
		public decimal? SellPriceChange5;
		/// <summary>
		/// 매수호가5 (55)
		/// </summary>
		[JsonProperty("55")]
		public KiwoomDecimal? BuyPrice5;
		/// <summary>
		/// 매수호가수량5 (75)
		/// </summary>
		[JsonProperty("75")]
		public decimal? BuyQuantity5;
		/// <summary>
		/// 매수호가직전대비5 (95)
		/// </summary>
		[JsonProperty("95")]
		public decimal? BuyPriceChange5;
		/// <summary>
		/// 매도호가6 (46)
		/// </summary>
		[JsonProperty("46")]
		public KiwoomDecimal? SellPrice6;
		/// <summary>
		/// 매도호가수량6 (66)
		/// </summary>
		[JsonProperty("66")]
		public decimal? SellQuantity6;
		/// <summary>
		/// 매도호가직전대비6 (86)
		/// </summary>
		[JsonProperty("86")]
		public decimal? SellPriceChange6;
		/// <summary>
		/// 매수호가6 (56)
		/// </summary>
		[JsonProperty("56")]
		public KiwoomDecimal? BuyPrice6;
		/// <summary>
		/// 매수호가수량6 (76)
		/// </summary>
		[JsonProperty("76")]
		public decimal? BuyQuantity6;
		/// <summary>
		/// 매수호가직전대비6 (96)
		/// </summary>
		[JsonProperty("96")]
		public decimal? BuyPriceChange6;
		/// <summary>
		/// 매도호가7 (47)
		/// </summary>
		[JsonProperty("47")]
		public KiwoomDecimal? SellPrice7;
		/// <summary>
		/// 매도호가수량7 (67)
		/// </summary>
		[JsonProperty("67")]
		public decimal? SellQuantity7;
		/// <summary>
		/// 매도호가직전대비7 (87)
		/// </summary>
		[JsonProperty("87")]
		public decimal? SellPriceChange7;
		/// <summary>
		/// 매수호가7 (57)
		/// </summary>
		[JsonProperty("57")]
		public KiwoomDecimal? BuyPrice7;
		/// <summary>
		/// 매수호가수량7 (77)
		/// </summary>
		[JsonProperty("77")]
		public decimal? BuyQuantity7;
		/// <summary>
		/// 매수호가직전대비7 (97)
		/// </summary>
		[JsonProperty("97")]
		public decimal? BuyPriceChange7;
		/// <summary>
		/// 매도호가8 (48)
		/// </summary>
		[JsonProperty("48")]
		public KiwoomDecimal? SellPrice8;
		/// <summary>
		/// 매도호가수량8 (68)
		/// </summary>
		[JsonProperty("68")]
		public decimal? SellQuantity8;
		/// <summary>
		/// 매도호가직전대비8 (88)
		/// </summary>
		[JsonProperty("88")]
		public decimal? SellPriceChange8;
		/// <summary>
		/// 매수호가8 (58)
		/// </summary>
		[JsonProperty("58")]
		public KiwoomDecimal? BuyPrice8;
		/// <summary>
		/// 매수호가수량8 (78)
		/// </summary>
		[JsonProperty("78")]
		public decimal? BuyQuantity8;
		/// <summary>
		/// 매수호가직전대비8 (98)
		/// </summary>
		[JsonProperty("98")]
		public decimal? BuyPriceChange8;
		/// <summary>
		/// 매도호가9 (49)
		/// </summary>
		[JsonProperty("49")]
		public KiwoomDecimal? SellPrice9;
		/// <summary>
		/// 매도호가수량9 (69)
		/// </summary>
		[JsonProperty("69")]
		public decimal? SellQuantity9;
		/// <summary>
		/// 매도호가직전대비9 (89)
		/// </summary>
		[JsonProperty("89")]
		public decimal? SellPriceChange9;
		/// <summary>
		/// 매수호가9 (59)
		/// </summary>
		[JsonProperty("59")]
		public KiwoomDecimal? BuyPrice9;
		/// <summary>
		/// 매수호가수량9 (79)
		/// </summary>
		[JsonProperty("79")]
		public decimal? BuyQuantity9;
		/// <summary>
		/// 매수호가직전대비9 (99)
		/// </summary>
		[JsonProperty("99")]
		public decimal? BuyPriceChange9;
		/// <summary>
		/// 매도호가10 (50)
		/// </summary>
		[JsonProperty("50")]
		public KiwoomDecimal? SellPrice10;
		/// <summary>
		/// 매도호가수량10 (70)
		/// </summary>
		[JsonProperty("70")]
		public decimal? SellQuantity10;
		/// <summary>
		/// 매수호가10 (60)
		/// </summary>
		[JsonProperty("60")]
		public KiwoomDecimal? BuyPrice10;
		/// <summary>
		/// 매도호가직전대비10 (90)
		/// </summary>
		[JsonProperty("90")]
		public decimal? SellPriceChange10;
		/// <summary>
		/// 매수호가수량10 (80)
		/// </summary>
		[JsonProperty("80")]
		public decimal? BuyQuantity10;
		/// <summary>
		/// 매수호가직전대비10 (100)
		/// </summary>
		[JsonProperty("100")]
		public decimal? BuyPriceChange10;
		/// <summary>
		/// 매도호가총잔량 (121)
		/// </summary>
		[JsonProperty("121")]
		public decimal? TotalSellQuantity;
		/// <summary>
		/// 매도호가총잔량직전대비 (122)
		/// </summary>
		[JsonProperty("122")]
		public KiwoomDecimal? TotalSellQuantityChange;
		/// <summary>
		/// 매수호가총잔량 (125)
		/// </summary>
		[JsonProperty("125")]
		public decimal? TotalBuyQuantity;
		/// <summary>
		/// 매수호가총잔량직전대비 (126)
		/// </summary>
		[JsonProperty("126")]
		public KiwoomDecimal? TotalBuyQuantityChange;
		/// <summary>
		/// 예상체결가 (23)
		/// </summary>
		[JsonProperty("23")]
		public KiwoomDecimal? ExpectedTradePrice;
		/// <summary>
		/// 예상체결수량 (24)
		/// </summary>
		[JsonProperty("24")]
		public decimal? ExpectedTradeQuantity;
		/// <summary>
		/// 순매수잔량 (128)
		/// </summary>
		[JsonProperty("128")]
		public KiwoomDecimal? NetBuyQuantity;
		/// <summary>
		/// 매수비율 (129)
		/// </summary>
		[JsonProperty("129")]
		public decimal? BuyRate;
		/// <summary>
		/// 순매도잔량 (138)
		/// </summary>
		[JsonProperty("138")]
		public KiwoomDecimal? NetSellQuantity;
		/// <summary>
		/// 매도비율 (139)
		/// </summary>
		[JsonProperty("139")]
		public decimal? SellRate;
		/// <summary>
		/// 예상체결가전일종가대비 (200)
		/// </summary>
		[JsonProperty("200")]
		public KiwoomDecimal? ExpectedTradePriceCloseChange;
		/// <summary>
		/// 예상체결가전일종가대비등락율 (201)
		/// </summary>
		[JsonProperty("201")]
		public KiwoomDecimal? ExpectedTradePriceCloseChangeRate;
		/// <summary>
		/// 예상체결가전일종가대비기호 (238)
		/// </summary>
		[JsonProperty("238")]
		public string? ExpectedTradePriceCloseChangeSign;
		/// <summary>
		/// 예상체결가 (291)
		/// </summary>
		[JsonProperty("291")]
		public decimal? ExpectedTradePriceDuringSession;
		/// <summary>
		/// 예상체결량 (292)
		/// </summary>
		[JsonProperty("292")]
		public decimal? ExpectedTradeAmount;
		/// <summary>
		/// 예상체결가전일대비기호 (293)
		/// </summary>
		[JsonProperty("293")]
		public string? ExpectedTradePriceChangeSign;
		/// <summary>
		/// 예상체결가전일대비 (294)
		/// </summary>
		[JsonProperty("294")]
		public decimal? ExpectedTradePriceChange;
		/// <summary>
		/// 예상체결가전일대비등락율 (295)
		/// </summary>
		[JsonProperty("295")]
		public decimal? ExpectedTradePriceChangeRate;
		/// <summary>
		/// LP매도호가수량1 (621)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("621")]
		public decimal? LpSellQuantity1;
		/// <summary>
		/// LP매수호가수량1 (631)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("631")]
		public decimal? LpBuyQuantity1;
		/// <summary>
		/// LP매도호가수량2 (622)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("622")]
		public decimal? LpSellQuantity2;
		/// <summary>
		/// LP매수호가수량2 (632)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("632")]
		public decimal? LpBuyQuantity2;
		/// <summary>
		/// LP매도호가수량3 (623)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("623")]
		public decimal? LpSellQuantity3;
		/// <summary>
		/// LP매수호가수량3 (633)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("633")]
		public decimal? LpBuyQuantity3;
		/// <summary>
		/// LP매도호가수량4 (624)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("624")]
		public decimal? LpSellQuantity4;
		/// <summary>
		/// LP매수호가수량4 (634)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("634")]
		public decimal? LpBuyQuantity4;
		/// <summary>
		/// LP매도호가수량5 (625)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("625")]
		public decimal? LpSellQuantity5;
		/// <summary>
		/// LP매수호가수량5 (635)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("635")]
		public decimal? LpBuyQuantity5;
		/// <summary>
		/// LP매도호가수량6 (626)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("626")]
		public decimal? LpSellQuantity6;
		/// <summary>
		/// LP매수호가수량6 (636)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("636")]
		public decimal? LpBuyQuantity6;
		/// <summary>
		/// LP매도호가수량7 (627)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("627")]
		public decimal? LpSellQuantity7;
		/// <summary>
		/// LP매수호가수량7 (637)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("637")]
		public decimal? LpBuyQuantity7;
		/// <summary>
		/// LP매도호가수량8 (628)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("628")]
		public decimal? LpSellQuantity8;
		/// <summary>
		/// LP매수호가수량8 (638)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("638")]
		public decimal? LpBuyQuantity8;
		/// <summary>
		/// LP매도호가수량9 (629)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("629")]
		public decimal? LpSellQuantity9;
		/// <summary>
		/// LP매수호가수량9 (639)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("639")]
		public decimal? LpBuyQuantity9;
		/// <summary>
		/// LP매도호가수량10 (630)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("630")]
		public decimal? LpSellQuantity10;
		/// <summary>
		/// LP매수호가수량10 (640)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("640")]
		public decimal? LpBuyQuantity10;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 전일거래량대비예상체결율 (299)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("299")]
		public KiwoomDecimal? ExpectedTradeRateVolumeChange;
		/// <summary>
		/// 장운영구분 (215)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("215")]
		public string? MarketOperationType;
		/// <summary>
		/// 투자자별ticker (216)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("216")]
		public string? InvestorTicker;
		/// <summary>
		/// KRX 매도호가잔량1 (6044)
		/// </summary>
		[JsonProperty("6044")]
		public decimal? KrxSellQuantity1;
		/// <summary>
		/// KRX 매도호가잔량2 (6045)
		/// </summary>
		[JsonProperty("6045")]
		public decimal? KrxSellQuantity2;
		/// <summary>
		/// KRX 매도호가잔량3 (6046)
		/// </summary>
		[JsonProperty("6046")]
		public decimal? KrxSellQuantity3;
		/// <summary>
		/// KRX 매도호가잔량4 (6047)
		/// </summary>
		[JsonProperty("6047")]
		public decimal? KrxSellQuantity4;
		/// <summary>
		/// KRX 매도호가잔량5 (6048)
		/// </summary>
		[JsonProperty("6048")]
		public decimal? KrxSellQuantity5;
		/// <summary>
		/// KRX 매도호가잔량6 (6049)
		/// </summary>
		[JsonProperty("6049")]
		public decimal? KrxSellQuantity6;
		/// <summary>
		/// KRX 매도호가잔량7 (6050)
		/// </summary>
		[JsonProperty("6050")]
		public decimal? KrxSellQuantity7;
		/// <summary>
		/// KRX 매도호가잔량8 (6051)
		/// </summary>
		[JsonProperty("6051")]
		public decimal? KrxSellQuantity8;
		/// <summary>
		/// KRX 매도호가잔량9 (6052)
		/// </summary>
		[JsonProperty("6052")]
		public decimal? KrxSellQuantity9;
		/// <summary>
		/// KRX 매도호가잔량10 (6053)
		/// </summary>
		[JsonProperty("6053")]
		public decimal? KrxSellQuantity10;
		/// <summary>
		/// KRX 매수호가잔량1 (6054)
		/// </summary>
		[JsonProperty("6054")]
		public decimal? KrxBuyQuantity1;
		/// <summary>
		/// KRX 매수호가잔량2 (6055)
		/// </summary>
		[JsonProperty("6055")]
		public decimal? KrxBuyQuantity2;
		/// <summary>
		/// KRX 매수호가잔량3 (6056)
		/// </summary>
		[JsonProperty("6056")]
		public decimal? KrxBuyQuantity3;
		/// <summary>
		/// KRX 매수호가잔량4 (6057)
		/// </summary>
		[JsonProperty("6057")]
		public decimal? KrxBuyQuantity4;
		/// <summary>
		/// KRX 매수호가잔량5 (6058)
		/// </summary>
		[JsonProperty("6058")]
		public decimal? KrxBuyQuantity5;
		/// <summary>
		/// KRX 매수호가잔량6 (6059)
		/// </summary>
		[JsonProperty("6059")]
		public decimal? KrxBuyQuantity6;
		/// <summary>
		/// KRX 매수호가잔량7 (6060)
		/// </summary>
		[JsonProperty("6060")]
		public decimal? KrxBuyQuantity7;
		/// <summary>
		/// KRX 매수호가잔량8 (6061)
		/// </summary>
		[JsonProperty("6061")]
		public decimal? KrxBuyQuantity8;
		/// <summary>
		/// KRX 매수호가잔량9 (6062)
		/// </summary>
		[JsonProperty("6062")]
		public decimal? KrxBuyQuantity9;
		/// <summary>
		/// KRX 매수호가잔량10 (6063)
		/// </summary>
		[JsonProperty("6063")]
		public decimal? KrxBuyQuantity10;
		/// <summary>
		/// KRX 매도호가총잔량 (6064)
		/// </summary>
		[JsonProperty("6064")]
		public decimal? KrxTotalSellQuantity;
		/// <summary>
		/// KRX 매수호가총잔량 (6065)
		/// </summary>
		[JsonProperty("6065")]
		public decimal? KrxTotalBuyQuantity;
		/// <summary>
		/// NXT 매도호가잔량1 (6066)
		/// </summary>
		[JsonProperty("6066")]
		public decimal? NxtSellQuantity1;
		/// <summary>
		/// NXT 매도호가잔량2 (6067)
		/// </summary>
		[JsonProperty("6067")]
		public decimal? NxtSellQuantity2;
		/// <summary>
		/// NXT 매도호가잔량3 (6068)
		/// </summary>
		[JsonProperty("6068")]
		public decimal? NxtSellQuantity3;
		/// <summary>
		/// NXT 매도호가잔량4 (6069)
		/// </summary>
		[JsonProperty("6069")]
		public decimal? NxtSellQuantity4;
		/// <summary>
		/// NXT 매도호가잔량5 (6070)
		/// </summary>
		[JsonProperty("6070")]
		public decimal? NxtSellQuantity5;
		/// <summary>
		/// NXT 매도호가잔량6 (6071)
		/// </summary>
		[JsonProperty("6071")]
		public decimal? NxtSellQuantity6;
		/// <summary>
		/// NXT 매도호가잔량7 (6072)
		/// </summary>
		[JsonProperty("6072")]
		public decimal? NxtSellQuantity7;
		/// <summary>
		/// NXT 매도호가잔량8 (6073)
		/// </summary>
		[JsonProperty("6073")]
		public decimal? NxtSellQuantity8;
		/// <summary>
		/// NXT 매도호가잔량9 (6074)
		/// </summary>
		[JsonProperty("6074")]
		public decimal? NxtSellQuantity9;
		/// <summary>
		/// NXT 매도호가잔량10 (6075)
		/// </summary>
		[JsonProperty("6075")]
		public decimal? NxtSellQuantity10;
		/// <summary>
		/// NXT 매수호가잔량1 (6076)
		/// </summary>
		[JsonProperty("6076")]
		public decimal? NxtBuyQuantity1;
		/// <summary>
		/// NXT 매수호가잔량2 (6077)
		/// </summary>
		[JsonProperty("6077")]
		public decimal? NxtBuyQuantity2;
		/// <summary>
		/// NXT 매수호가잔량3 (6078)
		/// </summary>
		[JsonProperty("6078")]
		public decimal? NxtBuyQuantity3;
		/// <summary>
		/// NXT 매수호가잔량4 (6079)
		/// </summary>
		[JsonProperty("6079")]
		public decimal? NxtBuyQuantity4;
		/// <summary>
		/// NXT 매수호가잔량5 (6080)
		/// </summary>
		[JsonProperty("6080")]
		public decimal? NxtBuyQuantity5;
		/// <summary>
		/// NXT 매수호가잔량6 (6081)
		/// </summary>
		[JsonProperty("6081")]
		public decimal? NxtBuyQuantity6;
		/// <summary>
		/// NXT 매수호가잔량7 (6082)
		/// </summary>
		[JsonProperty("6082")]
		public decimal? NxtBuyQuantity7;
		/// <summary>
		/// NXT 매수호가잔량8 (6083)
		/// </summary>
		[JsonProperty("6083")]
		public decimal? NxtBuyQuantity8;
		/// <summary>
		/// NXT 매수호가잔량9 (6084)
		/// </summary>
		[JsonProperty("6084")]
		public decimal? NxtBuyQuantity9;
		/// <summary>
		/// NXT 매수호가잔량10 (6085)
		/// </summary>
		[JsonProperty("6085")]
		public decimal? NxtBuyQuantity10;
		/// <summary>
		/// NXT 매도호가총잔량 (6086)
		/// </summary>
		[JsonProperty("6086")]
		public decimal? TotalNxtSellQuantity;
		/// <summary>
		/// NXT 매수호가총잔량 (6087)
		/// </summary>
		[JsonProperty("6087")]
		public decimal? TotalNxtBuyQuantity;
		/// <summary>
		/// KRX 중간가 매도 총잔량 증감 (6100)
		/// </summary>
		[JsonProperty("6100")]
		public decimal? TotalKrxMedianSellQuantityChange;
		/// <summary>
		/// KRX 중간가 매도 총잔량 (6101)
		/// </summary>
		[JsonProperty("6101")]
		public decimal? TotalKrxMedianSellQuantity;
		/// <summary>
		/// KRX 중간가 (6102)
		/// </summary>
		[JsonProperty("6102")]
		public KiwoomDecimal? KrxMedian;
		/// <summary>
		/// KRX 중간가 매수 총잔량 (6103)
		/// </summary>
		[JsonProperty("6103")]
		public decimal? TotalKrxMedianBuyQuantity;
		/// <summary>
		/// KRX 중간가 매수 총잔량 증감 (6104)
		/// </summary>
		[JsonProperty("6104")]
		public decimal? TotalKrxMedianBuyQuantityChange;
		/// <summary>
		/// NXT중간가 매도 총잔량 증감 (6105)
		/// </summary>
		[JsonProperty("6105")]
		public decimal? TotalNxtMedianSellQuantityChange;
		/// <summary>
		/// NXT중간가 매도 총잔량 (6106)
		/// </summary>
		[JsonProperty("6106")]
		public decimal? TotalNxtMedianSellQuantity;
		/// <summary>
		/// NXT중간가 (6107)
		/// </summary>
		[JsonProperty("6107")]
		public decimal? NxtMedian;
		/// <summary>
		/// NXT중간가 매수 총잔량 (6108)
		/// </summary>
		[JsonProperty("6108")]
		public decimal? TotalNxtMedianBuyQuantity;
		/// <summary>
		/// NXT중간가 매수 총잔량 증감 (6109)
		/// </summary>
		[JsonProperty("6109")]
		public decimal? TotalNxtMedianBuyQuantityChange;
		/// <summary>
		/// KRX중간가대비 (6110)
		/// </summary>
		[JsonProperty("6110")]
		public KiwoomDecimal? KrxMedianChange;
		/// <summary>
		/// KRX중간가대비 기호 (6111)
		/// </summary>
		[JsonProperty("6111")]
		public string? KrxMedianChangeSign;
		/// <summary>
		/// KRX중간가대비등락율 (6112)
		/// </summary>
		[JsonProperty("6112")]
		public KiwoomDecimal? KrxMedianChangeRate;
		/// <summary>
		/// NXT중간가대비 (6113)
		/// </summary>
		[JsonProperty("6113")]
		public decimal? NxtMedianChange;
		/// <summary>
		/// NXT중간가대비 기호 (6114)
		/// </summary>
		[JsonProperty("6114")]
		public string? NxtMedianChangeSign;
		/// <summary>
		/// NXT중간가대비등락율 (6115)
		/// </summary>
		[JsonProperty("6115")]
		public decimal? NxtMedianChangeRate;
	}

	public record KiwoomWebSocketRealtimeAfterMarketQuote
	{
		/// <summary>
		/// 호가시간 (21)
		/// </summary>
		[JsonProperty("21")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? QuoteTime;
		/// <summary>
		/// 시간외매도호가총잔량 (131)
		/// </summary>
		[JsonProperty("131")]
		public decimal? TotalAfterMarketSellQuantity;
		/// <summary>
		/// 시간외매도호가총잔량직전대비 (132)
		/// </summary>
		[JsonProperty("132")]
		public KiwoomDecimal? TotalAfterMarketSellQuantityChange;
		/// <summary>
		/// 시간외매수호가총잔량 (135)
		/// </summary>
		[JsonProperty("135")]
		public decimal? TotalAfterMarketBuyQuantity;
		/// <summary>
		/// 시간외매수호가총잔량직전대비 (136)
		/// </summary>
		[JsonProperty("136")]
		public decimal? TotalAfterMarketBuyQuantityChange;
	}

	public record KiwoomWebSocketRealtimeDailyBroker
	{
		/// <summary>
		/// 매도거래원1 (141)
		/// </summary>
		[JsonProperty("141")]
		public string? SellBroker1;
		/// <summary>
		/// 매도거래원수량1 (161)
		/// </summary>
		[JsonProperty("161")]
		public decimal? SellBrokerQuantity1;
		/// <summary>
		/// 매도거래원별증감1 (166)
		/// </summary>
		[JsonProperty("166")]
		public KiwoomDecimal? SellBrokerChange1;
		/// <summary>
		/// 매도거래원코드1 (146)
		/// </summary>
		[JsonProperty("146")]
		public string? SellBrokerCode1;
		/// <summary>
		/// 매도거래원색깔1 (271)
		/// </summary>
		[JsonProperty("271")]
		public string? SellBrokerColor1;
		/// <summary>
		/// 매수거래원1 (151)
		/// </summary>
		[JsonProperty("151")]
		public string? BuyBroker1;
		/// <summary>
		/// 매수거래원수량1 (171)
		/// </summary>
		[JsonProperty("171")]
		public decimal? BuyBrokerQuantity1;
		/// <summary>
		/// 매수거래원별증감1 (176)
		/// </summary>
		[JsonProperty("176")]
		public KiwoomDecimal? BuyBrokerChange1;
		/// <summary>
		/// 매수거래원코드1 (156)
		/// </summary>
		[JsonProperty("156")]
		public string? BuyBrokerCode1;
		/// <summary>
		/// 매수거래원색깔1 (281)
		/// </summary>
		[JsonProperty("281")]
		public string? BuyBrokerColor1;
		/// <summary>
		/// 매도거래원2 (142)
		/// </summary>
		[JsonProperty("142")]
		public string? SellBroker2;
		/// <summary>
		/// 매도거래원수량2 (162)
		/// </summary>
		[JsonProperty("162")]
		public decimal? SellBrokerQuantity2;
		/// <summary>
		/// 매도거래원별증감2 (167)
		/// </summary>
		[JsonProperty("167")]
		public KiwoomDecimal? SellBrokerChange2;
		/// <summary>
		/// 매도거래원코드2 (147)
		/// </summary>
		[JsonProperty("147")]
		public string? SellBrokerCode2;
		/// <summary>
		/// 매도거래원색깔2 (272)
		/// </summary>
		[JsonProperty("272")]
		public string? SellBrokerColor2;
		/// <summary>
		/// 매수거래원2 (152)
		/// </summary>
		[JsonProperty("152")]
		public string? BuyBroker2;
		/// <summary>
		/// 매수거래원수량2 (172)
		/// </summary>
		[JsonProperty("172")]
		public decimal? BuyBrokerQuantity2;
		/// <summary>
		/// 매수거래원별증감2 (177)
		/// </summary>
		[JsonProperty("177")]
		public KiwoomDecimal? BuyBrokerChange2;
		/// <summary>
		/// 매수거래원코드2 (157)
		/// </summary>
		[JsonProperty("157")]
		public string? BuyBrokerCode2;
		/// <summary>
		/// 매수거래원색깔2 (282)
		/// </summary>
		[JsonProperty("282")]
		public string? BuyBrokerColor2;
		/// <summary>
		/// 매도거래원3 (143)
		/// </summary>
		[JsonProperty("143")]
		public string? SellBroker3;
		/// <summary>
		/// 매도거래원수량3 (163)
		/// </summary>
		[JsonProperty("163")]
		public decimal? SellBrokerQuantity3;
		/// <summary>
		/// 매도거래원별증감3 (168)
		/// </summary>
		[JsonProperty("168")]
		public KiwoomDecimal? SellBrokerChange3;
		/// <summary>
		/// 매도거래원코드3 (148)
		/// </summary>
		[JsonProperty("148")]
		public string? SellBrokerCode3;
		/// <summary>
		/// 매도거래원색깔3 (273)
		/// </summary>
		[JsonProperty("273")]
		public string? SellBrokerColor3;
		/// <summary>
		/// 매수거래원3 (153)
		/// </summary>
		[JsonProperty("153")]
		public string? BuyBroker3;
		/// <summary>
		/// 매수거래원수량3 (173)
		/// </summary>
		[JsonProperty("173")]
		public decimal? BuyBrokerQuantity3;
		/// <summary>
		/// 매수거래원별증감3 (178)
		/// </summary>
		[JsonProperty("178")]
		public KiwoomDecimal? BuyBrokerChange3;
		/// <summary>
		/// 매수거래원코드3 (158)
		/// </summary>
		[JsonProperty("158")]
		public string? BuyBrokerCode3;
		/// <summary>
		/// 매수거래원색깔3 (283)
		/// </summary>
		[JsonProperty("283")]
		public string? BuyBrokerColor3;
		/// <summary>
		/// 매도거래원4 (144)
		/// </summary>
		[JsonProperty("144")]
		public string? SellBroker4;
		/// <summary>
		/// 매도거래원수량4 (164)
		/// </summary>
		[JsonProperty("164")]
		public decimal? SellBrokerQuantity4;
		/// <summary>
		/// 매도거래원별증감4 (169)
		/// </summary>
		[JsonProperty("169")]
		public KiwoomDecimal? SellBrokerChange4;
		/// <summary>
		/// 매도거래원코드4 (149)
		/// </summary>
		[JsonProperty("149")]
		public string? SellBrokerCode4;
		/// <summary>
		/// 매도거래원색깔4 (274)
		/// </summary>
		[JsonProperty("274")]
		public string? SellBrokerColor4;
		/// <summary>
		/// 매수거래원4 (154)
		/// </summary>
		[JsonProperty("154")]
		public string? BuyBroker4;
		/// <summary>
		/// 매수거래원수량4 (174)
		/// </summary>
		[JsonProperty("174")]
		public decimal? BuyBrokerQuantity4;
		/// <summary>
		/// 매수거래원별증감4 (179)
		/// </summary>
		[JsonProperty("179")]
		public KiwoomDecimal? BuyBrokerChange4;
		/// <summary>
		/// 매수거래원코드4 (159)
		/// </summary>
		[JsonProperty("159")]
		public string? BuyBrokerCode4;
		/// <summary>
		/// 매수거래원색깔4 (284)
		/// </summary>
		[JsonProperty("284")]
		public string? BuyBrokerColor4;
		/// <summary>
		/// 매도거래원5 (145)
		/// </summary>
		[JsonProperty("145")]
		public string? SellBroker5;
		/// <summary>
		/// 매도거래원수량5 (165)
		/// </summary>
		[JsonProperty("165")]
		public decimal? SellBrokerQuantity5;
		/// <summary>
		/// 매도거래원별증감5 (170)
		/// </summary>
		[JsonProperty("170")]
		public KiwoomDecimal? SellBrokerChange5;
		/// <summary>
		/// 매도거래원코드5 (150)
		/// </summary>
		[JsonProperty("150")]
		public string? SellBrokerCode5;
		/// <summary>
		/// 매도거래원색깔5 (275)
		/// </summary>
		[JsonProperty("275")]
		public string? SellBrokerColor5;
		/// <summary>
		/// 매수거래원5 (155)
		/// </summary>
		[JsonProperty("155")]
		public string? BuyBroker5;
		/// <summary>
		/// 매수거래원수량5 (175)
		/// </summary>
		[JsonProperty("175")]
		public decimal? BuyBrokerQuantity5;
		/// <summary>
		/// 매수거래원별증감5 (180)
		/// </summary>
		[JsonProperty("180")]
		public KiwoomDecimal? BuyBrokerChange5;
		/// <summary>
		/// 매수거래원코드5 (160)
		/// </summary>
		[JsonProperty("160")]
		public string? BuyBrokerCode5;
		/// <summary>
		/// 매수거래원색깔5 (285)
		/// </summary>
		[JsonProperty("285")]
		public string? BuyBrokerColor5;
		/// <summary>
		/// 외국계매도추정합 (261)
		/// </summary>
		[JsonProperty("261")]
		public decimal? TotalEstimatedForeignSell;
		/// <summary>
		/// 외국계매도추정합변동 (262)
		/// </summary>
		[JsonProperty("262")]
		public decimal? TotalEstimatedForeignSellChange;
		/// <summary>
		/// 외국계매수추정합 (263)
		/// </summary>
		[JsonProperty("263")]
		public decimal? TotalEstimatedForeignBuy;
		/// <summary>
		/// 외국계매수추정합변동 (264)
		/// </summary>
		[JsonProperty("264")]
		public decimal? TotalEstimatedForeignBuyChange;
		/// <summary>
		/// 외국계순매수추정합 (267)
		/// </summary>
		[JsonProperty("267")]
		public decimal? TotalEstimatedForeignNetBuy;
		/// <summary>
		/// 외국계순매수변동 (268)
		/// </summary>
		[JsonProperty("268")]
		public decimal? TotalEstimatedForeignNetBuyChange;
		/// <summary>
		/// 거래소구분 (337)
		/// </summary>
		[JsonProperty("337")]
		public KiwoomWebSocketStockExchangeType? ExchangeType;
	}

	public record KiwoomWebSocketRealtimeEtfNav
	{
		/// <summary>
		/// NAV (36)
		/// </summary>
		[JsonProperty("36")]
		public KiwoomDecimal? Nav;
		/// <summary>
		/// NAV전일대비 (37)
		/// </summary>
		[JsonProperty("37")]
		public KiwoomDecimal? NavChange;
		/// <summary>
		/// NAV등락율 (38)
		/// </summary>
		[JsonProperty("38")]
		public KiwoomDecimal? NavChangeRate;
		/// <summary>
		/// 추적오차율 (39)
		/// </summary>
		[JsonProperty("39")]
		public decimal? TrackingErrorRate;
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// ELW기어링비율 (667)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("667")]
		public decimal? ElwGearingRate;
		/// <summary>
		/// ELW손익분기율 (668)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("668")]
		public decimal? ElwBreakEvenRate;
		/// <summary>
		/// ELW자본지지점 (669)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("669")]
		public decimal? ElwCapitalSupportPoint;
		/// <summary>
		/// NAV/지수괴리율 (265)
		/// </summary>
		[JsonProperty("265")]
		public KiwoomDecimal? NavIndexDisparityRate;
		/// <summary>
		/// NAV/ETF괴리율 (266)
		/// </summary>
		[JsonProperty("266")]
		public KiwoomDecimal? NavEtfDisparityRate;
	}

	public record KiwoomWebSocketRealtimeExpectedTrade
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량 (15) - +는 매수체결,-는 매도체결
		/// </summary>
		[JsonProperty("15")]
		public KiwoomDecimal? Volume;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
	}

    public record KiwoomWebSocketRealtimeInternationalGoldPrice
    {
        /// <summary>
        /// 현재가 (10)
        /// </summary>
        [JsonProperty("10")]
        public KiwoomDecimal? CurrentPrice;
        /// <summary>
        /// 전일대비 (11)
        /// </summary>
        [JsonProperty("11")]
        public KiwoomDecimal? Change;
        /// <summary>
        /// 등락율 (12)
        /// </summary>
        [JsonProperty("12")]
        public KiwoomDecimal? ChangeRate;
        /// <summary>
        /// 전일대비기호 (25)
        /// </summary>
        [JsonProperty("25")]
        public string? ChangeSign;
    }

    public record KiwoomWebSocketRealtimeIndustryIndex
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래량 (15) - +는 매수체결,-는 매도체결
		/// </summary>
		[JsonProperty("15")]
		public decimal? Volume;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금 (14)
		/// </summary>
		[JsonProperty("14")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 시가 (16)
		/// </summary>
		[JsonProperty("16")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 고가 (17)
		/// </summary>
		[JsonProperty("17")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 저가 (18)
		/// </summary>
		[JsonProperty("18")]
		public KiwoomDecimal? Low;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// 전일거래량대비 (26) - 계약,주
		/// </summary>
		[JsonProperty("26")]
		public KiwoomDecimal? VolumeChange;
	}

	public record KiwoomWebSocketRealtimeIndustryChange
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 상승종목수 (252)
		/// </summary>
		[JsonProperty("252")]
		public int? UpStockCount;
		/// <summary>
		/// 상한종목수 (251)
		/// </summary>
		[JsonProperty("251")]
		public int? UpperStockCount;
		/// <summary>
		/// 보합종목수 (253)
		/// </summary>
		[JsonProperty("253")]
		public int? FlatStockCount;
		/// <summary>
		/// 하락종목수 (255)
		/// </summary>
		[JsonProperty("255")]
		public int? DownStockCount;
		/// <summary>
		/// 하한종목수 (254)
		/// </summary>
		[JsonProperty("254")]
		public int? LowerStockCount;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금 (14)
		/// </summary>
		[JsonProperty("14")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 거래형성종목수 (256) - 계약,주
		/// </summary>
		[JsonProperty("256")]
		public int? ActiveTradingStockCount;
		/// <summary>
		/// 거래형성비율 (257)
		/// </summary>
		[JsonProperty("257")]
		public decimal? ActiveTradingRate;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
	}

	public record KiwoomWebSocketRealtimeStockInfo
	{
		/// <summary>
		/// 임의연장 (297)
		/// </summary>
		[JsonProperty("297")]
		public string? ArbitraryExtension;
		/// <summary>
		/// 장전임의연장 (592)
		/// </summary>
		[JsonProperty("592")]
		public string? BeforeMarketArbitraryExtension;
		/// <summary>
		/// 장후임의연장 (593)
		/// </summary>
		[JsonProperty("593")]
		public string? AfterMarketArbitraryExtension;
		/// <summary>
		/// 상한가 (305)
		/// </summary>
		[JsonProperty("305")]
		public KiwoomDecimal? UpperPrice;
		/// <summary>
		/// 하한가 (306)
		/// </summary>
		[JsonProperty("306")]
		public KiwoomDecimal? LowerPrice;
		/// <summary>
		/// 기준가 (307)
		/// </summary>
		[JsonProperty("307")]
		public decimal? BasePrice;
		/// <summary>
		/// 조기종료ELW발생 (689)
		/// </summary>
		[JsonProperty("689")]
		public string? EarlyTerminationElw;
		/// <summary>
		/// 통화단위 (594)
		/// </summary>
		[JsonProperty("594")]
		public string? CurrencyUnit;
		/// <summary>
		/// 증거금율표시 (382)
		/// </summary>
		[JsonProperty("382")]
		public string? MarginRateDisplay;
		/// <summary>
		/// 종목정보 (370)
		/// </summary>
		[JsonProperty("370")]
		public string? StockInfo;
	}

	public record KiwoomWebSocketRealtimeElwTheoreticalPrice
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// ELW이론가 (670)
		/// </summary>
		[JsonProperty("670")]
		public decimal? ElwTheoreticalPrice;
		/// <summary>
		/// ELW내재변동성 (671)
		/// </summary>
		[JsonProperty("671")]
		public decimal? ElwImpliedVolatility;
		/// <summary>
		/// ELW델타 (672)
		/// </summary>
		[JsonProperty("672")]
		public decimal? ElwDelta;
		/// <summary>
		/// ELW감마 (673)
		/// </summary>
		[JsonProperty("673")]
		public decimal? ElwGamma;
		/// <summary>
		/// ELW쎄타 (674)
		/// </summary>
		[JsonProperty("674")]
		public decimal? ElwTheta;
		/// <summary>
		/// ELW베가 (675)
		/// </summary>
		[JsonProperty("675")]
		public decimal? ElwVega;
		/// <summary>
		/// ELW로 (676)
		/// </summary>
		[JsonProperty("676")]
		public decimal? ElwLaw;
		/// <summary>
		/// LP호가내재변동성 (706)
		/// </summary>
		[JsonProperty("706")]
		public decimal? LpQuoteImpliedVolatility;
	}

	public record KiwoomWebSocketRealtimeMarketOpenTime
	{
		/// <summary>
		/// 장운영구분 (215)<br/>
		/// 0:장시작전 알림(8:40부터 1분마다 수신)<br/>
		/// 2:장마감전 알림(15:20부터 1분마다 수신)<br/>
		/// 3:장시작(09:00)<br/>
		/// 4:장마감(15:30)<br/>
		/// 8:정규장마감(거래소 수신시 15:30 이후)<br/>
		/// 9:전체장마감(거래소 수신시 20:00 이후)<br/>
		/// a:시간외 종가매매 시작(15:40)<br/>
		/// b:시간외 종가매매 종료(16:00)<br/>
		/// g:KRX애프터마켓 시작(16:00)<br/>
		/// h:KRX애프터마켓 종료(20:00)<br/>
		/// s:선옵 장마감전 동시호가 시작<br/>
		/// e:선옵 장마감전 동시호가 종료<br/>
		/// f:선물옵션 장운영시간 알림(조기개장 상품)<br/>
		/// o:선옵 장시작<br/>
		/// P:NXT 프리마켓 시작<br/>
		/// Q:NXT 프리마켓 종료<br/>
		/// R:NXT 메인마켓 시작<br/>
		/// S:NXT 메인마켓 종료<br/>
		/// T:NXT 애프터마켓 단일가 시작<br/>
		/// U:NXT 애프터마켓 시작<br/>
		/// V:NXT 애프터마켓 종료<br/>
		/// </summary>
		[JsonProperty("215")]
		public string? MarketOperationType;
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 장시작예상잔여시간 (214)
		/// </summary>
		[JsonProperty("214")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? MarketOpenRemainingTime;
	}

	public record KiwoomWebSocketRealtimeElwIndicator
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// ELW패리티 (666)
		/// </summary>
		[JsonProperty("666")]
		public decimal? ElwParity;
		/// <summary>
		/// ELW프리미엄 (1211)
		/// </summary>
		[JsonProperty("1211")]
		public decimal? ElwPremium;
		/// <summary>
		/// ELW기어링비율 (667)
		/// </summary>
		[JsonProperty("667")]
		public decimal? ElwGearingRate;
		/// <summary>
		/// ELW손익분기율 (668)
		/// </summary>
		[JsonProperty("668")]
		public KiwoomDecimal? ElwBreakEvenRate;
		/// <summary>
		/// ELW자본지지점 (669)
		/// </summary>
		[JsonProperty("669")]
		public KiwoomDecimal? ElwCapitalSupportPoint;
	}

	public record KiwoomWebSocketRealtimeProgramTransaction
	{
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public KiwoomDecimal? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 매도수량 (202)
		/// </summary>
		[JsonProperty("202")]
		public decimal? SellQuantity;
		/// <summary>
		/// 매도금액 (204)
		/// </summary>
		[JsonProperty("204")]
		public decimal? SellAmount;
		/// <summary>
		/// 매수수량 (206)
		/// </summary>
		[JsonProperty("206")]
		public decimal? BuyQuantity;
		/// <summary>
		/// 매수금액 (208)
		/// </summary>
		[JsonProperty("208")]
		public decimal? BuyAmount;
		/// <summary>
		/// 순매수수량 (210)
		/// </summary>
		[JsonProperty("210")]
		public KiwoomDecimal? NetBuyQuantity;
		/// <summary>
		/// 순매수수량증감 (211) - 계약,주
		/// </summary>
		[JsonProperty("211")]
		public KiwoomDecimal? NetBuyQuantityChange;
		/// <summary>
		/// 순매수금액 (212)
		/// </summary>
		[JsonProperty("212")]
		public decimal? NetBuyAmount;
		/// <summary>
		/// 순매수금액증감 (213)
		/// </summary>
		[JsonProperty("213")]
		public decimal? NetBuyAmountChange;
		/// <summary>
		/// 장시작예상잔여시간 (214)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("214")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? MarketOpenRemainingTime;
		/// <summary>
		/// 장운영구분 (215)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("215")]
		public string? MarketOperationType;
		/// <summary>
		/// 투자자별ticker (216)
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 항목입니다. 값이 제공되지 않을 수 있습니다.")]
		[JsonProperty("216")]
		public string? InvestorTicker;
	}

	public record KiwoomWebSocketRealtimeViEvent
	{
		/// <summary>
		/// 종목코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 누적거래대금 (14)
		/// </summary>
		[JsonProperty("14")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// VI발동구분 (9068) - 1: 정적 VI, 2: 동적 VI, 3: 동적+정적 VI, 4: VI연장
		/// </summary>
		[JsonProperty("9068")]
		public string? ViStrikeType;
		/// <summary>
		/// KOSPI,KOSDAQ,전체구분 (9008)
		/// </summary>
		[JsonProperty("9008")]
		public string? MarketType;
		/// <summary>
		/// 장전구분 (9075)
		/// </summary>
		[JsonProperty("9075")]
		public string? BeforeMarketType;
		/// <summary>
		/// VI발동가격 (1221)
		/// </summary>
		[JsonProperty("1221")]
		public decimal? ViStrikePrice;
		/// <summary>
		/// 매매체결처리시각 (1223)
		/// </summary>
		[JsonProperty("1223")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeProcessTime;
		/// <summary>
		/// VI해제시각 (1224)
		/// </summary>
		[JsonProperty("1224")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? ViReleaseTime;
		/// <summary>
		/// VI적용구분 (1225) - 정적/동적/동적+정적
		/// </summary>
		[JsonProperty("1225")]
		public string? ViApplyType;
		/// <summary>
		/// 기준가격 정적 (1236) - 계약,주
		/// </summary>
		[JsonProperty("1236")]
		public decimal? BasePriceStatic;
		/// <summary>
		/// 기준가격 동적 (1237)
		/// </summary>
		[JsonProperty("1237")]
		public decimal? BasePriceDynamic;
		/// <summary>
		/// 괴리율 정적 (1238)
		/// </summary>
		[JsonProperty("1238")]
		public KiwoomDecimal? DisparityRateStatic;
		/// <summary>
		/// 괴리율 동적 (1239)
		/// </summary>
		[JsonProperty("1239")]
		public KiwoomDecimal? DisparityRateDynamic;
		/// <summary>
		/// VI발동가 등락율 (1489)
		/// </summary>
		[JsonProperty("1489")]
		public KiwoomDecimal? ViStrikePriceChangeRate;
		/// <summary>
		/// VI발동횟수 (1490)
		/// </summary>
		[JsonProperty("1490")]
		public int? ViStrikeCount;
		/// <summary>
		/// 발동방향구분 (9069)
		/// </summary>
		[JsonProperty("9069")]
		public string? StrikeDirectionType;
		/// <summary>
		/// Extra Item (1279)
		/// </summary>
		[JsonProperty("1279")]
		public KiwoomString? ExtraItem;
	}

	public record KiwoomWebSocketConditionSearchList
	{
		/// <summary>
		/// 조건검색식 일련번호
		/// </summary>
		[JsonProperty("seq")]
		public int? Id;
		/// <summary>
		/// 조건검색식 명
		/// </summary>
		[JsonProperty("name")]
		public string? Name;
	}

	public record KiwoomWebSocketConditionSearchRequest
	{
		/// <summary>
		/// 종목코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 종목명 (302)
		/// </summary>
		[JsonProperty("302")]
		public string? StockName;
		/// <summary>
		/// 현재가 (10)
		/// </summary>
		[JsonProperty("10")]
		public string? CurrentPrice;
		/// <summary>
		/// 전일대비기호 (25)
		/// </summary>
		[JsonProperty("25")]
		public string? ChangeSign;
		/// <summary>
		/// 전일대비 (11)
		/// </summary>
		[JsonProperty("11")]
		public string? Change;
		/// <summary>
		/// 등락율 (12)
		/// </summary>
		[JsonProperty("12")]
		public string? ChangeRate;
		/// <summary>
		/// 누적거래량 (13)
		/// </summary>
		[JsonProperty("13")]
		public string? AccumulatedVolume;
		/// <summary>
		/// 시가 (16)
		/// </summary>
		[JsonProperty("16")]
		public string? Open;
		/// <summary>
		/// 고가 (17)
		/// </summary>
		[JsonProperty("17")]
		public string? High;
		/// <summary>
		/// 저가 (18)
		/// </summary>
		[JsonProperty("18")]
		public string? Low;
	}

	public record KiwoomWebSocketConditionSearchRequestRealtime
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("jmcode")]
		public string? StockCode;
		/// <summary>
		/// 거래소구분 (ND:NASDAQ, NY:NYSE, NA:AMEX) - 미국주식 조건검색에서만 전달
		/// </summary>
		[JsonProperty("stexTp")]
		public string? ExchangeType;
	}

	public record KiwoomWebSocketConditionSearchRequestRealtime2
	{
		/// <summary>
		/// 서비스명
		/// </summary>
		[JsonProperty("trnm")]
		public string? ServiceName;
		/// <summary>
		/// 실시간 항목 타입 (ex: 0A, 0B ...)
		/// </summary>
		[JsonProperty("type")]
		public string? RealType;
		/// <summary>
		/// 실시간 항목명
		/// </summary>
		[JsonProperty("name")]
		public string? RealName;
		/// <summary>
		/// 실시간 수신 값
		/// </summary>
		[JsonProperty("values")]
		public KiwoomWebSocketConditionSearchRequestRealtime2Value? Values;
	}

	public record KiwoomWebSocketConditionSearchRequestRealtime2Value
	{
		/// <summary>
		/// 일련번호 (841)
		/// </summary>
		[JsonProperty("841")]
		public string? SerialId;
		/// <summary>
		/// 종목코드 (9001)
		/// </summary>
		[JsonProperty("9001")]
		public string? StockCode;
		/// <summary>
		/// 삽입삭제 구분 (843) - I: 삽입, D: 삭제
		/// </summary>
		[JsonProperty("843")]
		public string? InsertDeleteType;
		/// <summary>
		/// 체결시간 (20)
		/// </summary>
		[JsonProperty("20")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? TradeTime;
		/// <summary>
		/// 매도/수 구분 (907)
		/// </summary>
		[JsonProperty("907")]
		public string? OrderSide;
		/// <summary>
		/// 거래소 구분 (9081)
		/// </summary>
		[JsonProperty("9081")]
		public string? ExchangeType;
	}

	public record KiwoomWebSocketConditionSearchClear
	{

	}

}
