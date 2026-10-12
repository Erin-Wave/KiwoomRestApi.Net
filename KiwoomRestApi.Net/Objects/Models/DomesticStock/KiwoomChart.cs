using KiwoomRestApi.Net.Converters;
using KiwoomRestApi.Net.Enums.DomesticStock.Chart;
using KiwoomRestApi.Net.Objects.Commons;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KiwoomRestApi.Net.Objects.Models.DomesticStock
{
	public record KiwoomChartGetInvestorInstitutionCharts
	{
		/// <summary>
		/// 종목별투자자기관별차트 리스트
		/// </summary>
		[JsonProperty("stk_invsr_orgn_chart")]
		public IEnumerable<KiwoomChartGetInvestorInstitutionChartItem>? Items;
	}
	public record KiwoomChartGetInvestorInstitutionChartItem
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
		/// 누적거래대금
		/// </summary>
		[JsonProperty("acc_trde_prica")]
		public decimal? AccumulatedTransactionAmount;
		/// <summary>
		/// 개인투자자
		/// </summary>
		[JsonProperty("ind_invsr")]
		public KiwoomDecimal? RetailInvestor;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public KiwoomDecimal? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institution;
		/// <summary>
		/// 금융투자
		/// </summary>
		[JsonProperty("fnnc_invt")]
		public KiwoomDecimal? FinancialInvestment;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public KiwoomDecimal? Insurance;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public KiwoomDecimal? InvestmentTrust;
		/// <summary>
		/// 기타금융
		/// </summary>
		[JsonProperty("etc_fnnc")]
		public KiwoomDecimal? OtherFinancials;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public KiwoomDecimal? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public KiwoomDecimal? PensionFundEtc;
		/// <summary>
		/// 사모펀드
		/// </summary>
		[JsonProperty("samo_fund")]
		public KiwoomDecimal? PrivateFund;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public KiwoomDecimal? Nation;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public KiwoomDecimal? OtherCorporations;
		/// <summary>
		/// 내외국인
		/// </summary>
		[JsonProperty("natfor")]
		public KiwoomDecimal? DomesticForeign;
	}

	public record KiwoomChartGetIntradayInvestorTradeCharts
	{
		/// <summary>
		/// 장중투자자별매매차트 리스트
		/// </summary>
		[JsonProperty("opmr_invsr_trde_chart")]
		public IEnumerable<KiwoomChartGetIntradayInvestorTradeChartItem>? Items;
	}
	public record KiwoomChartGetIntradayInvestorTradeChartItem
	{
		/// <summary>
		/// 시간
		/// </summary>
		[JsonProperty("tm")]
		[JsonConverter(typeof(KiwoomTimeSpanConverter))]
		public TimeSpan? Time;
		/// <summary>
		/// 외국인투자자
		/// </summary>
		[JsonProperty("frgnr_invsr")]
		public KiwoomDecimal? ForeignInvestor;
		/// <summary>
		/// 기관계
		/// </summary>
		[JsonProperty("orgn")]
		public KiwoomDecimal? Institution;
		/// <summary>
		/// 투신
		/// </summary>
		[JsonProperty("invtrt")]
		public KiwoomDecimal? InvestmentTrust;
		/// <summary>
		/// 보험
		/// </summary>
		[JsonProperty("insrnc")]
		public KiwoomDecimal? Insurance;
		/// <summary>
		/// 은행
		/// </summary>
		[JsonProperty("bank")]
		public KiwoomDecimal? Bank;
		/// <summary>
		/// 연기금등
		/// </summary>
		[JsonProperty("penfnd_etc")]
		public KiwoomDecimal? PensionFundEtc;
		/// <summary>
		/// 기타법인
		/// </summary>
		[JsonProperty("etc_corp")]
		public KiwoomDecimal? OtherCorporations;
		/// <summary>
		/// 국가
		/// </summary>
		[JsonProperty("natn")]
		public KiwoomDecimal? Nation;
	}

	public record KiwoomChartGetTickCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 마지막틱갯수
		/// </summary>
		[JsonProperty("last_tic_cnt")]
		public int? LastTickCount;
		/// <summary>
		/// 주식틱차트조회 리스트
		/// </summary>
		[JsonProperty("stk_tic_chart_qry")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetMinuteCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식분봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_min_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetTickChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
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
		/// 누적거래량 (분봉차트에서만 제공)
		/// </summary>
		[JsonProperty("acc_trde_qty")]
		public decimal? AccumulatedVolume;
		/// <summary>
		/// 전일대비
		/// </summary>
        [JsonProperty("pred_pre")]
        public KiwoomDecimal? Change;
		/// <summary>
		/// 전일대비 기호
		/// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
		/// <summary>
		/// 수정구분자 - ,구분으로 복수개 출력 가능 (1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락)
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		public string? UpdatedStockPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public string? UpdateRate;
    }

	public record KiwoomChartGetDailyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식일봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_dt_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetWeeklyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식주봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_stk_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetMonthlyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식월봉차트조회 리스트
		/// </summary>
		[JsonProperty("stk_mth_pole_chart_qry")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
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
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
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
        /// 전일대비
        /// </summary>
        [JsonProperty("pred_pre")]
        public KiwoomDecimal? Change;
        /// <summary>
        /// 전일대비 기호
        /// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
        /// <summary>
        /// 거래회전율
        /// </summary>
        [JsonProperty("trde_tern_rt")]
        public KiwoomDecimal? TradeTurnoverRate;
		/// <summary>
		/// 수정구분자 - ,구분으로 복수개 출력 가능 (1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락)
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		public string? UpdatedStockPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public string? UpdateRate;
    }

    public record KiwoomChartGetYearlyCharts
    {
        /// <summary>
        /// 종목코드
        /// </summary>
        [JsonProperty("stk_cd")]
        public string? StockCode;
        /// <summary>
        /// 주식년봉차트조회 리스트
        /// </summary>
        [JsonProperty("stk_yr_pole_chart_qry")]
        public IEnumerable<KiwoomChartGetYearChartItem>? Items;
    }
    public record KiwoomChartGetYearChartItem
    {
        /// <summary>
        /// 현재가
        /// </summary>
        [JsonProperty("cur_prc")]
        public KiwoomDecimal? CurrentPrice;
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
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
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
		/// 수정구분자 - ,구분으로 복수개 출력 가능 (1:유상증자, 2:무상증자, 4:배당락, 8:액면분할, 16:액면병합, 32:기업합병, 64:감자, 256:권리락)
		/// </summary>
		[JsonProperty("upd_stkpc_tp")]
		public string? UpdatedStockPriceType;
		/// <summary>
		/// 수정비율
		/// </summary>
		[JsonProperty("upd_rt")]
		public string? UpdateRate;
    }

	public record KiwoomChartGetRegularMarketTickCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 마지막틱갯수
		/// </summary>
		[JsonProperty("last_tic_cnt")]
		public int? LastTickCount;
		/// <summary>
		/// 주식틱차트정규장조회 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetRegularMarketMinuteCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식분봉차트정규장조회 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomChartGetTickChartItem>? Items;
	}
	public record KiwoomChartGetRegularMarketDailyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식일봉차트정규장조회 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetRegularMarketWeeklyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식주봉차트정규장조회 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetRegularMarketMonthlyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식월봉차트정규장조회 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomChartGetChartItem>? Items;
	}
	public record KiwoomChartGetRegularMarketYearlyCharts
	{
		/// <summary>
		/// 종목코드
		/// </summary>
		[JsonProperty("stk_cd")]
		public string? StockCode;
		/// <summary>
		/// 주식년봉차트정규장조회 리스트
		/// </summary>
		[JsonProperty("result_list")]
		public IEnumerable<KiwoomChartGetYearChartItem>? Items;
	}

    public record KiwoomChartGetIndustryTickCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public KiwoomChartIndustryCode? IndustryCode;
		/// <summary>
		/// 업종틱차트조회 리스트
		/// </summary>
		[JsonProperty("inds_tic_chart_qry")]
		public IEnumerable<KiwoomChartGetIndustryTickChartItem>? Items;
	}
	public record KiwoomChartGetIndustryTickChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 체결시간
		/// </summary>
		[JsonProperty("cntr_tm")]
		[JsonConverter(typeof(KiwoomDateTimeConverter))]
		public DateTime? TradeTime;
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
        /// 전일대비
        /// </summary>
        [JsonProperty("pred_pre")]
        public KiwoomDecimal? Change;
        /// <summary>
        /// 전일대비 기호
        /// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
    }

    public record KiwoomChartGetIndustryMinuteCharts
    {
        /// <summary>
        /// 업종코드
        /// </summary>
        [JsonProperty("inds_cd")]
        public KiwoomChartIndustryCode? IndustryCode;
        /// <summary>
        /// 업종분봉조회 리스트
        /// </summary>
        [JsonProperty("inds_min_pole_qry")]
        public IEnumerable<KiwoomChartGetIndustryMinuteChartItem>? Items;
    }
    public record KiwoomChartGetIndustryMinuteChartItem
    {
        /// <summary>
        /// 현재가
        /// </summary>
        [JsonProperty("cur_prc")]
        public KiwoomDecimal? CurrentPrice;
        /// <summary>
        /// 거래량
        /// </summary>
        [JsonProperty("trde_qty")]
        public decimal? Volume;
        /// <summary>
        /// 체결시간
        /// </summary>
        [JsonProperty("cntr_tm")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeTime;
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
        /// 누적거래량
        /// </summary>
        [JsonProperty("acc_trde_qty")]
        public decimal? AccumulatedVolume;
        /// <summary>
        /// 전일대비
        /// </summary>
        [JsonProperty("pred_pre")]
        public KiwoomDecimal? Change;
        /// <summary>
        /// 전일대비 기호
        /// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
    }

    public record KiwoomChartGetIndustryDailyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public KiwoomChartIndustryCode? IndustryCode;
		/// <summary>
		/// 업종일봉조회 리스트
		/// </summary>
		[JsonProperty("inds_dt_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryWeeklyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public KiwoomChartIndustryCode? IndustryCode;
		/// <summary>
		/// 업종주봉조회 리스트
		/// </summary>
		[JsonProperty("inds_stk_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryMonthlyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public KiwoomChartIndustryCode? IndustryCode;
		/// <summary>
		/// 업종월봉조회 리스트
		/// </summary>
		[JsonProperty("inds_mth_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryYearlyCharts
	{
		/// <summary>
		/// 업종코드
		/// </summary>
		[JsonProperty("inds_cd")]
		public KiwoomChartIndustryCode? IndustryCode;
		/// <summary>
		/// 업종년봉조회 리스트
		/// </summary>
		[JsonProperty("inds_yr_pole_qry")]
		public IEnumerable<KiwoomChartGetIndustryChartItem>? Items;
	}
	public record KiwoomChartGetIndustryChartItem
	{
		/// <summary>
		/// 현재가
		/// </summary>
		[JsonProperty("cur_prc")]
		public KiwoomDecimal? CurrentPrice;
		/// <summary>
		/// 거래량
		/// </summary>
		[JsonProperty("trde_qty")]
		public decimal? Volume;
		/// <summary>
		/// 일자
		/// </summary>
		[JsonProperty("dt")]
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
		/// 거래대금
		/// </summary>
		[JsonProperty("trde_prica")]
		public decimal? TransactionAmount;
	}

    public record KiwoomChartGetGoldSpotTickCharts
    {
        /// <summary>
        /// 금현물틱차트조회
        /// </summary>
        [JsonProperty("gds_tic_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotTickChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotTickChartItem
    {
        /// <summary>
        /// 현재가
        /// </summary>
        [JsonProperty("cur_prc")]
        public KiwoomDecimal? CurrentPrice;
        /// <summary>
        /// 거래량
        /// </summary>
        [JsonProperty("trde_qty")]
        public decimal? Volume;
        /// <summary>
        /// 체결시간
        /// </summary>
        [JsonProperty("cntr_tm")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeTime;
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
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeDate;
    }

    public record KiwoomChartGetGoldSpotMinuteCharts
    {
        /// <summary>
        /// 금현물분봉차트조회
        /// </summary>
        [JsonProperty("gds_min_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotMinuteChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotMinuteChartItem
    {
        /// <summary>
        /// 현재가
        /// </summary>
        [JsonProperty("cur_prc")]
        public KiwoomDecimal? CurrentPrice;
        /// <summary>
        /// 누적거래량
        /// </summary>
        [JsonProperty("acc_trde_qty")]
        public decimal? AccumulatedVolume;
        /// <summary>
        /// 거래량
        /// </summary>
        [JsonProperty("trde_qty")]
        public decimal? Volume;
        /// <summary>
        /// 체결시간
        /// </summary>
        [JsonProperty("cntr_tm")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeTime;
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
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeDate;
    }

    public record KiwoomChartGetGoldSpotDailyCharts
    {
        /// <summary>
        /// 금현물일봉차트조회
        /// </summary>
        [JsonProperty("gds_day_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotDailyChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotDailyChartItem
    {
        /// <summary>
        /// 현재가
        /// </summary>
        [JsonProperty("cur_prc")]
        public KiwoomDecimal? CurrentPrice;
        /// <summary>
        /// 누적 거래량
        /// </summary>
        [JsonProperty("acc_trde_qty")]
        public decimal? AccumulatedVolume;
        /// <summary>
        /// 누적 거래대금
        /// </summary>
        [JsonProperty("acc_trde_prica")]
        public decimal? AccumulatedTransactionAmount;
        /// <summary>
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
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
        /// 전일대비 기호
        /// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
    }

    public record KiwoomChartGetGoldSpotWeeklyCharts
    {
        /// <summary>
        /// 금현물주봉차트조회
        /// </summary>
        [JsonProperty("gds_week_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotMonthlyCharts
    {
        /// <summary>
        /// 금현물월봉차트조회
        /// </summary>
        [JsonProperty("gds_month_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotChartItem
    {
        /// <summary>
        /// 현재가
        /// </summary>
        [JsonProperty("cur_prc")]
        public KiwoomDecimal? CurrentPrice;
        /// <summary>
        /// 누적 거래량
        /// </summary>
        [JsonProperty("acc_trde_qty")]
        public decimal? AccumulatedVolume;
        /// <summary>
        /// 누적 거래대금
        /// </summary>
        [JsonProperty("acc_trde_prica")]
        public decimal? AccumulatedTransactionAmount;
        /// <summary>
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
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
    }

    public record KiwoomChartGetGoldSpotTodayTickCharts
    {
        /// <summary>
        /// 금현물당일틱차트조회
        /// </summary>
        [JsonProperty("gds_tic_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotTodayTickChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotTodayTickChartItem
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
        /// 거래량(체결량)
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
        /// 체결시간
        /// </summary>
        [JsonProperty("cntr_tm")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeTime;
        /// <summary>
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? Date;
        /// <summary>
        /// 전일대비기호
        /// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
    }

    public record KiwoomChartGetGoldSpotTodayMinuteCharts
    {
        /// <summary>
        /// 금현물당일분봉차트조회
        /// </summary>
        [JsonProperty("gds_min_chart_qry")]
        public IEnumerable<KiwoomChartGetGoldSpotTodayMinuteChartItem>? Items;
    }
    public record KiwoomChartGetGoldSpotTodayMinuteChartItem
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
        /// 누적 거래량
        /// </summary>
        [JsonProperty("acc_trde_qty")]
        public decimal? AccumulatedVolume;
        /// <summary>
        /// 누적 거래대금
        /// </summary>
        [JsonProperty("acc_trde_prica")]
        public decimal? AccumulatedTransactionAmount;
        /// <summary>
        /// 거래량(체결량)
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
        /// 체결시간
        /// </summary>
        [JsonProperty("cntr_tm")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? TradeTime;
        /// <summary>
        /// 일자
        /// </summary>
        [JsonProperty("dt")]
        [JsonConverter(typeof(KiwoomDateTimeConverter))]
        public DateTime? Date;
        /// <summary>
        /// 전일대비기호
        /// </summary>
        [JsonProperty("pred_pre_sig")]
        public string? ChangeSign;
    }

}