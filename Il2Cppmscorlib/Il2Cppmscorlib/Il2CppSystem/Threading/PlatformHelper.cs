using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000263 RID: 611
	public static class PlatformHelper : Object
	{
		// Token: 0x06002A70 RID: 10864 RVA: 0x000DB234 File Offset: 0x000D9434
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "PlatformHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
			PlatformHelper.NativeFieldInfoPtr_s_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_processorCount");
			PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_lastProcessorCountRefreshTicks");
			PlatformHelper.NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100670051);
			PlatformHelper.NativeMethodInfoPtr_get_IsSingleProcessor_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100670052);
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000DB2B4 File Offset: 0x000D94B4
		public unsafe static int ProcessorCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 331168, RefRangeEnd = 331173, XrefRangeStart = 331162, XrefRangeEnd = 331168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000DB2E4 File Offset: 0x000D94E4
		public unsafe static bool IsSingleProcessor
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 331184, RefRangeEnd = 331193, XrefRangeStart = 331173, XrefRangeEnd = 331184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_get_IsSingleProcessor_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0000ECC7 File Offset: 0x0000CEC7
		public PlatformHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000DB314 File Offset: 0x000D9514
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		public unsafe static int s_processorCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_s_processorCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_s_processorCount, (void*)(&value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000DB330 File Offset: 0x000D9530
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x0000ECDE File Offset: 0x0000CEDE
		public unsafe static int s_lastProcessorCountRefreshTicks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&value));
			}
		}

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeFieldInfoPtr_s_processorCount;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSingleProcessor_Internal_Static_get_Boolean_0;
	}
}
