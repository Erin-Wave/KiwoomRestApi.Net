using KiwoomRestApi.Net.Enums.DomesticStock.Watchlist;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.UsStock
{
	/// <summary>
	/// 관심종목 배열 파라미터(거래소구분 + 종목코드)에 사용하는 항목입니다.
	/// </summary>
	public record KiwoomUsStockInfoWatchlistStock
	{
		[JsonProperty("stex_tp")]
		public string? StockExchangeType;
		[JsonProperty("stk_cd")]
		public string? StockCode;
	}

	#region usa10098, usa10099, usa10100 - 종목 기본정보
	public record KiwoomUsStockInfoGetExchangeTypes
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomUsStockInfoStockBasicItem>? Items;
	}

	public record KiwoomUsStockInfoGetStocks
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomUsStockInfoStockBasicItem>? Items;
	}

	public record KiwoomUsStockInfoStockBasicItem
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
		/// 거래소명
		/// </summary>
		[JsonProperty("mkgb")]
		public string? MarketName;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("upgb")]
		public string? IndustryName;
		/// <summary>
		/// ETF 여부
		/// </summary>
		[JsonProperty("isEtf")]
		public string? IsEtf;
	}

	public record KiwoomUsStockInfoGetStock
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
		/// 거래소명
		/// </summary>
		[JsonProperty("mkgb")]
		public string? MarketName;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("upgb")]
		public string? IndustryName;
		/// <summary>
		/// ETF 여부
		/// </summary>
		[JsonProperty("isEtf")]
		public string? IsEtf;
	}
	#endregion

	#region usa10103 - 종목메모 조회
	public record KiwoomUsStockInfoGetStockMemos
	{
		/// <summary>
		/// 처리결과
		/// </summary>
		[JsonProperty("rtcd")]
		private string? RawResult { get; set; }
		public KiwoomWatchlistResult Result => RawResult switch
		{
			"S" => KiwoomWatchlistResult.Success,
			"F" => KiwoomWatchlistResult.Failure,
			_ => KiwoomWatchlistResult.Failure
		};
		/// <summary>
		/// 종목메모 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoGetStockMemoItem>? Items;
	}

	public record KiwoomUsStockInfoGetStockMemoItem
	{
		/// <summary>
		/// 거래소구분 (ND:NASDAQ, NY:NYSE, NA:AMEX)
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 메모내용 - 영웅문G에서 설정한 메모 내용
		/// </summary>
		[JsonProperty("memo")]
		public string? Memo;
	}
	#endregion

	#region usa10101, usa10102, usa10104, usa10105 - 업종/지수/ETF 카테고리 리스트
	public record KiwoomUsStockInfoGetIndustries
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomUsStockInfoIndustryItem>? Items;
	}

	public record KiwoomUsStockInfoIndustryItem
	{
		/// <summary>
		/// 구분
		/// </summary>
		[JsonProperty("gubun")]
		public string? QueryType;
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
		/// 업종영문명
		/// </summary>
		[JsonProperty("inds_enm")]
		public string? IndustryEnglishName;
	}

	public record KiwoomUsStockInfoGetIndices
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomUsStockInfoIndexItem>? Items;
	}

	public record KiwoomUsStockInfoIndexItem
	{
		/// <summary>
		/// 거래소구분
		/// </summary>
		[JsonProperty("stex_tp")]
		public string? ExchangeType;
		/// <summary>
		/// 지수코드
		/// </summary>
		[JsonProperty("index_cd")]
		public string? IndexCode;
		/// <summary>
		/// 지수명
		/// </summary>
		[JsonProperty("index_nm")]
		public string? IndexName;
		/// <summary>
		/// 지수영문명
		/// </summary>
		[JsonProperty("index_enm")]
		public string? IndexEnglishName;
	}

	public record KiwoomUsStockInfoGetEtfEtns
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomUsStockInfoEtfEtnItem>? Items;
	}

	public record KiwoomUsStockInfoEtfEtnItem
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
		/// 카테고리1
		/// </summary>
		[JsonProperty("cate1")]
		public string? Category1;
		/// <summary>
		/// 카테고리2
		/// </summary>
		[JsonProperty("cate2")]
		public string? Category2;
		/// <summary>
		/// ETN여부
		/// </summary>
		[JsonProperty("etn")]
		public string? IsEtn;
		/// <summary>
		/// 거래소명
		/// </summary>
		[JsonProperty("mkgb")]
		public string? MarketName;
		/// <summary>
		/// 업종명
		/// </summary>
		[JsonProperty("upnm")]
		public string? IndustryName;
	}

	public record KiwoomUsStockInfoGetEtfCategories
	{
		[JsonProperty("list")]
		public IEnumerable<KiwoomUsStockInfoEtfCategoryItem>? Items;
	}

	public record KiwoomUsStockInfoEtfCategoryItem
	{
		/// <summary>
		/// 구분
		/// </summary>
		[JsonProperty("gubun")]
		public string? QueryType;
		/// <summary>
		/// 카테고리1차
		/// </summary>
		[JsonProperty("cate1")]
		public string? Category1;
		/// <summary>
		/// 카테고리1차명
		/// </summary>
		[JsonProperty("cate1nam")]
		public string? Category1Name;
		/// <summary>
		/// 카테고리2차
		/// </summary>
		[JsonProperty("cate2")]
		public string? Category2;
		/// <summary>
		/// 카테고리2차명
		/// </summary>
		[JsonProperty("cate2nam")]
		public string? Category2Name;
	}
	#endregion

	#region usa20520, usa20521 - 거래량급등락
	public record KiwoomUsStockInfoGetVolumeSurges
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoVolumeSurgeItem>? Items;
	}

	public record KiwoomUsStockInfoVolumeSurgeItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 급증률
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public KiwoomDecimal? SurgeRate;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBidPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBidPrice;
	}
	#endregion

	#region usa20570, usa20571 - 가격대별주가
	public record KiwoomUsStockInfoGetPriceRanges
	{
		/// <summary>
		/// 종목수
		/// </summary>
		[JsonProperty("stk_num")]
		public int? StockCount;
		/// <summary>
		/// 상승
		/// </summary>
		[JsonProperty("rising_stk_num")]
		public int? RisingStockCount;
		/// <summary>
		/// 보합
		/// </summary>
		[JsonProperty("flat_stk_num")]
		public int? FlatStockCount;
		/// <summary>
		/// 하락
		/// </summary>
		[JsonProperty("fall_stk_num")]
		public int? FallStockCount;
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoPriceRangeItem>? Items;
	}

	public record KiwoomUsStockInfoPriceRangeItem
	{
		/// <summary>
		/// 순위
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank;
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBidPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBidPrice;
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
	#endregion

	#region usa20930, usa20931, usa20932 - 가격급등락
	public record KiwoomUsStockInfoGetPriceVolatilities
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoPriceVolatilityItem>? Items;
	}

	public record KiwoomUsStockInfoPriceVolatilityItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 기준가
		/// </summary>
		[JsonProperty("base_pric")]
		public decimal? BasePrice;
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 기준대비
		/// </summary>
		[JsonProperty("base_pre")]
		public decimal? BaseChange;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 급증률
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public KiwoomDecimal? SurgeRate;
	}
	#endregion

	#region usa20970, usa20971 - 고가/저가 접근
	public record KiwoomUsStockInfoGetHighLowApproaches
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoHighLowApproachItem>? Items;
	}

	public record KiwoomUsStockInfoHighLowApproachItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBidPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBidPrice;
		/// <summary>
		/// 당일고가
		/// </summary>
		[JsonProperty("high_pric")]
		public KiwoomDecimal? High;
		/// <summary>
		/// 당일저가
		/// </summary>
		[JsonProperty("low_pric")]
		public KiwoomDecimal? Low;
	}
	#endregion

	#region usa20972 - 고가/저가 접근(관심종목)
	public record KiwoomUsStockInfoGetWatchlistHighLowApproaches
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoWatchlistHighLowApproachItem>? Items;
	}

	public record KiwoomUsStockInfoWatchlistHighLowApproachItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 누적거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 신종목구분자
		/// </summary>
		[JsonProperty("tp")]
		public string? NewStockType;
		/// <summary>
		/// 등락률
		/// </summary>
		[JsonProperty("flu_rt")]
		public KiwoomDecimal? ChangeRate;
		/// <summary>
		/// (최우선)매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBidPrice;
		/// <summary>
		/// (최우선)매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBidPrice;
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
	#endregion

	#region usa23400, usa23401 - 거래량갱신
	public record KiwoomUsStockInfoGetVolumeRenewals
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoVolumeRenewalItem>? Items;
	}

	public record KiwoomUsStockInfoVolumeRenewalItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 이전거래량
		/// </summary>
		[JsonProperty("prev_trde_qty")]
		public decimal? PreviousVolume;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBidPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBidPrice;
	}
	#endregion

	#region usa24100, usa24101 - 신고가/신저가
	public record KiwoomUsStockInfoGetNewPrices
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoNewPriceItem>? Items;
	}

	public record KiwoomUsStockInfoNewPriceItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 전일거래대비
		/// </summary>
		[JsonProperty("pre_trde_rt")]
		public KiwoomDecimal? PreviousDayVolumeRate;
		/// <summary>
		/// 매도호가
		/// </summary>
		[JsonProperty("sel_bid")]
		public KiwoomDecimal? SellBidPrice;
		/// <summary>
		/// 매수호가
		/// </summary>
		[JsonProperty("buy_bid")]
		public KiwoomDecimal? BuyBidPrice;
		/// <summary>
		/// 250일고가 (조회기간 내 고가)
		/// </summary>
		[JsonProperty("high_pric")]
		public decimal? High;
		/// <summary>
		/// 250일저가 (조회기간 내 저가)
		/// </summary>
		[JsonProperty("low_pric")]
		public decimal? Low;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
	}
	#endregion

	#region usa24140, usa24141 - 갭상승/갭하락
	public record KiwoomUsStockInfoGetGaps
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoGapItem>? Items;
	}

	public record KiwoomUsStockInfoGapItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 시가
		/// </summary>
		[JsonProperty("open_pric")]
		public KiwoomDecimal? Open;
		/// <summary>
		/// 전일종가
		/// </summary>
		[JsonProperty("base_close_pric")]
		public decimal? PreviousClose;
		/// <summary>
		/// 갭비율
		/// </summary>
		[JsonProperty("gap_rt")]
		public KiwoomDecimal? GapRate;
		/// <summary>
		/// 전일고가
		/// </summary>
		[JsonProperty("pre_high_pric")]
		public string? PreviousHigh;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[JsonProperty("pred_trde_qty")]
		public decimal? PreviousDayVolume;
	}
	#endregion

	#region usa24210, usa24211 - 잔량률급증
	public record KiwoomUsStockInfoGetRemainRatioSurges
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoRemainRatioSurgeItem>? Items;
	}

	public record KiwoomUsStockInfoRemainRatioSurgeItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 기준비율
		/// </summary>
		[JsonProperty("int")]
		public decimal? BaseRatio;
		/// <summary>
		/// 현재비율
		/// </summary>
		[JsonProperty("now_rt")]
		public decimal? CurrentRatio;
		/// <summary>
		/// 급증률
		/// </summary>
		[JsonProperty("sdnin_rt")]
		public decimal? SurgeRate;
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
	#endregion

	#region usa24220, usa24221 - 매물대집중
	public record KiwoomUsStockInfoGetVolumeZones
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoVolumeZoneItem>? Items;
	}

	public record KiwoomUsStockInfoVolumeZoneItem
	{
		/// <summary>
		/// 증거금률
		/// </summary>
		[JsonProperty("mgn_type")]
		public string? MarginType;
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
		/// 가격대시작
		/// </summary>
		[JsonProperty("pric_cnd_st")]
		public decimal? PriceZoneStart;
		/// <summary>
		/// 가격대끝
		/// </summary>
		[JsonProperty("pric_cnd_ed")]
		public decimal? PriceZoneEnd;
		/// <summary>
		/// 매물량
		/// </summary>
		[JsonProperty("prps_qty")]
		public decimal? VolumeZoneQuantity;
		/// <summary>
		/// 매물비
		/// </summary>
		[JsonProperty("prps_rt")]
		public decimal? VolumeZoneRate;
	}
	#endregion

	#region usa26410, usa26413, usa26414 - 연도별 등락률(종목/업종/ETF)
	public record KiwoomUsStockInfoGetYearlyChangeRates
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoYearlyChangeRateItem>? Items;
	}

	public record KiwoomUsStockInfoYearlyChangeRateItem
	{
		/// <summary>
		/// 연도 (0:평균, YYYY:년도)
		/// </summary>
		[JsonProperty("dt")]
		public string? Year;
		/// <summary>
		/// 1월 수익률
		/// </summary>
		[JsonProperty("m01_prft_rt")]
		public decimal? January;
		/// <summary>
		/// 2월 수익률
		/// </summary>
		[JsonProperty("m02_prft_rt")]
		public decimal? February;
		/// <summary>
		/// 3월 수익률
		/// </summary>
		[JsonProperty("m03_prft_rt")]
		public decimal? March;
		/// <summary>
		/// 4월 수익률
		/// </summary>
		[JsonProperty("m04_prft_rt")]
		public decimal? April;
		/// <summary>
		/// 5월 수익률
		/// </summary>
		[JsonProperty("m05_prft_rt")]
		public decimal? May;
		/// <summary>
		/// 6월 수익률
		/// </summary>
		[JsonProperty("m06_prft_rt")]
		public decimal? June;
		/// <summary>
		/// 7월 수익률
		/// </summary>
		[JsonProperty("m07_prft_rt")]
		public decimal? July;
		/// <summary>
		/// 8월 수익률
		/// </summary>
		[JsonProperty("m08_prft_rt")]
		public decimal? August;
		/// <summary>
		/// 9월 수익률
		/// </summary>
		[JsonProperty("m09_prft_rt")]
		public decimal? September;
		/// <summary>
		/// 10월 수익률
		/// </summary>
		[JsonProperty("m10_prft_rt")]
		public decimal? October;
		/// <summary>
		/// 11월 수익률
		/// </summary>
		[JsonProperty("m11_prft_rt")]
		public decimal? November;
		/// <summary>
		/// 12월 수익률
		/// </summary>
		[JsonProperty("m12_prft_rt")]
		public decimal? December;
	}
	#endregion

	#region usa26411, usa26412 - 연도별 업종별/ETF카테고리별 종목등락률
	public record KiwoomUsStockInfoGetStockYearlyChangeRates
	{
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomUsStockInfoStockYearlyChangeRateItem>? Items;
	}

	public record KiwoomUsStockInfoStockYearlyChangeRateItem
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
		/// 1월 수익률
		/// </summary>
		[JsonProperty("m01_prft_rt")]
		public decimal? January;
		/// <summary>
		/// 2월 수익률
		/// </summary>
		[JsonProperty("m02_prft_rt")]
		public decimal? February;
		/// <summary>
		/// 3월 수익률
		/// </summary>
		[JsonProperty("m03_prft_rt")]
		public decimal? March;
		/// <summary>
		/// 4월 수익률
		/// </summary>
		[JsonProperty("m04_prft_rt")]
		public decimal? April;
		/// <summary>
		/// 5월 수익률
		/// </summary>
		[JsonProperty("m05_prft_rt")]
		public decimal? May;
		/// <summary>
		/// 6월 수익률
		/// </summary>
		[JsonProperty("m06_prft_rt")]
		public decimal? June;
		/// <summary>
		/// 7월 수익률
		/// </summary>
		[JsonProperty("m07_prft_rt")]
		public decimal? July;
		/// <summary>
		/// 8월 수익률
		/// </summary>
		[JsonProperty("m08_prft_rt")]
		public decimal? August;
		/// <summary>
		/// 9월 수익률
		/// </summary>
		[JsonProperty("m09_prft_rt")]
		public decimal? September;
		/// <summary>
		/// 10월 수익률
		/// </summary>
		[JsonProperty("m10_prft_rt")]
		public decimal? October;
		/// <summary>
		/// 11월 수익률
		/// </summary>
		[JsonProperty("m11_prft_rt")]
		public decimal? November;
		/// <summary>
		/// 12월 수익률
		/// </summary>
		[JsonProperty("m12_prft_rt")]
		public decimal? December;
	}
	#endregion
}
