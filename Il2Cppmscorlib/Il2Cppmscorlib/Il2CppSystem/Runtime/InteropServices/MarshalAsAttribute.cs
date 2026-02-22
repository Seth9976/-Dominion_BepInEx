using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200045A RID: 1114
	public sealed class MarshalAsAttribute : Attribute
	{
		// Token: 0x0600436A RID: 17258 RVA: 0x001353CC File Offset: 0x001335CC
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalAsAttribute()
		{
			Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "MarshalAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr);
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalCookie");
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalType");
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalTypeRef");
			MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArrayUserDefinedSubType");
			MarshalAsAttribute.NativeFieldInfoPtr_utype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "utype");
			MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "ArraySubType");
			MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArraySubType");
			MarshalAsAttribute.NativeFieldInfoPtr_SizeConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeConst");
			MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "IidParameterIndex");
			MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeParamIndex");
			MarshalAsAttribute.NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100673074);
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x001354D8 File Offset: 0x001336D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358874, RefRangeEnd = 358875, XrefRangeStart = 358871, XrefRangeEnd = 358874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalAsAttribute Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalAsAttribute.NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr3) : null;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00019CAA File Offset: 0x00017EAA
		public MarshalAsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x00135518 File Offset: 0x00133718
		// (set) Token: 0x0600436E RID: 17262 RVA: 0x00019CB3 File Offset: 0x00017EB3
		public unsafe string MarshalCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x0600436F RID: 17263 RVA: 0x00135540 File Offset: 0x00133740
		// (set) Token: 0x06004370 RID: 17264 RVA: 0x00019CD2 File Offset: 0x00017ED2
		public unsafe string MarshalType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x00135568 File Offset: 0x00133768
		// (set) Token: 0x06004372 RID: 17266 RVA: 0x00019CF1 File Offset: 0x00017EF1
		public unsafe Type MarshalTypeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x00135598 File Offset: 0x00133798
		// (set) Token: 0x06004374 RID: 17268 RVA: 0x00019D10 File Offset: 0x00017F10
		public unsafe Type SafeArrayUserDefinedSubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06004375 RID: 17269 RVA: 0x001355C8 File Offset: 0x001337C8
		// (set) Token: 0x06004376 RID: 17270 RVA: 0x00019D2F File Offset: 0x00017F2F
		public unsafe UnmanagedType utype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_utype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_utype)) = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x001355F0 File Offset: 0x001337F0
		// (set) Token: 0x06004378 RID: 17272 RVA: 0x00019D4A File Offset: 0x00017F4A
		public unsafe UnmanagedType ArraySubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType)) = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x00135618 File Offset: 0x00133818
		// (set) Token: 0x0600437A RID: 17274 RVA: 0x00019D65 File Offset: 0x00017F65
		public unsafe VarEnum SafeArraySubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType)) = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x00135640 File Offset: 0x00133840
		// (set) Token: 0x0600437C RID: 17276 RVA: 0x00019D80 File Offset: 0x00017F80
		public unsafe int SizeConst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeConst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeConst)) = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x00135668 File Offset: 0x00133868
		// (set) Token: 0x0600437E RID: 17278 RVA: 0x00019D9B File Offset: 0x00017F9B
		public unsafe int IidParameterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex)) = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x00135690 File Offset: 0x00133890
		// (set) Token: 0x06004380 RID: 17280 RVA: 0x00019DB6 File Offset: 0x00017FB6
		public unsafe short SizeParamIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex)) = value;
			}
		}

		// Token: 0x04003717 RID: 14103
		private static readonly IntPtr NativeFieldInfoPtr_MarshalCookie;

		// Token: 0x04003718 RID: 14104
		private static readonly IntPtr NativeFieldInfoPtr_MarshalType;

		// Token: 0x04003719 RID: 14105
		private static readonly IntPtr NativeFieldInfoPtr_MarshalTypeRef;

		// Token: 0x0400371A RID: 14106
		private static readonly IntPtr NativeFieldInfoPtr_SafeArrayUserDefinedSubType;

		// Token: 0x0400371B RID: 14107
		private static readonly IntPtr NativeFieldInfoPtr_utype;

		// Token: 0x0400371C RID: 14108
		private static readonly IntPtr NativeFieldInfoPtr_ArraySubType;

		// Token: 0x0400371D RID: 14109
		private static readonly IntPtr NativeFieldInfoPtr_SafeArraySubType;

		// Token: 0x0400371E RID: 14110
		private static readonly IntPtr NativeFieldInfoPtr_SizeConst;

		// Token: 0x0400371F RID: 14111
		private static readonly IntPtr NativeFieldInfoPtr_IidParameterIndex;

		// Token: 0x04003720 RID: 14112
		private static readonly IntPtr NativeFieldInfoPtr_SizeParamIndex;

		// Token: 0x04003721 RID: 14113
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0;
	}
}
