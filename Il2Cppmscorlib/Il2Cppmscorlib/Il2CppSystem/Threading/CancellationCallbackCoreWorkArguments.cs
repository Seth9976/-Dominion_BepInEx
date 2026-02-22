using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000259 RID: 601
	public sealed class CancellationCallbackCoreWorkArguments : ValueType
	{
		// Token: 0x060029DB RID: 10715 RVA: 0x000D8F7C File Offset: 0x000D717C
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationCallbackCoreWorkArguments()
		{
			Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackCoreWorkArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr);
			CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "m_currArrayFragment");
			CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "m_currArrayIndex");
			CancellationCallbackCoreWorkArguments.NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, 100669974);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000D8FE8 File Offset: 0x000D71E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11679, RefRangeEnd = 11680, XrefRangeStart = 11679, XrefRangeEnd = 11680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currArrayFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currArrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackCoreWorkArguments.NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x0000E915 File Offset: 0x0000CB15
		public CancellationCallbackCoreWorkArguments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x0000E91E File Offset: 0x0000CB1E
		public CancellationCallbackCoreWorkArguments()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
		{
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x000D9048 File Offset: 0x000D7248
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0000E930 File Offset: 0x0000CB30
		public unsafe SparselyPopulatedArrayFragment<CancellationCallbackInfo> m_currArrayFragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayFragment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<CancellationCallbackInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayFragment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x000D9078 File Offset: 0x000D7278
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0000E94F File Offset: 0x0000CB4F
		public unsafe int m_currArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayIndex)) = value;
			}
		}

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeFieldInfoPtr_m_currArrayFragment;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeFieldInfoPtr_m_currArrayIndex;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0;
	}
}
