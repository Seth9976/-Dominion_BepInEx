using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000063 RID: 99
	public class Stopwatch : Object
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x0002BE78 File Offset: 0x0002A078
		// Note: this type is marked as 'beforefieldinit'.
		static Stopwatch()
		{
			Il2CppClassPointerStore<Stopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "Stopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr);
			Stopwatch.NativeFieldInfoPtr_Frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "Frequency");
			Stopwatch.NativeFieldInfoPtr_IsHighResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "IsHighResolution");
			Stopwatch.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "elapsed");
			Stopwatch.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "started");
			Stopwatch.NativeFieldInfoPtr_is_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "is_running");
			Stopwatch.NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664261);
			Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664262);
			Stopwatch.NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664263);
			Stopwatch.NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664264);
			Stopwatch.NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664265);
			Stopwatch.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100664266);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0002BF84 File Offset: 0x0002A184
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40881, RefRangeEnd = 40884, XrefRangeStart = 40880, XrefRangeEnd = 40881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTimestamp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0002BFB4 File Offset: 0x0002A1B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stopwatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002BFF0 File Offset: 0x0002A1F0
		public unsafe TimeSpan Elapsed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40884, XrefRangeEnd = 40900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0002C02C File Offset: 0x0002A22C
		public unsafe long ElapsedMilliseconds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40922, RefRangeEnd = 40923, XrefRangeStart = 40900, XrefRangeEnd = 40922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0002C068 File Offset: 0x0002A268
		public unsafe long ElapsedTicks
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 40927, RefRangeEnd = 40931, XrefRangeStart = 40923, XrefRangeEnd = 40927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40935, RefRangeEnd = 40936, XrefRangeStart = 40931, XrefRangeEnd = 40935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00004EA0 File Offset: 0x000030A0
		public Stopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0002C0D8 File Offset: 0x0002A2D8
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00004EA9 File Offset: 0x000030A9
		public unsafe static long Frequency
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_Frequency, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_Frequency, (void*)(&value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0002C0F4 File Offset: 0x0002A2F4
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00004EB7 File Offset: 0x000030B7
		public unsafe static bool IsHighResolution
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_IsHighResolution, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_IsHighResolution, (void*)(&value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0002C110 File Offset: 0x0002A310
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00004EC5 File Offset: 0x000030C5
		public unsafe long elapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_elapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_elapsed)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0002C138 File Offset: 0x0002A338
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00004EE0 File Offset: 0x000030E0
		public unsafe long started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0002C160 File Offset: 0x0002A360
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00004EFB File Offset: 0x000030FB
		public unsafe bool is_running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_is_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_is_running)) = value;
			}
		}

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_Frequency;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_IsHighResolution;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_elapsed;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_is_running;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
	}
}
