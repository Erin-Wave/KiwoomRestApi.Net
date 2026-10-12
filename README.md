<div align="center">

# KiwoomRestApi.Net

**키움증권 OpenAPI REST API 를 위한 현대적이고 직관적인 .NET Wrapper 라이브러리**

[![NuGet Version](https://img.shields.io/nuget/v/KiwoomRestApi.Net.svg?label=NuGet&color=blue)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KiwoomRestApi.Net.svg?label=Downloads&color=blueviolet)](https://www.nuget.org/packages/KiwoomRestApi.Net)
[![License](https://img.shields.io/github/license/dongbin300/KiwoomRestApi.Net.svg?label=License&color=green)](https://github.com/dongbin300/KiwoomRestApi.Net/blob/main/LICENSE)
[![.NET](https://img.shields.io/badge/.NET-Standard%202.0%20%7C%206%20%7C%208%20%7C%209%20%7C%2010-512bd4)](https://dotnet.microsoft.com/)

[문서](https://dongbin300.github.io/KiwoomRestApi.Net/) · [이슈](https://github.com/dongbin300/KiwoomRestApi.Net/issues) · [FAQ](docs/FAQ.html) · [키움 API 가이드](https://openapi.kiwoom.com/guide/apiguide)

</div>

> 🎮 **[ox64.app](https://ox64.app)** — 실전 매매 전 전략을 검증할 수 있는 모의투자 게임 플랫폼입니다. KiwoomRestApi.Net으로 만든 트레이딩 로직을 실제 자금 없이 테스트해보세요!

---

## ⚠️ Migration Notice (v0.9.0+)

미국주식(UsStocks) 지원이 추가되면서 `KiwoomRestApiClient`의 API 구조가 국내주식(`DomesticStock`) / 미국주식(`UsStock`)으로 분리되었습니다. 기존에 사용하던 최상위 프로퍼티(`client.Account`, `client.Order`, `client.Chart`, `client.StockInfo` 등)는 `[Obsolete]`로 표시되었으며, 향후 버전에서 제거될 예정이니 아래와 같이 마이그레이션해주세요.

```csharp
// 기존 방식 (Obsolete, 향후 제거 예정)
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
var deposits = await client.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal);
var buyOrderResult = await client.Order.PlaceOrderAsync(...);

// 변경된 방식 (권장) - 국내주식은 DomesticStock 하위로 이동
var stockInfo = await client.DomesticStock.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
var deposits = await client.DomesticStock.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal);
var buyOrderResult = await client.DomesticStock.Order.PlaceOrderAsync(...);

// 미국주식은 UsStock 하위에 신규 추가
var usStockInfo = await client.UsStock.MarketCondition.GetStockInfoAsync("AAPL");
var usBuyOrderResult = await client.UsStock.Order.BuyOrderAsync(...);
```

| 기존 (Obsolete) | 변경 (권장) |
|:---|:---|
| `client.Account` | `client.DomesticStock.Account` |
| `client.Order` | `client.DomesticStock.Order` |
| `client.Chart` | `client.DomesticStock.Chart` |
| `client.StockInfo` | `client.DomesticStock.StockInfo` |
| `client.MarketCondition` | `client.DomesticStock.MarketCondition` |
| `client.RankingInfo` | `client.DomesticStock.RankingInfo` |
| `client.Industry` | `client.DomesticStock.Industry` |
| `client.Theme` | `client.DomesticStock.Theme` |
| `client.Elw` | `client.DomesticStock.Elw` |
| `client.Etf` | `client.DomesticStock.Etf` |
| `client.Watchlist` | `client.DomesticStock.Watchlist` |
| `client.CreditOrder` | `client.DomesticStock.CreditOrder` |
| `client.ShortSale` | `client.DomesticStock.ShortSale` |
| `client.SecuritiesLending` | `client.DomesticStock.SecuritiesLending` |
| `client.ForeignInstitution` | `client.DomesticStock.ForeignInstitution` |
| _(신규)_ | `client.UsStock.*` |

> 아래 **Quick Start**, **Usage Examples** 등 문서 내 코드 예제는 하위 호환을 위해 아직 기존 방식(`client.Account` 등)을 사용하고 있습니다. 새로 작성하는 코드에서는 위 표를 참고하여 `client.DomesticStock.*` / `client.UsStock.*` 형태로 작성해주세요.

---

## Quick Start

```bash
dotnet add package KiwoomRestApi.Net
```

```csharp
using KiwoomRestApi.Net.Clients;

// 1. 클라이언트 생성
var client = await KiwoomRestApiClient.CreateAsync("_APP키_", "_SECRET키_", isMock: true);

// 2. 삼성전자 주식 정보 조회
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");

// 3. 당일 실현손익 조회
var todayRealizedProfitLoss = await client.Account.GetTodayRealizedProfitLossAsync("005930");
Console.WriteLine($"평가금액: {todayRealizedProfitLoss.Data.TodayRealizedProfitLoss}%");
```

---

## Features

| Feature | Description |
|:-------:|-------------|
| **OAuth 인증** | 토큰 발급/갱신 관리 |
| **계좌 관리** | 잔고, 주문내역, 예수금, 평가잔고, 실현손익 |
| **주식 정보** | 현재가, 호가, 체결정보 |
| **차트 데이터** | 일/주/월/분봉 차트 |
| **주문 관리** | 매수/매도, 정정, 취소 |
| **시장 정보** | 업종, 테마, 순위, 외국인/기관 |
| **실시간 데이터** | WebSocket 실시간 구독 |
| **종목 검색** | ETF, ELW, 종목 정보 조회 |
| **금현물 거래** | 금현물 시세, 주문, 잔고 |

---

## Key Features

### Complete Async Support

```csharp
// CancellationToken 완벽 지원
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var result = await client.Account.GetDailyStatusAsync(cts.Token);
```

### Dependency Injection Support

```csharp
// Program.cs 또는 Startup.cs
services.AddKiwoomRestApi(config => {
    config.AppKey = "your-app-key";
    config.SecretKey = "your-secret-key"; 
    config.IsMock = true;
    config.RequestTimeout = TimeSpan.FromSeconds(30);
});

// 컨트롤러에서 사용
[ApiController]
public class TradingController : ControllerBase
{
    private readonly KiwoomRestApiClient _client;
    
    public TradingController(KiwoomRestApiClient client) => _client = client;
}
```

---

## Usage Examples

### 주식 정보 조회

```csharp
// 현재가 조회
var stockInfo = await client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan);
Console.WriteLine($"삼성전자 현재가: {stockInfo.Data.CurrentPrice}원");

// 호가 조회
var orderBook = await client.MarketCondition.GetOrderBookAsync("005930");
Console.WriteLine($"매수 1호가: {orderBook.Data.BuyPrice1}원");

// 차트 데이터 조회
var chartData = await client.Chart.GetDailyChartsAsync("005930", DateTime.Today, true);
Console.WriteLine($"삼성전자 전일종가: {chartData.Data.Items.ElementAt(1).CurrentPrice}원");
```

### 계좌 및 주문 관리

```csharp
// 예수금 및 자금 관리
var deposits = await client.Account.GetDepositsAsync(KiwoomAccountDepositQueryType.Normal);
Console.WriteLine($"예수금: {deposits.Data.Deposit:N0}원");

var estimatedAsset = await client.Account.GetEstimatedDepositAssetAsync(isExcludeDelisted: false);
Console.WriteLine($"평가자산 총액: {estimatedAsset.Data.EstimatedDepositAsset:N0}원");

// 잔고 평가
var evaluationBalances = await client.Account.GetEvaluationBalancesAsync(
    	KiwoomAccountEvaluationBalanceQueryType.Aggregate,
	KiwoomAccountDomesticStockExchangeType2.Krx);
Console.WriteLine($"총평가금액: {evaluationBalances.Data.TotalEvaluationAmount:N0}원");

// 수익률 분석
var dailyBalanceProfitRates = await client.Account.GetDailyBalanceProfitRatesAsync(DateTime.Today);
Console.WriteLine($"일별잔고수익률: {dailyBalanceProfitRates.Data.DailyBalanceProfitRates:F2}%");

// 주문 관리
var unfilledOrders = await client.Account.GetUnfilledOrdersAsync(
    KiwoomAccountQueryType.All,
    KiwoomAccountTransactionType.All,
    KiwoomAccountStockExchangeType.Unified);
Console.WriteLine($"미체결 주문 수: {unfilledOrders.Data.Item.Count()}");

// 주문 실행
var buyOrderResult = await _client.Order.PlaceOrderAsync(
	KiwoomOrderType.Buy,
	KiwoomOrderDomesticStockExchangeType.Krx,
	"005930",
	10,
	KiwoomOrderTransactionType.Normal,
	80000);

// 주문 수정/취소
var modifyResult = await _client.Order.ModifyOrderAsync(
	KiwoomOrderDomesticStockExchangeType.Krx,
	"_원주문번호_",
	"005930",
	8,
	82000);

var cancelResult = await _client.Order.CancelOrderAsync(
	KiwoomOrderDomesticStockExchangeType.Krx,
	"_원주문번호_",
	"005930",
	cancelQuantity: 3);
```

### 실시간 데이터 구독

```csharp
var socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock: true);

// 실시간 주식체결 수신 이벤트
socketClient.OnRealtimeStockTradeReceived += (message) =>
{
	Console.WriteLine($"체결가: {message.ElementAt(0).Values.CurrentPrice}원");
};

// 실시간 주식체결 구독
await socketClient.WebSocket.SubscribeAsync(
	[KiwoomWebSocketServiceName.StockTrade],
	["005930", "000660"]);
```

### 차트 데이터 유틸리티

> 기간별 차트 데이터를 간편하게 조회할 수 있는 유틸리티 메서드입니다.

```csharp
// 주식 틱차트 조회 (기간)
var tickCharts = await client.Chart.GetTickChartsByRangeAsync(
    "005930",
    1,
    DateTime.Today.AddDays(-3),
    DateTime.Today,
    true
);

// 주식 분봉차트 조회 (기간)
var minuteCharts = await client.Chart.GetMinuteChartsByRangeAsync(
    "005930",
    1,
    DateTime.Today.AddDays(-30),
    DateTime.Today,
    true
);

// 주식 일봉차트 조회 (기간)
var dailyCharts = await client.Chart.GetDailyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddDays(-100), 
    DateTime.Today,
    true
);

// 주식 주봉차트 조회 (기간)
var weeklyCharts = await client.Chart.GetWeeklyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddDays(-100), 
    DateTime.Today,
    true
);

// 주식 월봉차트 조회 (기간)
var monthlyCharts = await client.Chart.GetMonthlyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddDays(-365), 
    DateTime.Today,
    true
);

// 주식 년봉차트 조회 (기간)
var yearlyCharts = await client.Chart.GetYearlyChartsByRangeAsync(
    "005930", 
    DateTime.Today.AddYears(-5), 
    DateTime.Today,
    true
);

// 업종 차트도 동일하게 지원
var industryTickCharts = await client.Chart.GetIndustryTickChartsByRangeAsync(
    KiwoomChartIndustryCode.Kospi200,
    1,
    DateTime.Today.AddDays(-3),
    DateTime.Today
);

// 금현물 차트도 지원
var goldSpotTickCharts = await client.Chart.GetGoldSpotTickChartsByRangeAsync(
    KiwoomGoldSpotStockCode.Gold_1kg,
    1,
    DateTime.Today.AddDays(-30),
    DateTime.Today,
    true
);
```

### 금현물 거래

```csharp
// 금현물 주문
var goldBuyOrderResult = await client.Order.GoldSpotPlaceOrderAsync(
    KiwoomOrderType.Buy,
    KiwoomGoldSpotStockCode.Gold_1kg,
    1,
    KiwoomOrderGoldSpotTransactionType.Normal,
    8500000);

// 금현물 잔고확인
var goldEvaluationBalances = await client.Account.GetGoldEvaluationBalancesAsync();
Console.WriteLine($"금현물 잔고평가금액: {goldEvaluationBalances.Data.BalanceEvaluation:N0}원");
```

---

## Performance Tips

### API 제한사항

> 키움증권 REST API 유량 정책 (2026.07.02 기준, 계좌(토큰)별). 정책은 변경될 수 있으니 [키움 REST API 공지사항](https://openapi.kiwoom.com/board/Board0101View)을 확인하세요.

| 구분 | 제한 | 권장사항 |
|:----:|:----:|----------|
| **국내주식 API 호출** | 주문 TR 초당 5 회, 조회 TR 초당 5 회 | Rate limiting 구현 |
| **미국주식 API 호출** | 주문 10 회 / 조회 5 회 / 환전 1 회 (초당, 피크타임 09~10시는 3 / 3 / 1 회)<br>전체 초당 50 회, 차트 초당 20 회, 종목리스트(usa10099) 분당 5 회 | Rate limiting 구현 |
| **모의투자** | TR 1개당 초당 1 회 | 테스트 시 호출 간격 조절 |
| **실시간 구독** | 세션당 200 종목 | 필요한 종목만 구독 |
| **실시간 조건검색** | 세션당 국내 10 건, 미국 10 건 (결과 최대 100 종목) | 사용하지 않는 조건검색 해제 |
| **WebSocket** | 계좌(토큰)별 세션 1 개 | 연결 상태 모니터링 |
| **토큰 유효기간** | 24 시간 | 자동 갱신 로직 구현 |

### 최적화 가이드

```csharp
// 권장: CancellationToken 사용
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
var result = await client.StockInfo.GetStockInfoAsync(
    "005930", 
    DateTime.Today,
    KiwoomStockInfoMarginLoanType.Loan, 
    cts.Token);

// 권장: 배치 처리
var stockCodes = new[] { "005930", "000660", "035420" };
var tasks = stockCodes.Select(code =>
    client.StockInfo.GetStockInfoAsync(code, DateTime.Today, KiwoomStockInfoMarginLoanType.Loan));
var results = await Task.WhenAll(tasks);

// 주의: 동기 블로킹은 피하세요
// var result = client.StockInfo.GetStockInfoAsync("005930", DateTime.Today, KiwoomStockInfoMarginLoanType.Loan).Result;
```

---

## Supported Platforms

| Platform | Version |
|:---------|:--------|
| .NET Standard | 2.0 (Unity, Xamarin 호환) |
| .NET Standard | 2.1 |
| .NET | 6.0 |
| .NET | 8.0 |
| .NET | 9.0 |
| .NET | 10.0 |

---

<details>
<summary><strong>Release Notes</strong></summary>

### v0.10.0 (2026-10-12)
- 키움 REST API 공지사항(2026.07~10) 및 API 가이드 변경분 반영 (KRX 애프터마켓 신설·NXT 제도 개편, 신규 TR, 조건검색 통합시세 등)

> ⚠️ **호환성 변경**
> - 아래 메서드는 `CancellationToken` 앞에 선택 파라미터가 추가되어, `CancellationToken`을 위치 인자로 넘기던 코드는 `cancellationToken:` 이름 지정 인자로 바꿔야 합니다.
>   `GetOpenMarketInvestorTransactionTopsAsync`(ka10065), `GetConsignedTransactionsAsync`(kt00015), `GetConditionSearchRequestAsync`(ka10172), `GetConditionSearchRequestRealtimeAsync`(ka10173)
> - `UsStock.Account.GetTransactionHistoryAsync`(ust21100), `GetPeriodProfitRatesAsync`(ust21650)는 명세상 필수값이 된 일자 파라미터가 필수로 바뀌었습니다.
> - 삭제된 TR과 사용할 수 없게 된 값은 `[Obsolete]`로 표시했으며, 향후 버전에서 제거될 예정입니다.

#### 국내주식
- 추가: | ka00190 | 대량체결상위 (`GetLargeTradeTopsAsync`)
- 추가: | ka00196 | 체결금액대별매매비중 (`GetTradeAmountRangeTransactionRatiosAsync`)
- 추가: | ka04196 | 수익률상위고객매매상세 (`GetTopProfitCustomerTransactionDetailsAsync`)
- 추가: | ka10103 | 종목메모 조회 (`GetStockMemosAsync`)
- 추가: | ka11079 | 주식틱차트정규장조회요청 (`GetRegularMarketTickChartsAsync`, `GetRegularMarketTickChartsByRangeAsync`)
- 추가: | ka11080 | 주식분봉차트정규장조회요청 (`GetRegularMarketMinuteChartsAsync`, `GetRegularMarketMinuteChartsByRangeAsync`)
- 추가: | ka11081 | 주식일봉차트정규장조회요청 (`GetRegularMarketDailyChartsAsync`, `GetRegularMarketDailyChartsByRangeAsync`)
- 추가: | ka11082 | 주식주봉차트정규장조회요청 (`GetRegularMarketWeeklyChartsAsync`, `GetRegularMarketWeeklyChartsByRangeAsync`)
- 추가: | ka11083 | 주식월봉차트정규장조회요청 (`GetRegularMarketMonthlyChartsAsync`, `GetRegularMarketMonthlyChartsByRangeAsync`)
- 추가: | ka11094 | 주식년봉차트정규장조회요청 (`GetRegularMarketYearlyChartsAsync`, `GetRegularMarketYearlyChartsByRangeAsync`)
- 추가: | kt10000, kt10001, kt10006, kt10007 | NXT 프리마켓 GTP 주문유형 보통(GTP) 40, 최유리(GTP) 46, 최우선(GTP) 47 (`KiwoomOrderTransactionType`, `KiwoomCreditOrderTransactionType`)
- 추가: | ka10172, ka10173 | 조건검색 통합시세 지원 거래소구분(`exchangeType`, `KiwoomWebSocketConditionSearchExchangeType`) 파라미터
- 추가: | ka10065 | 장중투자자별매매상위요청 금액수량구분(`amountQuantityType`) 파라미터
- 추가: | kt00015 | 위탁종합거래내역요청 조회정렬구분(`sortType`, `KiwoomAccountQuerySortType`) 파라미터
- 추가: | ka10079~ka10083, ka10094 | 주식 차트 응답에 수정구분자(`UpdatedStockPriceType`), 수정비율(`UpdateRate`) 필드, 분봉 누적거래량(`AccumulatedVolume`) 필드
- 추가: | ka10039 | 증권사별매매상위요청 응답에 순매수금액·매수금액·매도금액 필드
- 추가: | ka10063 | 장중투자자별매매요청 응답에 순매수금액·매수금액·매도금액 및 증감 필드
- 추가: | ka40006 | ETF시간대별추이요청 응답에 종목명·ETF대상지수명·원주가격·ETF/ETN과세유형 필드
- 추가: | ka90002 | 테마구성종목요청 응답에 등락률·기간수익률 필드
- 추가: | ka10101 | 업종코드 리스트 응답에 시장구분코드(`MarketCode`) 필드
- 추가: | ka10173 | 조건검색 실시간 수신값에 거래소구분(9081) 필드
- 추가: `KiwoomEtfManagementCompany` SOL(3048), HANARO(3257) / `KiwoomStockInfoInvestorType` 사모펀드(3100) / `KiwoomStockInfoMarketType3` 인프라투융자, 신주인수권증서, ETN, 손실제한 ETN, 금현물, 변동성 ETN / `KiwoomAccountMarketDealType` KRX금현물(5)
- 변경: | ka10086 | 일별주가요청 표시구분(`KiwoomMarketConditionAmountQuantityType2`) 값을 명세대로 수정 (수량 0, 금액 1)
- 변경: | ka30005 | ELW조건검색요청 권리구분을 명세대로 1자리(0~7)로 전송
- 변경: | kt00008 | 계좌별익일결제예정내역요청 응답 목록 키를 `acnt_nxdy_setl_frcs_prps_array`로 수정 (목록이 비어 있던 문제)
- 변경: | ka10172 | 조건검색 요청 일반 결과가 `OnConditionSearchRequestReceived` 이벤트로 전달되지 않던 문제 수정
- 변경: 실시간 VI발동구분(9068)에 VI연장(4), 장운영구분(215)에 KRX 애프터마켓 시작·종료 등 설명 갱신
- 변경: | ka90001, ka90005, ka90008 | 삭제 예정 파라미터(`themeName`, `date`) 안내 추가
- 삭제(Obsolete): | ka10009 | 주식기관요청 (`GetStockInstitutionsAsync`) - 2026.06.18 TR 삭제, ka10045 사용
- 삭제(Obsolete): | ka10087 | 시간외단일가요청 (`GetAfterMarketSinglePriceOrderBookAsync`, `GetAfterMarketSinglePriceOrderBookListAsync`) - KRX 시간외단일가 시장 폐지
- 삭제(Obsolete): | ka10098 | 시간외단일가등락율순위요청 (`GetAfterMarketSinglePriceChangeRateRanksAsync`) - KRX 시간외단일가 시장 폐지
- 삭제(Obsolete): 시간외단일가 주문유형(62) `KiwoomOrderTransactionType.AfterMarketSinglePrice`, `KiwoomCreditOrderTransactionType.AfterMarketSinglePrice`
- 삭제(Obsolete): 실시간 주문체결(00) 시간외단일가 현재가(10010), 주식호가잔량(0D)·ETF NAV(0G)·종목프로그램매매(0w)의 명세 제거 항목
- 삭제(Obsolete): `KiwoomStockInfoBeforeMarketType.Regular`, `AfterMarketSinglePrice` (ka10054), `KiwoomThemeQueryType.Theme` (ka90001)

#### 미국주식
- 추가: | usa10103 | 미국주식 종목메모 조회 (`GetStockMemosAsync`)
- 추가: | ust21200 | 미국주식 예약 매수주문 (`ReserveBuyOrderAsync`)
- 추가: | ust21201 | 미국주식 예약 매도주문 (`ReserveSellOrderAsync`)
- 추가: | ust21203 | 미국주식 예약주문 취소 (`CancelReservedOrderAsync`)
- 추가: | ust21204 | 미국주식 일자별 예약내역 조회 (`GetDailyReservedOrdersAsync`)
- 추가: | ust21205 | 미국주식 예약주문 내역조회 (`GetReservedOrdersAsync`)
- 추가: | usa23100 | 미국주식 업종별 등락률 상위/하위 응답에 매도호가·매수호가 필드
- 추가: | usa20290 | 미국주식 조건검색 요청 실시간 응답에 거래소구분(`stexTp`, 9081) 필드
- 변경: | ust21100 | 미국주식 거래내역 시작일자·종료일자 필수, 구분 기본값 전체(0), 원화대용입출금제외여부 기본값 비제외(N)
- 변경: | ust21650 | 미국주식 기간별 수익률 현황 조회시작일자·조회종료일자 필수
- 삭제(Obsolete): `KiwoomUsStockAccountTransactionType`의 명세 제거 구분값 (입출금, 입출고, 입금, 출금, 배당금입금, 환전 계열)

#### 기타
- 변경: README API 제한사항을 키움 유량 정책(2026.07.02 기준)으로 갱신

### v0.9.0 (2026-07-10)
- 추가: 미국주식(UsStocks) API Wrapper 전체 추가 (`client.UsStock`)

#### 계좌 (Account)
- 추가: | usa21670 | 미국주식 일별계좌수익률현황 (`GetDailyAccountProfitRatesAsync`)
- 추가: | usa21680 | 미국주식 월별계좌수익률현황 (`GetMonthlyAccountProfitRatesAsync`)
- 추가: | usa21690 | 미국주식 연도별계좌수익률현황 (`GetYearlyAccountProfitRatesAsync`)
- 추가: | usa21730 | 미국주식 일별종목수익률현황 (`GetDailyStockProfitRatesAsync`)
- 추가: | usa21731 | 미국주식 월별종목수익률현황 (`GetMonthlyStockProfitRatesAsync`)
- 추가: | usa21732 | 미국주식 연도별종목수익률현황 (`GetYearlyStockProfitRatesAsync`)
- 추가: | ust21050 | 미국주식 원장 미체결 (`GetUnfilledOrdersAsync`)
- 추가: | ust21070 | 미국주식 원장잔고확인 (`GetBalanceAsync`)
- 추가: | ust21100 | 미국주식 거래내역 (`GetTransactionHistoryAsync`)
- 추가: | ust21110 | 해외주식 예수금 (`GetDepositAsync`)
- 추가: | ust21111 | 원화출금가능 금액 조회 (원화대용 포함) (`GetKrwWithdrawableAmountAsync`)
- 추가: | ust21120 | 통화별 예수금 및 증권 평가금현황 (`GetCurrencyDepositEvaluationAsync`)
- 추가: | ust21121 | 해외증권 원장 평가금액현황 (`GetLedgerEvaluationAmountAsync`)
- 추가: | ust21131 | 해외증권 특정일 평가금액 (`GetSpecificDateEvaluationAmountAsync`)
- 추가: | ust21132 | 특정일 통화별 예수금 및 증권 평가금 (`GetSpecificDateCurrencyDepositEvaluationAsync`)
- 추가: | ust21150 | 미국주식 일별 주문체결내역 (`GetDailyOrderExecutionsAsync`)
- 추가: | ust21160 | 미국주식 예수금 상세 (`GetDepositDetailsAsync`)
- 추가: | ust21170 | 미국주식 당일 종목별 실현손익 (`GetTodayStockRealizedProfitLossesAsync`)
- 추가: | ust21180 | 미국주식 기간별 주문내역 (`GetOrderHistoryAsync`)
- 추가: | ust21510 | 미국주식 당일 주문체결 확인 (`GetTodayOrderExecutionsAsync`)
- 추가: | ust21530 | 미국주식 실현손익 (`GetRealizedProfitLossesAsync`)
- 추가: | ust21610 | 미국주식 당일매매 (`GetTodayTradesAsync`)
- 추가: | ust21620 | 미국주식 당일매매정리 (`GetTodayTradeSummaryAsync`)
- 추가: | ust21630 | 미국주식 당일 실현손익 (`GetTodayRealizedProfitLossesAsync`)
- 추가: | ust21640 | 미국주식 일별 종목별 실현손익 (`GetDailyStockRealizedProfitLossesAsync`)
- 추가: | ust21650 | 미국주식 기간별 수익률 현황 (`GetPeriodProfitRatesAsync`)
- 추가: | ust21660 | 미국주식 일별 실현손익 (`GetDailyRealizedProfitLossesAsync`)
- 추가: | ust21661 | 미국주식 월별 실현손익 (`GetMonthlyRealizedProfitLossesAsync`)

#### 차트 (Chart)
- 추가: | usa06010 | 미국주식 틱 차트 (`GetTickChartsAsync`, `GetTickChartsByRangeAsync`)
- 추가: | usa06011 | 미국주식 분 차트 (`GetMinuteChartsAsync`, `GetMinuteChartsByRangeAsync`)
- 추가: | usa06012 | 미국주식 일 차트 (`GetDailyChartsAsync`, `GetDailyChartsByRangeAsync`)
- 추가: | usa06013 | 미국주식 주 차트 (`GetWeeklyChartsAsync`, `GetWeeklyChartsByRangeAsync`)
- 추가: | usa06014 | 미국주식 월 차트 (`GetMonthlyChartsAsync`, `GetMonthlyChartsByRangeAsync`)
- 추가: | usa06015 | 미국주식 년 차트 (`GetYearlyChartsAsync`, `GetYearlyChartsByRangeAsync`)
- 추가: | usa06016 | 미국주식 분기 차트 (`GetQuarterlyChartsAsync`, `GetQuarterlyChartsByRangeAsync`)

#### 환전 (Exchange)
- 추가: | ust31300 | 환전 예상 금액 조회 (`GetExpectedAmountAsync`)
- 추가: | ust31301 | 환율 조회 (`GetExchangeRateAsync`)
- 추가: | ust31302 | 환전 신청 (`ApplyExchangeAsync`)

#### 업종 (Industry)
- 추가: | usa23000 | 미국주식 업종별 기간별 수익률 조회 (`GetPeriodReturnsAsync`)
- 추가: | usa23100 | 미국주식 업종별 등락률 상위/하위 조회 (`GetChangeRateRanksAsync`)

#### 종목정보 (Info)
- 추가: | usa10098 | 미국주식 거래소구분 조회 (`GetExchangeTypesAsync`)
- 추가: | usa10099 | 미국주식 종목리스트 (`GetStocksAsync`)
- 추가: | usa10100 | 미국주식 종목 조회 (`GetStockAsync`)
- 추가: | usa10101 | 미국주식 업종리스트 (`GetIndustriesAsync`)
- 추가: | usa10102 | 미국지수 리스트 (`GetIndicesAsync`)
- 추가: | usa10104 | 미국 ETF,ETN 리스트 (`GetEtfEtnsAsync`)
- 추가: | usa10105 | 미국 ETF 카테고리 리스트 (`GetEtfCategoriesAsync`)
- 추가: | usa20520 | 미국주식 거래량급등락(주식/업종) (`GetVolumeSurgesAsync`)
- 추가: | usa20521 | 미국주식 거래량급등락(ETF) (`GetEtfVolumeSurgesAsync`)
- 추가: | usa20570 | 미국주식 가격대별주가(주식/업종) (`GetPriceRangesAsync`)
- 추가: | usa20571 | 미국주식 가격대별주가(ETF) (`GetEtfPriceRangesAsync`)
- 추가: | usa20930 | 미국주식 가격급등락(주식/업종) (`GetPriceVolatilitiesAsync`)
- 추가: | usa20931 | 미국주식 가격급등락(ETF) (`GetEtfPriceVolatilitiesAsync`)
- 추가: | usa20932 | 미국주식 가격급등락(관심종목) (`GetWatchlistPriceVolatilitiesAsync`)
- 추가: | usa20970 | 미국주식 고가/저가 접근(주식/업종) (`GetHighLowApproachesAsync`)
- 추가: | usa20971 | 미국주식 고가/저가 접근(ETF) (`GetEtfHighLowApproachesAsync`)
- 추가: | usa20972 | 미국주식 고가/저가 접근(관심종목) (`GetWatchlistHighLowApproachesAsync`)
- 추가: | usa23400 | 미국주식 거래량갱신(주식/업종) (`GetVolumeRenewalsAsync`)
- 추가: | usa23401 | 미국주식 거래량갱신(ETF) (`GetEtfVolumeRenewalsAsync`)
- 추가: | usa23402 | 미국주식 거래량갱신(관심종목) (`GetWatchlistVolumeRenewalsAsync`)
- 추가: | usa24100 | 미국주식 신고가/신저가(주식/업종) (`GetNewPricesAsync`)
- 추가: | usa24101 | 미국주식 신고가/신저가(ETF) (`GetEtfNewPricesAsync`)
- 추가: | usa24140 | 미국주식 갭상승/갭하락(주식/업종) (`GetGapsAsync`)
- 추가: | usa24141 | 미국주식 갭상승/갭하락(ETF) (`GetEtfGapsAsync`)
- 추가: | usa24210 | 미국주식 잔량률급증(주식/업종) (`GetRemainRatioSurgesAsync`)
- 추가: | usa24211 | 미국주식 잔량률급증(ETF) (`GetEtfRemainRatioSurgesAsync`)
- 추가: | usa24220 | 미국주식 매물대집중(주식/업종) (`GetVolumeZonesAsync`)
- 추가: | usa24221 | 미국주식 매물대집중(ETF) (`GetEtfVolumeZonesAsync`)
- 추가: | usa26410 | 미국주식 연도별 등락률(종목) (`GetYearlyChangeRateAsync`)
- 추가: | usa26411 | 미국주식 연도별 업종별 종목등락률 (`GetIndustryStockYearlyChangeRatesAsync`)
- 추가: | usa26412 | 미국주식 연도별 ETF 카테고리별 종목등락률 (`GetEtfCategoryStockYearlyChangeRatesAsync`)
- 추가: | usa26413 | 미국주식 연도별 등락률(업종) (`GetIndustryYearlyChangeRateAsync`)
- 추가: | usa26414 | 미국주식 연도별 등락률(ETF) (`GetEtfCategoryYearlyChangeRateAsync`)

#### 투자정보 (InvestmentInfo)
- 추가: | usa24300 | 미국주식 리서치(미국주식/ETF) (`GetResearchesAsync`)

#### 시세 (MarketCondition)
- 추가: | usa20100 | 미국주식 현재가 종목정보 (`GetStockInfoAsync`)
- 추가: | usa20101 | 미국주식 현재가 10호가 (`GetOrderBookAsync`)
- 추가: | usa20150 | 미국주식 상세 체결내역 (`GetDetailedTradesAsync`)
- 추가: | usa20151 | 미국주식 일별 체결내역 (`GetDailyTradesAsync`)
- 추가: | usa20590 | 미국주식 일별주가 (`GetDailyPricesAsync`)

#### 주문 (Order)
- 추가: | ust20000 | 미국주식 매수주문 (`BuyOrderAsync`)
- 추가: | ust20001 | 미국주식 매도주문 (`SellOrderAsync`)
- 추가: | ust20002 | 미국주식 정정주문 (`ModifyOrderAsync`)
- 추가: | ust20003 | 미국주식 취소주문 (`CancelOrderAsync`)
- 추가: | ust31490 | 미국주식 증거금율별 주문가능수량 조회 (`GetAvailableOrderQuantityAsync`)

#### 순위정보 (RankingInfo)
- 추가: | usa01980 | 미국주식 실시간 종목 조회 순위 (`GetRealtimeQueryRanksAsync`)
- 추가: | usa01990 | 미국주식 관심종목 등록 상위 (`GetWatchlistRegistrationRanksAsync`)
- 추가: | usa20510 | 미국주식 기간별 등락률상위(주식/업종) (`GetPeriodChangeRateRanksAsync`)
- 추가: | usa20511 | 미국주식 기간별 등락률상위(ETF) (`GetEtfPeriodChangeRateRanksAsync`)
- 추가: | usa20512 | 미국주식 기간별 등락률상위(관심종목) (`GetWatchlistPeriodChangeRateRanksAsync`)
- 추가: | usa20530 | 미국주식 당일 거래량 상위(주식/업종) (`GetVolumeRanksAsync`)
- 추가: | usa20531 | 미국주식 당일 거래량 상위(ETF) (`GetEtfVolumeRanksAsync`)
- 추가: | usa20540 | 미국주식 당일 거래대금 상위(주식/업종) (`GetTransactionAmountRanksAsync`)
- 추가: | usa20541 | 미국주식 당일 거래대금 상위(ETF) (`GetEtfTransactionAmountRanksAsync`)
- 추가: | usa20550 | 미국주식 시가총액상위(주식/업종) (`GetMarketCapRanksAsync`)
- 추가: | usa20551 | 미국주식 시가총액상위(ETF) (`GetEtfMarketCapRanksAsync`)
- 추가: | usa20880 | 키움 거래 상위 종목(미국주식) (`GetKiwoomTradeRanksAsync`)
- 추가: | usa20881 | 키움 거래 상위 종목(미국 ETF) (`GetEtfKiwoomTradeRanksAsync`)
- 추가: | usa20910 | 미국주식 전일대비 등락률상위(주식/업종) (`GetChangeRateRanksAsync`)
- 추가: | usa20911 | 미국주식 전일대비 등락률상위(ETF) (`GetEtfChangeRateRanksAsync`)
- 추가: | usa20920 | 미국주식 시가대비 등락률상위(주식/업종) (`GetOpenPriceChangeRateRanksAsync`)
- 추가: | usa20921 | 미국주식 시가대비 등락률상위(ETF) (`GetEtfOpenPriceChangeRateRanksAsync`)
- 추가: | usa20922 | 미국주식 시가대비 등락률상위(관심종목) (`GetWatchlistOpenPriceChangeRateRanksAsync`)
- 추가: | usa20940 | 미국주식 누적 등락률 상위(주식/업종) (`GetCumulativeChangeRateRanksAsync`)
- 추가: | usa20941 | 미국주식 누적 등락률 상위(ETF) (`GetEtfCumulativeChangeRateRanksAsync`)
- 추가: | usa20960 | 미국주식 전일 거래상위(주식/업종) (`GetPreviousDayTradeRanksAsync`)
- 추가: | usa20961 | 미국주식 전일 거래상위(ETF) (`GetEtfPreviousDayTradeRanksAsync`)
- 추가: | usa24110 | 미국주식 최고최저가대비 상승하락(주식/업종) (`GetHighLowChangeRanksAsync`)
- 추가: | usa24111 | 미국주식 최고최저가대비 상승하락(ETF) (`GetEtfHighLowChangeRanksAsync`)
- 추가: | usa24120 | 미국주식 특정일자 상승/하락(주식/업종) (`GetSpecificDayChangeRanksAsync`)
- 추가: | usa24121 | 미국주식 특정일자 상승/하락(ETF) (`GetEtfSpecificDayChangeRanksAsync`)
- 추가: | usa24150 | 미국주식 회전율 상위(주식/업종) (`GetTurnoverRateRanksAsync`)
- 추가: | usa24151 | 미국주식 회전율 상위(ETF) (`GetEtfTurnoverRateRanksAsync`)
- 추가: | usa24160 | 미국주식 연속상승/하락 순위(주식/업종) (`GetContinuousChangeRanksAsync`)
- 추가: | usa24161 | 미국주식 연속상승/하락 순위(ETF) (`GetEtfContinuousChangeRanksAsync`)
- 추가: | usa24162 | 미국주식 연속상승/하락 순위(관심종목) (`GetWatchlistContinuousChangeRanksAsync`)
- 추가: | usa24200 | 미국주식 호가잔량상위(주식/업종) (`GetOrderBookRanksAsync`)
- 추가: | usa24201 | 미국주식 호가잔량상위(ETF) (`GetEtfOrderBookRanksAsync`)
- 추가: | usa24290 | 미국주식 주간거래 괴리율 상위(주식/업종) (`GetDisparityRateRanksAsync`)
- 추가: | usa24291 | 미국주식 주간거래 괴리율 상위(ETF) (`GetEtfDisparityRateRanksAsync`)

#### 관심종목 (Watchlist)
- 추가: | usa20200 | 미국주식 관심종목 그룹 리스트 조회 (`GetWatchlistGroupsAsync`)
- 추가: | usa20201 | 미국주식 관심종목 그룹 상세 조회 (`GetWatchlistGroupDetailsAsync`)

#### 실시간 (WebSocket)
- 추가: | REG/REMOVE | 미국주식 실시간시세 구독/구독해제 (`SubscribeAsync`, `UnsubscribeAsync`, `UnsubscribeAllAsync`) - F4(해외주식주문), F5(해외주식체결), FE(미국체결), FT(미국10호가)
- 추가: | usa20280 | 미국주식 조건검색 목록조회 (`GetConditionSearchListAsync`)
- 추가: | usa20281 | 미국주식 조건검색 요청 일반 (`GetConditionSearchRequestAsync`)
- 추가: | usa20290 | 미국주식 조건검색 요청 실시간 (`GetConditionSearchRequestRealtimeAsync`)
- 추가: | usa20291 | 미국주식 조건검색 실시간 해제 (`GetConditionSearchClearAsync`)
- 추가: `KiwoomUsStockSocketClient` (`OnRealtimeOrderReceived`, `OnRealtimeExecutionReceived`, `OnRealtimeTradeReceived`, `OnRealtimeOrderBookReceived`, `OnConditionSearchListReceived`, `OnConditionSearchRequestReceived`, `OnConditionSearchRequestRealtimeReceived`, `OnConditionSearchClearReceived`)

### v0.8.0 (2026-06-29)
- 추가: | ka01300 | 관심종목 그룹 리스트 조회 (`GetWatchlistGroupsAsync`)
- 추가: | ka01301 | 관심종목 그룹 상세 조회 (`GetWatchlistGroupDetailsAsync`)

### v0.7.2 (2026-04-29)
- 변경: 전체적인 성능 개선

### v0.7.0 (2026-03-18)
- 추가: | ka00001 | 계좌번호조회 (`GetAccountIdAsync`)
- 추가: | kt50020 | 금현물 잔고확인 (`GetGoldEvaluationBalancesAsync`)
- 추가: | kt50021 | 금현물 예수금 (`GetGoldDepositAsync`)
- 추가: | kt50030 | 금현물 주문체결전체조회 (`GetGoldAllTradesAsync`)
- 추가: | kt50031 | 금현물 주문체결조회 (`GetGoldTradesAsync`)
- 추가: | kt50032 | 금현물 거래내역조회 (`GetGoldTradeHistoriesAsync`)
- 추가: | kt50075 | 금현물 미체결조회 (`GetGoldUnfilledOrdersAsync`)
- 추가: 주식틱차트조회요청 (기간) (`GetTickChartsByRangeAsync`)
- 추가: 주식분봉차트조회요청 (기간) (`GetMinuteChartsByRangeAsync`)
- 추가: 주식일봉차트조회요청 (기간) (`GetDailyChartsByRangeAsync`)
- 추가: 주식주봉차트조회요청 (기간) (`GetWeeklyChartsByRangeAsync`)
- 추가: 주식월봉차트조회요청 (기간) (`GetMonthlyChartsByRangeAsync`)
- 추가: 주식년봉차트조회요청 (기간) (`GetYearlyChartsByRangeAsync`)
- 추가: 업종틱차트조회요청 (기간) (`GetIndustryTickChartsByRangeAsync`)
- 추가: 업종분봉조회요청 (기간) (`GetIndustryMinuteChartsByRangeAsync`)
- 추가: 업종일봉조회요청 (기간) (`GetIndustryDailyChartsByRangeAsync`)
- 추가: 업종주봉조회요청 (기간) (`GetIndustryWeeklyChartsByRangeAsync`)
- 추가: 업종월봉조회요청 (기간) (`GetIndustryMonthlyChartsByRangeAsync`)
- 추가: 업종년봉조회요청 (기간) (`GetIndustryYearlyChartsByRangeAsync`)
- 추가: 금현물틱차트조회요청 (기간) (`GetGoldSpotTickChartsByRangeAsync`)
- 추가: 금현물분봉차트조회요청 (기간) (`GetGoldSpotMinuteChartsByRangeAsync`)
- 추가: 금현물일봉차트조회요청 (기간) (`GetGoldSpotDailyChartsByRangeAsync`)
- 추가: 금현물주봉차트조회요청 (기간) (`GetGoldSpotWeeklyChartsByRangeAsync`)
- 추가: 금현물월봉차트조회요청 (기간) (`GetGoldSpotMonthlyChartsByRangeAsync`)
- 변경: `KiwoomAccountTransactionTypeType` -> `KiwoomAccountTransactionType4`
- 변경: `GetEvaluationBalancesAsync`파라미터 `KiwoomAccountDomesticStockExchangeType` -> `KiwoomAccountDomesticStockExchangeType2`
- 변경: `GetEvaluationsAsync`파라미터 `KiwoomAccountStockExchangeType` -> `KiwoomAccountStockExchangeType2`
- 변경: | ka10080 | 주식분봉차트조회요청 기준일자 (`date`) 파라미터 추가
- 변경: | ka20005 | 업종분봉조회요청 기준일자 (`date`) 파라미터 추가

### v0.6.2 (2026-02-05)
- 변경: `KiwoomWebSocketRealtimeOrderTrade`.`AccountId`, `OrderId`, `ManagerId`를 `decimal?` -> `string?` (#2)
- 변경: `KiwoomWebSocketRealtimeBalance`.`AccountId`를 `decimal?` -> `string?` (#2)

### v0.6.1 (2026-02-05)
- 변경: `KiwoomWebSocketRealtimeBalance`.`StockCode`를 `decimal?` -> `string?` (#2)
- 변경: `KiwoomWebSocketRealtimeOrderTrade`.`StockCode`를 `decimal?` -> `string?` (#2)

### v0.6.0 (2026-01-02)
- 변경: 대용량 메시지 수신 시 JSON 파싱 에러 해결 (#1)
- 변경: Microsoft.Extensions, System.Text.Json 최신 버전으로 업데이트 (10.0.1)
- 변경: | kt00005 | 체결잔고요청 `KiwoomAccountStockExchangeType` -> `KiwoomAccountStockExchangeType2`
- 변경: | ka10073 | 일자별종목별실현손익요청_기간 `TodayHtsSellFee` 를 `string` 로 변경
- 변경: | ka30002 | 거래원별 ELW 순매매상위요청 `issuerCompanyCode` 파라미터를 `string` 로 변경
- 변경: | ka10005 | 주식일주월시분요청 `KiwoomMarketConditionGetDailyWeeklyMonthly` 멤버 변경
- 변경: | ka10101 | 업종코드 리스트 `marketCode` 를 `list` 로 변경
- 변경: KiwoomWebSocketRealtime 멤버변수 일부 `string` -> `KiwoomString`

### v0.5.1 (2025-11-05)
- 삭제: | ka10079 | 주식틱차트조회요청 체결일
- 삭제: | ka20004 | 업종틱차트조회요청 체결일

### v0.5.0 (2025-10-16)
- 추가: | ka50010 | 금현물체결추이 API (`GetGoldTradeTrendsAsync`)
- 추가: | ka50012 | 금현물일별추이 API (`GetGoldDailyTrendsAsync`)
- 추가: | ka50087 | 금현물예상체결 API (`GetGoldExpectedTradesAsync`)
- 추가: | ka50100 | 금현물시세정보 API (`GetGoldInfoAsync`)
- 추가: | ka50101 | 금현물 호가 API (`GetGoldQuotesAsync`)
- 추가: | kt50000 | 금현물 매수주문 API (`GoldSpotPlaceOrderAsync`)
- 추가: | kt50001 | 금현물 매도주문 API (`GoldSpotPlaceOrderAsync`)
- 추가: | kt50002 | 금현물 정정주문 API (`GoldSpotModifyOrderAsync`)
- 추가: | kt50003 | 금현물 취소주문 API (`GoldSpotCancelOrderAsync`)
- 추가: | ka50079 | 금현물틱차트조회요청 API (`GetGoldSpotTickChartsAsync`)
- 추가: | ka50080 | 금현물분봉차트조회요청 API (`GetGoldSpotMinuteChartsAsync`)
- 추가: | ka50081 | 금현물일봉차트조회요청 API (`GetGoldSpotDailyChartsAsync`)
- 추가: | ka50082 | 금현물주봉차트조회요청 API (`GetGoldSpotWeeklyChartsAsync`)
- 추가: | ka50083 | 금현물월봉차트조회요청 API (`GetGoldSpotMonthlyChartsAsync`)
- 추가: | ka50091 | 금현물당일틱차트조회요청 API (`GetGoldSpotTodayTickChartsAsync`)
- 추가: | ka50092 | 금현물당일분봉차트조회요청 API (`GetGoldSpotTodayMinuteChartsAsync`)
- 추가: | ka52301 | 금현물투자자현황 API (`GetGoldSpotInvestorStatusAsync`)
- 추가: | 0I | 국제금환산가격 API (`OnRealtimeInternationalGoldPriceReceived`)
- 변경: `KiwoomChartGetTickChartItem`
- 변경: `KiwoomChartGetChartItem`
- 변경: `KiwoomChartGetYearlyCharts`
- 추가: `KiwoomChartGetYearChartItem`
- 변경: `KiwoomChartGetIndustryTickChartItem`
- 변경: `KiwoomChartGetIndustryMinuteCharts`
- 추가: `KiwoomChartGetIndustryMinuteChartItem`
- 변경: `KiwoomChartGetIndustryChartItem`
- 변경: API 문서화 개선

### v0.4.0 (2025-09-15)
- 추가: .NET 10.0 타겟 프레임워크 추가 (Preview)
- 변경: `GetCreditLoanAvailableStocksAsync` 요청필드명 `crd_stk_grae_tp` -> `crd_stk_grde_tp`
- 변경: `KiwoomAccountGetDeposits.MinimumOrderable` 를 `decimal`로 수정
- 변경: `KiwoomAccountGetCreditDepositOrders.StockDepositRate` 를 `string`로 수정
- 변경: `KiwoomAccountGetMarginOrders.AccountMarginRate` 를 `string`로 수정
- 변경: `ExchangeType` 관련 필드를 모두 `~StockExchangeType` 로 수정
- 변경: `StockExchangeType` 관련 필드를 모두 `~StockExchangeType` 로 수정
- 변경: `IndustryCode` 필드를 `KiwoomChartIndustryCode` 로 수정
- 변경: `ContYn` 필드를 `bool`로 수정
- 변경: `NxtEnable` 필드를 `bool`로 수정
- 변경: `Rank` 필드를 `decimal` -> `int`
- 변경: `Count` 관련 필드를 모두 `int`, `KiwoomInt`로 수정
- 변경: `ProfitLoss` 관련 필드를 모두 `KiwoomDecimal`로 수정
- 변경: `AfterMarketSinglePriceChange` 를 `KiwoomDecimal`로 수정
- 변경: `NetBuyVolume`, `NetBuyAmount` 필드를 `KiwoomDecimal`로 수정
- 변경: `AfterMarketSinglePriceChangeRate` 를 `KiwoomDecimal`로 수정
- 변경: `KiwoomStockInfoGetTradeItem.TradeVolume` 를 `KiwoomDecimal`로 수정
- 변경: `BuyBrokerVolume`, `SellBrokerVolume` 필드를 `KiwoomDecimal`로 수정
- 변경: `KiwoomMarketConditionGetStockInstitutionTransactionTrendItem.InstitutionPeriodAccumulation`, `InstitutionDailyNetVolume`, `ForeignPeriodAccumulation`, `ForeignDailyNetVolume`를 `KiwoomDecimal`로 수정
- 변경: `TopBuyExitBroker` 필드를 `KiwoomString`로 수정
- 변경: `HoldingCount` 를 `HoldingQuantity` 로 수정
- 변경: `AcquirableCount` 를 `AcquirableQuantity` 로 수정
- 변경: `GetHourlyProgramTradeTrendsAsync`, `GetDailyProgramTradeTrendsAsync` 파라미터를 `KiwoomMarketConditionMarketType3` 로 수정
- 변경: `KiwoomMarketConditionGetStockOriginTradeTrends` -> `KiwoomMarketConditionGetStockInstitutionTransactionTrends`

### v0.3.1 (2025-09-09)
- 추가: `KiwoomString` 타입
- 변경: `KiwoomDecimal`로 변환 작업
- 변경: `Rank` 필드를 `string` -> `decimal`
- 추가: `KiwoomMarketConditionGetDailyInstitutionTradingStockItem`에 누락된 필드 추가
- 변경: `KiwoomTimeSpanConverter` 에서 파싱 실패하는 경우는 `null`로 반환하도록 수정

<details>
<summary><strong>v0.3.0 및 이전 버전</strong></summary>

### v0.3.0 (2025-09-09)

#### 금융 시스템 네이밍 체계화
##### 기본 수치 개념
- 합, 합계, 전체: `Total`
- 수량, 금액: `Quantity`, `Amount`
- 누적: `Accumulated`
- 율, 비율, 대비율: `Rate`

##### 위치/방향 개념
- 상위, 하위: `Top`, `Bottom`
- 상한, 하한: `Upper`, `Lower`
- 상승, 보합, 하락: `Up`, `Flat`, `Down`
- 입금, 출금: `Deposit`, `Withdrawal`
- 입고, 출고: `Incoming`, `Outgoing`

##### 거래 행위
- 매수, 매도: `Buy`, `Sell`
- 순매수, 순매도: `NetBuy`, `NetSell`
- 거래, 매매: `Transaction`
- 체결, 미체결: `Trade`, `Unfilled`
- 위탁: `Consignment`
- 접수: `Submission`

##### 호가 및 잔량
- 호가: `Quote`
- 잔량, 호가잔량: `RemainQuantity`, `OrderBook`

##### 가격 데이터
- 시가, 고가, 저가, 종가: `Open`, `High`, `Low`, `Close`

##### 거래량 관련
- 거래량, 거래수량, 매매수량: `Volume`
- 거래금액, 거래대금: `TransactionAmount`
- 거래량대비: `VolumeChange`
- 전일거래량: `PreviousDayVolume`

##### 시간 개념
- 금일, 전일: `Today`, `PreviousDay`
- D+1, D+2: `-D1`, `-D2`
- 일별: `Daily`

##### 변화 개념
- 전일대비: `Change`, `PreviousDayChange`(한 레코드 안에 대비 개념이 중복될 경우)
- 급증, 급감: `Spike`, `Drop`
- 급등, 급락: `Surge`, `Plunge`
- 강도: `Momentum`
- 기호: `Sign`

##### 투자자 분류
- 개인, 기관, 외국인: `Retail`, `Institution`, `Foreign`
- 거래원: `Broker`

##### 자금 및 신용 관련
- 현금, 신용, 대출, 융자, 담보, 대주, 대용: `Cash`, `Credit`, `Loan`, `CreditLoan`, `Collateral`, `ShortSell`, `Substitute`
- 변제, 상환: `Repayment`
- 미납, 미상환: `Unpaid`
- 납부: `Payment`

##### 보증금 및 증거금
- 증거금, 미수금: `Margin`, `Unsettled`
- 예수금, 보증금: `Deposit`

##### 비용 관련
- 수수료, 세금: `Fee`, `Tax`

##### 투자 상품 분류
- 주식, 투자, 원금: `Stock`, `Investment`, `Principal`
- 유가증권, 수익증권, 채권: `Securities`, `Fund`, `Bond`
- 업종: `Industry`

##### 기타 거래 개념
- 차익: `Arbitrage`
- 정산: `Settlement`
- 보유: `Holding`
- 행사, 상장: `Exercise`, `List`
- 시가총액: `MarketCapitalization`
- 대차거래: `SecuritiesLending`

### v0.2.1 (2025-09-03)
- 추가: 소스코드 주석
- 추가: | ka01690 | 일별잔고수익률 API
- 삭제: `KiwoomRealteQuoteRequests`
- 삭제: `KiwoomRealteQuoteRequestItem`
- 삭제: `KiwoomRealteQuoteRegistrations`
- 삭제: `KiwoomRealteQuoteRegistrationItem`
- 삭제: `KiwoomRealteQuoteValue`
- 변경: `KiwoomRankingInfoGetForeignPeriodTransactionTopItem.NetBuyQuantity` 를 `KiwoomDecimal`로 수정
- 변경: 종속성 라이브러리 버전별 분기

### v0.2.0 (2025-08-29)
- 추가: 소스코드 주석
- 추가: | ka00198 | 실시간종목조회순위 API
- 추가: `KiwoomStockInfoStockCondition.ExcludeManagedAndPreferredAndCaution`
- 추가: `KiwoomWebSocketStockExchangeType.Unified`, `NXT` 추가
- 변경: | ka10061 | 종목별투자자기관별합계요청의 `trde_tp` 값 `0` 으로 고정
- 변경: | kt10003 | 주식 취소주문의 API ID 를 `kt10002`로 잘못 호출하고 있던 문제 수정
- 변경: `KiwoomAccountDelistingQueryType` 을 `bool`로 수정 (`isExcludeDelisted`)
- 변경: `KiwoomChartUseOption` 을 `bool`로 수정 (`isUpdateStockPrice`)
- 변경: `KiwoomRankingInfoInclusionOption` 을 `bool`로 수정
- 변경: `KiwoomStockInfonInclusionOption` 을 `bool`로 수정
- 변경: `KiwoomStockInfoUseOption` 을 `bool`로 수정
- 변경: `KiwoomElwTradeQuantityType` 을 `decimal`로 수정 (`minVolume`)
- 변경: `KiwoomRankingInfoTradeQuantityType` 을 `decimal`로 수정 (`minVolume`)
- 변경: `KiwoomRankingInfoTradePriceCondition` 을 `decimal`로 수정 (`minTransactionAmount`)
- 변경: `KiwoomStockInfoTradeQuantityType` 을 `decimal`로 수정 (`minVolume`)
- 변경: `KiwoomForeignInstitutionPeriodQueryType` 을 `int`로 수정 (`period`)
- 변경: `KiwoomAccountDepositQueryType.General` -> `KiwoomAccountDepositQueryType.Normal`
- 변경: `KiwoomMarketConditionEstimatedUnitPriceType` -> `KiwoomMarketConditionUnitPriceType`
- 변경: `KiwoomRankingInfoTradeQuantitySortType.TradingVolume` -> `Volume`
- 변경: `KiwoomRankingInfoTradeQuantitySortType.TradingAmount` -> `TransactionAmount`
- 변경: `KiwoomRankingInfoPreviousTradeQuantityQueryType.Top100ByYesterdayTradingAmount` -> `Top100ByYesterdayTransactionAmount`
- 변경: `KiwoomWebSocketRealtimeOrderExecution.ExchangeType` 타입을 `KiwoomWebSocketStockExchangeType` 로 수정
- 변경: `KiwoomWebSocketRealtimeStockExecution.ExchangeType` 타입을 `KiwoomWebSocketStockExchangeType` 로 수정
- 삭제: `KiwoomForeignInstitutionNetSellAmountType` (`2` 고정값)
- 삭제: `KiwoomSecuritiesLendingQueryType`

### v0.1.2 (2025-08-27)
- 아이콘 업데이트 및 NuGet 패키지 메타데이터 개선
- 코드 문서화 개선
- 프로젝트 아이콘 변경
- README 문서 구조 개선

### v0.1.1 (2025-08-27)
- NuGet 패키지 최초 릴리즈
- 패키지 메타데이터 및 설명 추가
- API 문서화 개선
- 빌드 설정 최적화
- FAQ 문서 추가
- 패키지 참조 오류 수정

</details>
</details>

---

## Disclaimer

> 이 라이브러리는 키움증권과 공식적인 관계가 없는 개인 프로젝트입니다.
> 실제 거래 시에는 충분한 테스트를 거쳐 사용하시기 바랍니다.
>
> 💡 실제 자금 투입 전, 모의투자 게임 플랫폼 **[ox64.app](https://ox64.app)** 에서 먼저 전략을 검증해보세요.

## License

This project is licensed under the [MIT License](LICENSE).

---

<div align="center">

**If this project helped you, consider giving it a star!**

[Report Bug](https://github.com/dongbin300/KiwoomRestApi.Net/issues) · [Request Feature](https://github.com/dongbin300/KiwoomRestApi.Net/issues) · [Documentation](https://dongbin300.github.io/KiwoomRestApi.Net/) · [모의투자 게임 ox64.app](https://ox64.app)

</div>
