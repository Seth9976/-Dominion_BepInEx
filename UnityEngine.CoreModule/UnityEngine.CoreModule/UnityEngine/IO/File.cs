using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.IO
{
	// Token: 0x020002BA RID: 698
	public static class File
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00069B9C File Offset: 0x00067D9C
		public static ulong totalOpenCalls
		{
			get
			{
				return File.GetTotalOpenCalls();
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00069BB4 File Offset: 0x00067DB4
		public static ulong totalCloseCalls
		{
			get
			{
				return File.GetTotalCloseCalls();
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00069BCC File Offset: 0x00067DCC
		public static ulong totalReadCalls
		{
			get
			{
				return File.GetTotalReadCalls();
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00069BE4 File Offset: 0x00067DE4
		public static ulong totalWriteCalls
		{
			get
			{
				return File.GetTotalWriteCalls();
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00069BFC File Offset: 0x00067DFC
		public static ulong totalSeekCalls
		{
			get
			{
				return File.GetTotalSeekCalls();
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x00069C14 File Offset: 0x00067E14
		public static ulong totalZeroSeekCalls
		{
			get
			{
				return File.GetTotalZeroSeekCalls();
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00069C2C File Offset: 0x00067E2C
		public static ulong totalFilesOpened
		{
			get
			{
				return File.GetTotalFilesOpened();
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x00069C44 File Offset: 0x00067E44
		public static ulong totalFilesClosed
		{
			get
			{
				return File.GetTotalFilesClosed();
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00069C5C File Offset: 0x00067E5C
		public static ulong totalBytesRead
		{
			get
			{
				return File.GetTotalBytesRead();
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00069C74 File Offset: 0x00067E74
		public static ulong totalBytesWritten
		{
			get
			{
				return File.GetTotalBytesWritten();
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00069C8C File Offset: 0x00067E8C
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00014197 File Offset: 0x00012397
		public static bool recordZeroSeeks
		{
			get
			{
				return File.GetRecordZeroSeeks();
			}
			set
			{
				File.SetRecordZeroSeeks(value);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x00069CA4 File Offset: 0x00067EA4
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x000141A1 File Offset: 0x000123A1
		public static ThreadIORestrictionMode MainThreadIORestrictionMode
		{
			get
			{
				return File.GetMainThreadFileIORestriction();
			}
			set
			{
				File.SetMainThreadFileIORestriction(value);
			}
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000141AB File Offset: 0x000123AB
		public static void SetRecordZeroSeeks(bool enable)
		{
			File.SetRecordZeroSeeksDelegateField(enable);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000141B8 File Offset: 0x000123B8
		public static bool GetRecordZeroSeeks()
		{
			return File.GetRecordZeroSeeksDelegateField();
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000141C4 File Offset: 0x000123C4
		public static ulong GetTotalOpenCalls()
		{
			return File.GetTotalOpenCallsDelegateField();
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000141D0 File Offset: 0x000123D0
		public static ulong GetTotalCloseCalls()
		{
			return File.GetTotalCloseCallsDelegateField();
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000141DC File Offset: 0x000123DC
		public static ulong GetTotalReadCalls()
		{
			return File.GetTotalReadCallsDelegateField();
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000141E8 File Offset: 0x000123E8
		public static ulong GetTotalWriteCalls()
		{
			return File.GetTotalWriteCallsDelegateField();
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000141F4 File Offset: 0x000123F4
		public static ulong GetTotalSeekCalls()
		{
			return File.GetTotalSeekCallsDelegateField();
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00014200 File Offset: 0x00012400
		public static ulong GetTotalZeroSeekCalls()
		{
			return File.GetTotalZeroSeekCallsDelegateField();
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0001420C File Offset: 0x0001240C
		public static ulong GetTotalFilesOpened()
		{
			return File.GetTotalFilesOpenedDelegateField();
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00014218 File Offset: 0x00012418
		public static ulong GetTotalFilesClosed()
		{
			return File.GetTotalFilesClosedDelegateField();
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00014224 File Offset: 0x00012424
		public static ulong GetTotalBytesRead()
		{
			return File.GetTotalBytesReadDelegateField();
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00014230 File Offset: 0x00012430
		public static ulong GetTotalBytesWritten()
		{
			return File.GetTotalBytesWrittenDelegateField();
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0001423C File Offset: 0x0001243C
		public static void SetMainThreadFileIORestriction(ThreadIORestrictionMode mode)
		{
			File.SetMainThreadFileIORestrictionDelegateField(mode);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00014249 File Offset: 0x00012449
		public static ThreadIORestrictionMode GetMainThreadFileIORestriction()
		{
			return File.GetMainThreadFileIORestrictionDelegateField();
		}

		// Token: 0x04001BA7 RID: 7079
		private static readonly File.SetRecordZeroSeeksDelegate SetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.SetRecordZeroSeeksDelegate>("UnityEngine.IO.File::SetRecordZeroSeeks");

		// Token: 0x04001BA8 RID: 7080
		private static readonly File.GetRecordZeroSeeksDelegate GetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.GetRecordZeroSeeksDelegate>("UnityEngine.IO.File::GetRecordZeroSeeks");

		// Token: 0x04001BA9 RID: 7081
		private static readonly File.GetTotalOpenCallsDelegate GetTotalOpenCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalOpenCallsDelegate>("UnityEngine.IO.File::GetTotalOpenCalls");

		// Token: 0x04001BAA RID: 7082
		private static readonly File.GetTotalCloseCallsDelegate GetTotalCloseCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalCloseCallsDelegate>("UnityEngine.IO.File::GetTotalCloseCalls");

		// Token: 0x04001BAB RID: 7083
		private static readonly File.GetTotalReadCallsDelegate GetTotalReadCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalReadCallsDelegate>("UnityEngine.IO.File::GetTotalReadCalls");

		// Token: 0x04001BAC RID: 7084
		private static readonly File.GetTotalWriteCallsDelegate GetTotalWriteCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalWriteCallsDelegate>("UnityEngine.IO.File::GetTotalWriteCalls");

		// Token: 0x04001BAD RID: 7085
		private static readonly File.GetTotalSeekCallsDelegate GetTotalSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalSeekCallsDelegate>("UnityEngine.IO.File::GetTotalSeekCalls");

		// Token: 0x04001BAE RID: 7086
		private static readonly File.GetTotalZeroSeekCallsDelegate GetTotalZeroSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalZeroSeekCallsDelegate>("UnityEngine.IO.File::GetTotalZeroSeekCalls");

		// Token: 0x04001BAF RID: 7087
		private static readonly File.GetTotalFilesOpenedDelegate GetTotalFilesOpenedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesOpenedDelegate>("UnityEngine.IO.File::GetTotalFilesOpened");

		// Token: 0x04001BB0 RID: 7088
		private static readonly File.GetTotalFilesClosedDelegate GetTotalFilesClosedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesClosedDelegate>("UnityEngine.IO.File::GetTotalFilesClosed");

		// Token: 0x04001BB1 RID: 7089
		private static readonly File.GetTotalBytesReadDelegate GetTotalBytesReadDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesReadDelegate>("UnityEngine.IO.File::GetTotalBytesRead");

		// Token: 0x04001BB2 RID: 7090
		private static readonly File.GetTotalBytesWrittenDelegate GetTotalBytesWrittenDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesWrittenDelegate>("UnityEngine.IO.File::GetTotalBytesWritten");

		// Token: 0x04001BB3 RID: 7091
		private static readonly File.SetMainThreadFileIORestrictionDelegate SetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.SetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::SetMainThreadFileIORestriction");

		// Token: 0x04001BB4 RID: 7092
		private static readonly File.GetMainThreadFileIORestrictionDelegate GetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.GetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::GetMainThreadFileIORestriction");

		// Token: 0x02000D0C RID: 3340
		// (Invoke) Token: 0x060037FC RID: 14332
		private delegate void SetRecordZeroSeeksDelegate(bool enable);

		// Token: 0x02000D0D RID: 3341
		// (Invoke) Token: 0x060037FE RID: 14334
		private delegate bool GetRecordZeroSeeksDelegate();

		// Token: 0x02000D0E RID: 3342
		// (Invoke) Token: 0x06003800 RID: 14336
		private delegate ulong GetTotalOpenCallsDelegate();

		// Token: 0x02000D0F RID: 3343
		// (Invoke) Token: 0x06003802 RID: 14338
		private delegate ulong GetTotalCloseCallsDelegate();

		// Token: 0x02000D10 RID: 3344
		// (Invoke) Token: 0x06003804 RID: 14340
		private delegate ulong GetTotalReadCallsDelegate();

		// Token: 0x02000D11 RID: 3345
		// (Invoke) Token: 0x06003806 RID: 14342
		private delegate ulong GetTotalWriteCallsDelegate();

		// Token: 0x02000D12 RID: 3346
		// (Invoke) Token: 0x06003808 RID: 14344
		private delegate ulong GetTotalSeekCallsDelegate();

		// Token: 0x02000D13 RID: 3347
		// (Invoke) Token: 0x0600380A RID: 14346
		private delegate ulong GetTotalZeroSeekCallsDelegate();

		// Token: 0x02000D14 RID: 3348
		// (Invoke) Token: 0x0600380C RID: 14348
		private delegate ulong GetTotalFilesOpenedDelegate();

		// Token: 0x02000D15 RID: 3349
		// (Invoke) Token: 0x0600380E RID: 14350
		private delegate ulong GetTotalFilesClosedDelegate();

		// Token: 0x02000D16 RID: 3350
		// (Invoke) Token: 0x06003810 RID: 14352
		private delegate ulong GetTotalBytesReadDelegate();

		// Token: 0x02000D17 RID: 3351
		// (Invoke) Token: 0x06003812 RID: 14354
		private delegate ulong GetTotalBytesWrittenDelegate();

		// Token: 0x02000D18 RID: 3352
		// (Invoke) Token: 0x06003814 RID: 14356
		private delegate void SetMainThreadFileIORestrictionDelegate(ThreadIORestrictionMode mode);

		// Token: 0x02000D19 RID: 3353
		// (Invoke) Token: 0x06003816 RID: 14358
		private delegate ThreadIORestrictionMode GetMainThreadFileIORestrictionDelegate();
	}
}
