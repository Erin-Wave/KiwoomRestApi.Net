using System;

namespace KiwoomRestApi.Net.Enums.DomesticStock.Theme
{
	/// <summary>
	/// 검색구분
	/// </summary>
	public enum KiwoomThemeQueryType
	{
		/// <summary>
		/// 전체검색
		/// </summary>
		All = 0,
		/// <summary>
		/// 테마검색
		/// </summary>
		[Obsolete("키움 API 명세에서 제거된 값입니다. All(0:전체검색) 또는 Stock(2:종목검색)을 사용하세요.")]
		Theme = 1,
		/// <summary>
		/// 종목검색
		/// </summary>
		Stock = 2
	}
}
