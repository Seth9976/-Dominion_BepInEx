using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020001D1 RID: 465
	public sealed class CrashReport
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x0000F901 File Offset: 0x0000DB01
		public static int Compare(CrashReport c1, CrashReport c2)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0000F90E File Offset: 0x0000DB0E
		public static void PopulateReports()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x0000F91B File Offset: 0x0000DB1B
		public static Il2CppReferenceArray<CrashReport> reports
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0000F928 File Offset: 0x0000DB28
		public static CrashReport lastReport
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0000F935 File Offset: 0x0000DB35
		public static void RemoveAll()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0000F942 File Offset: 0x0000DB42
		public void Remove()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00061F10 File Offset: 0x00060110
		public static Il2CppStringArray GetReports()
		{
			IntPtr intPtr = CrashReport.GetReportsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00061F38 File Offset: 0x00060138
		public static string GetReportData(string id, out double secondsSinceUnixEpoch)
		{
			IntPtr intPtr = CrashReport.GetReportDataDelegateField(IL2CPP.ManagedStringToIl2Cpp(id), out secondsSinceUnixEpoch);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0000F94F File Offset: 0x0000DB4F
		public static bool RemoveReport(string id)
		{
			return CrashReport.RemoveReportDelegateField(IL2CPP.ManagedStringToIl2Cpp(id));
		}

		// Token: 0x0400166D RID: 5741
		private static readonly CrashReport.GetReportsDelegate GetReportsDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportsDelegate>("UnityEngine.CrashReport::GetReports");

		// Token: 0x0400166E RID: 5742
		private static readonly CrashReport.GetReportDataDelegate GetReportDataDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportDataDelegate>("UnityEngine.CrashReport::GetReportData");

		// Token: 0x0400166F RID: 5743
		private static readonly CrashReport.RemoveReportDelegate RemoveReportDelegateField = IL2CPP.ResolveICall<CrashReport.RemoveReportDelegate>("UnityEngine.CrashReport::RemoveReport");

		// Token: 0x02000AA6 RID: 2726
		// (Invoke) Token: 0x0600334E RID: 13134
		private delegate IntPtr GetReportsDelegate();

		// Token: 0x02000AA7 RID: 2727
		// (Invoke) Token: 0x06003350 RID: 13136
		private delegate IntPtr GetReportDataDelegate(IntPtr id, [Out] IntPtr secondsSinceUnixEpoch);

		// Token: 0x02000AA8 RID: 2728
		// (Invoke) Token: 0x06003352 RID: 13138
		private delegate bool RemoveReportDelegate(IntPtr id);
	}
}
