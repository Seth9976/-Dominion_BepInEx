using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046E RID: 1134
	[Serializable]
	public class CaseInsensitiveComparer : Object
	{
		// Token: 0x060043DD RID: 17373 RVA: 0x00136758 File Offset: 0x00134958
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveComparer()
		{
			Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CaseInsensitiveComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr);
			CaseInsensitiveComparer.NativeFieldInfoPtr_m_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, "m_compareInfo");
			CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100673141);
			CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100673142);
			CaseInsensitiveComparer.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100673143);
			CaseInsensitiveComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100673144);
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x001367EC File Offset: 0x001349EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359395, XrefRangeEnd = 359400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00136828 File Offset: 0x00134A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359401, RefRangeEnd = 359402, XrefRangeStart = 359400, XrefRangeEnd = 359401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveComparer(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00136874 File Offset: 0x00134A74
		public unsafe static CaseInsensitiveComparer Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 359410, RefRangeEnd = 359412, XrefRangeStart = 359402, XrefRangeEnd = 359410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveComparer>(intPtr3) : null;
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x001368A8 File Offset: 0x00134AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359412, XrefRangeEnd = 359415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x0001A114 File Offset: 0x00018314
		public CaseInsensitiveComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00136908 File Offset: 0x00134B08
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x0001A11D File Offset: 0x0001831D
		public unsafe CompareInfo m_compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveComparer.NativeFieldInfoPtr_m_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveComparer.NativeFieldInfoPtr_m_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeFieldInfoPtr_m_compareInfo;

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveComparer_0;

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
	}
}
