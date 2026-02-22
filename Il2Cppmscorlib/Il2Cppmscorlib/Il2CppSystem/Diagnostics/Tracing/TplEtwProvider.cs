using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050E RID: 1294
	public class TplEtwProvider : EventSource
	{
		// Token: 0x06004ABD RID: 19133 RVA: 0x001563B0 File Offset: 0x001545B0
		// Note: this type is marked as 'beforefieldinit'.
		static TplEtwProvider()
		{
			Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TplEtwProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr);
			TplEtwProvider.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, "Log");
			TplEtwProvider.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674371);
			TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674372);
			TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage1_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674373);
			TplEtwProvider.NativeMethodInfoPtr_SetActivityId_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674374);
			TplEtwProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674375);
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x00156458 File Offset: 0x00154658
		public unsafe bool Debug
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 372774, RefRangeEnd = 372778, XrefRangeStart = 372773, XrefRangeEnd = 372774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x00156494 File Offset: 0x00154694
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 372779, RefRangeEnd = 372785, XrefRangeStart = 372778, XrefRangeEnd = 372779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugFacilityMessage(string Facility, string Message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Facility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x001564E8 File Offset: 0x001546E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372785, XrefRangeEnd = 372786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugFacilityMessage1(string Facility, string Message, string Arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Facility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage1_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00156550 File Offset: 0x00154750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372794, RefRangeEnd = 372795, XrefRangeStart = 372786, XrefRangeEnd = 372794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActivityId(Guid Id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_SetActivityId_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00156590 File Offset: 0x00154790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372795, XrefRangeEnd = 372799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TplEtwProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x0001C0DD File Offset: 0x0001A2DD
		public TplEtwProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x001565CC File Offset: 0x001547CC
		// (set) Token: 0x06004AC5 RID: 19141 RVA: 0x0001C0E6 File Offset: 0x0001A2E6
		public unsafe static TplEtwProvider Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TplEtwProvider.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TplEtwProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TplEtwProvider.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C51 RID: 15441
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x04003C52 RID: 15442
		private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;

		// Token: 0x04003C53 RID: 15443
		private static readonly IntPtr NativeMethodInfoPtr_DebugFacilityMessage_Public_Void_String_String_0;

		// Token: 0x04003C54 RID: 15444
		private static readonly IntPtr NativeMethodInfoPtr_DebugFacilityMessage1_Public_Void_String_String_String_0;

		// Token: 0x04003C55 RID: 15445
		private static readonly IntPtr NativeMethodInfoPtr_SetActivityId_Public_Void_Guid_0;

		// Token: 0x04003C56 RID: 15446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200067B RID: 1659
		public class Keywords : Object
		{
			// Token: 0x0600570A RID: 22282 RVA: 0x00021B11 File Offset: 0x0001FD11
			// Note: this type is marked as 'beforefieldinit'.
			static Keywords()
			{
				Il2CppClassPointerStore<TplEtwProvider.Keywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, "Keywords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TplEtwProvider.Keywords>.NativeClassPtr);
				TplEtwProvider.Keywords.NativeFieldInfoPtr_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TplEtwProvider.Keywords>.NativeClassPtr, "Debug");
			}

			// Token: 0x0600570B RID: 22283 RVA: 0x00021B45 File Offset: 0x0001FD45
			public Keywords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001668 RID: 5736
			// (get) Token: 0x0600570C RID: 22284 RVA: 0x0017F4B0 File Offset: 0x0017D6B0
			// (set) Token: 0x0600570D RID: 22285 RVA: 0x00021B4E File Offset: 0x0001FD4E
			public unsafe static EventKeywords Debug
			{
				get
				{
					EventKeywords eventKeywords;
					IL2CPP.il2cpp_field_static_get_value(TplEtwProvider.Keywords.NativeFieldInfoPtr_Debug, (void*)(&eventKeywords));
					return eventKeywords;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TplEtwProvider.Keywords.NativeFieldInfoPtr_Debug, (void*)(&value));
				}
			}

			// Token: 0x040045AC RID: 17836
			private static readonly IntPtr NativeFieldInfoPtr_Debug;
		}
	}
}
