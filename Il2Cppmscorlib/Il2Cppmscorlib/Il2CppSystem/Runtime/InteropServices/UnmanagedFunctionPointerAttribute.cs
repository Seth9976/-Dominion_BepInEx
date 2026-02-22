using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043A RID: 1082
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		// Token: 0x06004285 RID: 17029 RVA: 0x00132168 File Offset: 0x00130368
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedFunctionPointerAttribute()
		{
			Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "UnmanagedFunctionPointerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr);
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "m_callingConvention");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_CharSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "CharSet");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_BestFitMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "BestFitMapping");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "ThrowOnUnmappableChar");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_SetLastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "SetLastError");
			UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, 100672961);
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x00132210 File Offset: 0x00130410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callingConvention;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000196E6 File Offset: 0x000178E6
		public UnmanagedFunctionPointerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x00132258 File Offset: 0x00130458
		// (set) Token: 0x06004289 RID: 17033 RVA: 0x000196EF File Offset: 0x000178EF
		public unsafe CallingConvention m_callingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention)) = value;
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x00132280 File Offset: 0x00130480
		// (set) Token: 0x0600428B RID: 17035 RVA: 0x0001970A File Offset: 0x0001790A
		public unsafe CharSet CharSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_CharSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_CharSet)) = value;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x001322A8 File Offset: 0x001304A8
		// (set) Token: 0x0600428D RID: 17037 RVA: 0x00019725 File Offset: 0x00017925
		public unsafe bool BestFitMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_BestFitMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_BestFitMapping)) = value;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x001322D0 File Offset: 0x001304D0
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x00019740 File Offset: 0x00017940
		public unsafe bool ThrowOnUnmappableChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar)) = value;
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x001322F8 File Offset: 0x001304F8
		// (set) Token: 0x06004291 RID: 17041 RVA: 0x0001975B File Offset: 0x0001795B
		public unsafe bool SetLastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_SetLastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_SetLastError)) = value;
			}
		}

		// Token: 0x0400360E RID: 13838
		private static readonly IntPtr NativeFieldInfoPtr_m_callingConvention;

		// Token: 0x0400360F RID: 13839
		private static readonly IntPtr NativeFieldInfoPtr_CharSet;

		// Token: 0x04003610 RID: 13840
		private static readonly IntPtr NativeFieldInfoPtr_BestFitMapping;

		// Token: 0x04003611 RID: 13841
		private static readonly IntPtr NativeFieldInfoPtr_ThrowOnUnmappableChar;

		// Token: 0x04003612 RID: 13842
		private static readonly IntPtr NativeFieldInfoPtr_SetLastError;

		// Token: 0x04003613 RID: 13843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0;
	}
}
